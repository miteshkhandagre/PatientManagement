using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Model
{
    public class User
    {
        public static int Id { get; set; }

        public static string Name { get; set; }
        public static string Role { get; set; } = string.Empty;

        public static bool IsAdmin
        {
            get
            {
                return Role.Equals("ADMIN", StringComparison.CurrentCultureIgnoreCase);
            }
        }
        public static bool IsDoctor
        {
            get
            {
                return Role.Equals("DOCTOR", StringComparison.CurrentCultureIgnoreCase);
            }
        }
        public static bool IsStaff
        {
            get
            {
                return Role.Equals("STAFF", StringComparison.CurrentCultureIgnoreCase);
            }
        }
    }
}
