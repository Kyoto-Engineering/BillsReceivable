namespace BillsReceivableSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.txtInvoiceAmount = new System.Windows.Forms.TextBox();
            this.lblInvoiceAmount = new System.Windows.Forms.Label();
            this.txtPayerAddress = new System.Windows.Forms.RichTextBox();
            this.lblPayerAddress = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.cmbBillPayable = new System.Windows.Forms.ComboBox();
            this.lblBillPayable = new System.Windows.Forms.Label();
            this.lblBillImage = new System.Windows.Forms.Label();
            this.txtpictureBox = new System.Windows.Forms.PictureBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.CustomFormat = "dd/MM/yyyy";
            this.dtpInvoiceDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(347, 208);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(144, 29);
            this.dtpInvoiceDate.TabIndex = 2;
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDate.ForeColor = System.Drawing.Color.Blue;
            this.lblInvoiceDate.Location = new System.Drawing.Point(221, 210);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(123, 22);
            this.lblInvoiceDate.TabIndex = 113;
            this.lblInvoiceDate.Text = "Invoice Date :";
            // 
            // txtInvoiceAmount
            // 
            this.txtInvoiceAmount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceAmount.Location = new System.Drawing.Point(346, 288);
            this.txtInvoiceAmount.Name = "txtInvoiceAmount";
            this.txtInvoiceAmount.Size = new System.Drawing.Size(267, 29);
            this.txtInvoiceAmount.TabIndex = 4;
            this.txtInvoiceAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceAmount_KeyPress_1);
            // 
            // lblInvoiceAmount
            // 
            this.lblInvoiceAmount.AutoSize = true;
            this.lblInvoiceAmount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceAmount.ForeColor = System.Drawing.Color.Blue;
            this.lblInvoiceAmount.Location = new System.Drawing.Point(196, 288);
            this.lblInvoiceAmount.Name = "lblInvoiceAmount";
            this.lblInvoiceAmount.Size = new System.Drawing.Size(147, 22);
            this.lblInvoiceAmount.TabIndex = 111;
            this.lblInvoiceAmount.Text = "Invoice Amount :";
            // 
            // txtPayerAddress
            // 
            this.txtPayerAddress.BackColor = System.Drawing.Color.White;
            this.txtPayerAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayerAddress.Location = new System.Drawing.Point(347, 117);
            this.txtPayerAddress.Name = "txtPayerAddress";
            this.txtPayerAddress.Size = new System.Drawing.Size(360, 85);
            this.txtPayerAddress.TabIndex = 1;
            this.txtPayerAddress.Text = "";
            // 
            // lblPayerAddress
            // 
            this.lblPayerAddress.AutoSize = true;
            this.lblPayerAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayerAddress.ForeColor = System.Drawing.Color.Blue;
            this.lblPayerAddress.Location = new System.Drawing.Point(193, 119);
            this.lblPayerAddress.Name = "lblPayerAddress";
            this.lblPayerAddress.Size = new System.Drawing.Size(151, 22);
            this.lblPayerAddress.TabIndex = 109;
            this.lblPayerAddress.Text = "Payer\'s Address :";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(347, 247);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(267, 29);
            this.txtInvoiceNo.TabIndex = 3;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.ForeColor = System.Drawing.Color.Blue;
            this.lblInvoiceNo.Location = new System.Drawing.Point(237, 250);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(108, 22);
            this.lblInvoiceNo.TabIndex = 107;
            this.lblInvoiceNo.Text = "Invoice No :";
            // 
            // cmbBillPayable
            // 
            this.cmbBillPayable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBillPayable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBillPayable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBillPayable.DropDownWidth = 233;
            this.cmbBillPayable.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBillPayable.FormattingEnabled = true;
            this.cmbBillPayable.ItemHeight = 22;
            this.cmbBillPayable.Location = new System.Drawing.Point(348, 78);
            this.cmbBillPayable.Name = "cmbBillPayable";
            this.cmbBillPayable.Size = new System.Drawing.Size(267, 30);
            this.cmbBillPayable.TabIndex = 0;
            this.cmbBillPayable.SelectedIndexChanged += new System.EventHandler(this.cmbBillPayable_SelectedIndexChanged_1);
            // 
            // lblBillPayable
            // 
            this.lblBillPayable.AutoSize = true;
            this.lblBillPayable.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillPayable.ForeColor = System.Drawing.Color.Blue;
            this.lblBillPayable.Location = new System.Drawing.Point(226, 78);
            this.lblBillPayable.Name = "lblBillPayable";
            this.lblBillPayable.Size = new System.Drawing.Size(118, 22);
            this.lblBillPayable.TabIndex = 106;
            this.lblBillPayable.Text = "Bill Payable :";
            // 
            // lblBillImage
            // 
            this.lblBillImage.AutoSize = true;
            this.lblBillImage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillImage.ForeColor = System.Drawing.Color.Blue;
            this.lblBillImage.Location = new System.Drawing.Point(237, 326);
            this.lblBillImage.Name = "lblBillImage";
            this.lblBillImage.Size = new System.Drawing.Size(104, 22);
            this.lblBillImage.TabIndex = 115;
            this.lblBillImage.Text = "Bill Image :";
            // 
            // txtpictureBox
            // 
            this.txtpictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtpictureBox.BackgroundImage")));
            this.txtpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtpictureBox.Location = new System.Drawing.Point(344, 326);
            this.txtpictureBox.Name = "txtpictureBox";
            this.txtpictureBox.Size = new System.Drawing.Size(363, 189);
            this.txtpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtpictureBox.TabIndex = 114;
            this.txtpictureBox.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.DarkGreen;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.Location = new System.Drawing.Point(586, 554);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(121, 60);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.Color.Cyan;
            this.browseButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.ForeColor = System.Drawing.Color.Black;
            this.browseButton.Location = new System.Drawing.Point(346, 523);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(144, 33);
            this.browseButton.TabIndex = 5;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(341, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 31);
            this.label1.TabIndex = 118;
            this.label1.Text = "Bills Receivable Entry";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 670);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.lblBillImage);
            this.Controls.Add(this.txtpictureBox);
            this.Controls.Add(this.dtpInvoiceDate);
            this.Controls.Add(this.lblInvoiceDate);
            this.Controls.Add(this.txtInvoiceAmount);
            this.Controls.Add(this.lblInvoiceAmount);
            this.Controls.Add(this.txtPayerAddress);
            this.Controls.Add(this.lblPayerAddress);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.lblInvoiceNo);
            this.Controls.Add(this.cmbBillPayable);
            this.Controls.Add(this.lblBillPayable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.TextBox txtInvoiceAmount;
        private System.Windows.Forms.Label lblInvoiceAmount;
        private System.Windows.Forms.RichTextBox txtPayerAddress;
        private System.Windows.Forms.Label lblPayerAddress;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.ComboBox cmbBillPayable;
        private System.Windows.Forms.Label lblBillPayable;
        private System.Windows.Forms.Label lblBillImage;
        public System.Windows.Forms.PictureBox txtpictureBox;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label1;
    }
}

