using PatientManagement.Controller;
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
    public partial class PatientInfo : Form
    {
        public PatientInfo()
        {
            InitializeComponent();
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            PatientInfoDto patientInfoDto = patientDetails1.GetPatientInfo();

            if (patientInfoDto != null) {
                if (string.IsNullOrEmpty(patientInfoDto.FirstName))
                {
                    MessageBox.Show("Please provide valid FirstName.");
                    return;
                }
                if (string.IsNullOrEmpty(patientInfoDto.LastName))
                {
                    MessageBox.Show("Please provide valid LastName.");
                    return;
                }
                if (patientInfoDto.Mobile == 0)
                {
                    MessageBox.Show("Please provide valid Mobile No.");
                    return;
                }
                if (string.IsNullOrEmpty(patientInfoDto.Gender))
                {
                    MessageBox.Show("Please provide valid Gender.");
                    return;
                }
                if (string.IsNullOrEmpty(patientInfoDto.IdType))
                {
                    MessageBox.Show("Please provide valid Id Type.");
                    return;
                }
                if (string.IsNullOrEmpty(patientInfoDto.IdDetails))
                {
                    MessageBox.Show("Please provide valid Id Details.");
                    return;
                }
            }

            (bool success, int newId) = DBManager.Instance.AddPatientInfo(patientInfoDto);
            if (success)
            {
                MessageBox.Show($"Record saved successfully. New Patient Id: {newId}");
                this.Close();
            }
            else {
                MessageBox.Show("Error while saving record!");
            }
        }
    }
}
