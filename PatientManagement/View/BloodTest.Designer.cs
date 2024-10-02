namespace PatientManagement.View
{
    partial class BloodTest
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
            grpReportDetails = new GroupBox();
            doctorDetails1 = new DoctorDetails();
            btnSave = new Button();
            cbBloodTestType = new ComboBox();
            lblBloodTestType = new Label();
            paymentDetails1 = new PaymentDetails();
            patientDetails1 = new PatientDetails();
            grpSearch = new GroupBox();
            btnFind = new Button();
            txtId = new TextBox();
            lblPatientId = new Label();
            grpReportDetails.SuspendLayout();
            grpSearch.SuspendLayout();
            SuspendLayout();
            // 
            // grpReportDetails
            // 
            grpReportDetails.Controls.Add(doctorDetails1);
            grpReportDetails.Controls.Add(btnSave);
            grpReportDetails.Controls.Add(cbBloodTestType);
            grpReportDetails.Controls.Add(lblBloodTestType);
            grpReportDetails.Dock = DockStyle.Fill;
            grpReportDetails.Location = new Point(0, 330);
            grpReportDetails.Name = "grpReportDetails";
            grpReportDetails.Size = new Size(800, 120);
            grpReportDetails.TabIndex = 12;
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
            // cbBloodTestType
            // 
            cbBloodTestType.FormattingEnabled = true;
            cbBloodTestType.Items.AddRange(new object[] { "Blood Glucose", "Calcium", "Cholestrol & Lipid", "C-reactive Protein (CRP)", "D-dimer", "Erythrocyte Sedimentation rate", "Folate", "Full Blood Count", "HbA1c", "hCG", "Iron Studies", "Kidney Function", "Liver Function", "Magnesium", "Oestrogen", "Prostate Specific Antigen (PSA)", "Testosterone", "Thyroid Function", "Vitamin B12", "Vitamin D" });
            cbBloodTestType.Location = new Point(75, 38);
            cbBloodTestType.Name = "cbBloodTestType";
            cbBloodTestType.Size = new Size(245, 23);
            cbBloodTestType.TabIndex = 20;
            // 
            // lblBloodTestType
            // 
            lblBloodTestType.AutoSize = true;
            lblBloodTestType.Location = new Point(12, 42);
            lblBloodTestType.Name = "lblBloodTestType";
            lblBloodTestType.Size = new Size(64, 15);
            lblBloodTestType.TabIndex = 19;
            lblBloodTestType.Text = "Blood Test:";
            // 
            // paymentDetails1
            // 
            paymentDetails1.Dock = DockStyle.Top;
            paymentDetails1.Location = new Point(0, 225);
            paymentDetails1.Name = "paymentDetails1";
            paymentDetails1.Size = new Size(800, 105);
            paymentDetails1.TabIndex = 11;
            // 
            // patientDetails1
            // 
            patientDetails1.Dock = DockStyle.Top;
            patientDetails1.Enabled = false;
            patientDetails1.Location = new Point(0, 50);
            patientDetails1.Name = "patientDetails1";
            patientDetails1.Size = new Size(800, 175);
            patientDetails1.TabIndex = 10;
            // 
            // grpSearch
            // 
            grpSearch.Controls.Add(btnFind);
            grpSearch.Controls.Add(txtId);
            grpSearch.Controls.Add(lblPatientId);
            grpSearch.Dock = DockStyle.Top;
            grpSearch.Location = new Point(0, 0);
            grpSearch.Name = "grpSearch";
            grpSearch.Size = new Size(800, 50);
            grpSearch.TabIndex = 9;
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
            // BloodTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpReportDetails);
            Controls.Add(paymentDetails1);
            Controls.Add(patientDetails1);
            Controls.Add(grpSearch);
            Name = "BloodTest";
            Text = "BloodTest";
            grpReportDetails.ResumeLayout(false);
            grpReportDetails.PerformLayout();
            grpSearch.ResumeLayout(false);
            grpSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpReportDetails;
        private DoctorDetails doctorDetails1;
        private Button btnSave;
        private ComboBox cbBloodTestType;
        private Label lblBloodTestType;
        private PaymentDetails paymentDetails1;
        private PatientDetails patientDetails1;
        private GroupBox grpSearch;
        private Button btnFind;
        private TextBox txtId;
        private Label lblPatientId;
    }
}