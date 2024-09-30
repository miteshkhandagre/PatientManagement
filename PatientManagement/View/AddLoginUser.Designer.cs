namespace PatientManagement.View
{
    partial class AddLoginUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpLogin = new GroupBox();
            cbRole = new ComboBox();
            lblRole = new Label();
            btnAddUser = new Button();
            txtPwd = new TextBox();
            lblPwd = new Label();
            txtUserId = new TextBox();
            lblUserId = new Label();
            grpLogin.SuspendLayout();
            SuspendLayout();
            // 
            // grpLogin
            // 
            grpLogin.Controls.Add(cbRole);
            grpLogin.Controls.Add(lblRole);
            grpLogin.Controls.Add(btnAddUser);
            grpLogin.Controls.Add(txtPwd);
            grpLogin.Controls.Add(lblPwd);
            grpLogin.Controls.Add(txtUserId);
            grpLogin.Controls.Add(lblUserId);
            grpLogin.Location = new Point(1, 3);
            grpLogin.Name = "grpLogin";
            grpLogin.Size = new Size(291, 161);
            grpLogin.TabIndex = 1;
            grpLogin.TabStop = false;
            grpLogin.Text = "Login:";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "ADMIN", "DOCTOR", "STAFF" });
            cbRole.Location = new Point(73, 93);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(199, 23);
            cbRole.TabIndex = 7;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(8, 95);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(33, 15);
            lblRole.TabIndex = 6;
            lblRole.Text = "Role:";
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(193, 128);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(75, 23);
            btnAddUser.TabIndex = 4;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(73, 55);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.Size = new Size(199, 23);
            txtPwd.TabIndex = 3;
            // 
            // lblPwd
            // 
            lblPwd.AutoSize = true;
            lblPwd.Location = new Point(8, 59);
            lblPwd.Name = "lblPwd";
            lblPwd.Size = new Size(60, 15);
            lblPwd.TabIndex = 2;
            lblPwd.Text = "Password:";
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(73, 19);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(199, 23);
            txtUserId.TabIndex = 1;
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Location = new Point(8, 23);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(46, 15);
            lblUserId.TabIndex = 0;
            lblUserId.Text = "User Id:";
            // 
            // AddLoginUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 164);
            Controls.Add(grpLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddLoginUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Login User";
            grpLogin.ResumeLayout(false);
            grpLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpLogin;
        private ComboBox cbRole;
        private Label lblRole;
        private Button btnAddUser;
        private TextBox txtPwd;
        private Label lblPwd;
        private TextBox txtUserId;
        private Label lblUserId;
    }
}