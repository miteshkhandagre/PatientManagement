using PatientManagement.Controller;
using PatientManagement.Model;
using System.Data;

namespace PatientManagement.View
{
    public partial class PatientReports : Form
    {
        public PatientReports()
        {
            InitializeComponent();
        }

        private void cbReportBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbReportBy.SelectedIndex == 0)
            {
                cbReportMonth.Visible = true;

                dtReportYear.Visible = false;
                grpReportDateRange.Visible = false;
            }
            else if (cbReportBy.SelectedIndex == 1)
            {
                dtReportYear.Left = cbReportMonth.Left;
                dtReportYear.Visible = true;

                cbReportMonth.Visible = false;
                grpReportDateRange.Visible = false;
            }
            else if (cbReportBy.SelectedIndex == 2)
            {
                grpReportDateRange.Left = cbReportMonth.Left;
                grpReportDateRange.Visible = true;

                dtReportYear.Visible = false;
                cbReportMonth.Visible = false;
            }
        }

        private void btnReportSearch_Click(object sender, EventArgs e)
        {
            DateTime fromDate = DateTime.MinValue;
            DateTime toDate = DateTime.MinValue;

            if (cbReportMonth.Visible && !string.IsNullOrEmpty(cbReportMonth.Text))
            {
                fromDate = DateTime.ParseExact(cbReportMonth.Text, "MMM", null);
                toDate = fromDate.AddMonths(1).AddDays(-1);
            }
            else if (dtReportYear.Visible)
            {
                fromDate = DateTime.ParseExact(dtReportYear.Value.Year.ToString(), "yyyy", null);
                toDate = fromDate.AddYears(1).AddDays(-1);
            }
            else if (grpReportDateRange.Visible)
            {
                fromDate = dtReportFrom.Value.Date;
                toDate = dtReportTo.Value.Date.AddDays(1);
            }

            if (fromDate != DateTime.MinValue && toDate != DateTime.MinValue)
            {
                DataTable dt = null;
                if (fromDate == toDate)
                {

                    dt = DBManager.Instance.GetPatientRecordByDate(
                        fromDate.ToString("yyyy-MM-dd"), doctorDetails1.GetDoctorInfo().Id);
                }
                else
                {
                    dt = DBManager.Instance.GetPatientRecordByDateRange(
                        fromDate.ToString("yyyy-MM-dd"), toDate.ToString("yyyy-MM-dd"), doctorDetails1.GetDoctorInfo().Id);
                }

                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvReport.DataSource = dt;
                }
                else
                {
                    dgvReport.DataSource = null;
                    MessageBox.Show("No records found.");
                }
            }
        }

        private void PatientReports_Load(object sender, EventArgs e)
        {
            if (User.IsDoctor)
                doctorDetails1.DisplayCurrentUser();
            else
                doctorDetails1.AddReportFilterValue();
        }
    }
}
