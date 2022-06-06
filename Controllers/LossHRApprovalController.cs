using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoleBasedAuthorization.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RoleBasedAuthorization.Controllers
{
    public class LossHRApprovalController : Controller
    {
        MyDbContext _context = new MyDbContext();

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
            var inq = "Processing";
            IQueryable<Offlinehours> students = from s in _context.Offlinehours
                                                  where inq.Contains(s.status)
                                                  select s;
            //select new { s.LookupID, s.FirstName, s.LastName, s.JoinedDate};
            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.JobID.Contains(searchString)
                                       || s.locale.Contains(searchString)
                                       || s.WorkedHrs.Contains(searchString)
                                       || s.PacteraEdgeEmail.Contains(searchString)
                                       || s.StarshotCrashIsError.Contains(searchString)
                                      );
            }
            switch (sortOrder)
            {
                case "name_desc":
                    students = students.OrderByDescending(s => s.JobID);
                    break;
                case "Date":
                    students = students.OrderBy(s => s.JobID);
                    break;
                case "date_desc":
                    students = students.OrderByDescending(s => s.JobID);
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

            return View(await PaginatedList<Offlinehours>.CreateAsync(students.AsNoTracking(), pageNumber ?? 1, pageSize));
        }
        [HttpPost, ActionName("OnGetComment")]
        public async Task<IActionResult> OnGetComment()
        {
            int OfflineHrsID = Convert.ToInt32(Request.Form["OfflineHrsID"].ToString());

            var comment = Request.Form["Comment"].ToString();
            if (String.IsNullOrEmpty(comment))
            {
                ViewData["comment"] = OfflineHrsID;
                return RedirectToAction(nameof(Index), new { @errorId = ViewData["comment"] });
            }
            if (OfflineHrsID == 0)
            {
                return NotFound();
            }
            Offlinehours admin = await _context.Offlinehours.Where(s => s.OfflineHrsID == OfflineHrsID).FirstOrDefaultAsync();
            admin.status = "Rejected";
            admin.comments = comment;
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }        
    
    public async Task<IActionResult> OnPostDelete(int id)
    {
        if (id == null)
        {
            return NotFound();
        }
        Offlinehours admin = await _context.Offlinehours.Where(s => s.OfflineHrsID == id).FirstOrDefaultAsync();
        admin.status = "Confirmed";
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }
    }
}
