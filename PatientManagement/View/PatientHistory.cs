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
    public partial class PatientHistory : Form
    {
        public PatientHistory()
        {
            InitializeComponent();
        }

        public void btnFind_Click(object sender, EventArgs e)
        {
            int patientId;
            if (!string.IsNullOrEmpty(txtId.Text) && int.TryParse(txtId.Text, out patientId))
            {
                PatientInfoDto patientInfo = DBManager.Instance.GetPatientInfoById(patientId);

                if (patientInfo == null) {
                    MessageBox.Show($"Patient is not registered with Id: {patientId}");
                    return;
                }

                patientDetails1.SetPatientInfo(patientInfo);

                DataTable dt = DBManager.Instance.GetPatientHistoryById(patientId);
                if (dt != null && dt.Rows.Count > 0) { 
                    //BindingSource bindingSource = new BindingSource();
                    //bindingSource.DataSource = dt;
                    dgvPatientHistory.DataSource = dt.DefaultView;
                }
            }
        }
    }
}
