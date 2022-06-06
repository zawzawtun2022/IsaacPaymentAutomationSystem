using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using RoleBasedAuthorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace RoleBasedAuthorization.Controllers
{
    public class AnnotatorCheckerController : Controller
    {
        MyDbContext db = new MyDbContext();
        public static IConfiguration Configuration;

        public AnnotatorCheckerController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("email") == null)
            {
                return Redirect("/Account/Login");
            }
            //Dropdownlist multi_Dropdownlist = new Dropdownlist
            //{
            //    month = PopulateMonthly(),
            //    childusertype = PopulateUserTypes(Id)
            //    //userList = PopulateJobID()
            //};
            MonthlyReviews objParent = new MonthlyReviews();

            //List<Menus> menus = db.LinkRolesMenus.Where(s => s.RolesId == roleId).Select(s => s.Menus).OrderBy(s => s.Id).ToList();
            int Id = HttpContext.Session.GetInt32("id").Value;

            IEnumerable<SelectListItem> monthly = GetMonth();
            ViewBag.MONTHLY = monthly;

            IEnumerable<SelectListItem> item = GetUserType(Id);
            ViewBag.ITEM = item;
            
            var num = "Listing";
            var myDbContext = db.AssignMonthlyReviews
                              .Where(s => s.status.Contains(num)).ToAsyncEnumerable();

            List<MonthlyReviews> viewmodelList = new List<MonthlyReviews>();
            viewmodelList.Add(objParent);
            
            return View(viewmodelList.AsEnumerable());

        }
        public IEnumerable<SelectListItem> GetMonth()
        {
            List<SelectListItem> list = null;

            using (var context = new MyDbContext())
            { 
                // Queries DB for list of categories by AccountID
                var query = ( from ca in context.MonthlyReviews
                             orderby ca.Monthly
                             select new SelectListItem { Text = ca.Monthly, Value = ca.Monthly }).Distinct();
                list = query.ToList();
                                
            }

            return list;
        }
        public static int IsCalculated(int Id, string month)
        {
            int count = 0;
            try
            {
                MySqlConnection conn = null;
                string myConn = Configuration.GetConnectionString("myConn");
                conn = new MySqlConnection(myConn);                
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select count(*) from monthlyreviews WHERE AnnotatorId=" + Id + " and status='Calculated' and monthly='" + month + "'";

                count = Convert.ToInt32(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static decimal GetAverageRating(int Id, string month)
        {
            decimal count = 0;
            try
            {
                MySqlConnection conn = null;
                string myConn = Configuration.GetConnectionString("myConn");
                conn = new MySqlConnection(myConn);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select sum(rating)/count(*) from assignmonthlyreviews WHERE AnnotatorId=" + Id + " and monthly='" + month + "' and status='Calculated'";

                count = Convert.ToDecimal(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static decimal GetAverageScore(string email, decimal qualitypercentageformula)
        {
            decimal count = 0;
            try
            {
                MySqlConnection conn = null;
                string myConn = Configuration.GetConnectionString("myConn");
                conn = new MySqlConnection(myConn);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select avg(ProductivityPercentage + "+ qualitypercentageformula + ") / 2 as averagecolumn from sglookup WHERE PacteraEdgeEmail='" + email + "'";

                count = Convert.ToDecimal(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static decimal GetFinalPaymentAmount(string email, decimal qualitypercentageformula, string month)
        {
            decimal count = 0;
            try
            {
                MySqlConnection conn = null;
                string myConn = Configuration.GetConnectionString("myConn");
                conn = new MySqlConnection(myConn);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select TotalHrs*PayRateUS*" + qualitypercentageformula +"/ 100 from sglookup WHERE PacteraEdgeEmail='" + email + "'and BillingMonth='" + month + "'";

                count = Convert.ToDecimal(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public IEnumerable<SelectListItem> GetUserType(int Id)
        {
            List<SelectListItem> list = null;

            using (var context = new MyDbContext())
            {
                // Queries DB for list of categories by AccountID
                var query = (from ca in context.Admins
                             where ca.parentadminroleid == Id && ca.RolesId == 8
                             orderby ca.Email
                             select new SelectListItem { Text = ca.Email, Value = ca.Id.ToString() }).Distinct();
                list = query.ToList();

            }

            return list;
        }

        public static string GetUserTypeEmail(string Id)
        {
                MySqlConnection con = null;
                String items = "";
                string myConn = Configuration.GetConnectionString("myConn");
                con = new MySqlConnection(myConn);
                string query = "SELECT Email, Id FROM Admins where Id=" + Id + "";
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            items = sdr["Email"].ToString();
                        }
                    }
                    con.Close();
                }
                return items;
            
        }
        public async Task<IActionResult> OnGetDelete()
        {
            int myDbContext = db.MonthlyReviews.ToList().Count;

            for (int i = 0; i < myDbContext; i++)
            {
                MySqlConnection conn = null;
                string myConn = Configuration.GetConnectionString("myConn");
                conn = new MySqlConnection(myConn);
                string query = "Update monthlyreviews SET status='Processing'";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            return RedirectToAction(nameof(Index));
        }
        [HttpPost]

        public async Task<IActionResult> AnnotatorChecker( [Bind("MonthlyreviewID,status")] AssignMonthlyReviews admins, MonthlyReviews monthlyReviews)

        {
            var month = Request.Form["ddlMonthly"].ToString();
            int usertype = Convert.ToInt32(Request.Form["ddlchildusertype"].ToString());
            int Id = HttpContext.Session.GetInt32("id").Value;

            var type = usertype.ToString();
            var email = GetUserTypeEmail(type).ToString();
                        
            IEnumerable<SelectListItem> monthly = GetMonth();
            HttpContext.Session.SetString("MONTHLY", month);
            ViewBag.MONTHLY = monthly;

            IEnumerable<SelectListItem> item = GetUserType(Id);
            HttpContext.Session.SetInt32("ITEM", usertype);
            HttpContext.Session.SetString("ITEMEMAIL", email);
            ViewBag.ITEM = item;

            var statusvar = "Processing";
            int myDbContext = db.AssignMonthlyReviews
                              .Where(s => s.Monthly.Contains(month) && s.AnnotatorID.Equals(usertype) && s.status.Contains(statusvar)).ToList().Count;

            //AssignMonthlyReviews admin = await db.AssignMonthlyReviews.Where(s => s.AnnotatorID.Equals(usertype)).FirstOrDefaultAsync();
            for (int i = 0; i < myDbContext; i++)
            {
                MySqlConnection conn = null;
                string myConn = Configuration.GetConnectionString("myConn");
                conn = new MySqlConnection(myConn);
                string query1 = "Update AssignMonthlyReviews SET status='Listing' WHERE AnnotatorId=" + usertype+ " and Monthly='" + month + "'";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query1, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            var varstatus = "Listing";
            var query = from p in db.AssignMonthlyReviews
                        join prd in db.MonthlyReviews
                        on p.MonthlyreviewID equals prd.MonthlyreviewID
                        where p.status.Contains(varstatus) && p.AnnotatorID == usertype && p.Monthly == month
                        select new
                        {
                            p.MonthlyreviewID,
                            p.Monthly,
                            prd.Numberofweek,
                            prd.Startdate,
                            prd.Enddate,
                            p.Rating
                        };

            List<MonthlyReviews> data_to_View = new List<MonthlyReviews>();

            foreach (var note_data in query)

            {

                //< Data >
                MonthlyReviews data = new MonthlyReviews();
                data.MonthlyreviewID = note_data.MonthlyreviewID;
                AssignMonthlyReviews assignment = await db.AssignMonthlyReviews.Where(s => s.AnnotatorID.Equals(usertype) && s.MonthlyreviewID.Equals(note_data.MonthlyreviewID)).FirstOrDefaultAsync();

                data.AssignMonthlyReviews = assignment;

                data.Monthly = note_data.Monthly;

                data.Numberofweek = note_data.Numberofweek;

                data.Startdate = note_data.Startdate;

                data.Enddate = note_data.Enddate;

                if (note_data.Rating == 0)
                {
                    data.AssignMonthlyReviews.Rating = 0;
                }
                else
                {
                    data.AssignMonthlyReviews.Rating = note_data.Rating;
                }
                

                //</ Data 

                //< add >
                data_to_View.Add(data);
                
                //</ add >

            }

            //--</ fill Data_to_View >--


            //< out to view >

            return View("Index",data_to_View.AsEnumerable());
            

            //return View("Index", query);

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

                
                List<MonthlyReviews> monthlyReviews = new List<MonthlyReviews>();
                var varstatus = "Listing";
                var query = (from p in db.AssignMonthlyReviews
                            join prd in db.MonthlyReviews
                            on p.MonthlyreviewID equals prd.MonthlyreviewID
                            where p.status.Contains(varstatus) && p.MonthlyreviewID == id
                            select new
                            {
                                p.MonthlyreviewID,
                                p.Monthly,
                                prd.Numberofweek,
                                prd.Startdate,
                                prd.Enddate,
                                p.Rating,
                                p.AnnotatorID
                            }).ToList();
                if (query == null)
                {
                    return NotFound();
                }
                MonthlyReviews vm = new MonthlyReviews();
                foreach (var items in query)
                {
                    AssignMonthlyReviews admin = await db.AssignMonthlyReviews.Where(s => s.MonthlyreviewID == id).FirstOrDefaultAsync();
                    vm.AssignMonthlyReviews = admin;
                    vm.MonthlyreviewID = items.MonthlyreviewID;
                    vm.Monthly = items.Monthly;
                    vm.Numberofweek = items.Numberofweek;
                    vm.Startdate = items.Startdate; 
                    vm.Enddate = items.Enddate;
                    vm.AssignMonthlyReviews.AnnotatorID = items.AnnotatorID;
                    vm.AssignMonthlyReviews.Rating = items.Rating;
                }
                var student = vm;
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
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("AssignID,MonthlyreviewID")] AssignMonthlyReviews admins)
        {
            if (id != admins.MonthlyreviewID)
            {
                return NotFound();
            }
            int rating = Convert.ToInt32(Request.Form["rating"].ToString());
            AssignMonthlyReviews admin = await db.AssignMonthlyReviews.Where(s => s.MonthlyreviewID == admins.MonthlyreviewID && s.status == "Listing").FirstOrDefaultAsync();
            admin.Rating = rating;
            await db.SaveChangesAsync();

            IEnumerable<SelectListItem> monthly = GetMonth();
            HttpContext.Session.SetString("MONTHLY", admin.Monthly);
            ViewBag.MONTHLY = monthly;
            
            int Id = HttpContext.Session.GetInt32("id").Value;
            int usertype = admin.AnnotatorID;
            var type = usertype.ToString();
            var email = GetUserTypeEmail(type).ToString();
            IEnumerable<SelectListItem> item = GetUserType(Id);
            HttpContext.Session.SetInt32("ITEM", usertype);
            HttpContext.Session.SetString("ITEMEMAIL", email);
            ViewBag.ITEM = item;

            var varstatus = "Listing";
            var query = (from p in db.AssignMonthlyReviews
                         join prd in db.MonthlyReviews
                         on p.MonthlyreviewID equals prd.MonthlyreviewID
                         where p.status.Contains(varstatus) && p.AnnotatorID == admin.AnnotatorID && p.Monthly == admin.Monthly
                        select new
                        {
                            p.MonthlyreviewID,
                            p.Monthly,
                            prd.Numberofweek,
                            prd.Startdate,
                            prd.Enddate,
                            p.Rating
                        }).ToList();

            List<MonthlyReviews> data_to_View = new List<MonthlyReviews>();

            foreach (var note_data in query)

            {

                //< Data >
                MonthlyReviews data = new MonthlyReviews();
                AssignMonthlyReviews assignment = await db.AssignMonthlyReviews.Where(s => s.MonthlyreviewID == note_data.MonthlyreviewID && s.Monthly == admin.Monthly && s.status == "Listing").FirstOrDefaultAsync();

                data.AssignMonthlyReviews = assignment;
                data.MonthlyreviewID = note_data.MonthlyreviewID;

                data.Monthly = note_data.Monthly;

                data.Numberofweek = note_data.Numberofweek;

                data.Startdate = note_data.Startdate;

                data.Enddate = note_data.Enddate;

                if (note_data.Rating == 0)
                {
                    data.AssignMonthlyReviews.Rating = 0;
                }
                else
                {
                    data.AssignMonthlyReviews.Rating = note_data.Rating;
                }


                //</ Data 

                //< add >
                data_to_View.Add(data);

                //</ add >

            }

            //--</ fill Data_to_View >--


            //< out to view >

            return View("Index", data_to_View.AsEnumerable());

        }

        /// POST: Admins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> RetrieveResult()
        {
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("MONTHLY")))
            {
                //var quality = Request.Form["ddlnumberofquality"].ToString();
                //int numberofquality = Convert.ToInt32(quality);
                int usertype = HttpContext.Session.GetInt32("ITEM").Value;
                var month = HttpContext.Session.GetString("MONTHLY").ToString();
                var email = HttpContext.Session.GetString("ITEMEMAIL").ToString();


                if (IsCalculated(usertype, month) > 0)
                {
                    ViewBag.Message = "Data is calculated already done!!!";
                }
                else
                {
                    MySqlConnection conn = null;
                    string myConn = Configuration.GetConnectionString("myConn");
                    conn = new MySqlConnection(myConn);
                    string query = "Update assignmonthlyreviews SET status='Calculated' WHERE AnnotatorId=" + usertype + " and Monthly='" + month + "'";
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    //retrieve average functions
                    decimal average = GetAverageRating(usertype, month);
                    var averageformula = Math.Round(average, 2, MidpointRounding.AwayFromZero); //Rounds "Inactive Hours"

                    //0,1,1A - Reviewer
                    //2 - no need quality check Quality 100 % -80 %
                    
                    var _level = db.Admins.Where(s => s.Id == usertype).FirstOrDefault();
                    if (_level.Level.Contains("0") || _level.Level.Contains("1") || _level.Level.Contains("1A"))
                    {
                        var qualityValue = averageformula * 10;
                        //=IF(P158>94,100,P158) for quality%
                        decimal qualitypercentage = 0;
                        decimal qualitypercentageformula = 0;
                        if (qualityValue > 94)
                        {
                            qualitypercentage = 100;
                            qualitypercentageformula = Math.Round(qualitypercentage, 2, MidpointRounding.AwayFromZero); //Rounds "Inactive Hours"
                        }
                        else
                        {
                            qualitypercentage = qualityValue;
                            qualitypercentageformula = Math.Round(qualitypercentage, 2, MidpointRounding.AwayFromZero); //Rounds "Inactive Hours"

                        }
                        var averagescore1 = GetAverageScore(email, qualitypercentageformula);
                        var averagescoreformula1 = Math.Round(averagescore1, 2, MidpointRounding.AwayFromZero); //Rounds "Inactive Hours"

                        //final amount formula
                        //=(AA146*I146*(S146/100))+SUM(AD146:AF146)
                        //=(TotalHours*RatePerHr(AverageScore/100)) + SUM(UHRSUSD)
                        decimal finalpaymentamount1 = GetFinalPaymentAmount(email, qualitypercentageformula, month);
                        string query2 = "Update sglookup SET averagerating='" + averageformula + "', quality='" + qualityValue + "', qualitypercentage='" + qualitypercentageformula + "', averagescore='" + averagescoreformula1 + "', finalamountpayable='" + finalpaymentamount1 + "' WHERE PacteraEdgeEmail='" + email + "' and BillingMonth='" + month + "'";
                        conn.Open();
                        MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                        cmd2.ExecuteNonQuery();
                        conn.Close();
                    }
                    else if (_level.Level.Contains("2"))
                    {
                        var qualityValue = averageformula * 10;
                        //=IF(P158>94,100,P158) for quality%
                        decimal qualitypercentage = 0;
                        decimal qualitypercentageformula = 0;
                        qualitypercentage = qualityValue;
                        qualitypercentageformula = Math.Round(qualitypercentage, 2, MidpointRounding.AwayFromZero); //Rounds "Inactive Hours"
                        var averagescore1 = GetAverageScore(email, qualitypercentageformula);
                        var averagescoreformula1 = Math.Round(averagescore1, 2, MidpointRounding.AwayFromZero); //Rounds "Inactive Hours"

                        var averagescore = GetAverageScore(email, qualitypercentageformula);
                        var averagescoreformula = Math.Round(averagescore, 2, MidpointRounding.AwayFromZero); //Rounds "Inactive Hours"

                        //final amount formula
                        //=(AA146*I146*(S146/100))+SUM(AD146:AF146)
                        //=(TotalHours*RatePerHr(AverageScore/100)) + SUM(UHRSUSD)
                        decimal finalpaymentamount = GetFinalPaymentAmount(email, qualitypercentageformula, month);
                        string query1 = "Update sglookup SET averagerating='" + averageformula + "', quality='" + qualityValue + "', qualitypercentage='" + qualitypercentageformula + "', averagescore='" + averagescoreformula + "', finalamountpayable='" + finalpaymentamount + "' WHERE PacteraEdgeEmail='" + email + "' and BillingMonth='" + month + "'";
                        conn.Open();
                        MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                        cmd1.ExecuteNonQuery();
                        conn.Close();
                    }

                    

                    ViewBag.Message = "Inserted data into the database!!!";

                    }
            }

            return RedirectToAction(nameof(Index));
        }
        
    }
}
