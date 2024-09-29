namespace PatientManagement.View
{
    partial class DoctorDetails
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
            grpDoctor = new GroupBox();
            cbDoctor = new ComboBox();
            grpDoctor.SuspendLayout();
            SuspendLayout();
            // 
            // grpDoctor
            // 
            grpDoctor.Controls.Add(cbDoctor);
            grpDoctor.Location = new Point(0, 0);
            grpDoctor.Name = "grpDoctor";
            grpDoctor.Size = new Size(211, 46);
            grpDoctor.TabIndex = 0;
            grpDoctor.TabStop = false;
            grpDoctor.Text = "Doctor:";
            // 
            // cbDoctor
            // 
            cbDoctor.FormattingEnabled = true;
            cbDoctor.Location = new Point(4, 17);
            cbDoctor.Name = "cbDoctor";
            cbDoctor.Size = new Size(193, 23);
            cbDoctor.TabIndex = 0;
            // 
            // DoctorDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpDoctor);
            Name = "DoctorDetails";
            Size = new Size(216, 48);
            Load += DoctorDetails_Load;
            grpDoctor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDoctor;
        private ComboBox cbDoctor;
    }
}
