using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoleBasedAuthorization.Models;
using System;
using System.Linq;
using System.Linq.Dynamic;
using System.Threading.Tasks;

namespace RoleBasedAuthorization.Controllers
{
    public class CalculationGridController : Controller
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
    int? pageNumber)
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

            var num = "false";
            IQueryable<Sglookup> students = from s in _context.Sglookup
                                            where num.Contains(s.deleted)
                                            select s;
                           //select new { s.LookupID, s.FirstName, s.LastName, s.JoinedDate};
            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.JoinedDate.Contains(searchString)
                                       || s.Contract.Contains(searchString)
                                       || s.FirstName.Contains(searchString)
                                       || s.LastName.Contains(searchString)
                                       || s.PacteraEdgeEmail.Contains(searchString)
                                       || s.oneforma.Contains(searchString)
                                       || s.PayRateUS.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    students = students.OrderByDescending(s => s.LastName);
                    break;
                case "Date":
                    students = students.OrderBy(s => s.JoinedDate);
                    break;
                case "date_desc":
                    students = students.OrderByDescending(s => s.JoinedDate);
                    break;
                default:
                    students = students.OrderBy(s => s.FirstName);
                    break;
            } 
            int pageSize = 10;
            //return View(await students.AsNoTracking().ToListAsync());

            return View(await PaginatedList<Sglookup>.CreateAsync(students.AsNoTracking(), pageNumber ?? 1, pageSize));
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }
                ControllerContext.RouteData.DataTokens.Add("custom", "zzt");

                var student = await _context.Sglookup.FindAsync(id);
                if (student == null)
                {
                    return NotFound();
                }
                return View(student);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// POST: Admins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [ServiceFilter(typeof(UserActivityFilter))]
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("LookupID,JoinedDate,Contract,FirstName,LastName,PacteraEdgeEmail,oneforma,PayRateUS")] Sglookup admins)
        {
            if (id != admins.LookupID)
            {
                return NotFound();
            }

            Sglookup admin = await _context.Sglookup.Where(s => s.LookupID == admins.LookupID).FirstOrDefaultAsync();
            admin.JoinedDate = admins.JoinedDate;
            admin.Contract = admins.Contract;
            admin.FirstName = admins.FirstName;
            admin.LastName = admins.LastName;
            admin.PacteraEdgeEmail = admins.PacteraEdgeEmail;
            admin.oneforma = admins.oneforma;
            //admin.UHRS = admins.UHRS;
            admin.PayRateUS = admins.PayRateUS;
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admins = await _context.Sglookup
                .SingleOrDefaultAsync(m => m.LookupID == id);
            if (admins == null)
            {
                return NotFound();
            }

            return View(admins);
        }

        // POST: Admins/DeleteConfirmed/5
        [ServiceFilter(typeof(UserActivityFilter))]
        [HttpPost, ActionName("DeleteConfirmed")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var admins = await _context.Sglookup.SingleOrDefaultAsync(m => m.LookupID == id);
            admins.deleted = "true";
            //_context.Sglookup.Remove(admins);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}

