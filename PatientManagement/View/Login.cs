using PatientManagement.Controller;
using PatientManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string loginId = txtUserId.Text.Trim();
            string password = txtPwd.Text.Trim();
            if (string.IsNullOrEmpty(loginId) && string.IsNullOrEmpty(password)) {
                MessageBox.Show("Invalid username or password.");
                return;
            }

            string? dbConstr = ConfigurationManager.AppSettings["SqliteConStr"];
            string dbFile = dbConstr.Substring(12, (dbConstr.IndexOf(';') - 12));

            if (!File.Exists(dbFile))
                DBManager.Instance.CreateDatabase();

            var result = DBManager.Instance.IsValidUser(loginId, password);
            if (result.valid)
            {
                User.Name = loginId;
                User.Role = result.role;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
