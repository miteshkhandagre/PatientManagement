using PatientManagement.Controller;
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

        public (int Id, string FirstName, string LastName) GetDoctorInfo()
        {
            DataRow[] dRows = dtDoctor.Select($"Id = {cbDoctor.SelectedValue}");
            if (dRows != null && dRows.Length > 0)
            {
                DataRow dRow = dRows[0];
                return (Convert.ToInt32(dRow["Id"]), Convert.ToString(dRow["FirstName"]), Convert.ToString(dRow["LastName"]));
            }
            return default;
        }
    }
}
