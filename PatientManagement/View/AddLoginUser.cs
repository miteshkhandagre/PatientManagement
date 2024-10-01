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
    public partial class AddLoginUser : Form
    {
        public AddLoginUser()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string loginId = txtUserId.Text.Trim();
            string password = txtPwd.Text.Trim();
            if (string.IsNullOrEmpty(loginId) && string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Invalid username or password.");
                return;
            }
            if(string.IsNullOrEmpty(cbRole.Text)){
                MessageBox.Show("Please select Role.");
                return;
            }
            if (DBManager.Instance.AddLoginUser(loginId, password, cbRole.Text))
            {
                MessageBox.Show("User added successfully.");
                this.Close();
            }
            else
                MessageBox.Show("Error while trying to add user.");
        }
    }
}
