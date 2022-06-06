using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoleBasedAuthorization.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;
using System.Data;

using System.Text;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace RoleBasedAuthorization.Controllers
{
    public class SglookupController : Controller
    {
        MyDbContext _context = new MyDbContext();
        public static IConfiguration Configuration;

        public SglookupController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        [AuthorizedAction]
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
            
            IQueryable<Sglookup> students;
            if (createdBy.Equals(1))
            {
                students = from s in _context.Sglookup
                           where num.Contains(s.deleted)
                           select s;
            }
            else
            {
                students = from s in _context.Sglookup
                           where num.Contains(s.deleted) 
                           select s;

            }
            //select new { s.LookupID, s.FirstName, s.LastName, s.JoinedDate};
            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.BillingMonth.Contains(searchString)
                                       || s.PacteraEdgeEmail.Contains(searchString)
                                       || s.Contract.Contains(searchString)
                                       || s.PayRateUS.Contains(searchString)
                                       || s.Status.Contains(searchString)
                                       );
            }
            switch (sortOrder)
            {
                case "name_desc":
                    students = students.OrderByDescending(s => s.LookupID);
                    break;
                case "Date":
                    students = students.OrderBy(s => s.JoinedDate);
                    break;
                case "date_desc":
                    students = students.OrderByDescending(s => s.JoinedDate);
                    break;
                default:
                    students = students.OrderBy(s => s.PacteraEdgeEmail);
                    break;
            }
            int pageSize = 10;
            int roleId = (int)HttpContext.Session.GetInt32("role_id");

            var _role = _context.Roles.Where(s => s.Id == roleId).FirstOrDefault();
            if (_role.Title.Contains("Manager"))
            {
                ViewBag.RoleLevel = _role.Title;
            }
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
                
                int roleId = (int)HttpContext.Session.GetInt32("role_id");

                var _role = _context.Roles.Where(s => s.Id == roleId).FirstOrDefault();
                if (_role.Title.Contains("Manager"))
                {
                    ViewBag.RoleLevel = _role.Title;
                }
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
        public static decimal GetFinalPaymentAmount(string email, int lookupID)
        {
            decimal count = 0;
            try
            {
                MySqlConnection conn = null;

                string myConn = Configuration.GetConnectionString("myConn");
                conn = new MySqlConnection(myConn);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select TotalHrs*PayRateUS* (averagescore /100) from sglookup WHERE PacteraEdgeEmail='" + email + "' and LookupID=" + lookupID;

                count = Convert.ToDecimal(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        /// POST: Admins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("LookupID,FirstName,LastName,Contract,PacteraEdgeEmail,TotalHrs")] Sglookup admins)
        {
            var usdtotal = Request.Form["USDTotal"].ToString();
            if (!string.IsNullOrEmpty(usdtotal))
            {
                usdtotal = usdtotal;
            }
            else
            {
                usdtotal = "0";
            }
            if (id != admins.LookupID)
            {
                return NotFound();
            }
            decimal finalpaymentamount = GetFinalPaymentAmount(admins.PacteraEdgeEmail,id);
            
            Sglookup admin = await _context.Sglookup.Where(s => s.LookupID == admins.LookupID).FirstOrDefaultAsync();
            admin.FirstName = admins.FirstName;
            admin.LastName = admins.LastName;
            admin.Contract = admins.Contract;
            admin.PacteraEdgeEmail = admins.PacteraEdgeEmail;
            admin.TotalHrs = admins.TotalHrs;
            admin.USDTotal = Convert.ToDecimal(usdtotal);
            admin.finalamountpayable = finalpaymentamount;

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
        [HttpPost, ActionName("DeleteConfirmed")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var admins = await _context.Sglookup.SingleOrDefaultAsync(m => m.LookupID == id);
            admins.deleted = "true";
            //_context.Offlinehours.Remove(admins);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
       
        [HttpPost]
        public FileResult ExportToCSV()
        {
            
            MyDbContext entities = new MyDbContext();
            List<object> lstStudents = (from Student in entities.Sglookup.ToList()
                                        select new[] { Student.Status.ToString(),
                                                        Student.BillingMonth.ToString(),
                                                        Student.JoinedDate.ToString(),
                                                        Student.PacteraEdgeEmail.ToString(),
                                                        Student.Contract.ToString(),
                                                        Student.FirstName.ToString(),
                                                        Student.LastName.ToString(),
                                                        Student.oneforma.ToString(),
                                                        //Student.UHRS.ToString(),
                                                        Student.PayRateUS.ToString(),
                                                        Student.UserID.ToString(),
                                                        Student.SumOfTimeActive.ToString(),
                                                        Student.SumOfTimeInactive.ToString(),
                                                        Student.TotalTime.ToString(),
                                                        Student.Hrs.ToString(),
                                                        Student.ActiveHrs.ToString(),
                                                        Student.InactiveHrs.ToString(),
                                                        Student.BillableInactiveHrs.ToString(),
                                                        Student.TotalHrs.ToString(),
                                                        Student.Productivity.ToString(),
                                                        Student.ProductivityPercentage.ToString(),
                                                        Student.deleted.ToString(),
                                                        Student.averagerating.ToString(),
                                                        Student.quality.ToString(),
                                                        Student.qualitypercentage.ToString(),
                                                        Student.averagescore.ToString(),
                                                        Student.finalamountpayable.ToString(),
                                                        Student.USDTotal.ToString()
                                  }).ToList<object>();

            
            var names = typeof(Sglookup).GetProperties()
                        .Select(property => property.Name)
                        .ToArray();

            lstStudents.Insert(0, names.Where(x => x != names[0]).ToArray());

           
            StringBuilder sb = new StringBuilder();
            foreach (var item in lstStudents)
            {
                string[] arrStudents = (string[])item;
                foreach (var data in arrStudents)
                {
                    //Append data with comma(,) separator.
                    sb.Append(data + ',');
                }
                //Append new line character.
                sb.Append("\r\n");
            }

           
            return File(Encoding.ASCII.GetBytes(sb.ToString()), "text/csv", "Sglookup.csv");

        }

    }
}
