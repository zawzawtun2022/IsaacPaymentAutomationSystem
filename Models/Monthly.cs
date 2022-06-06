using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace RoleBasedAuthorization.Models
{
    public class Monthly
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IEnumerable<SelectListItem> MonthlyList { get; set; }

    }
}
