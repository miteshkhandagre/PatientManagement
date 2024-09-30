namespace PatientManagement
{
    partial class Master
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            registrationToolStripMenuItem = new ToolStripMenuItem();
            patientToolStripMenuItem = new ToolStripMenuItem();
            doctorToolStripMenuItem = new ToolStripMenuItem();
            uSGToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            patientHistoryToolStripMenuItem1 = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            createDBToolStripMenuItem = new ToolStripMenuItem();
            addUserToolStripMenuItem = new ToolStripMenuItem();
            patientReportDatewiseToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, registrationToolStripMenuItem, reportsToolStripMenuItem, adminToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // registrationToolStripMenuItem
            // 
            registrationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { patientToolStripMenuItem, doctorToolStripMenuItem, uSGToolStripMenuItem });
            registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            registrationToolStripMenuItem.Size = new Size(82, 20);
            registrationToolStripMenuItem.Text = "Registration";
            // 
            // patientToolStripMenuItem
            // 
            patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            patientToolStripMenuItem.Size = new Size(111, 22);
            patientToolStripMenuItem.Text = "Patient";
            patientToolStripMenuItem.Click += patientToolStripMenuItem_Click;
            // 
            // doctorToolStripMenuItem
            // 
            doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            doctorToolStripMenuItem.Size = new Size(111, 22);
            doctorToolStripMenuItem.Text = "Doctor";
            doctorToolStripMenuItem.Click += doctorToolStripMenuItem_Click;
            // 
            // uSGToolStripMenuItem
            // 
            uSGToolStripMenuItem.Name = "uSGToolStripMenuItem";
            uSGToolStripMenuItem.Size = new Size(111, 22);
            uSGToolStripMenuItem.Text = "USG";
            uSGToolStripMenuItem.Click += uSGToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { patientHistoryToolStripMenuItem1, patientReportDatewiseToolStripMenuItem });
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(59, 20);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // patientHistoryToolStripMenuItem1
            // 
            patientHistoryToolStripMenuItem1.Name = "patientHistoryToolStripMenuItem1";
            patientHistoryToolStripMenuItem1.Size = new Size(199, 22);
            patientHistoryToolStripMenuItem1.Text = "Patient History";
            patientHistoryToolStripMenuItem1.Click += patientHistoryToolStripMenuItem1_Click;
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createDBToolStripMenuItem, addUserToolStripMenuItem });
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(55, 20);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // createDBToolStripMenuItem
            // 
            createDBToolStripMenuItem.Name = "createDBToolStripMenuItem";
            createDBToolStripMenuItem.Size = new Size(126, 22);
            createDBToolStripMenuItem.Text = "Create DB";
            createDBToolStripMenuItem.Click += createDBToolStripMenuItem_Click;
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(126, 22);
            addUserToolStripMenuItem.Text = "Add User";
            addUserToolStripMenuItem.Click += addUserToolStripMenuItem_Click;
            // 
            // patientReportDatewiseToolStripMenuItem
            // 
            patientReportDatewiseToolStripMenuItem.Name = "patientReportDatewiseToolStripMenuItem";
            patientReportDatewiseToolStripMenuItem.Size = new Size(199, 22);
            patientReportDatewiseToolStripMenuItem.Text = "Patient Report Datewise";
            patientReportDatewiseToolStripMenuItem.Click += patientReportDatewiseToolStripMenuItem_Click;
            // 
            // Master
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Master";
            Text = "Patient Management";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem registrationToolStripMenuItem;
        private ToolStripMenuItem patientToolStripMenuItem;
        private ToolStripMenuItem doctorToolStripMenuItem;
        private ToolStripMenuItem uSGToolStripMenuItem;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem createDBToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem patientHistoryToolStripMenuItem1;
        private ToolStripMenuItem addUserToolStripMenuItem;
        private ToolStripMenuItem patientReportDatewiseToolStripMenuItem;
    }
}
