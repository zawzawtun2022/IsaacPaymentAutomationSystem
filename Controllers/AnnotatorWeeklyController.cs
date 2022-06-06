using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Nancy.Json;
using RoleBasedAuthorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleBasedAuthorization.Controllers
{
    public class AnnotatorWeeklyController : Controller
    {
        MyDbContext _context = new MyDbContext();
        public static IConfiguration Configuration;

        public AnnotatorWeeklyController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }
        public IEnumerable<SelectListItem> GetMonth()
        {
             var Provinces = new List<SelectListItem>();
             
                Provinces.Add(new SelectListItem() { Text = "January", Value = "January" });
                Provinces.Add(new SelectListItem() { Text = "February", Value = "February" });
                Provinces.Add(new SelectListItem() { Text = "March", Value = "March" });
                Provinces.Add(new SelectListItem() { Text = "April", Value = "April" });
                Provinces.Add(new SelectListItem() { Text = "May", Value = "May" });
                Provinces.Add(new SelectListItem() { Text = "June", Value = "June" });
                Provinces.Add(new SelectListItem() { Text = "July", Value = "July" });
                Provinces.Add(new SelectListItem() { Text = "August", Value = "August" });
                Provinces.Add(new SelectListItem() { Text = "September", Value = "September" });
                Provinces.Add(new SelectListItem() { Text = "October", Value = "October" });
                Provinces.Add(new SelectListItem() { Text = "November", Value = "November" });
                Provinces.Add(new SelectListItem() { Text = "December", Value = "December" });

           return this.ViewBag.MONTHLY = new SelectList(Provinces, "Value", "Text");

        }

        public List<string> GetMonthList(string month)
        {
            List<string> domains = new List<string>();
            domains.Add("January");
            domains.Add("February");
            domains.Add("March");
            domains.Add("April");
            domains.Add("May");
            return domains;
        }
        public async Task<IActionResult> Index(int? errorId, string otherParam)
        {
            if (HttpContext.Session.GetString("email") == null)
            {
                return Redirect("/Account/Login");
            }
            if (errorId > 0)
            {
                ViewBag.numberofweek = errorId;
                //IEnumerable<SelectListItem> monthly = GetMonth();

                ViewBag.MONTHLY = new SelectList(_context.TblMonths, "MonthId", "Month", otherParam);
            }   
            else
            {
                ViewBag.MONTHLY = new SelectList(_context.TblMonths, "MonthId", "Month");
                //IEnumerable<SelectListItem> monthly = GetMonth();
                //ViewBag.MONTHLY = monthly;
            }
            //List<Admins> admins = db.Admins.ToList();
            //List<MonthlyReviews> monthlyreviews = db.MonthlyReviews.ToList();
            AnnotatorModels annotator = new AnnotatorModels();
            //int num = 7;
            //var admins = db.Admins.Where(s => s.RolesId.Equals(num)).Select(e => new SelectListItem() { Value = e.Id.ToString(), Text = e.FullName }).ToList();
            annotator.Annotators = PopulateAnnotators();


            //ViewData["ddlAnnotators"] = admins;

            return View(annotator);
        }
        private static List<SelectListItem> PopulateAnnotators()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            MySqlConnection conn = null;
            string myConn = Configuration.GetConnectionString("myConn");
            conn = new MySqlConnection(myConn);
            string query = " SELECT distinct id,full_name from admins where roles_id=8";
            using (MySqlCommand cmd = new MySqlCommand(query))
            {
                cmd.Connection = conn;
                conn.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        items.Add(new SelectListItem
                        {
                            Text = sdr["full_name"].ToString(),
                            Value = sdr["id"].ToString()
                        });
                    }
                }
                conn.Close();
            }

            return items;
        }

        [AuthorizedAction]
        public IActionResult Create()
        {

            //ViewBag.userroles = new SelectList(PopulateRole(), "Id", "FullName", 1);

            return View();
        }

        [HttpPost]
        public IActionResult WeeklyResult(AnnotatorModels annotatorModels)
        {
            int noofweek = Convert.ToInt32(Request.Form["Numberofweek"].ToString());
            annotatorModels.Annotators = PopulateAnnotators();

            
                if (noofweek == 1)
                {
                    if (annotatorModels.AnnotatorIds != null)
                    {
                            for (int i = 1; i < 2; i++)
                            {
                                var monthly = Request.Form["Monthly"].ToString();
                                var numberofweek = "Week" + i;
                                var startdate = Request.Form["Startdate_" + i].ToString();
                                var enddate = Request.Form["Enddate_" + i].ToString();

                                MySqlConnection conn = null;
                                string myConn = Configuration.GetConnectionString("myConn");
                                conn = new MySqlConnection(myConn);
                                string query = "insert into monthlyreviews(monthly,numberofweek,startdate,enddate) Values ('" + monthly + "','" + numberofweek + "','" + startdate + "','" + enddate + "'); SELECT LAST_INSERT_ID();";
                                conn.Open();
                                MySqlCommand cmd = new MySqlCommand(query, conn);
                                int id = Convert.ToInt32(cmd.ExecuteScalar());
                                conn.Close();



                                 List<SelectListItem> selectedItems = annotatorModels.Annotators.Where(p => annotatorModels.AnnotatorIds.Contains(int.Parse(p.Value))).ToList();

                                foreach (var selectedItem in selectedItems)
                                {
                                    selectedItem.Selected = true;
                                    var userid = selectedItem.Value;

                                    string query1 = "insert into assignmonthlyreviews(monthlyreviewID,rating,annotatorId,status,monthly) Values ('" + id + "','0','"+ userid + "','Processing','" + monthly + "')";
                                    conn.Open();
                                    MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                                    cmd1.ExecuteNonQuery();
                                    conn.Close();
                            }
                        }
                    }
                    
                }
                else if (noofweek == 2)
                {
                    for (int i = 1; i < 3; i++)
                    {
                        List<SelectListItem> selectedItems = annotatorModels.Annotators.Where(p => annotatorModels.AnnotatorIds.Contains(int.Parse(p.Value))).ToList();
                        var monthly = Request.Form["Monthly"].ToString();
                        var numberofweek = "Week" + i;
                        var startdate = Request.Form["Startdate_" + i].ToString();
                        var enddate = Request.Form["Enddate_" + i].ToString();

                        MySqlConnection conn = null;
                        string myConn = Configuration.GetConnectionString("myConn");
                        conn = new MySqlConnection(myConn);
                        string query = "insert into monthlyreviews(monthly,numberofweek,startdate,enddate) Values ('" + monthly + "','" + numberofweek + "','" + startdate + "','" + enddate + "'); SELECT LAST_INSERT_ID();";
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        int id = Convert.ToInt32(cmd.ExecuteScalar());
                        conn.Close();

                        foreach (var selectedItem in selectedItems)
                        {
                            selectedItem.Selected = true;
                            var userid = selectedItem.Value;

                            string query1 = "insert into assignmonthlyreviews(monthlyreviewID,rating,annotatorId,status,monthly) Values ('" + id + "','0','" + userid + "','Processing','" + monthly + "')";
                            conn.Open();
                            MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                            cmd1.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                }
                else if (noofweek == 3)
                {
                for (int i = 1; i < 4; i++)
                {
                    List<SelectListItem> selectedItems = annotatorModels.Annotators.Where(p => annotatorModels.AnnotatorIds.Contains(int.Parse(p.Value))).ToList();
                    var monthly = Request.Form["Monthly"].ToString();
                    var numberofweek = "Week" + i;
                    var startdate = Request.Form["Startdate_" + i].ToString();
                    var enddate = Request.Form["Enddate_" + i].ToString();

                    MySqlConnection conn = null;
                    string myConn = Configuration.GetConnectionString("myConn");
                    conn = new MySqlConnection(myConn);
                    string query = "insert into monthlyreviews(monthly,numberofweek,startdate,enddate) Values ('" + monthly + "','" + numberofweek + "','" + startdate + "','" + enddate + "'); SELECT LAST_INSERT_ID();";
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int id = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();

                    foreach (var selectedItem in selectedItems)
                        {
                            selectedItem.Selected = true;
                            var userid = selectedItem.Value;

                            string query1 = "insert into assignmonthlyreviews(monthlyreviewID,rating,annotatorId,status,monthly) Values ('" + id + "','0','" + userid + "','Processing','" + monthly + "')";
                            conn.Open();
                            MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                            cmd1.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                }
                else if (noofweek == 4)
                {
                    for (int i = 1; i < 5; i++)
                    {
                        List<SelectListItem> selectedItems = annotatorModels.Annotators.Where(p => annotatorModels.AnnotatorIds.Contains(int.Parse(p.Value))).ToList();
                        var monthly = Request.Form["Monthly"].ToString();
                        var numberofweek = "Week" + i;
                        var startdate = Request.Form["Startdate_" + i].ToString();
                        var enddate = Request.Form["Enddate_" + i].ToString();

                        MySqlConnection conn = null;
                        string myConn = Configuration.GetConnectionString("myConn");
                        conn = new MySqlConnection(myConn);
                        string query = "insert into monthlyreviews(monthly,numberofweek,startdate,enddate) Values ('" + monthly + "','" + numberofweek + "','" + startdate + "','" + enddate + "'); SELECT LAST_INSERT_ID();";
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        int id = Convert.ToInt32(cmd.ExecuteScalar());
                        conn.Close();

                        foreach (var selectedItem in selectedItems)
                        {
                            selectedItem.Selected = true;
                            var userid = selectedItem.Value;                            

                            string query1 = "insert into assignmonthlyreviews(monthlyreviewID,rating,annotatorId,status,monthly) Values ('" + id + "','0','" + userid + "','Processing','" + monthly + "')";
                            conn.Open();
                            MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                            cmd1.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                }
                else if (noofweek == 5)
                {
                    for (int i = 1; i < 6; i++)
                    {
                        List<SelectListItem> selectedItems = annotatorModels.Annotators.Where(p => annotatorModels.AnnotatorIds.Contains(int.Parse(p.Value))).ToList();
                        var monthly = Request.Form["Monthly"].ToString();
                        var numberofweek = "Week" + i;
                        var startdate = Request.Form["Startdate_" + i].ToString();
                        var enddate = Request.Form["Enddate_" + i].ToString();

                        MySqlConnection conn = null;
                        string myConn = Configuration.GetConnectionString("myConn");
                        conn = new MySqlConnection(myConn);
                        string query = "insert into monthlyreviews(monthly,numberofweek,startdate,enddate) Values ('" + monthly + "','" + numberofweek + "','" + startdate + "','" + enddate + "'); SELECT LAST_INSERT_ID();";
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        int id = Convert.ToInt32(cmd.ExecuteScalar());
                        conn.Close();

                        foreach (var selectedItem in selectedItems)
                        {
                            selectedItem.Selected = true;
                            var userid = selectedItem.Value;                        

                            string query1 = "insert into assignmonthlyreviews(monthlyreviewID,rating,annotatorId,status,monthly) Values ('" + id + "','0','" + userid + "','Processing','" + monthly + "')";
                            conn.Open();
                            MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                            cmd1.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                }     

            return RedirectToAction(nameof(Index));


        }
        // GET: Admins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var admins = await _context.MonthlyReviews.FindAsync(id);
            if (admins == null)
            {
                return NotFound();
            }
            //ViewBag.userroles = new SelectList(PopulateRole(), "Id", "FullName", admins.AnnotatorId);
            return View(admins);
        }

        // POST: Admins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("MonthlyreviewID,Monthly,Numberofweek,Startdate,Enddate,Rating,Status,AnnotatorId")] MonthlyReviews admins)
        {
            int monthID = Convert.ToInt32(Request.Form["monthID"].ToString());
            if (id != monthID)
            {
                return NotFound();
            }
            //var parentId = Request.Form["AnnotatorId"].ToString();
            //admins.AnnotatorId = Convert.ToInt32(parentId);

            MonthlyReviews admin = await _context.MonthlyReviews.Where(s => s.MonthlyreviewID == monthID).FirstOrDefaultAsync();
            admin.Monthly = admins.Monthly;
            admin.Numberofweek = admins.Numberofweek;
            admin.Startdate = admins.Startdate;
            admin.Enddate = admins.Enddate;
            //admin.Rating = admins.Rating;
            //admin.status = "Processing";
            //admin.AnnotatorId = admins.AnnotatorId;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        // POST: Admins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //public async Task<IActionResult> Create([Bind("MonthlyreviewID,Monthly,Numberofweek,Startdate,Enddate,Rating,Status,AnnotatorId")] MonthlyReviews admins)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var parentId = Request.Form["AnnotatorId"].ToString();
        //        //admins.AnnotatorId = Convert.ToInt32(parentId);
        //        //admins.Rating = "0";
        //        //admins.status = "Processing";
        //        db.Add(admins);
        //        await db.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    //ViewData["AnnotatorId"] = new SelectList(db.Admins, "Id", "FullName", admins.AnnotatorId);

        //    return View(admins);
        //}
        [HttpPost]
        public IActionResult IndexRecord(string ddl)
        {
            int noofweek = Convert.ToInt32(Request.Form["Numberofweek"].ToString());

            var month = Request.Form["MONTHLY"].ToString();
            ViewBag.MONTHLY  = month;

            ViewBag.numberofweek = noofweek;

            if (noofweek > 0)
            {
                ViewData["layer"] = "layer";
            }
            AnnotatorModels annotator = new AnnotatorModels();
            //int num = 7;
            //var admins = db.Admins.Where(s => s.RolesId.Equals(num)).Select(e => new SelectListItem() { Value = e.Id.ToString(), Text = e.FullName }).ToList();
            annotator.Annotators = PopulateAnnotators();

            return RedirectToAction("Index", new
            {
                @errorId = ViewBag.numberofweek,
                otherParam = ViewBag.MONTHLY
            });
            //return RedirectToAction(nameof(Index),ViewBag.numberofweek);

        } // GET: Admins/Edit/5

        // GET: Admins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var num = "Processing";
            List<Admins> admins = _context.Admins.ToList();
            List<MonthlyReviews> monthlyreviews = _context.MonthlyReviews.ToList();

            //var myDbContext = db.MonthlyReviews
            //                  .Where(s => s.status.Contains(num)).ToListAsync();
            //var results = (from p in admins
            //               join prd in monthlyreviews
            //               on p.Id equals prd.AnnotatorId
            //               where prd.status.Contains(num) && prd.MonthlyreviewID == id
            //               select new ViewModel
            //               {
            //                   admins = p,
            //                   monthlyreviews = prd
            //               }).ToList();
            return View();
        }

        // POST: Admins/DeleteConfirmed/5
        [HttpPost, ActionName("DeleteConfirmed")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var admins = await _context.MonthlyReviews.SingleOrDefaultAsync(m => m.MonthlyreviewID == id);
            //admins.status = "Calculated"; 
            //db.MonthlyReviews.Remove(admins);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
    

