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
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.cmbBillPayable = new System.Windows.Forms.ComboBox();
            this.dtpNextFollowUpDate = new System.Windows.Forms.DateTimePicker();
            this.lblNextFollowUpDate = new System.Windows.Forms.Label();
            this.lblBillPayable = new System.Windows.Forms.Label();
            this.lblBillImage = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.txtpictureBox = new System.Windows.Forms.PictureBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.txtRP = new System.Windows.Forms.TextBox();
            this.lblRespondentPerson = new System.Windows.Forms.Label();
            this.txtFollowUpNote = new System.Windows.Forms.RichTextBox();
            this.lblFollowUpNote = new System.Windows.Forms.Label();
            this.txtPayerAddress = new System.Windows.Forms.RichTextBox();
            this.lblPayerAddress = new System.Windows.Forms.Label();
            this.txtInvoiceAmount = new System.Windows.Forms.TextBox();
            this.lblInvoiceAmount = new System.Windows.Forms.Label();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDirectCellNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(232, 294);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(267, 29);
            this.txtInvoiceNo.TabIndex = 50;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.ForeColor = System.Drawing.Color.Blue;
            this.lblInvoiceNo.Location = new System.Drawing.Point(122, 297);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(108, 22);
            this.lblInvoiceNo.TabIndex = 65;
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
            this.cmbBillPayable.Location = new System.Drawing.Point(233, 117);
            this.cmbBillPayable.Name = "cmbBillPayable";
            this.cmbBillPayable.Size = new System.Drawing.Size(267, 30);
            this.cmbBillPayable.TabIndex = 51;
            this.cmbBillPayable.SelectedIndexChanged += new System.EventHandler(this.cmbBillPayable_SelectedIndexChanged);
            // 
            // dtpNextFollowUpDate
            // 
            this.dtpNextFollowUpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpNextFollowUpDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNextFollowUpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNextFollowUpDate.Location = new System.Drawing.Point(795, 378);
            this.dtpNextFollowUpDate.Name = "dtpNextFollowUpDate";
            this.dtpNextFollowUpDate.Size = new System.Drawing.Size(145, 29);
            this.dtpNextFollowUpDate.TabIndex = 49;
            // 
            // lblNextFollowUpDate
            // 
            this.lblNextFollowUpDate.AutoSize = true;
            this.lblNextFollowUpDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextFollowUpDate.ForeColor = System.Drawing.Color.Blue;
            this.lblNextFollowUpDate.Location = new System.Drawing.Point(600, 380);
            this.lblNextFollowUpDate.Name = "lblNextFollowUpDate";
            this.lblNextFollowUpDate.Size = new System.Drawing.Size(191, 22);
            this.lblNextFollowUpDate.TabIndex = 61;
            this.lblNextFollowUpDate.Text = "Next Follow Up Date :";
            // 
            // lblBillPayable
            // 
            this.lblBillPayable.AutoSize = true;
            this.lblBillPayable.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillPayable.ForeColor = System.Drawing.Color.Blue;
            this.lblBillPayable.Location = new System.Drawing.Point(111, 117);
            this.lblBillPayable.Name = "lblBillPayable";
            this.lblBillPayable.Size = new System.Drawing.Size(118, 22);
            this.lblBillPayable.TabIndex = 58;
            this.lblBillPayable.Text = "Bill Payable :";
            // 
            // lblBillImage
            // 
            this.lblBillImage.AutoSize = true;
            this.lblBillImage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillImage.ForeColor = System.Drawing.Color.Blue;
            this.lblBillImage.Location = new System.Drawing.Point(122, 369);
            this.lblBillImage.Name = "lblBillImage";
            this.lblBillImage.Size = new System.Drawing.Size(104, 22);
            this.lblBillImage.TabIndex = 72;
            this.lblBillImage.Text = "Bill Image :";
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.Color.Cyan;
            this.browseButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.ForeColor = System.Drawing.Color.Black;
            this.browseButton.Location = new System.Drawing.Point(228, 563);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(144, 33);
            this.browseButton.TabIndex = 66;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // txtpictureBox
            // 
            this.txtpictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtpictureBox.BackgroundImage")));
            this.txtpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtpictureBox.Location = new System.Drawing.Point(229, 369);
            this.txtpictureBox.Name = "txtpictureBox";
            this.txtpictureBox.Size = new System.Drawing.Size(363, 189);
            this.txtpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtpictureBox.TabIndex = 71;
            this.txtpictureBox.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.DarkGreen;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.Location = new System.Drawing.Point(794, 526);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(121, 60);
            this.BtnSave.TabIndex = 73;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(791, 302);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(267, 29);
            this.txtContactNo.TabIndex = 82;
            this.txtContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactNo_KeyPress);
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.ForeColor = System.Drawing.Color.Blue;
            this.lblContactNo.Location = new System.Drawing.Point(675, 305);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(114, 22);
            this.lblContactNo.TabIndex = 83;
            this.lblContactNo.Text = "Contact No :";
            // 
            // txtRP
            // 
            this.txtRP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRP.Location = new System.Drawing.Point(790, 250);
            this.txtRP.Name = "txtRP";
            this.txtRP.Size = new System.Drawing.Size(267, 29);
            this.txtRP.TabIndex = 80;
            // 
            // lblRespondentPerson
            // 
            this.lblRespondentPerson.AutoSize = true;
            this.lblRespondentPerson.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespondentPerson.ForeColor = System.Drawing.Color.Blue;
            this.lblRespondentPerson.Location = new System.Drawing.Point(572, 252);
            this.lblRespondentPerson.Name = "lblRespondentPerson";
            this.lblRespondentPerson.Size = new System.Drawing.Size(216, 22);
            this.lblRespondentPerson.TabIndex = 81;
            this.lblRespondentPerson.Text = "Respondent Person(RP) :";
            // 
            // txtFollowUpNote
            // 
            this.txtFollowUpNote.BackColor = System.Drawing.Color.White;
            this.txtFollowUpNote.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFollowUpNote.Location = new System.Drawing.Point(791, 101);
            this.txtFollowUpNote.Name = "txtFollowUpNote";
            this.txtFollowUpNote.Size = new System.Drawing.Size(330, 133);
            this.txtFollowUpNote.TabIndex = 78;
            this.txtFollowUpNote.Text = "";
            // 
            // lblFollowUpNote
            // 
            this.lblFollowUpNote.AutoSize = true;
            this.lblFollowUpNote.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFollowUpNote.ForeColor = System.Drawing.Color.Blue;
            this.lblFollowUpNote.Location = new System.Drawing.Point(641, 102);
            this.lblFollowUpNote.Name = "lblFollowUpNote";
            this.lblFollowUpNote.Size = new System.Drawing.Size(148, 22);
            this.lblFollowUpNote.TabIndex = 79;
            this.lblFollowUpNote.Text = "Follow Up Note :";
            // 
            // txtPayerAddress
            // 
            this.txtPayerAddress.BackColor = System.Drawing.Color.White;
            this.txtPayerAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayerAddress.Location = new System.Drawing.Point(232, 159);
            this.txtPayerAddress.Name = "txtPayerAddress";
            this.txtPayerAddress.Size = new System.Drawing.Size(360, 85);
            this.txtPayerAddress.TabIndex = 84;
            this.txtPayerAddress.Text = "";
            // 
            // lblPayerAddress
            // 
            this.lblPayerAddress.AutoSize = true;
            this.lblPayerAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayerAddress.ForeColor = System.Drawing.Color.Blue;
            this.lblPayerAddress.Location = new System.Drawing.Point(78, 161);
            this.lblPayerAddress.Name = "lblPayerAddress";
            this.lblPayerAddress.Size = new System.Drawing.Size(151, 22);
            this.lblPayerAddress.TabIndex = 85;
            this.lblPayerAddress.Text = "Payer\'s Address :";
            // 
            // txtInvoiceAmount
            // 
            this.txtInvoiceAmount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceAmount.Location = new System.Drawing.Point(231, 331);
            this.txtInvoiceAmount.Name = "txtInvoiceAmount";
            this.txtInvoiceAmount.Size = new System.Drawing.Size(267, 29);
            this.txtInvoiceAmount.TabIndex = 88;
            this.txtInvoiceAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceAmount_KeyPress);
            // 
            // lblInvoiceAmount
            // 
            this.lblInvoiceAmount.AutoSize = true;
            this.lblInvoiceAmount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceAmount.ForeColor = System.Drawing.Color.Blue;
            this.lblInvoiceAmount.Location = new System.Drawing.Point(81, 331);
            this.lblInvoiceAmount.Name = "lblInvoiceAmount";
            this.lblInvoiceAmount.Size = new System.Drawing.Size(147, 22);
            this.lblInvoiceAmount.TabIndex = 89;
            this.lblInvoiceAmount.Text = "Invoice Amount :";
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.CustomFormat = "dd/MM/yyyy";
            this.dtpInvoiceDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(232, 257);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(144, 29);
            this.dtpInvoiceDate.TabIndex = 92;
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDate.ForeColor = System.Drawing.Color.Blue;
            this.lblInvoiceDate.Location = new System.Drawing.Point(106, 259);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(123, 22);
            this.lblInvoiceDate.TabIndex = 93;
            this.lblInvoiceDate.Text = "Invoice Date :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(790, 337);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 29);
            this.textBox1.TabIndex = 94;
            // 
            // lblDirectCellNo
            // 
            this.lblDirectCellNo.AutoSize = true;
            this.lblDirectCellNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectCellNo.ForeColor = System.Drawing.Color.Blue;
            this.lblDirectCellNo.Location = new System.Drawing.Point(650, 340);
            this.lblDirectCellNo.Name = "lblDirectCellNo";
            this.lblDirectCellNo.Size = new System.Drawing.Size(138, 22);
            this.lblDirectCellNo.TabIndex = 95;
            this.lblDirectCellNo.Text = "Direct Cell No :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1168, 661);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDirectCellNo);
            this.Controls.Add(this.dtpInvoiceDate);
            this.Controls.Add(this.lblInvoiceDate);
            this.Controls.Add(this.txtInvoiceAmount);
            this.Controls.Add(this.lblInvoiceAmount);
            this.Controls.Add(this.txtPayerAddress);
            this.Controls.Add(this.lblPayerAddress);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.txtRP);
            this.Controls.Add(this.lblRespondentPerson);
            this.Controls.Add(this.txtFollowUpNote);
            this.Controls.Add(this.lblFollowUpNote);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.lblBillImage);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.txtpictureBox);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.lblInvoiceNo);
            this.Controls.Add(this.cmbBillPayable);
            this.Controls.Add(this.dtpNextFollowUpDate);
            this.Controls.Add(this.lblNextFollowUpDate);
            this.Controls.Add(this.lblBillPayable);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.ComboBox cmbBillPayable;
        private System.Windows.Forms.DateTimePicker dtpNextFollowUpDate;
        private System.Windows.Forms.Label lblNextFollowUpDate;
        private System.Windows.Forms.Label lblBillPayable;
        private System.Windows.Forms.Label lblBillImage;
        private System.Windows.Forms.Button browseButton;
        public System.Windows.Forms.PictureBox txtpictureBox;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.TextBox txtRP;
        private System.Windows.Forms.Label lblRespondentPerson;
        private System.Windows.Forms.RichTextBox txtFollowUpNote;
        private System.Windows.Forms.Label lblFollowUpNote;
        private System.Windows.Forms.RichTextBox txtPayerAddress;
        private System.Windows.Forms.Label lblPayerAddress;
        private System.Windows.Forms.TextBox txtInvoiceAmount;
        private System.Windows.Forms.Label lblInvoiceAmount;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDirectCellNo;
    }
}

