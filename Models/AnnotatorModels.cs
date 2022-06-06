using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace RoleBasedAuthorization.Models
{
    public class AnnotatorModels
    {
        public List<SelectListItem> Annotators { get; set; }
        public int[] AnnotatorIds { get; set; }
    }
}
