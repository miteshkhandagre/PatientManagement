using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatientManagement.Model;

namespace PatientManagement
{
    public partial class PaymentDetails : UserControl
    {
        public PaymentDetails()
        {
            InitializeComponent();
        }

        public PaymentInfoDto GetPaymentInfo()
        {
            PaymentInfoDto paymentInfo = new PaymentInfoDto
            {
                Amount = Convert.ToInt32(txtAmount.Text),
                PaymentMode = cbPaymentMode.Text,
                PaymentId = txtPaymentId.Text,
                OtherDetails = txtOtherDetails.Text,
            };
            return paymentInfo;
        }
    }
}
