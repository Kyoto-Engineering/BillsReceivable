namespace BillsReceivableSystem.Report
{
    partial class ReportForInvoice
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
            this.label1 = new System.Windows.Forms.Label();
            this.invoiceIdcomboBox = new System.Windows.Forms.ComboBox();
            this.Getbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice Id :";
            // 
            // invoiceIdcomboBox
            // 
            this.invoiceIdcomboBox.FormattingEnabled = true;
            this.invoiceIdcomboBox.Location = new System.Drawing.Point(218, 55);
            this.invoiceIdcomboBox.Name = "invoiceIdcomboBox";
            this.invoiceIdcomboBox.Size = new System.Drawing.Size(121, 21);
            this.invoiceIdcomboBox.TabIndex = 1;
            this.invoiceIdcomboBox.SelectedIndexChanged += new System.EventHandler(this.invoiceIdcomboBox_SelectedIndexChanged);
            // 
            // Getbutton
            // 
            this.Getbutton.Location = new System.Drawing.Point(246, 108);
            this.Getbutton.Name = "Getbutton";
            this.Getbutton.Size = new System.Drawing.Size(75, 23);
            this.Getbutton.TabIndex = 2;
            this.Getbutton.Text = "Get";
            this.Getbutton.UseVisualStyleBackColor = true;
            this.Getbutton.Click += new System.EventHandler(this.Getbutton_Click);
            // 
            // ReportForInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 293);
            this.Controls.Add(this.Getbutton);
            this.Controls.Add(this.invoiceIdcomboBox);
            this.Controls.Add(this.label1);
            this.Name = "ReportForInvoice";
            this.Text = "ReportForInvoice";
            this.Load += new System.EventHandler(this.ReportForInvoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox invoiceIdcomboBox;
        private System.Windows.Forms.Button Getbutton;
    }
}