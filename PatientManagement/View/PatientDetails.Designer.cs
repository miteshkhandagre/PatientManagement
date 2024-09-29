namespace PatientManagement
{
    partial class PatientDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            grpGender = new GroupBox();
            rbOther = new RadioButton();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            txtOther = new TextBox();
            lblOther = new Label();
            cbIdType = new ComboBox();
            dtpDoB = new DateTimePicker();
            lblDob = new Label();
            txtIdDetails = new TextBox();
            lblIdDetails = new Label();
            lblIdType = new Label();
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
            lblPatientId = new Label();
            groupBox1.SuspendLayout();
            grpGender.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grpGender);
            groupBox1.Controls.Add(txtOther);
            groupBox1.Controls.Add(lblOther);
            groupBox1.Controls.Add(cbIdType);
            groupBox1.Controls.Add(dtpDoB);
            groupBox1.Controls.Add(lblDob);
            groupBox1.Controls.Add(txtIdDetails);
            groupBox1.Controls.Add(lblIdDetails);
            groupBox1.Controls.Add(lblIdType);
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
            groupBox1.Controls.Add(lblPatientId);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(701, 175);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Patient Details";
            // 
            // grpGender
            // 
            grpGender.Controls.Add(rbOther);
            grpGender.Controls.Add(rbFemale);
            grpGender.Controls.Add(rbMale);
            grpGender.Location = new Point(441, 90);
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
            // txtOther
            // 
            txtOther.Location = new Point(513, 135);
            txtOther.Name = "txtOther";
            txtOther.Size = new Size(164, 23);
            txtOther.TabIndex = 20;
            // 
            // lblOther
            // 
            lblOther.AutoSize = true;
            lblOther.Location = new Point(467, 139);
            lblOther.Name = "lblOther";
            lblOther.Size = new Size(40, 15);
            lblOther.TabIndex = 19;
            lblOther.Text = "Other:";
            // 
            // cbIdType
            // 
            cbIdType.FormattingEnabled = true;
            cbIdType.Items.AddRange(new object[] { "Aadhar", "Driving License", "PAN", "Passport", "Voter ID", "Other" });
            cbIdType.Location = new Point(75, 135);
            cbIdType.Name = "cbIdType";
            cbIdType.Size = new Size(100, 23);
            cbIdType.TabIndex = 18;
            // 
            // dtpDoB
            // 
            dtpDoB.Location = new Point(513, 57);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(164, 23);
            dtpDoB.TabIndex = 17;
            // 
            // lblDob
            // 
            lblDob.AutoSize = true;
            lblDob.Location = new Point(475, 61);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(32, 15);
            lblDob.TabIndex = 16;
            lblDob.Text = "DoB:";
            // 
            // txtIdDetails
            // 
            txtIdDetails.Location = new Point(263, 135);
            txtIdDetails.Name = "txtIdDetails";
            txtIdDetails.Size = new Size(164, 23);
            txtIdDetails.TabIndex = 15;
            // 
            // lblIdDetails
            // 
            lblIdDetails.AutoSize = true;
            lblIdDetails.Location = new Point(199, 139);
            lblIdDetails.Name = "lblIdDetails";
            lblIdDetails.Size = new Size(58, 15);
            lblIdDetails.TabIndex = 14;
            lblIdDetails.Text = "Id Details:";
            // 
            // lblIdType
            // 
            lblIdType.AutoSize = true;
            lblIdType.Location = new Point(12, 139);
            lblIdType.Name = "lblIdType";
            lblIdType.Size = new Size(47, 15);
            lblIdType.TabIndex = 12;
            lblIdType.Text = "Id Type:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(263, 57);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(164, 23);
            txtEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(218, 61);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(75, 57);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(100, 23);
            txtMobile.TabIndex = 9;
            // 
            // lblMobile
            // 
            lblMobile.AutoSize = true;
            lblMobile.Location = new Point(12, 61);
            lblMobile.Name = "lblMobile";
            lblMobile.Size = new Size(47, 15);
            lblMobile.TabIndex = 8;
            lblMobile.Text = "Mobile:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(75, 98);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(352, 23);
            txtAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(12, 102);
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
            // lblPatientId
            // 
            lblPatientId.AutoSize = true;
            lblPatientId.Location = new Point(12, 27);
            lblPatientId.Name = "lblPatientId";
            lblPatientId.Size = new Size(60, 15);
            lblPatientId.TabIndex = 0;
            lblPatientId.Text = "Patient Id:";
            // 
            // PatientDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "PatientDetails";
            Size = new Size(701, 175);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpGender.ResumeLayout(false);
            grpGender.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox grpGender;
        private RadioButton rbOther;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private TextBox txtOther;
        private Label lblOther;
        private ComboBox cbIdType;
        private DateTimePicker dtpDoB;
        private Label lblDob;
        private TextBox txtIdDetails;
        private Label lblIdDetails;
        private Label lblIdType;
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
        private Label lblPatientId;
    }
}
