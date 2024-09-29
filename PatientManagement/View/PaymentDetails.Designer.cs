namespace PatientManagement
{
    partial class PaymentDetails
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
            grpPaymentDetails = new GroupBox();
            txtOtherDetails = new TextBox();
            lblOtherDetails = new Label();
            txtPaymentId = new TextBox();
            lblPaymentId = new Label();
            cbPaymentMode = new ComboBox();
            lblPaymentMode = new Label();
            txtAmount = new TextBox();
            lblAmount = new Label();
            grpPaymentDetails.SuspendLayout();
            SuspendLayout();
            // 
            // grpPaymentDetails
            // 
            grpPaymentDetails.Controls.Add(txtOtherDetails);
            grpPaymentDetails.Controls.Add(lblOtherDetails);
            grpPaymentDetails.Controls.Add(txtPaymentId);
            grpPaymentDetails.Controls.Add(lblPaymentId);
            grpPaymentDetails.Controls.Add(cbPaymentMode);
            grpPaymentDetails.Controls.Add(lblPaymentMode);
            grpPaymentDetails.Controls.Add(txtAmount);
            grpPaymentDetails.Controls.Add(lblAmount);
            grpPaymentDetails.Location = new Point(0, 0);
            grpPaymentDetails.Name = "grpPaymentDetails";
            grpPaymentDetails.Size = new Size(510, 100);
            grpPaymentDetails.TabIndex = 0;
            grpPaymentDetails.TabStop = false;
            grpPaymentDetails.Text = "Payment Details:";
            // 
            // txtOtherDetails
            // 
            txtOtherDetails.Location = new Point(359, 56);
            txtOtherDetails.Name = "txtOtherDetails";
            txtOtherDetails.Size = new Size(128, 23);
            txtOtherDetails.TabIndex = 23;
            // 
            // lblOtherDetails
            // 
            lblOtherDetails.AutoSize = true;
            lblOtherDetails.Location = new Point(252, 60);
            lblOtherDetails.Name = "lblOtherDetails";
            lblOtherDetails.Size = new Size(78, 15);
            lblOtherDetails.TabIndex = 22;
            lblOtherDetails.Text = "Other Details:";
            // 
            // txtPaymentId
            // 
            txtPaymentId.Location = new Point(81, 61);
            txtPaymentId.Name = "txtPaymentId";
            txtPaymentId.Size = new Size(128, 23);
            txtPaymentId.TabIndex = 21;
            // 
            // lblPaymentId
            // 
            lblPaymentId.AutoSize = true;
            lblPaymentId.Location = new Point(5, 64);
            lblPaymentId.Name = "lblPaymentId";
            lblPaymentId.Size = new Size(70, 15);
            lblPaymentId.TabIndex = 20;
            lblPaymentId.Text = "Payment Id:";
            // 
            // cbPaymentMode
            // 
            cbPaymentMode.FormattingEnabled = true;
            cbPaymentMode.Items.AddRange(new object[] { "CASH", "Online" });
            cbPaymentMode.Location = new Point(359, 22);
            cbPaymentMode.Name = "cbPaymentMode";
            cbPaymentMode.Size = new Size(128, 23);
            cbPaymentMode.TabIndex = 19;
            // 
            // lblPaymentMode
            // 
            lblPaymentMode.AutoSize = true;
            lblPaymentMode.Location = new Point(252, 26);
            lblPaymentMode.Name = "lblPaymentMode";
            lblPaymentMode.Size = new Size(91, 15);
            lblPaymentMode.TabIndex = 6;
            lblPaymentMode.Text = "Payment Mode:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(81, 22);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(128, 23);
            txtAmount.TabIndex = 5;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(5, 26);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(54, 15);
            lblAmount.TabIndex = 4;
            lblAmount.Text = "Amount:";
            // 
            // PaymentDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpPaymentDetails);
            Name = "PaymentDetails";
            Size = new Size(516, 105);
            grpPaymentDetails.ResumeLayout(false);
            grpPaymentDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpPaymentDetails;
        private Label lblPaymentMode;
        private TextBox txtAmount;
        private Label lblAmount;
        private TextBox txtOtherDetails;
        private Label lblOtherDetails;
        private TextBox txtPaymentId;
        private Label lblPaymentId;
        private ComboBox cbPaymentMode;
    }
}
