namespace PatientManagement.View
{
    partial class Login
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
            btnCancel = new Button();
            btnLogin = new Button();
            txtPwd = new TextBox();
            lblPwd = new Label();
            txtUserId = new TextBox();
            lblUserId = new Label();
            grpLogin.SuspendLayout();
            SuspendLayout();
            // 
            // grpLogin
            // 
            grpLogin.Controls.Add(btnCancel);
            grpLogin.Controls.Add(btnLogin);
            grpLogin.Controls.Add(txtPwd);
            grpLogin.Controls.Add(lblPwd);
            grpLogin.Controls.Add(txtUserId);
            grpLogin.Controls.Add(lblUserId);
            grpLogin.Location = new Point(0, 0);
            grpLogin.Name = "grpLogin";
            grpLogin.Size = new Size(291, 130);
            grpLogin.TabIndex = 0;
            grpLogin.TabStop = false;
            grpLogin.Text = "Login:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(197, 97);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(113, 97);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
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
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 131);
            Controls.Add(grpLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Login";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Login";
            grpLogin.ResumeLayout(false);
            grpLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpLogin;
        private Button btnCancel;
        private Button btnLogin;
        private TextBox txtPwd;
        private Label lblPwd;
        private TextBox txtUserId;
        private Label lblUserId;
    }
}