using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RoleBasedAuthorization.Models
{
    public class ParentModel
    { 
        public List<Dropdownlist> Dropdownlists { get; set; }
        public List<Offlinehours> Offlinehours { get; set; }
    }
    public class Dropdownlist

    {

        public List<MonthlyReviews> month { get; set; }

        public List<Admins> childusertype { get; set; }

        public List<Sglookup> lookupList { get; set; }

        public List<users> userList { get; set; }

        public List<Typeoftask> typeoftaskList { get; set;}
    }
    public class users

    {
        public int UserUID { get; set; }

        public string UserID { get; set; }

        public string JobID { get; set; }

        public string JobName { get; set; }
    }

    public class Offlinehours
    {
        MyDbContext db = new MyDbContext();
        [Key]
        public int OfflineHrsID { get; set; }

        public string JobID { get; set; }

        public string locale { get; set; }

        public string PacteraEdgeEmail { get; set; }

        public string TaskID { get; set; }

        public string WorkID { get; set; }

        public string WorkedHrs { get; set; }

        public string StarshotCrashIsError { get; set; }

        public string TypeOfTaskID { get; set; }

        public string status { get; set; }

        public string deleted { get; set; }

        public int createdby { get; set; }

        public string comments { get; set; }
        public List<SelectListItem> offlineHours { get; set; }

        public List<Typeoftask> typeoftaskList { get; set; }
    }
}
