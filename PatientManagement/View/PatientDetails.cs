using PatientManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement
{
    public partial class PatientDetails : UserControl
    {
        public PatientDetails()
        {
            InitializeComponent();
        }

        public PatientInfoDto GetPatientInfo() {
            int id = -1;
            int.TryParse(txtId.Text, out id);
            int mobileNo = -1;
            int.TryParse(txtMobile.Text, out mobileNo);
            return new PatientInfoDto
            {
                Id = id,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                DoB = dtpDoB.Value,
                Gender = rbMale.Checked ? "Male" : (rbFemale.Checked ? "Female" : "Other"),
                Mobile = mobileNo,
                Email = txtEmail.Text,
                Address = txtAddress.Text,
                IdType = Convert.ToString(cbIdType.SelectedItem),
                IdDetails = txtIdDetails.Text,
                Other = txtOther.Text
            };
        }

        public void SetPatientInfo(PatientInfoDto info) { 
            txtId.Text = info.Id.ToString();
            txtFirstName.Text = info.FirstName.ToString();
            txtLastName.Text = info.LastName.ToString();
            dtpDoB.Value = info.DoB;
            if(info.Gender == "Male")
                rbMale.Checked = true;
            else if(info.Gender == "Female")
                rbFemale.Checked = true;
            else
                rbOther.Checked = true;
            txtMobile.Text = info.Mobile.ToString();
            txtEmail.Text = info.Email.ToString();
            txtAddress.Text = info.Address.ToString();
            cbIdType.SelectedText = info.IdType;
            txtIdDetails.Text = info.IdDetails.ToString();
            txtOther.Text = info.Other.ToString();
        }
    }
}
