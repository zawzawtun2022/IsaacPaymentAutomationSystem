using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.Pkcs;

namespace RoleBasedAuthorization.Models
{

    public partial class Sglookup
    {
        MyDbContext _db = new MyDbContext();
        [Key]
        public int LookupID { get; set; }

        public string Status { get; set; }

        public string BillingMonth { get; set; }
        public string JoinedDate { get; set; }
        public string PacteraEdgeEmail { get; set; }

        public string Contract { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string oneforma { get; set; }

        //public string UHRS { get; set; }

        public string PayRateUS { get; set; }

        public string UserID { get; set; }

        public int SumOfTimeActive { get; set; }

        public int SumOfTimeInactive { get; set; }

        public decimal TotalTime { get; set; }

        public decimal Hrs { get; set; }

        public decimal ActiveHrs { get; set; }

        public decimal InactiveHrs { get; set; }

        public decimal BillableInactiveHrs { get; set; }

        public decimal TotalHrs { get; set; }

        public decimal Productivity { get; set; }

        public decimal ProductivityPercentage { get; set; }

        public string deleted { get; set; }

        public string averagerating { get; set; }

        public decimal quality { get; set; }

        public decimal qualitypercentage { get; set; }

        public decimal averagescore { get; set; }

        public decimal finalamountpayable { get; set; }
        //public List<SelectListItem> Lookups { get; set; }

        //public decimal UHRSMonthDiscrepancy { get; set; }
        //public decimal UHRSAdditional { get; set; }
        //public decimal UHRSNonJA { get; set; }
        public decimal USDTotal { get; set; }

        public string dashboardstatus { get; set; }
        
        public string createdby { get; set; }
        public string comment { get; set; }
    }   

}
