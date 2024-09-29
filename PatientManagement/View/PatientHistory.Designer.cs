namespace PatientManagement
{
    partial class PatientHistory
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
            btnFind = new Button();
            txtId = new TextBox();
            lblPatientId = new Label();
            dgvPatientHistory = new DataGridView();
            patientDetails1 = new PatientDetails();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatientHistory).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFind);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(lblPatientId);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 66);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Patient Details";
            // 
            // btnFind
            // 
            btnFind.Location = new Point(216, 23);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 23);
            btnFind.TabIndex = 1;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
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
            // dgvPatientHistory
            // 
            dgvPatientHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatientHistory.Location = new Point(0, 247);
            dgvPatientHistory.Name = "dgvPatientHistory";
            dgvPatientHistory.Size = new Size(800, 203);
            dgvPatientHistory.TabIndex = 3;
            // 
            // patientDetails1
            // 
            patientDetails1.Dock = DockStyle.Top;
            patientDetails1.Location = new Point(0, 66);
            patientDetails1.Name = "patientDetails1";
            patientDetails1.Size = new Size(800, 175);
            patientDetails1.TabIndex = 2;
            // 
            // PatientHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(patientDetails1);
            Controls.Add(dgvPatientHistory);
            Controls.Add(groupBox1);
            Name = "PatientHistory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PatientHistory";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatientHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnFind;
        private TextBox txtId;
        private Label lblPatientId;
        private DataGridView dgvPatientHistory;
        private PatientDetails patientDetails1;
    }
}