using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Model
{
    public class PaymentInfoDto
    {
        public int Amount { get; set; }
        public string PaymentMode { get; set; }
        public string PaymentId { get; set; }
        public string OtherDetails { get; set; }
    }
}
