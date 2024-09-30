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
            string? loginDetails = ConfigurationManager.AppSettings["LoginDetails"];
            if (string.IsNullOrEmpty(loginDetails)) {
                MessageBox.Show("Login not configured.");
                return;
            }

            string loginId = txtUserId.Text;
            string password = txtPwd.Text;
            if (string.IsNullOrEmpty(loginId) && string.IsNullOrEmpty(password)) {
                MessageBox.Show("Invalid username or password.");
                return;
            }

            string[] loginArray = loginDetails.Split(':');
            if (loginArray.Length == 2)
            {
                if (loginArray[0] == loginId && loginArray[1] == password)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else {
                    MessageBox.Show("Invalid username or password.");
                }
            }            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
