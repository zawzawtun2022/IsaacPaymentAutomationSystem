using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace RoleBasedAuthorization.Models
{
    public class ViewModel
    {
       
        public Admins admins { get; set; }
        public MonthlyReviews monthlyreviews { get; set; }
    }
}
