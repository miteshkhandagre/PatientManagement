using PatientManagement.Controller;
using PatientManagement.View;

namespace PatientManagement
{
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }

        public void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientInfo patientInfo = new PatientInfo();
            patientInfo.ShowDialog();
        }

        public void patientHistoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PatientHistory patientHistory = new PatientHistory();
            patientHistory.ShowDialog();
        }
        public void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorInfo doctorInfo = new DoctorInfo();
            doctorInfo.ShowDialog();
        }
        public void uSGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            USG usg = new USG();
            usg.ShowDialog();
        }
        public void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void createDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"This will delete any existing DB and all associated record's. Are you sure?", "WARNING!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (DBManager.Instance.CreateDatabase())
                    MessageBox.Show("Database created successfully. Application need to restart.");
                else
                    MessageBox.Show("Error on database creation.");

                Application.Exit();
            }
        }
        public void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLoginUser user = new AddLoginUser();
            user.ShowDialog();
        }
    }
}
