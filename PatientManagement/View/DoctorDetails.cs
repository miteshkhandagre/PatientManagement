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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PatientManagement.View
{
    public partial class DoctorDetails : UserControl
    {
        private DataTable dtDoctor;
        public DoctorDetails()
        {
            InitializeComponent();
        }

        private void DoctorDetails_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                dtDoctor = DBManager.Instance.GetDoctors();
                if (dtDoctor != null && dtDoctor.Rows.Count > 0)
                {
                    cbDoctor.DataSource = dtDoctor;
                    cbDoctor.DisplayMember = "FirstName";
                    cbDoctor.ValueMember = "Id";
                }
            }
        }

        public void AddReportFilterValue()
        {
            if (dtDoctor != null && dtDoctor.Rows.Count > 0)
            {
                cbDoctor.DataSource = null;
                DataRow drow = dtDoctor.NewRow();
                drow["Id"] = 0;
                drow["FirstName"] = "All";
                dtDoctor.Rows.InsertAt(drow, 0);
                cbDoctor.DataSource = dtDoctor;
                cbDoctor.DisplayMember = "FirstName";
                cbDoctor.ValueMember = "Id";
                cbDoctor.SelectedValue = 0;
            }
        }

        public void DisplayCurrentUser()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("Id", typeof(int));
            DataRow drow = dt.NewRow();
            drow["Id"] = User.Id;
            drow["FirstName"] = User.Name;
            dt.Rows.Add(drow);
            cbDoctor.DataSource = null;
            cbDoctor.Items.Clear();
            cbDoctor.DataSource = dt;
            cbDoctor.DisplayMember = "FirstName";
            cbDoctor.ValueMember = "Id";
        }

        public (int Id, string FirstName, string LastName) GetDoctorInfo()
        {
            if (dtDoctor.Rows.Count > 0)
            {
                DataRow[] dRows = dtDoctor.Select($"Id = {cbDoctor.SelectedValue}");
                if (dRows != null && dRows.Length > 0)
                {
                    DataRow dRow = dRows[0];
                    return (Convert.ToInt32(dRow["Id"]), Convert.ToString(dRow["FirstName"]), Convert.ToString(dRow["LastName"]));
                }
            }
            return default;
        }
    }
}
