namespace PatientManagement
{
    partial class DoctorInfo
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
            groupBox1 = new GroupBox();
            btnSave = new Button();
            grpGender = new GroupBox();
            rbOther = new RadioButton();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            txtRegNo = new TextBox();
            lblRegistrationNo = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtMobile = new TextBox();
            lblMobile = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            txtId = new TextBox();
            lblDoctorId = new Label();
            groupBox1.SuspendLayout();
            grpGender.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(grpGender);
            groupBox1.Controls.Add(txtRegNo);
            groupBox1.Controls.Add(lblRegistrationNo);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(txtMobile);
            groupBox1.Controls.Add(lblMobile);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(lblAddress);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(lblLastName);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(lblFirstName);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(lblDoctorId);
            groupBox1.Location = new Point(2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(695, 179);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Patient Details";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(595, 143);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // grpGender
            // 
            grpGender.Controls.Add(rbOther);
            grpGender.Controls.Add(rbFemale);
            grpGender.Controls.Add(rbMale);
            grpGender.Location = new Point(441, 49);
            grpGender.Name = "grpGender";
            grpGender.Size = new Size(236, 39);
            grpGender.TabIndex = 21;
            grpGender.TabStop = false;
            grpGender.Text = "Gender";
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Location = new Point(158, 14);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(55, 19);
            rbOther.TabIndex = 24;
            rbOther.TabStop = true;
            rbOther.Text = "Other";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(76, 14);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(63, 19);
            rbFemale.TabIndex = 23;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(6, 14);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(51, 19);
            rbMale.TabIndex = 22;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // txtRegNo
            // 
            txtRegNo.Location = new Point(513, 98);
            txtRegNo.Name = "txtRegNo";
            txtRegNo.Size = new Size(164, 23);
            txtRegNo.TabIndex = 20;
            // 
            // lblRegistrationNo
            // 
            lblRegistrationNo.AutoSize = true;
            lblRegistrationNo.Location = new Point(415, 102);
            lblRegistrationNo.Name = "lblRegistrationNo";
            lblRegistrationNo.Size = new Size(92, 15);
            lblRegistrationNo.TabIndex = 19;
            lblRegistrationNo.Text = "Registration No:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(238, 98);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(164, 23);
            txtEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(190, 102);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(75, 98);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(100, 23);
            txtMobile.TabIndex = 9;
            // 
            // lblMobile
            // 
            lblMobile.AutoSize = true;
            lblMobile.Location = new Point(12, 102);
            lblMobile.Name = "lblMobile";
            lblMobile.Size = new Size(47, 15);
            lblMobile.TabIndex = 8;
            lblMobile.Text = "Mobile:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(75, 57);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(352, 23);
            txtAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(12, 61);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Address:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(513, 23);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(164, 23);
            txtLastName.TabIndex = 5;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(441, 27);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(66, 15);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(263, 23);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(164, 23);
            txtFirstName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(190, 27);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 15);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name:";
            // 
            // txtId
            // 
            txtId.Location = new Point(75, 23);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // lblDoctorId
            // 
            lblDoctorId.AutoSize = true;
            lblDoctorId.Location = new Point(12, 27);
            lblDoctorId.Name = "lblDoctorId";
            lblDoctorId.Size = new Size(59, 15);
            lblDoctorId.TabIndex = 0;
            lblDoctorId.Text = "Doctor Id:";
            // 
            // DoctorInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 185);
            Controls.Add(groupBox1);
            Name = "DoctorInfo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DoctorInfo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpGender.ResumeLayout(false);
            grpGender.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSave;
        private GroupBox grpGender;
        private RadioButton rbOther;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private TextBox txtRegNo;
        private Label lblRegistrationNo;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtMobile;
        private Label lblMobile;
        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private TextBox txtId;
        private Label lblDoctorId;
    }
}