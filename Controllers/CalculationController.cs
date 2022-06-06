using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using RoleBasedAuthorization.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RoleBasedAuthorization.Controllers
{
    public class CalculationController : Controller
    {
        MyDbContext _context = new MyDbContext();
        public static IConfiguration Configuration;



        [AuthorizedAction]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("email") == null)
            {
                return Redirect("/Account/Login");
            }
            return View();
        }

        private IHostingEnvironment hostingEnv;

        public CalculationController(IHostingEnvironment envc, IConfiguration _configuration)

        {
            Configuration = _configuration;
            this.hostingEnv = envc;

        }

        public IConfigurationRoot GetConnection()

        {

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();

            return builder;

        }


        [HttpGet]

        public IActionResult Calculation()

        {

            return View();

        }
        public static int GetCount(string Id)
        {
            MySqlConnection con = null;
            int items = 0;
            string myConn = Configuration.GetConnectionString("myConn");
            con = new MySqlConnection(myConn);
            string query = "SELECT COUNT(*) as count FROM Admins where Email='" + Id + "'";
            using (MySqlCommand cmd = new MySqlCommand(query))
            {
                cmd.Connection = con;
                con.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        items = Convert.ToInt32(sdr["count"].ToString());
                    }
                }
                con.Close();
            }
            return items;

        }
        [HttpPost]

        public async Task<IActionResult> Calculation(IFormFile FormFile)

        {
            //get file name
            var filename = ContentDispositionHeaderValue.Parse(FormFile.ContentDisposition).FileName.Trim('"');

            //get path
            var MainPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads");

            //create directory "Uploads" if it doesn't exists
            if (!Directory.Exists(MainPath))
            {
                Directory.CreateDirectory(MainPath);
            }

            //get file path 
            var filePath = Path.Combine(MainPath, FormFile.FileName);
            using (System.IO.Stream stream = new FileStream(filePath, FileMode.Create))
            {
                await FormFile.CopyToAsync(stream);
            }

            //get extension
            string extension = Path.GetExtension(filename);


            string cnn = string.Empty;

            switch (extension)
            {
                case ".xls": //Excel 97-03.
                    cnn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=YES'";
                    break;
                case ".xlsx": //Excel 07 and above.
                    cnn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=YES'";
                    break;
            }

            DataTable dt = new DataTable();
            cnn = string.Format(cnn, filePath);

            using (OleDbConnection connExcel = new OleDbConnection(cnn))
            {
                using (OleDbCommand cmdExcel = new OleDbCommand())
                {
                    using (OleDbDataAdapter odaExcel = new OleDbDataAdapter())
                    {
                        cmdExcel.Connection = connExcel;


                        //Get the name of First Sheet.
                        connExcel.Open();
                        DataTable dtExcelSchema;
                        dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        string sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                        connExcel.Close();

                        //Read Data from First Sheet.
                        connExcel.Open();
                        cmdExcel.CommandText = "SELECT * From [" + sheetName + "]";
                        odaExcel.SelectCommand = cmdExcel;
                        odaExcel.Fill(dt);
                        connExcel.Close();
                    }

                }
            }
            try
            {

            MySqlConnection conn = null;
            string myConn = Configuration.GetConnectionString("myConn");
            conn = new MySqlConnection(myConn);
            
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                long uIDActive = 0;
                long uIDInactive = 0;
                long uIDTimeTotal = 0;
                int averagerating = 0;
                int qualitypercentage = 0; 
                int averagescore = 0; 
                int finalamountpayable = 0; 
                int USDTotal = 0;
                SqlConnection sqlconn = null;
                string mysqlConn = Configuration.GetConnectionString("mySqlConn");
                    sqlconn = new SqlConnection(mysqlConn);

                    string queryString = "SELECT COALESCE(sum(TimeActive), 0) AS SumTimeActive,COALESCE(sum(TimeInActive), 0) as SumTimeInactive,COALESCE(sum(TimeTotal), 0) as SumTimeTotal FROM tblusers WHERE userid = '" + ds.Tables[0].Rows[i][8] + "'";
                    sqlconn.Open();
                SqlCommand cmd = new SqlCommand(queryString, sqlconn);

                SqlDataReader myReader = cmd.ExecuteReader();

                if (myReader.Read())
                {
                    uIDActive = Convert.ToInt64(myReader["SumTimeActive"].ToString());
                    uIDInactive = Convert.ToInt64(myReader["SumTimeInactive"].ToString());
                    uIDTimeTotal = Convert.ToInt64(myReader["SumTimeTotal"].ToString());

                     if (uIDTimeTotal.Equals(0))
                    {
                            //zero is nothing to do
                            sqlconn.Close();
                    }
                    else
                    {
                            var firstnumber = uIDTimeTotal;
                            var secondnumber = 60 * 60 * 1000;
                            var result = decimal.Divide(firstnumber, secondnumber);
                            var Hrs = Math.Round(result, 2, MidpointRounding.AwayFromZero); //Rounds "Hours"
                            var firstUIDActive = uIDActive;
                            var result1 = decimal.Divide(firstUIDActive, secondnumber);
                            var ActiveHrs = Math.Round(result1, 2, MidpointRounding.AwayFromZero); //Rounds "Active Hours"
                            var firstInactive = uIDInactive;
                            var result2 = decimal.Divide(firstInactive, secondnumber);
                            var productivityscore = Math.Round(result2, 2, MidpointRounding.AwayFromZero); //Rounds "Inactive Hours"

                            var tmpInactiveHrs = uIDInactive;
                            var InactiveHrs = decimal.Divide(tmpInactiveHrs, secondnumber);
                            //Billable Inactive Hours
                            //= IF(InactiveHrs > (0.24 * (ActiveHrs + InactiveHrs)), (0.24 * (ActiveHrs + InactiveHrs)), InactiveHrs)

                            decimal billvariable = Convert.ToDecimal(0.24);
                            var billresult = billvariable * (ActiveHrs + InactiveHrs);
                            var billresultValue = Math.Round(billresult, 2, MidpointRounding.AwayFromZero);
                            decimal BillableInactiveHrs;
                            if (InactiveHrs > billresultValue)
                            {
                                BillableInactiveHrs = billresultValue;
                            }
                            else
                            {
                                BillableInactiveHrs = InactiveHrs;
                            }
                            var GrandTotal = ActiveHrs + BillableInactiveHrs;
                            var quality = Request.Form["ddlnumberofquality"].ToString();
                            var qty = Convert.ToInt32(quality);
                            var email = HttpContext.Session.GetString("email").ToString();
                            var currentmonth = GetMonth(myConn, email).ToString();
                            //Productivity Excel Formula - =IF(B14="JP (Remote - FT)",AA14/(40*3),AA14/(20*3))

                            if (ds.Tables[0].Rows[i][2].ToString().Contains("Remote - FT"))
                            {
                                var firstvalue = GrandTotal;
                                var secondvalue = 40 * qty;
                                decimal productivity = decimal.Divide(firstvalue, secondvalue);
                                var productivityformula = Math.Round(productivity, 2, MidpointRounding.AwayFromZero); //Rounds "Inactive Hours"

                                int userid = (int)HttpContext.Session.GetInt32("id");

                                //Productivity % Excel Formula IF(productivityformula>0.8,1,productivityformula)*100
                                var InactivePercentage = InactiveHrs / (ActiveHrs + InactiveHrs);
                                var tmpValue = InactivePercentage * 100;
                                int productpercentage = 0;
                                if (tmpValue < 25)
                                {
                                    productpercentage = 100;
                                }
                                else if (tmpValue >= 25 && tmpValue <= 30)
                                {
                                    productpercentage = 80;
                                }
                                else if (tmpValue >= 31 && tmpValue <= 35)
                                {
                                    productpercentage = 75;
                                }
                                else if (tmpValue >= 36 && tmpValue <= 40)
                                {
                                    productpercentage = 70;
                                }
                                else if (tmpValue >= 41 && tmpValue <= 45)
                                {
                                    productpercentage = 65;
                                }
                                else if (tmpValue >= 46 && tmpValue <= 50)
                                {
                                    productpercentage = 60;
                                }
                                else if (tmpValue >= 50)
                                {
                                    productpercentage = 50;
                                }
                                    conn.Close();
                                    string query = "insert into sglookup(Status, JoinedDate, BillingMonth, Contract, FirstName, LastName, PacteraEdgeEmail, oneforma, PayRateUS, UserID, reviewer, SumOfTimeActive, SumOfTimeInactive, TotalTime, Hrs, ActiveHrs, InactiveHrs, BillableInactiveHrs, TotalHrs,Productivity,ProductivityPercentage,averagerating, qualitypercentage,averagescore,finalamountpayable,USDTotal,createdby,InactivePercentage) values ('" + ds.Tables[0].Rows[i][0].ToString() + "', '" + ds.Tables[0].Rows[i][1].ToString() + "', '" + currentmonth + "', '" + ds.Tables[0].Rows[i][2].ToString() + "', '" + ds.Tables[0].Rows[i][3].ToString() + "', '" + ds.Tables[0].Rows[i][4].ToString() + "', '" + ds.Tables[0].Rows[i][5].ToString() + "', '" + ds.Tables[0].Rows[i][6].ToString() + "', '" + ds.Tables[0].Rows[i][7].ToString() + "', '" + ds.Tables[0].Rows[i][8].ToString() + "', '" + ds.Tables[0].Rows[i][9].ToString() + "', '" + uIDActive + "', '" + uIDInactive + "', '" + uIDTimeTotal + "', '" + Hrs + "', '" + ActiveHrs + "', '" + InactiveHrs + "', '" + BillableInactiveHrs + "','" + GrandTotal + "', '" + productivityformula + "','" + productpercentage + "','" + averagerating + "','" + qualitypercentage + "', '" + averagescore + "', '" + finalamountpayable + "', '" + USDTotal + "', '" + userid + "', '" + InactivePercentage + "')";
                                    conn.Open();
                                    MySqlCommand cmd1 = new MySqlCommand(query, conn);
                                    cmd1.ExecuteNonQuery();
                                    conn.Close();

                            }
                            else
                            {

                                var firstvalue = GrandTotal;
                                var secondvalue = 20 * qty;
                                decimal productivity = decimal.Divide(firstvalue, secondvalue);
                                var productivityformula = Math.Round(productivity, 2, MidpointRounding.AwayFromZero); //Rounds "Inactive Hours"
                                int userid = (int)HttpContext.Session.GetInt32("id");

                                //Productivity % Excel Formula IF(productivityformula>0.8,1,productivityformula)*100
                                var InactivePercentage = InactiveHrs / (ActiveHrs + InactiveHrs);
                                var tmpValue = InactivePercentage * 100;
                                int productpercentage = 0;
                                if (tmpValue < 25)
                                {
                                    productpercentage = 100;
                                }
                                else if (tmpValue >= 25 && tmpValue <= 30)
                                {
                                    productpercentage = 80;
                                }
                                else if (tmpValue >= 31 && tmpValue <= 35)
                                {
                                    productpercentage = 75;
                                }
                                else if (tmpValue >= 36 && tmpValue <= 40)
                                {
                                    productpercentage = 70;
                                }
                                else if (tmpValue >= 41 && tmpValue <= 45)
                                {
                                    productpercentage = 65;
                                }
                                else if (tmpValue >= 46 && tmpValue <= 50)
                                {
                                    productpercentage = 60;
                                }
                                else if (tmpValue >= 50)
                                {
                                    productpercentage = 50;
                                }
                                conn.Close();
                                string query = "insert into sglookup(Status, JoinedDate, BillingMonth, Contract, FirstName, LastName, PacteraEdgeEmail, oneforma, PayRateUS, UserID, reviewer, SumOfTimeActive, SumOfTimeInactive, TotalTime, Hrs, ActiveHrs, InactiveHrs, BillableInactiveHrs, TotalHrs,Productivity,ProductivityPercentage,averagerating, qualitypercentage,averagescore,finalamountpayable,USDTotal,createdby,InactivePercentage) values ('" + ds.Tables[0].Rows[i][0].ToString() + "', '" + ds.Tables[0].Rows[i][1].ToString() + "', '" + currentmonth + "', '" + ds.Tables[0].Rows[i][2].ToString() + "', '" + ds.Tables[0].Rows[i][3].ToString() + "', '" + ds.Tables[0].Rows[i][4].ToString() + "', '" + ds.Tables[0].Rows[i][5].ToString() + "', '" + ds.Tables[0].Rows[i][6].ToString() + "', '" + ds.Tables[0].Rows[i][7].ToString() + "', '" + ds.Tables[0].Rows[i][8].ToString() + "', '" + ds.Tables[0].Rows[i][9].ToString() + "', '" + uIDActive + "', '" + uIDInactive + "', '" + uIDTimeTotal + "', '" + Hrs + "', '" + ActiveHrs + "', '" + InactiveHrs + "', '" + BillableInactiveHrs + "','" + GrandTotal + "', '" + productivityformula + "','" + productpercentage + "','" + averagerating + "','" + qualitypercentage + "', '" + averagescore + "', '" + finalamountpayable + "', '" + USDTotal + "', '" + userid + "', '" + InactivePercentage + "')";
                                conn.Open();
                                MySqlCommand cmd1 = new MySqlCommand(query, conn);
                                cmd1.ExecuteNonQuery();
                                conn.Close();

                            }
                            if (GetCount(ds.Tables[0].Rows[i][5].ToString()) > 0)
                            {

                            }
                            else
                            {

                                int reviewerId = GetReviewer(myConn, ds.Tables[0].Rows[i][9].ToString());
                                string userid = ds.Tables[0].Rows[i][8].ToString();

                                if (reviewerId > 0)
                                {
                                    reviewerId = reviewerId;
                                }
                                else
                                {
                                    reviewerId = 1;
                                }
                                //insert into admins table accordingly
                                string query1 = "insert into admins(full_name, email, password, roles_id,level,parentadminroleid,userid) values ('" + ds.Tables[0].Rows[i][3].ToString() + " " + ds.Tables[0].Rows[i][4].ToString() + "','" + ds.Tables[0].Rows[i][5].ToString() + "','123456','8','" + ds.Tables[0].Rows[i][10].ToString() + "','" + reviewerId + "','" + userid +"')";
                                conn.Open();
                                MySqlCommand cmd2 = new MySqlCommand(query1, conn);
                                cmd2.ExecuteNonQuery();
                                conn.Close();
                            }
                        }
                                       
                }

                else
                {
                    return null;
                }


            }
                ViewBag.Message = "File Imported and excel data saved into database";
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendErrorToText(ex);
                ViewBag.Message = "File Imported is invalid data saved into database";
            }
            //if the code reach here means everthing goes fine and excel data is imported into database
            


            return View("Index");
        }
        public static int GetReviewer(string connStr, string name)
        {
            int count = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select id from admins where full_name like '%" + name + "%'";

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

        
    }
}

