using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Model
{
    public class PatientHistoryDto
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string TestType { get; set; }
        public string TestSpecific { get; set; }
        public string TestResult { get; set; }
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public int Amount { get; set; }
        public string PaymentMode { get; set; }
        public string PaymentId { get; set; }
        public string Other { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
