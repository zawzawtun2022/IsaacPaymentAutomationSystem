using System.Collections.Generic;

namespace RoleBasedAuthorization.Models
{
    public class Typeoftask
    {
        public Typeoftask()
        {
            offlinehours = new HashSet<Offlinehours>();
        }
        public int TypeOfTaskID { get; set; }

        public string TypeOfTask { get; set; }

        public ICollection<Offlinehours> offlinehours { get; set; }
    }
}
