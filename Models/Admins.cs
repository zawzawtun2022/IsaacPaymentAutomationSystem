using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RoleBasedAuthorization.Models
{
    public partial class Admins
    {

        MyDbContext context = new MyDbContext();
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? RolesId { get; set; }

        public int? parentadminroleid { get; set; }

        public string userid { get; set; }
        public string Level { get; set; }
        public Roles Roles { get; set; }

    }
}
