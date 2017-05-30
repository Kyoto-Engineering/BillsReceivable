namespace BillsReceivableSystem.UI
{
    partial class NewInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewInvoice));
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeliveryNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWorkOrderNo = new System.Windows.Forms.TextBox();
            this.lblWorkOrderNo = new System.Windows.Forms.Label();
            this.txtLandPhone = new System.Windows.Forms.TextBox();
            this.lblLandPhone = new System.Windows.Forms.Label();
            this.dtpPromisedDate = new System.Windows.Forms.DateTimePicker();
            this.lblPromisedDate = new System.Windows.Forms.Label();
            this.txtNetReceivable = new System.Windows.Forms.TextBox();
            this.lblNetReceivable = new System.Windows.Forms.Label();
            this.txtInvoiceParty = new System.Windows.Forms.TextBox();
            this.lblInvoiceParty = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.txtGrossReceivable = new System.Windows.Forms.TextBox();
            this.lblGrossReceivable = new System.Windows.Forms.Label();
            this.txtPayerAddress = new System.Windows.Forms.RichTextBox();
            this.lblPayerAddress = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblQuotation = new System.Windows.Forms.Label();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.txtRP = new System.Windows.Forms.TextBox();
            this.lblRespondentPerson = new System.Windows.Forms.Label();
            this.txtQuotation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(526, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 31);
            this.label2.TabIndex = 206;
            this.label2.Text = "Invoice";
            // 
            // txtDeliveryNo
            // 
            this.txtDeliveryNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeliveryNo.Location = new System.Drawing.Point(265, 184);
            this.txtDeliveryNo.Name = "txtDeliveryNo";
            this.txtDeliveryNo.Size = new System.Drawing.Size(267, 29);
            this.txtDeliveryNo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(55, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 22);
            this.label1.TabIndex = 203;
            this.label1.Text = "Delivery Order/Chalan :";
            // 
            // txtWorkOrderNo
            // 
            this.txtWorkOrderNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkOrderNo.Location = new System.Drawing.Point(266, 140);
            this.txtWorkOrderNo.Name = "txtWorkOrderNo";
            this.txtWorkOrderNo.Size = new System.Drawing.Size(267, 29);
            this.txtWorkOrderNo.TabIndex = 1;
            // 
            // lblWorkOrderNo
            // 
            this.lblWorkOrderNo.AutoSize = true;
            this.lblWorkOrderNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkOrderNo.ForeColor = System.Drawing.Color.Black;
            this.lblWorkOrderNo.Location = new System.Drawing.Point(70, 143);
            this.lblWorkOrderNo.Name = "lblWorkOrderNo";
            this.lblWorkOrderNo.Size = new System.Drawing.Size(193, 22);
            this.lblWorkOrderNo.TabIndex = 201;
            this.lblWorkOrderNo.Text = "Work Order Number :";
            // 
            // txtLandPhone
            // 
            this.txtLandPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLandPhone.Location = new System.Drawing.Point(265, 386);
            this.txtLandPhone.MaxLength = 9;
            this.txtLandPhone.Name = "txtLandPhone";
            this.txtLandPhone.Size = new System.Drawing.Size(268, 29);
            this.txtLandPhone.TabIndex = 5;
            this.txtLandPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLandPhone_KeyPress);
            // 
            // lblLandPhone
            // 
            this.lblLandPhone.AutoSize = true;
            this.lblLandPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLandPhone.ForeColor = System.Drawing.Color.Black;
            this.lblLandPhone.Location = new System.Drawing.Point(144, 389);
            this.lblLandPhone.Name = "lblLandPhone";
            this.lblLandPhone.Size = new System.Drawing.Size(118, 22);
            this.lblLandPhone.TabIndex = 200;
            this.lblLandPhone.Text = "Land Phone :";
            // 
            // dtpPromisedDate
            // 
            this.dtpPromisedDate.CustomFormat = "dd/MM/yyyy";
            this.dtpPromisedDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPromisedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPromisedDate.Location = new System.Drawing.Point(817, 276);
            this.dtpPromisedDate.Name = "dtpPromisedDate";
            this.dtpPromisedDate.Size = new System.Drawing.Size(254, 29);
            this.dtpPromisedDate.TabIndex = 12;
            this.dtpPromisedDate.ValueChanged += new System.EventHandler(this.dtpPromisedDate_ValueChanged);
            // 
            // lblPromisedDate
            // 
            this.lblPromisedDate.AutoSize = true;
            this.lblPromisedDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromisedDate.ForeColor = System.Drawing.Color.Black;
            this.lblPromisedDate.Location = new System.Drawing.Point(568, 281);
            this.lblPromisedDate.Name = "lblPromisedDate";
            this.lblPromisedDate.Size = new System.Drawing.Size(243, 22);
            this.lblPromisedDate.TabIndex = 198;
            this.lblPromisedDate.Text = "Promised Date Of Payment :";
            // 
            // txtNetReceivable
            // 
            this.txtNetReceivable.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetReceivable.Location = new System.Drawing.Point(816, 229);
            this.txtNetReceivable.Name = "txtNetReceivable";
            this.txtNetReceivable.Size = new System.Drawing.Size(255, 29);
            this.txtNetReceivable.TabIndex = 11;
            this.txtNetReceivable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNetReceivable_KeyPress);
            // 
            // lblNetReceivable
            // 
            this.lblNetReceivable.AutoSize = true;
            this.lblNetReceivable.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetReceivable.ForeColor = System.Drawing.Color.Black;
            this.lblNetReceivable.Location = new System.Drawing.Point(670, 232);
            this.lblNetReceivable.Name = "lblNetReceivable";
            this.lblNetReceivable.Size = new System.Drawing.Size(143, 22);
            this.lblNetReceivable.TabIndex = 196;
            this.lblNetReceivable.Text = "Net Receivable :";
            // 
            // txtInvoiceParty
            // 
            this.txtInvoiceParty.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceParty.Location = new System.Drawing.Point(266, 231);
            this.txtInvoiceParty.Name = "txtInvoiceParty";
            this.txtInvoiceParty.Size = new System.Drawing.Size(267, 29);
            this.txtInvoiceParty.TabIndex = 3;
            // 
            // lblInvoiceParty
            // 
            this.lblInvoiceParty.AutoSize = true;
            this.lblInvoiceParty.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceParty.ForeColor = System.Drawing.Color.Black;
            this.lblInvoiceParty.Location = new System.Drawing.Point(34, 234);
            this.lblInvoiceParty.Name = "lblInvoiceParty";
            this.lblInvoiceParty.Size = new System.Drawing.Size(229, 22);
            this.lblInvoiceParty.TabIndex = 194;
            this.lblInvoiceParty.Text = "Invoice Party/Invoiced To :";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDueDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDueDate.Location = new System.Drawing.Point(817, 136);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(254, 29);
            this.dtpDueDate.TabIndex = 9;
            this.dtpDueDate.ValueChanged += new System.EventHandler(this.dtpDueDate_ValueChanged);
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.ForeColor = System.Drawing.Color.Black;
            this.lblDueDate.Location = new System.Drawing.Point(717, 141);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(97, 22);
            this.lblDueDate.TabIndex = 192;
            this.lblDueDate.Text = "Due Date :";
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.CustomFormat = "dd/MM/yyyy";
            this.dtpInvoiceDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(817, 89);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(254, 29);
            this.dtpInvoiceDate.TabIndex = 8;
            this.dtpInvoiceDate.ValueChanged += new System.EventHandler(this.dtpInvoiceDate_ValueChanged);
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDate.ForeColor = System.Drawing.Color.Black;
            this.lblInvoiceDate.Location = new System.Drawing.Point(691, 92);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(123, 22);
            this.lblInvoiceDate.TabIndex = 190;
            this.lblInvoiceDate.Text = "Invoice Date :";
            // 
            // txtGrossReceivable
            // 
            this.txtGrossReceivable.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossReceivable.Location = new System.Drawing.Point(816, 182);
            this.txtGrossReceivable.Name = "txtGrossReceivable";
            this.txtGrossReceivable.Size = new System.Drawing.Size(255, 29);
            this.txtGrossReceivable.TabIndex = 10;
            this.txtGrossReceivable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrossReceivable_KeyPress);
            // 
            // lblGrossReceivable
            // 
            this.lblGrossReceivable.AutoSize = true;
            this.lblGrossReceivable.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossReceivable.ForeColor = System.Drawing.Color.Black;
            this.lblGrossReceivable.Location = new System.Drawing.Point(652, 185);
            this.lblGrossReceivable.Name = "lblGrossReceivable";
            this.lblGrossReceivable.Size = new System.Drawing.Size(163, 22);
            this.lblGrossReceivable.TabIndex = 188;
            this.lblGrossReceivable.Text = "Gross Receivable :";
            // 
            // txtPayerAddress
            // 
            this.txtPayerAddress.BackColor = System.Drawing.Color.White;
            this.txtPayerAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayerAddress.Location = new System.Drawing.Point(265, 276);
            this.txtPayerAddress.Name = "txtPayerAddress";
            this.txtPayerAddress.Size = new System.Drawing.Size(268, 95);
            this.txtPayerAddress.TabIndex = 4;
            this.txtPayerAddress.Text = "";
            // 
            // lblPayerAddress
            // 
            this.lblPayerAddress.AutoSize = true;
            this.lblPayerAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayerAddress.ForeColor = System.Drawing.Color.Black;
            this.lblPayerAddress.Location = new System.Drawing.Point(111, 279);
            this.lblPayerAddress.Name = "lblPayerAddress";
            this.lblPayerAddress.Size = new System.Drawing.Size(151, 22);
            this.lblPayerAddress.TabIndex = 186;
            this.lblPayerAddress.Text = "Payer\'s Address :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Coral;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(974, 347);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 68);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Generate Invoice";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblQuotation
            // 
            this.lblQuotation.AutoSize = true;
            this.lblQuotation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuotation.ForeColor = System.Drawing.Color.Black;
            this.lblQuotation.Location = new System.Drawing.Point(33, 97);
            this.lblQuotation.Name = "lblQuotation";
            this.lblQuotation.Size = new System.Drawing.Size(229, 22);
            this.lblQuotation.TabIndex = 183;
            this.lblQuotation.Text = "Quotation Id/Ref/Number :";
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCellPhone.Location = new System.Drawing.Point(268, 473);
            this.txtCellPhone.MaxLength = 11;
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(264, 29);
            this.txtCellPhone.TabIndex = 7;
            this.txtCellPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCellPhone_KeyPress);
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellPhone.ForeColor = System.Drawing.Color.Black;
            this.lblCellPhone.Location = new System.Drawing.Point(156, 476);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(109, 22);
            this.lblCellPhone.TabIndex = 182;
            this.lblCellPhone.Text = "Cell Phone :";
            // 
            // txtRP
            // 
            this.txtRP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRP.Location = new System.Drawing.Point(266, 428);
            this.txtRP.Name = "txtRP";
            this.txtRP.Size = new System.Drawing.Size(267, 29);
            this.txtRP.TabIndex = 6;
            // 
            // lblRespondentPerson
            // 
            this.lblRespondentPerson.AutoSize = true;
            this.lblRespondentPerson.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespondentPerson.ForeColor = System.Drawing.Color.Black;
            this.lblRespondentPerson.Location = new System.Drawing.Point(47, 431);
            this.lblRespondentPerson.Name = "lblRespondentPerson";
            this.lblRespondentPerson.Size = new System.Drawing.Size(216, 22);
            this.lblRespondentPerson.TabIndex = 180;
            this.lblRespondentPerson.Text = "Respondent Person(RP) :";
            // 
            // txtQuotation
            // 
            this.txtQuotation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuotation.Location = new System.Drawing.Point(265, 97);
            this.txtQuotation.Name = "txtQuotation";
            this.txtQuotation.Size = new System.Drawing.Size(267, 29);
            this.txtQuotation.TabIndex = 0;
            // 
            // NewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1135, 638);
            this.Controls.Add(this.txtQuotation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDeliveryNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWorkOrderNo);
            this.Controls.Add(this.lblWorkOrderNo);
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
            this.Controls.Add(this.lblQuotation);
            this.Controls.Add(this.txtCellPhone);
            this.Controls.Add(this.lblCellPhone);
            this.Controls.Add(this.txtRP);
            this.Controls.Add(this.lblRespondentPerson);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewInvoice";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewInvoice_FormClosed);
            this.Load += new System.EventHandler(this.NewInvoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDeliveryNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWorkOrderNo;
        private System.Windows.Forms.Label lblWorkOrderNo;
        private System.Windows.Forms.TextBox txtLandPhone;
        private System.Windows.Forms.Label lblLandPhone;
        private System.Windows.Forms.DateTimePicker dtpPromisedDate;
        private System.Windows.Forms.Label lblPromisedDate;
        private System.Windows.Forms.TextBox txtNetReceivable;
        private System.Windows.Forms.Label lblNetReceivable;
        private System.Windows.Forms.TextBox txtInvoiceParty;
        private System.Windows.Forms.Label lblInvoiceParty;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.TextBox txtGrossReceivable;
        private System.Windows.Forms.Label lblGrossReceivable;
        private System.Windows.Forms.RichTextBox txtPayerAddress;
        private System.Windows.Forms.Label lblPayerAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblQuotation;
        private System.Windows.Forms.TextBox txtCellPhone;
        private System.Windows.Forms.Label lblCellPhone;
        private System.Windows.Forms.TextBox txtRP;
        private System.Windows.Forms.Label lblRespondentPerson;
        private System.Windows.Forms.TextBox txtQuotation;
    }
}