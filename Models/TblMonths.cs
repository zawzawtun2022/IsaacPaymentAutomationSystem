using System.ComponentModel.DataAnnotations;

namespace RoleBasedAuthorization.Models
{
    public class TblMonths
    {
        [Key]
        public string MonthId { get; set; }
        public string Month { get; set; }
    }
}