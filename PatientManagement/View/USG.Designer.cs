namespace PatientManagement
{
    partial class USG
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
            grpSearch = new GroupBox();
            btnFind = new Button();
            txtId = new TextBox();
            lblPatientId = new Label();
            patientDetails1 = new PatientDetails();
            paymentDetails1 = new PaymentDetails();
            grpReportDetails = new GroupBox();
            doctorDetails1 = new View.DoctorDetails();
            btnSave = new Button();
            cbUsgType = new ComboBox();
            lblUsgType = new Label();
            grpSearch.SuspendLayout();
            grpReportDetails.SuspendLayout();
            SuspendLayout();
            // 
            // grpSearch
            // 
            grpSearch.Controls.Add(btnFind);
            grpSearch.Controls.Add(txtId);
            grpSearch.Controls.Add(lblPatientId);
            grpSearch.Dock = DockStyle.Top;
            grpSearch.Location = new Point(0, 0);
            grpSearch.Name = "grpSearch";
            grpSearch.Size = new Size(704, 50);
            grpSearch.TabIndex = 1;
            grpSearch.TabStop = false;
            grpSearch.Text = "Search:";
            // 
            // btnFind
            // 
            btnFind.Location = new Point(217, 18);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 23);
            btnFind.TabIndex = 24;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(69, 18);
            txtId.Name = "txtId";
            txtId.Size = new Size(129, 23);
            txtId.TabIndex = 3;
            // 
            // lblPatientId
            // 
            lblPatientId.AutoSize = true;
            lblPatientId.Location = new Point(6, 22);
            lblPatientId.Name = "lblPatientId";
            lblPatientId.Size = new Size(60, 15);
            lblPatientId.TabIndex = 2;
            lblPatientId.Text = "Patient Id:";
            // 
            // patientDetails1
            // 
            patientDetails1.Dock = DockStyle.Top;
            patientDetails1.Enabled = false;
            patientDetails1.Location = new Point(0, 50);
            patientDetails1.Name = "patientDetails1";
            patientDetails1.Size = new Size(704, 175);
            patientDetails1.TabIndex = 2;
            // 
            // paymentDetails1
            // 
            paymentDetails1.Dock = DockStyle.Top;
            paymentDetails1.Location = new Point(0, 225);
            paymentDetails1.Name = "paymentDetails1";
            paymentDetails1.Size = new Size(704, 105);
            paymentDetails1.TabIndex = 3;
            // 
            // grpReportDetails
            // 
            grpReportDetails.Controls.Add(doctorDetails1);
            grpReportDetails.Controls.Add(btnSave);
            grpReportDetails.Controls.Add(cbUsgType);
            grpReportDetails.Controls.Add(lblUsgType);
            grpReportDetails.Dock = DockStyle.Fill;
            grpReportDetails.Location = new Point(0, 330);
            grpReportDetails.Name = "grpReportDetails";
            grpReportDetails.Size = new Size(704, 102);
            grpReportDetails.TabIndex = 4;
            grpReportDetails.TabStop = false;
            grpReportDetails.Text = "Report Details:";
            // 
            // doctorDetails1
            // 
            doctorDetails1.Location = new Point(326, 22);
            doctorDetails1.Name = "doctorDetails1";
            doctorDetails1.Size = new Size(216, 48);
            doctorDetails1.TabIndex = 26;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(594, 72);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbUsgType
            // 
            cbUsgType.FormattingEnabled = true;
            cbUsgType.Items.AddRange(new object[] { "Abdomen", "General", "Thyroid", "Uterus", "Vascular" });
            cbUsgType.Location = new Point(75, 38);
            cbUsgType.Name = "cbUsgType";
            cbUsgType.Size = new Size(245, 23);
            cbUsgType.TabIndex = 20;
            // 
            // lblUsgType
            // 
            lblUsgType.AutoSize = true;
            lblUsgType.Location = new Point(12, 42);
            lblUsgType.Name = "lblUsgType";
            lblUsgType.Size = new Size(59, 15);
            lblUsgType.TabIndex = 19;
            lblUsgType.Text = "USG Type:";
            // 
            // USG
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 432);
            Controls.Add(grpReportDetails);
            Controls.Add(paymentDetails1);
            Controls.Add(patientDetails1);
            Controls.Add(grpSearch);
            Name = "USG";
            StartPosition = FormStartPosition.CenterParent;
            Text = "USG";
            grpSearch.ResumeLayout(false);
            grpSearch.PerformLayout();
            grpReportDetails.ResumeLayout(false);
            grpReportDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpSearch;
        private TextBox txtId;
        private Label lblPatientId;
        private Button btnFind;
        private PatientDetails patientDetails1;
        private PaymentDetails paymentDetails1;
        private GroupBox grpReportDetails;
        private ComboBox cbUsgType;
        private Label lblUsgType;
        private Button btnSave;
        private View.DoctorDetails doctorDetails1;
    }
}