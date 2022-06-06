using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleBasedAuthorization.Models;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using OfficeOpenXml;
using Microsoft.EntityFrameworkCore;
using static System.Net.WebRequestMethods;
using System;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using MySqlConnector;

namespace RoleBasedAuthorization.Controllers
{
    public class ImportsController : Controller
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

        public ImportsController(IHostingEnvironment env, IConfiguration _configuration)

        {
            Configuration = _configuration;
            this.hostingEnv = env;

        }

        public IConfigurationRoot GetConnection()

        {

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();

            return builder;

        }


        [HttpGet]

        public IActionResult Import()

        {

            return View();

        }
        //public async Task<bool> InsertCSVRecords(DataTable csvdt)
        //{
        //    try
        //    {
        //        MySqlConnection sqlConnection = new MySqlConnection();
        //        sqlConnection.ConnectionString = Configuration.GetConnectionString("myConn");
        //        bool isSuccuss = false;
        //        sqlConnection.Open();
        //        var _ConnectionString = sqlConnection.ConnectionString;
        //        bool result = true;
        //        using (var connection = new MySqlConnector.MySqlConnection(_ConnectionString + ";AllowLoadLocalInfile=True"))
        //        {
        //            await connection.OpenAsync();
        //            var bulkCopy = new MySqlBulkCopy(connection);
        //            bulkCopy.DestinationTableName = "tblusers";
        //            // the column mapping is required if you have a identity column in the table
        //            bulkCopy.ColumnMappings.AddRange(GetMySqlColumnMapping(csvdt));
        //            await bulkCopy.WriteToServerAsync(csvdt);
        //            return result;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}
        //private List<MySqlBulkCopyColumnMapping> GetMySqlColumnMapping(DataTable dataTable)
        //{
        //    List<MySqlBulkCopyColumnMapping> colMappings = new List<MySqlBulkCopyColumnMapping>();
        //    int i = 0;
        //    foreach (DataColumn col in dataTable.Columns)
        //    {
        //        colMappings.Add(new MySqlBulkCopyColumnMapping(i, col.ColumnName));
        //        i++;
        //    }
        //    return colMappings;
        //}
        //private static void InsertCSVRecords(DataTable csvdt)
        //{
        //    try
        //    {

        //        MySqlConnection sqlConnection = new MySqlConnection();
        //        sqlConnection.ConnectionString = Configuration.GetConnectionString("myConn");
        //        bool isSuccuss = false;
        //        sqlConnection.Open();
                
        //        using (MySqlBulkCopy mySqlBulkCopy = new MySqlBulkCopy(sqlConnection))
        //        { 
                
        //        }
        //        using (MySqlBulkCopy objbulk = new MySqlBulkCopy(sqlConnection, null))
        //        {
        //            objbulk.DestinationTableName = "tblusers";

        //            objbulk.ColumnMappings.Add("UserID", "SN");
        //            objbulk.ColumnMappings.Add("UserGroup", "TEST");
        //            objbulk.ColumnMappings.Add("PARTNUM", "PARTNUM");
        //            objbulk.ColumnMappings.Add("DAY", "DAY");
        //            objbulk.ColumnMappings.Add("TESTVERSION", "TESTVERSION");
        //            objbulk.ColumnMappings.Add("TCAVERSION", "TCAVERSION");
        //            objbulk.ColumnMappings.Add("SHIFTDATE", "SHIFTDATE");
        //            objbulk.ColumnMappings.Add("FIRST", "FIRST");
        //            objbulk.ColumnMappings.Add("LAST", "LAST");
        //            objbulk.ColumnMappings.Add("PASSFAIL", "PASSFAIL");
        //            objbulk.ColumnMappings.Add("SHIFT", "SHIFT");
        //            objbulk.ColumnMappings.Add("FAMILY", "FAMILY");
        //            objbulk.ColumnMappings.Add("LINE", "LINE");
        //            objbulk.ColumnMappings.Add("STATION", "STATION");
        //            objbulk.ColumnMappings.Add("X1", "X1");
        //            objbulk.ColumnMappings.Add("X2", "X2");
        //            objbulk.ColumnMappings.Add("X3", "X3");
        //            objbulk.ColumnMappings.Add("X4", "X4");
        //            objbulk.ColumnMappings.Add("X5", "X5");
        //            objbulk.ColumnMappings.Add("X6", "X6");
        //            objbulk.ColumnMappings.Add("X7", "X7");
        //            objbulk.ColumnMappings.Add("X8", "X8");
        //            objbulk.ColumnMappings.Add("X9", "X9");
        //            objbulk.ColumnMappings.Add("X10", "X10");
        //            objbulk.ColumnMappings.Add("X11", "X11");
        //            objbulk.ColumnMappings.Add("X12", "X12");
        //            objbulk.ColumnMappings.Add("X13", "X13");
        //            objbulk.ColumnMappings.Add("X14", "X14");
        //            objbulk.ColumnMappings.Add("X15", "X15");
        //            objbulk.ColumnMappings.Add("X16", "X16");
        //            objbulk.ColumnMappings.Add("X17", "X17");
        //            objbulk.ColumnMappings.Add("X18", "X18");
        //            objbulk.ColumnMappings.Add("X19", "X19");
        //            objbulk.ColumnMappings.Add("X20", "X20");
        //            objbulk.ColumnMappings.Add("X21", "X21");
        //            objbulk.ColumnMappings.Add("X22", "X22");
        //            objbulk.ColumnMappings.Add("X23", "X23");
        //            objbulk.ColumnMappings.Add("X24", "X24");
        //            objbulk.ColumnMappings.Add("X25", "X25");
        //            objbulk.ColumnMappings.Add("X26", "X26");
        //            objbulk.ColumnMappings.Add("X27", "X27");
        //            objbulk.ColumnMappings.Add("X28", "X28");
        //            objbulk.ColumnMappings.Add("X29", "X29");
        //            objbulk.ColumnMappings.Add("X30", "X30");
        //            objbulk.ColumnMappings.Add("ALFA1", "ALFA1");
        //            objbulk.ColumnMappings.Add("ALFA2", "ALFA2");
        //            objbulk.ColumnMappings.Add("ALFA3", "ALFA3");
        //            objbulk.ColumnMappings.Add("ALFA4", "ALFA4");
        //            objbulk.ColumnMappings.Add("ENTITY", "ENTITY");
        //            //foreach (var column in csvdt.Columns)
        //            //    s.ColumnMappings.Add(column.ToString(), column.ToString());

        //            objbulk.WriteToServer(csvdt);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string errorMessage = string.Empty;

        //        if (ex.Message.Contains("Received an invalid column length from the bcp client for colid"))
        //        {
        //            // this method gives message with column name with length.  
        //            // errorMessage contains "Column: "XYZ" contains data with a length greater than: 20", column, length  

        //        }
        //    }

            
        //}

        public static int GetCount(string Id,string jobId, string timestampStartUTC, string timestampEndUTC)
        {
            MySqlConnection con = null;
            int items = 0;
            string myConn = Configuration.GetConnectionString("myConn");
            con = new MySqlConnection(myConn);
            string query = "SELECT COUNT(*) as count FROM tblusers where userid='" + Id + "' and jobid = '" + jobId + "' and timestampStartUTC = '" + timestampStartUTC + "' and timestampEndUTC = '" + timestampEndUTC + "'";
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

        public async Task<IActionResult> Import(IFormFile FormFile)

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
            MySqlConnection conn = null;
            string myConn = Configuration.GetConnectionString("myConn");
            conn = new MySqlConnection(myConn);
            
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (GetCount(ds.Tables[0].Rows[i][0].ToString(), ds.Tables[0].Rows[i][5].ToString(), ds.Tables[0].Rows[i][10].ToString(), ds.Tables[0].Rows[i][11].ToString()) > 0)
                {

                }
                else
                {
                    MySqlConnection sqlConnection = new MySqlConnection();
                    sqlConnection.ConnectionString = Configuration.GetConnectionString("myConn");
                    bool isSuccuss = false;
                    sqlConnection.Open();
                    string query = "insert into tblusers(UserID,UserGroup,AccountID,ProjectID,Ticket,JobID,JobName,JobTag,PluginName,PluginVersion,timestampStartUTC,timestampEndUTC,AnnotationsAdded,AnnotationsDeleted,AnnotationsChanged,TasksSolved,TasksSubmitted,TimeBillable,TimeActive,TimeInActive,TimeNetwork,TimeTotal,TimePerTask,NumberOfTasksWorked_Between_0_5,NumberOfTasksWorked_Between_5_10,NumberOfTasksWorked_Between_10_20,NumberOfTasksWorked_Between_20_40,NumberOfTasksWorked_Between_40_80,NumberOfTasksWorked_Between_80_160,NumberOfTasksWorked_Between_160_320,NumberOfTasksWorked_Between_320_640,NumberOfTasksWorked_Between_640_1280,NumberOfTasksWorked_Between_1280_2560,NumberOfTasksWorked_Between_2560_5120,NumberOfTasksWorked_Between_longer_5120) Values ('" + ds.Tables[0].Rows[i][0].ToString() + "','" + ds.Tables[0].Rows[i][1].ToString() + "','" + ds.Tables[0].Rows[i][2].ToString() + "','" + ds.Tables[0].Rows[i][3].ToString() + "','" + ds.Tables[0].Rows[i][4].ToString() + "','" + ds.Tables[0].Rows[i][5].ToString() + "','" + ds.Tables[0].Rows[i][6].ToString() + "','" + ds.Tables[0].Rows[i][7].ToString() + "','" + ds.Tables[0].Rows[i][8].ToString() + "','" + ds.Tables[0].Rows[i][9].ToString() + "','" + ds.Tables[0].Rows[i][10].ToString() + "','" + ds.Tables[0].Rows[i][11].ToString() + "','" + ds.Tables[0].Rows[i][12].ToString() + "','" + ds.Tables[0].Rows[i][13].ToString() + "','" + ds.Tables[0].Rows[i][14].ToString() + "','" + ds.Tables[0].Rows[i][15].ToString() + "','" + ds.Tables[0].Rows[i][16].ToString() + "','" + ds.Tables[0].Rows[i][17].ToString() + "','" + ds.Tables[0].Rows[i][18].ToString() + "','" + ds.Tables[0].Rows[i][19].ToString() + "','" + ds.Tables[0].Rows[i][20].ToString() + "','" + ds.Tables[0].Rows[i][21].ToString() + "','" + ds.Tables[0].Rows[i][22].ToString() + "','" + ds.Tables[0].Rows[i][23].ToString() + "','" + ds.Tables[0].Rows[i][24].ToString() + "','" + ds.Tables[0].Rows[i][25].ToString() + "','" + ds.Tables[0].Rows[i][26].ToString() + "','" + ds.Tables[0].Rows[i][27].ToString() + "','" + ds.Tables[0].Rows[i][28].ToString() + "','" + ds.Tables[0].Rows[i][29].ToString() + "','" + ds.Tables[0].Rows[i][30].ToString() + "','" + ds.Tables[0].Rows[i][31].ToString() + "','" + ds.Tables[0].Rows[i][32].ToString() + "','" + ds.Tables[0].Rows[i][33].ToString() + "','" + ds.Tables[0].Rows[i][34].ToString() + "')";
                    //conn.Open();
                    MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    //MySqlCommand cmd = new MySqlCommand(query, conn);
                    //cmd.ExecuteNonQuery();
                    //conn.Close();
                }
                 
            }
            //if the code reach here means everthing goes fine and excel data is imported into database
            ViewBag.Message = "File Imported and excel data saved into database";


            return View("Index");

        }
    }
}
