namespace BillsReceivableSystem.Report
{
    partial class ReportsUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsUI));
            this.InReportButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AllReceiBillListButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InReportButton
            // 
            this.InReportButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.InReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InReportButton.Location = new System.Drawing.Point(15, 19);
            this.InReportButton.Name = "InReportButton";
            this.InReportButton.Size = new System.Drawing.Size(113, 55);
            this.InReportButton.TabIndex = 0;
            this.InReportButton.Text = "Invoice Report";
            this.InReportButton.UseVisualStyleBackColor = false;
            this.InReportButton.Click += new System.EventHandler(this.InReportButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AllReceiBillListButton);
            this.groupBox1.Controls.Add(this.InReportButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 361);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumPurple;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reports";
            // 
            // AllReceiBillListButton
            // 
            this.AllReceiBillListButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.AllReceiBillListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllReceiBillListButton.Location = new System.Drawing.Point(144, 19);
            this.AllReceiBillListButton.Name = "AllReceiBillListButton";
            this.AllReceiBillListButton.Size = new System.Drawing.Size(140, 55);
            this.AllReceiBillListButton.TabIndex = 1;
            this.AllReceiBillListButton.Text = "All Receivable Bills List";
            this.AllReceiBillListButton.UseVisualStyleBackColor = false;
            this.AllReceiBillListButton.Click += new System.EventHandler(this.AllReceiBillListButton_Click);
            // 
            // ReportsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(644, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportsUI";
            this.Text = "ReportsUI";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InReportButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AllReceiBillListButton;
        private System.Windows.Forms.Label label1;
    }
}