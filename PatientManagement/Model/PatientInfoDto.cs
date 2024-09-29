using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Model
{
    public class PatientInfoDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Mobile { get; set; }
        public string Email { get; set; }
        public DateTime DoB { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string IdType { get; set; }
        public string IdDetails { get; set; }
        public string Other { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
