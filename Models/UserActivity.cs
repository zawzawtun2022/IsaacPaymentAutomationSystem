using System;
using System.ComponentModel.DataAnnotations;

namespace RoleBasedAuthorization.Models
{
    public class UserActivity
    {
        MyDbContext context = new MyDbContext();

        [Key]
        public int Id { get; set; }
        public string Url { get; set; }
        public string Data { get; set; }
        public string UserName { get; set; }
        public string IpAddress { get; set; }
        public string ClientPC { get; set; }
        public DateTime ActivityDate { get; set; } = DateTime.Now;
    }
}
