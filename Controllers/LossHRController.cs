using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoleBasedAuthorization.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using PageList;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace RoleBasedAuthorization.Controllers
{
    public class LossHRController : Controller
    {
        public static IConfiguration Configuration;

        public LossHRController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("email") == null)
            {
                return Redirect("/Account/Login");
            }
            Dropdownlist multi_Dropdownlist = new Dropdownlist
            {
                //lookupList = PopulateEmailID(),
                typeoftaskList = PopulateTask()
            };
            return View(multi_Dropdownlist);
        }

        private static string PopulateJobID(string jobid)
        {

            SqlConnection con = null;
            String items = "";

            string myConn = Configuration.GetConnectionString("mySqlConn");
            con = new SqlConnection(myConn);
            string query = "SELECT JobName, JobID FROM tblusers where JobID='" + jobid + "'";
            using (SqlCommand cmd = new SqlCommand(query))
            {
                cmd.Connection = con;
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        items = sdr["JobName"].ToString();
                    }
                }
                con.Close();
            }
            return items;
        }

        private List<Sglookup> PopulateEmailID()
        {
            int userid = HttpContext.Session.GetInt32("id").Value;
            var useremail = HttpContext.Session.GetString("email").ToString();
            MySqlConnection con = null;
            string myConn = Configuration.GetConnectionString("myConn");
            con = new MySqlConnection(myConn);
            List<Sglookup> items = new List<Sglookup>();
            string query = "";
            if (userid.Equals(1) || userid.Equals(2) || userid.Equals(3))
            {                
                query = "SELECT sglookup.PacteraEdgeEmail, sglookup.LookupID FROM sglookup inner join admins on sglookup.PacteraEdgeEmail = admins.email";

            }
            else
            {
                query = "SELECT sglookup.PacteraEdgeEmail, sglookup.LookupID FROM sglookup inner join admins on sglookup.PacteraEdgeEmail = admins.email WHERE sglookup.PacteraEdgeEmail='" + useremail + "' limit 1";

            }
            string createdBy = HttpContext.Session.GetString("email").ToString();

             using (MySqlCommand cmd = new MySqlCommand(query))
            {
                cmd.Connection = con;
                con.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        items.Add(new Sglookup
                        {
                            LookupID = Convert.ToInt32(sdr["LookupID"]),
                            PacteraEdgeEmail = Convert.ToString(sdr["PacteraEdgeEmail"])                            
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
            string query = "SELECT TypeOfTask, TypeOfTaskID FROM typeoftask";
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

        [HttpPost]
        public IActionResult LossHR(string fav_starshot, IFormCollection fobj)
        {
            int createdBy = HttpContext.Session.GetInt32("id").Value;

            //email id - dropdownlist
            var emailValue = HttpContext.Session.GetString("email").ToString();
            //type task - dropdownlist
            var typeTaskValue = fobj["hidden2"].ToString();
            MySqlConnection conn = null;
            string[] stringSeparators = new string[] { "\r\n" };

            var jobid = Request.Form["txtJobID"].ToString();
            //ViewBag.Result = PopulateJobID(jobid);
            //ViewBag.jobid = jobid;
            //string[] jobvalue = jobid.Split(":", StringSplitOptions.None).ToString();
            string[] jobresult = jobid.Split(stringSeparators, StringSplitOptions.None);
            var result = jobresult[0].ToString();
            string[] jobIDValue = result.Split(": ", StringSplitOptions.RemoveEmptyEntries);
            var result1 = jobIDValue[1].ToString();
            var taskID = jobresult[1].ToString();
            string[] taskIDValue = taskID.Split(": ", StringSplitOptions.RemoveEmptyEntries);
            var result2 = taskIDValue[1].ToString();
            var workID = jobresult[2].ToString();
            string[] workIDValue = workID.Split(": ", StringSplitOptions.RemoveEmptyEntries);
            var result3 = workIDValue[1].ToString();

            var jobname = Request.Form["txtJobName"].ToString();
            var locale = Request.Form["txtLocale"].ToString();
            //var selectedDate = Request.Form["txtSelectedDate"].ToString();
            var WH = Request.Form["txttimetaken"].ToString();
            var selecteditem = fav_starshot;

            if (!String.IsNullOrEmpty(emailValue) && !String.IsNullOrEmpty(typeTaskValue))
            {
                var guidValue = result2;
                var guidValue1 = result3;
                var status = "Processing";

                string myConn = Configuration.GetConnectionString("myConn");
                conn = new MySqlConnection(myConn);
                string query = "insert into offlinehours(JobID,Locale,PacteraEdgeEmail,TaskID,WorkID,WorkedHrs,StarshotCrashIsError,TypeOfTaskID,status,createdby) Values ('" + jobname + "','" + locale + "','" + emailValue + "','" + guidValue + "','" + guidValue1 + "','" + WH + "','" + selecteditem + "','" + typeTaskValue + "','" + status + "','" + createdBy + "')";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                ViewBag.Message = "Inserted data saved into database!";

            }
            else
            {
                ViewBag.Message = "Please choose data!";
            }
            Dropdownlist multi_Dropdownlist = new Dropdownlist
            {
               // lookupList = PopulateEmailID(),
                typeoftaskList = PopulateTask()
                //userList = PopulateJobID()
            };
            //if the code reach here means everthing goes fine and excel data is imported into database

            return View("Index", multi_Dropdownlist);

        }


        [HttpPost]
        public IActionResult Generate()
        {
            string[] stringSeparators = new string[] { "\r\n" };

            //Guid guid = Guid.NewGuid();
            var jobid = Request.Form["txtJobID"].ToString();
            //ViewBag.Result = PopulateJobID(jobid);
            //ViewBag.jobid = jobid;
            //string[] jobvalue = jobid.Split(":", StringSplitOptions.None).ToString();
            string[] jobresult = jobid.Split(stringSeparators, StringSplitOptions.None);
            var result = jobresult[0].ToString();
            string[] jobIDValue = result.Split(": ", StringSplitOptions.RemoveEmptyEntries);
            var result1 = jobIDValue[1].ToString();
            var taskID = jobresult[1].ToString();
            string[] taskIDValue = taskID.Split(": ", StringSplitOptions.RemoveEmptyEntries);
            var result2 = taskIDValue[1].ToString();
            var workID = jobresult[2].ToString();
            string[] workIDValue = workID.Split(": ", StringSplitOptions.RemoveEmptyEntries);
            var result3 = workIDValue[1].ToString();

            var jobname = PopulateJobID(result1);
            ViewBag.Result = PopulateJobID(result1);
            ViewBag.jobid = jobid;
            ViewBag.taskid = result2;
            ViewBag.workID = result3;
            if (!String.IsNullOrEmpty(jobname))
            {
                ViewBag.locale = jobname.Substring(0, 2);
            }
            Dropdownlist multi_Dropdownlist = new Dropdownlist
            {
                //lookupList = PopulateEmailID(),
                typeoftaskList = PopulateTask()
                //userList = PopulateJobID()
            };

            return View("Index", multi_Dropdownlist);
        }
    }
}