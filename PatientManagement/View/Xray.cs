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

namespace PatientManagement.View
{
    public partial class Xray : Form
    {
        public Xray()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int patientId;
            if (!string.IsNullOrEmpty(txtId.Text) && int.TryParse(txtId.Text, out patientId))
            {
                PatientInfoDto patientInfo = DBManager.Instance.GetPatientInfoById(patientId);

                if (patientInfo == null)
                {
                    MessageBox.Show($"Patient is not registered with Id: {patientId}");
                    return;
                }

                patientDetails1.SetPatientInfo(patientInfo);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PatientInfoDto patientInfo = patientDetails1.GetPatientInfo();

            if (patientInfo == null)
            {
                MessageBox.Show("Invalid Patient Info.");
                return;
            }

            PaymentInfoDto paymentInfo = paymentDetails1.GetPaymentInfo();

            (int doctorId, string firstName, string lastName) = doctorDetails1.GetDoctorInfo();

            PatientHistoryDto patientHistory = new()
            {
                PatientId = patientInfo.Id,
                Name = patientInfo.FirstName + " " + patientInfo.LastName,
                TestType = "XRay",
                TestSpecific = cbXrayType.Text,
                TestResult = "",
                DoctorId = doctorId,
                DoctorName = firstName + " " + lastName,
                Amount = paymentInfo.Amount,
                PaymentMode = paymentInfo.PaymentMode,
                PaymentId = paymentInfo.PaymentId,
                Other = paymentInfo.OtherDetails
            };

            if (DBManager.Instance.AddPatientHistory(patientHistory).success)
            {
                MessageBox.Show($"Record saved successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error while saving record!");
            }
        }
    }
}
