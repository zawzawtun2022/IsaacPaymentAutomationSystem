using Microsoft.AspNetCore.Http;

namespace RoleBasedAuthorization.Models
{
    public class Userlist
    {
        public string Name { get; set; }

        public IFormFile File { get; set; }

    }
}
