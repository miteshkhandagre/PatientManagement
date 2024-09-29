namespace PatientManagement
{
    partial class PatientInfo
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
            btnSave = new Button();
            patientDetails1 = new PatientDetails();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(599, 182);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 24;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // patientDetails1
            // 
            patientDetails1.Dock = DockStyle.Top;
            patientDetails1.Location = new Point(0, 0);
            patientDetails1.Name = "patientDetails1";
            patientDetails1.Size = new Size(698, 175);
            patientDetails1.TabIndex = 25;
            // 
            // PatientInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 213);
            Controls.Add(patientDetails1);
            Controls.Add(btnSave);
            Name = "PatientInfo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PatientInfo";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private PatientDetails patientDetails1;
    }
}