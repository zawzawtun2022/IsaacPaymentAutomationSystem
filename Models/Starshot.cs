using System.Collections.Generic;

namespace RoleBasedAuthorization.Models
{
    public class Starshot
    {
        public Starshot()
        {
            offlinehours = new HashSet<Offlinehours>();
        }
        public int StarshotCrashID { get; set; }

        public string Description { get; set; }

        public ICollection<Offlinehours> offlinehours { get; set; }
    }
}
