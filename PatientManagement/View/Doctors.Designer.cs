namespace PatientManagement.View
{
    partial class Doctors
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
            grpDoctors = new GroupBox();
            dgvDoctors = new DataGridView();
            grpDoctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).BeginInit();
            SuspendLayout();
            // 
            // grpDoctors
            // 
            grpDoctors.Controls.Add(dgvDoctors);
            grpDoctors.Dock = DockStyle.Fill;
            grpDoctors.Location = new Point(0, 0);
            grpDoctors.Name = "grpDoctors";
            grpDoctors.Size = new Size(800, 450);
            grpDoctors.TabIndex = 0;
            grpDoctors.TabStop = false;
            grpDoctors.Text = "Doctor Details:";
            // 
            // dgvDoctors
            // 
            dgvDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctors.Dock = DockStyle.Fill;
            dgvDoctors.Location = new Point(3, 19);
            dgvDoctors.Name = "dgvDoctors";
            dgvDoctors.Size = new Size(794, 428);
            dgvDoctors.TabIndex = 0;
            // 
            // Doctors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpDoctors);
            Name = "Doctors";
            Text = "Doctors";
            Load += Doctors_Load;
            grpDoctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDoctors;
        private DataGridView dgvDoctors;
    }
}