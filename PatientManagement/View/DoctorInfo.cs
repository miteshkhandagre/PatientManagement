using PatientManagement.Controller;
using PatientManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
namespace PatientManagement
{
    public partial class DoctorInfo : Form
    {
        public DoctorInfo()
        {
            InitializeComponent();
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            DoctorInfoDto doctorInfo = new DoctorInfoDto
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Mobile = Convert.ToInt32(txtMobile.Text),
                Email = txtEmail.Text,
                Address = txtAddress.Text,
                Gender = rbMale.Checked ? "Male" : (rbFemale.Checked ? "Female" : "Other"),
                RegistrationNo = txtRegNo.Text
            };

            (bool success, int newId) = DBManager.Instance.AddDoctor(doctorInfo);
            if (success)
            {
                MessageBox.Show($"Record saved successfully. New Doctor Id: {newId}");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error while saving record!");
            }
        }
    }
}
