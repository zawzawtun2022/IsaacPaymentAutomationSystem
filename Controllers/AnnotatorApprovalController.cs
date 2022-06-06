using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using RoleBasedAuthorization.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RoleBasedAuthorization.Controllers
{
    public class AnnotatorApprovalController : Controller
    {
        MyDbContext _context = new MyDbContext();
        public static IConfiguration Configuration;

        public AnnotatorApprovalController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }
        [AuthorizedAction]

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public async Task<IActionResult> Index(
    string sortOrder,
    string currentFilter,
    string searchString,
    int? pageNumber, int? errorId)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;
            //var temp = from s in _context.sglookup
            //               select new { s.LookupID, s.FirstName, s.LastName, s.JoinedDate };
            var inq = "Confirmed";
            IQueryable<Sglookup> students = from s in _context.Sglookup
                                                where inq.Contains(s.dashboardstatus)
                                                select s;
            //select new { s.LookupID, s.FirstName, s.LastName, s.JoinedDate};
            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.BillingMonth.Contains(searchString)
                                       || s.Contract.Contains(searchString)
                                       || s.FirstName.Contains(searchString)
                                       || s.LastName.Contains(searchString)
                                       || s.PacteraEdgeEmail.Contains(searchString)
                                       || s.dashboardstatus.Contains(searchString)
                                      );
            }
            switch (sortOrder)
            {
                case "name_desc":
                    students = students.OrderByDescending(s => s.BillingMonth);
                    break;
                case "Date":
                    students = students.OrderBy(s => s.BillingMonth);
                    break;
                case "date_desc":
                    students = students.OrderByDescending(s => s.BillingMonth);
                    break;
                default:
                    students = students.OrderBy(s => s.PacteraEdgeEmail);
                    break;
            }
            int pageSize = 10;
            ViewData["comment"] = errorId;
            if (ViewData["comment"] != null)
            {
                ViewBag.Message = "Comment";
            }
            //return View(await students.AsNoTracking().ToListAsync());

            return View(await PaginatedList<Sglookup>.CreateAsync(students.AsNoTracking(), pageNumber ?? 1, pageSize));
        }
        [HttpPost, ActionName("OnGetComment")]
        public async Task<IActionResult> OnGetComment()
        {
            int LookupID = Convert.ToInt32(Request.Form["LookupID"].ToString());

            int annotatorId = (int)HttpContext.Session.GetInt32("id");

            var comment = Request.Form["Comment"].ToString();
            if (String.IsNullOrEmpty(comment))
            {
                ViewData["comment"] = LookupID;
                return RedirectToAction(nameof(Index), new { @errorId = ViewData["comment"] });
            }
            if (LookupID == 0)
            {
                return NotFound();
            }
            Sglookup admin = await _context.Sglookup.Where(s => s.LookupID == LookupID).FirstOrDefaultAsync();
            admin.dashboardstatus = "Rejected";
            admin.comment = comment;
            await _context.SaveChangesAsync();


            Offlinehours offlinehours = await _context.Offlinehours.Where(s => s.createdby == annotatorId).FirstOrDefaultAsync();
            offlinehours.status = "Rejected";
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            
            if (id == null)
            {
                return NotFound();
            }
                
                Sglookup admin = await _context.Sglookup.Where(s => s.LookupID == id).FirstOrDefaultAsync();
                admin.dashboardstatus = "Approved";
                await _context.SaveChangesAsync();

                int UID = Convert.ToInt32(admin.createdby);
                int myDbContext = _context.Offlinehours.ToList().Where(s => s.createdby == UID).ToList().Count;

                for (int i = 0; i < myDbContext; i++)
                {
                    MySqlConnection conn = null;

                    string myConn = Configuration.GetConnectionString("myConn");
                    conn = new MySqlConnection(myConn);

                    string query = "Update offlinehours SET status='Approved' WHERE createdby=" + UID;
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
           
                
            return RedirectToAction(nameof(Index));
        }
    }
}
