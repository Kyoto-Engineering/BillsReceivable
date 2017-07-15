namespace BillsReceivableSystem.UI
{
    partial class Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.txtRP = new System.Windows.Forms.TextBox();
            this.lblRespondentPerson = new System.Windows.Forms.Label();
            this.lblQuotation = new System.Windows.Forms.Label();
            this.cmbQuotation = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPayerAddress = new System.Windows.Forms.RichTextBox();
            this.lblPayerAddress = new System.Windows.Forms.Label();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.txtGrossReceivable = new System.Windows.Forms.TextBox();
            this.lblGrossReceivable = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.txtInvoiceParty = new System.Windows.Forms.TextBox();
            this.lblInvoiceParty = new System.Windows.Forms.Label();
            this.txtNetReceivable = new System.Windows.Forms.TextBox();
            this.lblNetReceivable = new System.Windows.Forms.Label();
            this.dtpPromisedDate = new System.Windows.Forms.DateTimePicker();
            this.lblPromisedDate = new System.Windows.Forms.Label();
            this.txtLandPhone = new System.Windows.Forms.TextBox();
            this.lblLandPhone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCellPhone.Location = new System.Drawing.Point(251, 426);
            this.txtCellPhone.MaxLength = 11;
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.ReadOnly = true;
            this.txtCellPhone.Size = new System.Drawing.Size(264, 29);
            this.txtCellPhone.TabIndex = 5;
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellPhone.ForeColor = System.Drawing.Color.Blue;
            this.lblCellPhone.Location = new System.Drawing.Point(137, 426);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(109, 22);
            this.lblCellPhone.TabIndex = 105;
            this.lblCellPhone.Text = "Cell Phone :";
            // 
            // txtRP
            // 
            this.txtRP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRP.Location = new System.Drawing.Point(249, 377);
            this.txtRP.MaxLength = 90;
            this.txtRP.Name = "txtRP";
            this.txtRP.ReadOnly = true;
            this.txtRP.Size = new System.Drawing.Size(267, 29);
            this.txtRP.TabIndex = 4;
            // 
            // lblRespondentPerson
            // 
            this.lblRespondentPerson.AutoSize = true;
            this.lblRespondentPerson.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespondentPerson.ForeColor = System.Drawing.Color.Blue;
            this.lblRespondentPerson.Location = new System.Drawing.Point(27, 377);
            this.lblRespondentPerson.Name = "lblRespondentPerson";
            this.lblRespondentPerson.Size = new System.Drawing.Size(216, 22);
            this.lblRespondentPerson.TabIndex = 101;
            this.lblRespondentPerson.Text = "Respondent Person(RP) :";
            // 
            // lblQuotation
            // 
            this.lblQuotation.AutoSize = true;
            this.lblQuotation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuotation.ForeColor = System.Drawing.Color.Blue;
            this.lblQuotation.Location = new System.Drawing.Point(17, 91);
            this.lblQuotation.Name = "lblQuotation";
            this.lblQuotation.Size = new System.Drawing.Size(229, 22);
            this.lblQuotation.TabIndex = 106;
            this.lblQuotation.Text = "Quotation Id/Ref/Number :";
            // 
            // cmbQuotation
            // 
            this.cmbQuotation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbQuotation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbQuotation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQuotation.FormattingEnabled = true;
            this.cmbQuotation.Location = new System.Drawing.Point(251, 91);
            this.cmbQuotation.Name = "cmbQuotation";
            this.cmbQuotation.Size = new System.Drawing.Size(264, 30);
            this.cmbQuotation.TabIndex = 0;
            this.cmbQuotation.SelectedIndexChanged += new System.EventHandler(this.cmbQuotation_SelectedIndexChanged);
            this.cmbQuotation.Leave += new System.EventHandler(this.cmbQuotation_Leave);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Coral;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(935, 392);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 63);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Generate Invoice";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPayerAddress
            // 
            this.txtPayerAddress.BackColor = System.Drawing.Color.White;
            this.txtPayerAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayerAddress.Location = new System.Drawing.Point(248, 190);
            this.txtPayerAddress.MaxLength = 250;
            this.txtPayerAddress.Name = "txtPayerAddress";
            this.txtPayerAddress.ReadOnly = true;
            this.txtPayerAddress.Size = new System.Drawing.Size(267, 118);
            this.txtPayerAddress.TabIndex = 2;
            this.txtPayerAddress.Text = "";
            // 
            // lblPayerAddress
            // 
            this.lblPayerAddress.AutoSize = true;
            this.lblPayerAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayerAddress.ForeColor = System.Drawing.Color.Blue;
            this.lblPayerAddress.Location = new System.Drawing.Point(92, 190);
            this.lblPayerAddress.Name = "lblPayerAddress";
            this.lblPayerAddress.Size = new System.Drawing.Size(151, 22);
            this.lblPayerAddress.TabIndex = 123;
            this.lblPayerAddress.Text = "Payer\'s Address :";
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.CustomFormat = "dd/MM/yyyy";
            this.dtpInvoiceDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(779, 89);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(252, 29);
            this.dtpInvoiceDate.TabIndex = 6;
            this.dtpInvoiceDate.ValueChanged += new System.EventHandler(this.dtpInvoiceDate_ValueChanged);
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDate.ForeColor = System.Drawing.Color.Blue;
            this.lblInvoiceDate.Location = new System.Drawing.Point(653, 92);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(123, 22);
            this.lblInvoiceDate.TabIndex = 130;
            this.lblInvoiceDate.Text = "Invoice Date :";
            // 
            // txtGrossReceivable
            // 
            this.txtGrossReceivable.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossReceivable.Location = new System.Drawing.Point(778, 185);
            this.txtGrossReceivable.Name = "txtGrossReceivable";
            this.txtGrossReceivable.Size = new System.Drawing.Size(253, 29);
            this.txtGrossReceivable.TabIndex = 8;
            this.txtGrossReceivable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrossReceivable_KeyPress);
            // 
            // lblGrossReceivable
            // 
            this.lblGrossReceivable.AutoSize = true;
            this.lblGrossReceivable.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossReceivable.ForeColor = System.Drawing.Color.Blue;
            this.lblGrossReceivable.Location = new System.Drawing.Point(614, 188);
            this.lblGrossReceivable.Name = "lblGrossReceivable";
            this.lblGrossReceivable.Size = new System.Drawing.Size(163, 22);
            this.lblGrossReceivable.TabIndex = 128;
            this.lblGrossReceivable.Text = "Gross Receivable :";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDueDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDueDate.Location = new System.Drawing.Point(779, 137);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(252, 29);
            this.dtpDueDate.TabIndex = 7;
            this.dtpDueDate.ValueChanged += new System.EventHandler(this.dtpDueDate_ValueChanged);
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.ForeColor = System.Drawing.Color.Blue;
            this.lblDueDate.Location = new System.Drawing.Point(679, 140);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(97, 22);
            this.lblDueDate.TabIndex = 140;
            this.lblDueDate.Text = "Due Date :";
            // 
            // txtInvoiceParty
            // 
            this.txtInvoiceParty.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceParty.Location = new System.Drawing.Point(249, 141);
            this.txtInvoiceParty.MaxLength = 90;
            this.txtInvoiceParty.Name = "txtInvoiceParty";
            this.txtInvoiceParty.ReadOnly = true;
            this.txtInvoiceParty.Size = new System.Drawing.Size(267, 29);
            this.txtInvoiceParty.TabIndex = 1;
            // 
            // lblInvoiceParty
            // 
            this.lblInvoiceParty.AutoSize = true;
            this.lblInvoiceParty.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceParty.ForeColor = System.Drawing.Color.Blue;
            this.lblInvoiceParty.Location = new System.Drawing.Point(14, 142);
            this.lblInvoiceParty.Name = "lblInvoiceParty";
            this.lblInvoiceParty.Size = new System.Drawing.Size(229, 22);
            this.lblInvoiceParty.TabIndex = 142;
            this.lblInvoiceParty.Text = "Invoice Party/Invoiced To :";
            // 
            // txtNetReceivable
            // 
            this.txtNetReceivable.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetReceivable.Location = new System.Drawing.Point(778, 233);
            this.txtNetReceivable.Name = "txtNetReceivable";
            this.txtNetReceivable.Size = new System.Drawing.Size(253, 29);
            this.txtNetReceivable.TabIndex = 9;
            this.txtNetReceivable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNetReceivable_KeyPress);
            // 
            // lblNetReceivable
            // 
            this.lblNetReceivable.AutoSize = true;
            this.lblNetReceivable.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetReceivable.ForeColor = System.Drawing.Color.Blue;
            this.lblNetReceivable.Location = new System.Drawing.Point(632, 236);
            this.lblNetReceivable.Name = "lblNetReceivable";
            this.lblNetReceivable.Size = new System.Drawing.Size(143, 22);
            this.lblNetReceivable.TabIndex = 144;
            this.lblNetReceivable.Text = "Net Receivable :";
            // 
            // dtpPromisedDate
            // 
            this.dtpPromisedDate.CustomFormat = "dd/MM/yyyy";
            this.dtpPromisedDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPromisedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPromisedDate.Location = new System.Drawing.Point(779, 281);
            this.dtpPromisedDate.Name = "dtpPromisedDate";
            this.dtpPromisedDate.Size = new System.Drawing.Size(252, 29);
            this.dtpPromisedDate.TabIndex = 10;
            this.dtpPromisedDate.ValueChanged += new System.EventHandler(this.dtpPromisedDate_ValueChanged);
            // 
            // lblPromisedDate
            // 
            this.lblPromisedDate.AutoSize = true;
            this.lblPromisedDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromisedDate.ForeColor = System.Drawing.Color.Blue;
            this.lblPromisedDate.Location = new System.Drawing.Point(534, 284);
            this.lblPromisedDate.Name = "lblPromisedDate";
            this.lblPromisedDate.Size = new System.Drawing.Size(243, 22);
            this.lblPromisedDate.TabIndex = 146;
            this.lblPromisedDate.Text = "Promised Date Of Payment :";
            // 
            // txtLandPhone
            // 
            this.txtLandPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLandPhone.Location = new System.Drawing.Point(248, 328);
            this.txtLandPhone.MaxLength = 11;
            this.txtLandPhone.Name = "txtLandPhone";
            this.txtLandPhone.ReadOnly = true;
            this.txtLandPhone.Size = new System.Drawing.Size(267, 29);
            this.txtLandPhone.TabIndex = 3;
            // 
            // lblLandPhone
            // 
            this.lblLandPhone.AutoSize = true;
            this.lblLandPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLandPhone.ForeColor = System.Drawing.Color.Blue;
            this.lblLandPhone.Location = new System.Drawing.Point(125, 328);
            this.lblLandPhone.Name = "lblLandPhone";
            this.lblLandPhone.Size = new System.Drawing.Size(118, 22);
            this.lblLandPhone.TabIndex = 148;
            this.lblLandPhone.Text = "Land Phone :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(420, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 31);
            this.label1.TabIndex = 149;
            this.label1.Text = "Invoice Creation Form";
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1070, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLandPhone);
            this.Controls.Add(this.lblLandPhone);
            this.Controls.Add(this.dtpPromisedDate);
            this.Controls.Add(this.lblPromisedDate);
            this.Controls.Add(this.txtNetReceivable);
            this.Controls.Add(this.lblNetReceivable);
            this.Controls.Add(this.txtInvoiceParty);
            this.Controls.Add(this.lblInvoiceParty);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.dtpInvoiceDate);
            this.Controls.Add(this.lblInvoiceDate);
            this.Controls.Add(this.txtGrossReceivable);
            this.Controls.Add(this.lblGrossReceivable);
            this.Controls.Add(this.txtPayerAddress);
            this.Controls.Add(this.lblPayerAddress);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbQuotation);
            this.Controls.Add(this.lblQuotation);
            this.Controls.Add(this.txtCellPhone);
            this.Controls.Add(this.lblCellPhone);
            this.Controls.Add(this.txtRP);
            this.Controls.Add(this.lblRespondentPerson);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInvoice";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Invoice_FormClosed);
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCellPhone;
        private System.Windows.Forms.Label lblCellPhone;
        private System.Windows.Forms.TextBox txtRP;
        private System.Windows.Forms.Label lblRespondentPerson;
        private System.Windows.Forms.Label lblQuotation;
        private System.Windows.Forms.ComboBox cmbQuotation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox txtPayerAddress;
        private System.Windows.Forms.Label lblPayerAddress;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.TextBox txtGrossReceivable;
        private System.Windows.Forms.Label lblGrossReceivable;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.TextBox txtInvoiceParty;
        private System.Windows.Forms.Label lblInvoiceParty;
        private System.Windows.Forms.TextBox txtNetReceivable;
        private System.Windows.Forms.Label lblNetReceivable;
        private System.Windows.Forms.DateTimePicker dtpPromisedDate;
        private System.Windows.Forms.Label lblPromisedDate;
        private System.Windows.Forms.TextBox txtLandPhone;
        private System.Windows.Forms.Label lblLandPhone;
        private System.Windows.Forms.Label label1;
    }
}