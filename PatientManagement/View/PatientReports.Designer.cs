namespace PatientManagement.View
{
    partial class PatientReports
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
            grpReportFilters = new GroupBox();
            btnReportSearch = new Button();
            grpReportDateRange = new GroupBox();
            lblReportFrom = new Label();
            dtReportFrom = new DateTimePicker();
            lblReportTo = new Label();
            dtReportTo = new DateTimePicker();
            dtReportYear = new DateTimePicker();
            cbReportMonth = new ComboBox();
            cbReportBy = new ComboBox();
            label16 = new Label();
            grpPatientDetails = new GroupBox();
            dgvReport = new DataGridView();
            grpReportFilters.SuspendLayout();
            grpReportDateRange.SuspendLayout();
            grpPatientDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // grpReportFilters
            // 
            grpReportFilters.Controls.Add(btnReportSearch);
            grpReportFilters.Controls.Add(grpReportDateRange);
            grpReportFilters.Controls.Add(dtReportYear);
            grpReportFilters.Controls.Add(cbReportMonth);
            grpReportFilters.Controls.Add(cbReportBy);
            grpReportFilters.Controls.Add(label16);
            grpReportFilters.Dock = DockStyle.Top;
            grpReportFilters.Location = new Point(0, 0);
            grpReportFilters.Name = "grpReportFilters";
            grpReportFilters.Size = new Size(800, 91);
            grpReportFilters.TabIndex = 0;
            grpReportFilters.TabStop = false;
            grpReportFilters.Text = "Report Filters:";
            // 
            // btnReportSearch
            // 
            btnReportSearch.ForeColor = Color.Black;
            btnReportSearch.Location = new Point(697, 64);
            btnReportSearch.Name = "btnReportSearch";
            btnReportSearch.Size = new Size(75, 23);
            btnReportSearch.TabIndex = 36;
            btnReportSearch.Text = "Search";
            btnReportSearch.UseVisualStyleBackColor = true;
            btnReportSearch.Click += btnReportSearch_Click;
            // 
            // grpReportDateRange
            // 
            grpReportDateRange.Controls.Add(lblReportFrom);
            grpReportDateRange.Controls.Add(dtReportFrom);
            grpReportDateRange.Controls.Add(lblReportTo);
            grpReportDateRange.Controls.Add(dtReportTo);
            grpReportDateRange.ForeColor = SystemColors.ControlText;
            grpReportDateRange.Location = new Point(387, 14);
            grpReportDateRange.Name = "grpReportDateRange";
            grpReportDateRange.Size = new Size(407, 44);
            grpReportDateRange.TabIndex = 35;
            grpReportDateRange.TabStop = false;
            grpReportDateRange.Text = "Date Range";
            grpReportDateRange.Visible = false;
            // 
            // lblReportFrom
            // 
            lblReportFrom.AutoSize = true;
            lblReportFrom.Location = new Point(6, 19);
            lblReportFrom.Name = "lblReportFrom";
            lblReportFrom.Size = new Size(38, 15);
            lblReportFrom.TabIndex = 17;
            lblReportFrom.Text = "From:";
            // 
            // dtReportFrom
            // 
            dtReportFrom.CustomFormat = "";
            dtReportFrom.Location = new Point(64, 15);
            dtReportFrom.Name = "dtReportFrom";
            dtReportFrom.Size = new Size(138, 23);
            dtReportFrom.TabIndex = 22;
            // 
            // lblReportTo
            // 
            lblReportTo.AutoSize = true;
            lblReportTo.Location = new Point(219, 19);
            lblReportTo.Name = "lblReportTo";
            lblReportTo.Size = new Size(22, 15);
            lblReportTo.TabIndex = 25;
            lblReportTo.Text = "To:";
            // 
            // dtReportTo
            // 
            dtReportTo.CustomFormat = "";
            dtReportTo.Location = new Point(247, 15);
            dtReportTo.Name = "dtReportTo";
            dtReportTo.Size = new Size(138, 23);
            dtReportTo.TabIndex = 24;
            // 
            // dtReportYear
            // 
            dtReportYear.CustomFormat = "yyyy";
            dtReportYear.Format = DateTimePickerFormat.Custom;
            dtReportYear.Location = new Point(306, 28);
            dtReportYear.Name = "dtReportYear";
            dtReportYear.Size = new Size(75, 23);
            dtReportYear.TabIndex = 34;
            dtReportYear.Visible = false;
            // 
            // cbReportMonth
            // 
            cbReportMonth.FormattingEnabled = true;
            cbReportMonth.Items.AddRange(new object[] { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" });
            cbReportMonth.Location = new Point(225, 28);
            cbReportMonth.Name = "cbReportMonth";
            cbReportMonth.Size = new Size(75, 23);
            cbReportMonth.TabIndex = 33;
            cbReportMonth.Visible = false;
            // 
            // cbReportBy
            // 
            cbReportBy.FormattingEnabled = true;
            cbReportBy.Items.AddRange(new object[] { "Month", "Year", "Date Range" });
            cbReportBy.Location = new Point(74, 28);
            cbReportBy.Name = "cbReportBy";
            cbReportBy.Size = new Size(138, 23);
            cbReportBy.TabIndex = 32;
            cbReportBy.SelectedIndexChanged += cbReportBy_SelectedIndexChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(7, 32);
            label16.Name = "label16";
            label16.Size = new Size(61, 15);
            label16.TabIndex = 31;
            label16.Text = "Report By:";
            // 
            // grpPatientDetails
            // 
            grpPatientDetails.Controls.Add(dgvReport);
            grpPatientDetails.Dock = DockStyle.Fill;
            grpPatientDetails.ForeColor = SystemColors.ControlText;
            grpPatientDetails.Location = new Point(0, 91);
            grpPatientDetails.Name = "grpPatientDetails";
            grpPatientDetails.Size = new Size(800, 359);
            grpPatientDetails.TabIndex = 8;
            grpPatientDetails.TabStop = false;
            grpPatientDetails.Text = "Patient Details";
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Dock = DockStyle.Fill;
            dgvReport.Location = new Point(3, 19);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 62;
            dgvReport.Size = new Size(794, 337);
            dgvReport.TabIndex = 0;
            // 
            // PatientReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpPatientDetails);
            Controls.Add(grpReportFilters);
            Name = "PatientReports";
            Text = "PatientReports";
            grpReportFilters.ResumeLayout(false);
            grpReportFilters.PerformLayout();
            grpReportDateRange.ResumeLayout(false);
            grpReportDateRange.PerformLayout();
            grpPatientDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpReportFilters;
        private Button btnReportSearch;
        private GroupBox grpReportDateRange;
        private Label lblReportFrom;
        private DateTimePicker dtReportFrom;
        private Label lblReportTo;
        private DateTimePicker dtReportTo;
        private DateTimePicker dtReportYear;
        private ComboBox cbReportMonth;
        private ComboBox cbReportBy;
        private Label label16;
        private GroupBox grpPatientDetails;
        private DataGridView dgvReport;
    }
}