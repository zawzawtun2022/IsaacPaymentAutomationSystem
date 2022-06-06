using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using RoleBasedAuthorization.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RoleBasedAuthorization.Controllers
{
    public class HomeController : Controller
    {
        MyDbContext db = new MyDbContext();

        private readonly ILogger<HomeController> _logger;
        public static IConfiguration Configuration;
        public HomeController(ILogger<HomeController> logger, IConfiguration _configuration)
        {
            _logger = logger;
            Configuration = _configuration;
        }
        public static int GetAdminCount(string connStr)
        {
            int count = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) From admins WHERE roles_id=1";

                count = Convert.ToInt32(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static int GetManagerCount(string connStr)
        {
            int count = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) From admins WHERE roles_id=2";

                count = Convert.ToInt32(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static int GetProjectManagerCount(string connStr)
        {
            int count = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) From admins WHERE roles_id=6";

                count = Convert.ToInt32(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static int GetProjectCoordinatorCount(string connStr)
        {
            int count = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) From admins WHERE roles_id=7";

                count = Convert.ToInt32(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static int GetAnnotatorCount(string connStr)
        {
            int count = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) From admins WHERE roles_id=8";

                count = Convert.ToInt32(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static int GetTotalUsersCount(string connStr)
        {
            int count = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) From admins";

                count = Convert.ToInt32(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        [ServiceFilter(typeof(UserActivityFilter))]
        public IActionResult Index()
        {

            if (HttpContext.Session.GetString("email") == null)
            {
                return Redirect("/Account/Login");
            }
            DashboardViewModel dashboard = new DashboardViewModel();

            string emailId = HttpContext.Session.GetString("email").ToString();

            string myConn = Configuration.GetConnectionString("myConn");
            dashboard.admin_count = GetAdminCount(myConn);
            dashboard.manager_count = GetManagerCount(myConn);
            dashboard.projectmanager_count = GetProjectManagerCount(myConn);
            dashboard.projectcoordinator_count = GetProjectCoordinatorCount(myConn);
            dashboard.annotator_count = GetAnnotatorCount(myConn);
            dashboard.totalusers_count = GetTotalUsersCount(myConn); 

            dashboard.month_count = GetMonthCount(myConn, emailId);
            dashboard.annotate_count = GetAnnotateCount(myConn, emailId);
            dashboard.sumoftimeactive_count = Getsumoftimeactive_count(myConn, emailId);
            dashboard.sumoftimeinactive_count = Getsumoftimeinactive_count(myConn, emailId);
            dashboard.totaltime_count = Gettotaltime_count(myConn, emailId);
            dashboard.activehours_count = Getactivehours_count(myConn, emailId);
            dashboard.inactivehours_count = Getinactivehours_count(myConn, emailId);
            dashboard.billableinactivehours_count = Getbillableinactivehours_count(myConn, emailId);
            dashboard.totalhours_count = Gettotalhours_count(myConn, emailId);
            dashboard.productivity_count = Getproductivity_count(myConn, emailId);
            dashboard.productivitypercentage_count= Getproductivitypercentage_count(myConn, emailId);
            dashboard.averagerating_count = Getaveragerating_count(myConn, emailId);
            dashboard.quality_count = Getquality_count(myConn, emailId);
            dashboard.qualitypercentage_count = Getqualitypercentage_count(myConn, emailId);
            dashboard.averagescore_count= Getaveragescore_count(myConn, emailId);
            dashboard.finalamountpayable_count = Getfinalamountpayable_count(myConn, emailId);
            dashboard.USDTotal_count = GetTotalUSD_count(myConn, emailId);
            dashboard.dashboardstatus_count = Getdashboardstatus_count(myConn, emailId);
            dashboard.oneformaid_count = GetoneformID_count(myConn, emailId);
            
            return View(dashboard);


        }
        public static decimal GetTotalUSD_count(string connStr, string email)
        {
            decimal count = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT USDTotal From sglookup WHERE PacteraEdgeEmail='" + email + "' and BillingMonth=(SELECT MONTHNAME(STR_TO_DATE(month(now()), '%m')) AS 'Month Name')";

                count = Convert.ToDecimal(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static decimal Getfinalamountpayable_count(string connStr, string email)
        {
            decimal count = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT finalamountpayable From sglookup WHERE PacteraEdgeEmail='" + email + "' and BillingMonth=(SELECT MONTHNAME(STR_TO_DATE(month(now()), '%m')) AS 'Month Name')";

                count = Convert.ToDecimal(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static decimal Getquality_count(string connStr, string email)
        {
            decimal count = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT quality From sglookup WHERE PacteraEdgeEmail='" + email + "' and BillingMonth=(SELECT MONTHNAME(STR_TO_DATE(month(now()), '%m')) AS 'Month Name')";

                count = Convert.ToDecimal(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static decimal Getqualitypercentage_count(string connStr, string email)
        {
            decimal count = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT qualitypercentage From sglookup WHERE PacteraEdgeEmail='" + email + "' and BillingMonth=(SELECT MONTHNAME(STR_TO_DATE(month(now()), '%m')) AS 'Month Name')";

                count = Convert.ToDecimal(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public static decimal Getaveragescore_count(string connStr, string email)
        {
            decimal count = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT averagescore From sglookup WHERE PacteraEdgeEmail='" + email + "' and BillingMonth=(SELECT MONTHNAME(STR_TO_DATE(month(now()), '%m')) AS 'Month Name')";

                count = Convert.ToDecimal(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static string GetoneformID_count(string connStr, string email)
        {
            string count = "";
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT oneforma From sglookup WHERE PacteraEdgeEmail='" + email + "' and BillingMonth=(SELECT MONTHNAME(STR_TO_DATE(month(now()), '%m')) AS 'Month Name')";

                count = Convert.ToString(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public static string Getdashboardstatus_count(string connStr, string email)
        {
            string count = "";
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT dashboardstatus From sglookup WHERE PacteraEdgeEmail='" + email + "' and finalamountpayable is not null and BillingMonth=(SELECT MONTHNAME(STR_TO_DATE(month(now()), '%m')) AS 'Month Name')";

                count = Convert.ToString(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public static decimal Getaveragerating_count(string connStr, string email)
        {
            decimal count = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT AverageRating From sglookup WHERE PacteraEdgeEmail='" + email + "' and BillingMonth=(SELECT MONTHNAME(STR_TO_DATE(month(now()), '%m')) AS 'Month Name')";

                count = Convert.ToDecimal(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static decimal Getproductivitypercentage_count(string connStr, string email)
        {
            decimal count = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT ProductivityPercentage From sglookup WHERE PacteraEdgeEmail='" + email + "' and BillingMonth=(SELECT MONTHNAME(STR_TO_DATE(month(now()), '%m')) AS 'Month Name')";

                count = Convert.ToDecimal(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static decimal Getproductivity_count(string connStr, string email)
        {
            decimal count = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT Productivity From sglookup WHERE PacteraEdgeEmail='" + email + "' and BillingMonth=(SELECT MONTHNAME(STR_TO_DATE(month(now()), '%m')) AS 'Month Name')";

                count = Convert.ToDecimal(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static decimal Gettotalhours_count(string connStr, string email)
        {
            decimal count = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT TotalHrs From sglookup WHERE PacteraEdgeEmail='" + email + "' and BillingMonth=(SELECT MONTHNAME(STR_TO_DATE(month(now()), '%m')) AS 'Month Name')";

                count = Convert.ToDecimal(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static decimal Getbillableinactivehours_count(string connStr, string email)
        {
            decimal count = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT BillableInActiveHrs From sglookup WHERE PacteraEdgeEmail='" + email + "' and BillingMonth=(SELECT MONTHNAME(STR_TO_DATE(month(now()), '%m')) AS 'Month Name')";

                count = Convert.ToDecimal(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static decimal Getinactivehours_count(string connStr, string email)
        {
            decimal count = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT InActiveHrs From sglookup WHERE PacteraEdgeEmail='" + email + "' and BillingMonth=(SELECT MONTHNAME(STR_TO_DATE(month(now()), '%m')) AS 'Month Name')";

                count = Convert.ToDecimal(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static decimal Getactivehours_count(string connStr, string email)
        {
            decimal count = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT ActiveHrs From sglookup WHERE PacteraEdgeEmail='" + email + "' and BillingMonth=(SELECT MONTHNAME(STR_TO_DATE(month(now()), '%m')) AS 'Month Name')";

                count = Convert.ToDecimal(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static int Gettotaltime_count(string connStr, string email)
        {
            int count = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT TotalTime From sglookup WHERE PacteraEdgeEmail='" + email + "' and BillingMonth=(SELECT MONTHNAME(STR_TO_DATE(month(now()), '%m')) AS 'Month Name')";

                count = Convert.ToInt32(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static int Getsumoftimeinactive_count(string connStr, string email)
        {
            int count = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT SumOfTimeInactive From sglookup WHERE PacteraEdgeEmail='" + email + "' and BillingMonth=(SELECT MONTHNAME(STR_TO_DATE(month(now()), '%m')) AS 'Month Name')";

                count = Convert.ToInt32(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static int Getsumoftimeactive_count(string connStr, string email)
        {
            int count = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT SumOfTimeActive From sglookup WHERE PacteraEdgeEmail='" + email + "' and BillingMonth=(SELECT MONTHNAME(STR_TO_DATE(month(now()), '%m')) AS 'Month Name')";

                count = Convert.ToInt32(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public static string GetMonth(string connStr, string email)
        {
            string count = "";
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT MONTHNAME(STR_TO_DATE(month(now()), '%m')) AS 'Monthname'";
        
                count = Convert.ToString(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public static string GetAnnotateCount(string connStr, string email)
        {
            string count = "";
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT PacteraEdgeEmail From sglookup WHERE PacteraEdgeEmail='" + email + "' and BillingMonth=(SELECT MONTHNAME(STR_TO_DATE(month(now()), '%m')) AS 'Month Name')";

                count = Convert.ToString(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public static string GetMonthCount(string connStr, string email)
        {
            string count = "";
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT BillingMonth From sglookup WHERE PacteraEdgeEmail='" + email + "' and BillingMonth=(SELECT MONTHNAME(STR_TO_DATE(month(now()), '%m')) AS 'Month Name')";

                count = Convert.ToString(cmd.ExecuteScalar());

                return count;
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        [HttpPost, ActionName("OnApproval")]
        public async Task<IActionResult> OnApproval()
        {
            var oneformID = Request.Form["txtoneformaid"].ToString();
            var emailId = HttpContext.Session.GetString("email").ToString();
            string myConn = Configuration.GetConnectionString("myConn");
            var month = GetMonth(myConn, emailId).ToString();
            var admins = await db.Sglookup.FirstOrDefaultAsync(m => m.PacteraEdgeEmail == emailId && m.BillingMonth == month);
            admins.dashboardstatus = "Confirmed";
            admins.oneforma = oneformID;
            //_context.Sglookup.Remove(admins);
            await db.SaveChangesAsync();

            int annotatorId = (int)HttpContext.Session.GetInt32("id");
            HttpContext.Session.SetString("annotatorId", annotatorId.ToString());
            int myDbContext = db.Offlinehours.ToList().Where(s => s.createdby == annotatorId).ToList().Count;

            for (int i = 0; i < myDbContext; i++)
            {
                MySqlConnection conn = null;

                conn = new MySqlConnection(myConn);

                string query = "Update offlinehours SET status='Confirmed' WHERE createdby=" + annotatorId;
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}