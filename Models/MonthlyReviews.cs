using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RoleBasedAuthorization.Models
{
    public class MonthlyReviews
    {
        MyDbContext db = new MyDbContext();
        [Key]
        public int MonthlyreviewID { get; set; }
        public string Monthly { get; set; }
        public string Numberofweek { get; set; }
        public string Startdate { get; set; }
        public string Enddate { get; set; }
        public AssignMonthlyReviews AssignMonthlyReviews { get; set; }


    }
    public class AssignMonthlyReviews
    {
        MyDbContext db = new MyDbContext();
        [Key]
        public int AssignID { get; set; }
        public int MonthlyreviewID { get; set; }
        public string Monthly { get; set; }
        public int Rating { get; set; }
        public int AnnotatorID { get; set; }
        public string status { get; set; }
    }
}
