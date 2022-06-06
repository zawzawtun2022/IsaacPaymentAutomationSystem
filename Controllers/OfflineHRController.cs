using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using RoleBasedAuthorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleBasedAuthorization.Controllers
{
    public class OfflineHRController : Controller
    {
            MyDbContext _context = new MyDbContext();
            public static IConfiguration Configuration;

            public OfflineHRController(IConfiguration _configuration)
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
            int createdBy = HttpContext.Session.GetInt32("id").Value;
            //var inq = "Pending";
            var num = "false";
            var useremail = HttpContext.Session.GetString("email").ToString();
            //var approvestatus = "Approved";
            //var rejectedstatus = "Rejected";
            //var pendingstatus = "Pending";
            //var _role = _context.Offlinehours.Where(s => s.PacteraEdgeEmail == useremail).FirstOrDefault();
            //if (_role.status.Contains("Approved"))
            //{
            //    ViewBag.ApproveLevel = _role.PacteraEdgeEmail;
            //}
            IQueryable<Offlinehours> students;
            if (createdBy.Equals(1))
            {
                students = from s in _context.Offlinehours
                                                    where num.Contains(s.deleted)
                                                    select s;
            }
            else
            {
                 students = from s in _context.Offlinehours
                               where num.Contains(s.deleted) && s.createdby == createdBy
                               select s;
               
            }
            //select new { s.LookupID, s.FirstName, s.LastName, s.JoinedDate};
            if (!String.IsNullOrEmpty(searchString))
                {
                    students = students.Where(s => s.JobID.Contains(searchString)
                                           || s.PacteraEdgeEmail.Contains(searchString)
                                           || s.WorkedHrs.Contains(searchString)
                                           || s.StarshotCrashIsError.Contains(searchString)
                                           || s.TypeOfTaskID.Contains(searchString)
                                           || s.status.Contains(searchString)
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
                        students = students.OrderBy(s => s.JobID);
                        break;
                }
                int pageSize = 10;
                //return View(await students.AsNoTracking().ToListAsync());

                return View(await PaginatedList<Offlinehours>.CreateAsync(students.AsNoTracking(), pageNumber ?? 1, pageSize));
            }
        private List<Starshot> PopulateStarshot()
        {

            MySqlConnection con = null;
            List<Starshot> items = new List<Starshot>();
            string myConn = Configuration.GetConnectionString("myConn");
            con = new MySqlConnection(myConn);
            
            string query = "select starshotcrash.Description,starshotcrash.StarshotCrashID from starshotcrash";
            using (MySqlCommand cmd = new MySqlCommand(query))
            {
                cmd.Connection = con;
                con.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        items.Add(new Starshot
                        {
                            StarshotCrashID = Convert.ToInt32(sdr["StarshotCrashID"]),
                            Description = Convert.ToString(sdr["Description"])
                        });
                    }
                }
                con.Close();
            }
            return items;
        }
        private List<Typeoftask> PopulateTask()
        {

            MySqlConnection con = null;
            List<Typeoftask> items = new List<Typeoftask>();
            string myConn = Configuration.GetConnectionString("myConn");
            con = new MySqlConnection(myConn);
            string query = "SELECT typeoftask.TypeOfTask,typeoftask.TypeOfTaskID FROM typeoftask";
            using (MySqlCommand cmd = new MySqlCommand(query))
            {
                cmd.Connection = con;
                con.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        items.Add(new Typeoftask
                        {
                            TypeOfTaskID = Convert.ToInt32(sdr["TypeOfTaskID"]),
                            TypeOfTask = Convert.ToString(sdr["TypeOfTask"])
                        });
                    }
                }
                con.Close();
            }
            return items;
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
                     var student = await _context.Offlinehours.FindAsync(id);

                
                    ViewBag.starshot = new SelectList(PopulateStarshot(), "Description", "Description", 1);

                    ViewBag.typeoftask = new SelectList(PopulateTask(), "TypeOfTask", "TypeOfTask", 1);
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
            public async Task<IActionResult> Edit(int id, [Bind("OfflineHrsID,JobID,PacteraEdgeEmail,WorkedHrs,StarshotCrashIsError,TypeOfTaskID")] Offlinehours admins)
            {
            
                if (id != admins.OfflineHrsID)
                {
                    return NotFound();
                }

                Offlinehours admin = await _context.Offlinehours.Where(s => s.OfflineHrsID == admins.OfflineHrsID).FirstOrDefaultAsync();
                admin.JobID = admins.JobID;
                admin.PacteraEdgeEmail = admins.PacteraEdgeEmail;
                admin.WorkedHrs = admins.WorkedHrs;
                admin.StarshotCrashIsError = admins.StarshotCrashIsError;
                admin.TypeOfTaskID = admins.TypeOfTaskID;
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            public async Task<IActionResult> Delete(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var admins = await _context.Offlinehours
                    .SingleOrDefaultAsync(m => m.OfflineHrsID == id);
                if (admins == null)
                {
                    return NotFound();
                }

                return View(admins);
            }

            public async Task<IActionResult> Withdraw(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var admins = await _context.Offlinehours
                    .SingleOrDefaultAsync(m => m.OfflineHrsID == id);
                if (admins == null)
                {
                    return NotFound();
                }

                return View(admins);
            }
        [ServiceFilter(typeof(UserActivityFilter))]
        [HttpPost, ActionName("WithdrawConfirmed")]
            public async Task<IActionResult> WithdrawConfirmed(int id)
            {
                var admins = await _context.Offlinehours.SingleOrDefaultAsync(m => m.OfflineHrsID == id);
                admins.status = "Processing";
                //_context.Offlinehours.Remove(admins);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
        // POST: Admins/DeleteConfirmed/5
        [ServiceFilter(typeof(UserActivityFilter))]
        [HttpPost, ActionName("DeleteConfirmed")]
            public async Task<IActionResult> DeleteConfirmed(int id)
            {
                var admins = await _context.Offlinehours.SingleOrDefaultAsync(m => m.OfflineHrsID == id);
                admins.deleted = "true";
                //_context.Offlinehours.Remove(admins);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
        }
    }


