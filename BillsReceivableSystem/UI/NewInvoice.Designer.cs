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
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CustomerIdcomboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.WorkOrderRefcomboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpPromisedDate = new System.Windows.Forms.DateTimePicker();
            this.lblPromisedDate = new System.Windows.Forms.Label();
            this.txtNetReceivable = new System.Windows.Forms.TextBox();
            this.lblNetReceivable = new System.Windows.Forms.Label();
            this.txtGrossReceivable = new System.Windows.Forms.TextBox();
            this.lblGrossReceivable = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.txtQuotation = new System.Windows.Forms.TextBox();
            this.txtDeliveryNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWorkOrderNo = new System.Windows.Forms.TextBox();
            this.lblWorkOrderNo = new System.Windows.Forms.Label();
            this.txtLandPhone = new System.Windows.Forms.TextBox();
            this.lblLandPhone = new System.Windows.Forms.Label();
            this.txtInvoiceParty = new System.Windows.Forms.TextBox();
            this.lblInvoiceParty = new System.Windows.Forms.Label();
            this.txtPayerAddress = new System.Windows.Forms.RichTextBox();
            this.lblPayerAddress = new System.Windows.Forms.Label();
            this.lblQuotation = new System.Windows.Forms.Label();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.txtRP = new System.Windows.Forms.TextBox();
            this.lblRespondentPerson = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.QtytextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UnitPricetextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UnitcomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DescriptionrichTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(418, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 31);
            this.label2.TabIndex = 206;
            this.label2.Text = "Invoice Creation Form";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Coral;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1027, 455);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 74);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Generate Invoice";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CustomerIdcomboBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.WorkOrderRefcomboBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpPromisedDate);
            this.groupBox1.Controls.Add(this.lblPromisedDate);
            this.groupBox1.Controls.Add(this.txtNetReceivable);
            this.groupBox1.Controls.Add(this.lblNetReceivable);
            this.groupBox1.Controls.Add(this.txtGrossReceivable);
            this.groupBox1.Controls.Add(this.lblGrossReceivable);
            this.groupBox1.Controls.Add(this.dtpDueDate);
            this.groupBox1.Controls.Add(this.lblDueDate);
            this.groupBox1.Controls.Add(this.dtpInvoiceDate);
            this.groupBox1.Controls.Add(this.lblInvoiceDate);
            this.groupBox1.Controls.Add(this.txtQuotation);
            this.groupBox1.Controls.Add(this.txtDeliveryNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtWorkOrderNo);
            this.groupBox1.Controls.Add(this.lblWorkOrderNo);
            this.groupBox1.Controls.Add(this.txtLandPhone);
            this.groupBox1.Controls.Add(this.lblLandPhone);
            this.groupBox1.Controls.Add(this.txtInvoiceParty);
            this.groupBox1.Controls.Add(this.lblInvoiceParty);
            this.groupBox1.Controls.Add(this.txtPayerAddress);
            this.groupBox1.Controls.Add(this.lblPayerAddress);
            this.groupBox1.Controls.Add(this.lblQuotation);
            this.groupBox1.Controls.Add(this.txtCellPhone);
            this.groupBox1.Controls.Add(this.lblCellPhone);
            this.groupBox1.Controls.Add(this.txtRP);
            this.groupBox1.Controls.Add(this.lblRespondentPerson);
            this.groupBox1.Location = new System.Drawing.Point(36, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 602);
            this.groupBox1.TabIndex = 221;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CustomerIdcomboBox
            // 
            this.CustomerIdcomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CustomerIdcomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CustomerIdcomboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIdcomboBox.FormattingEnabled = true;
            this.CustomerIdcomboBox.Location = new System.Drawing.Point(202, 20);
            this.CustomerIdcomboBox.Name = "CustomerIdcomboBox";
            this.CustomerIdcomboBox.Size = new System.Drawing.Size(267, 29);
            this.CustomerIdcomboBox.TabIndex = 0;
            this.CustomerIdcomboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerIdcomboBox_SelectedIndexChanged);
            this.CustomerIdcomboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerIdcomboBox_KeyDown);
            this.CustomerIdcomboBox.Leave += new System.EventHandler(this.CustomerIdcomboBox_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(97, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 19);
            this.label8.TabIndex = 234;
            this.label8.Text = "Customer Id :";
            // 
            // WorkOrderRefcomboBox
            // 
            this.WorkOrderRefcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WorkOrderRefcomboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkOrderRefcomboBox.FormattingEnabled = true;
            this.WorkOrderRefcomboBox.Items.AddRange(new object[] {
            "Verbal",
            "Email",
            "Hand Writing"});
            this.WorkOrderRefcomboBox.Location = new System.Drawing.Point(202, 83);
            this.WorkOrderRefcomboBox.Name = "WorkOrderRefcomboBox";
            this.WorkOrderRefcomboBox.Size = new System.Drawing.Size(268, 30);
            this.WorkOrderRefcomboBox.TabIndex = 2;
            this.WorkOrderRefcomboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WorkOrderRefcomboBox_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(70, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 19);
            this.label7.TabIndex = 231;
            this.label7.Text = "Work Order Ref :";
            // 
            // dtpPromisedDate
            // 
            this.dtpPromisedDate.Checked = false;
            this.dtpPromisedDate.CustomFormat = "dd/MM/yyyy";
            this.dtpPromisedDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPromisedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPromisedDate.Location = new System.Drawing.Point(210, 558);
            this.dtpPromisedDate.Name = "dtpPromisedDate";
            this.dtpPromisedDate.ShowCheckBox = true;
            this.dtpPromisedDate.Size = new System.Drawing.Size(254, 29);
            this.dtpPromisedDate.TabIndex = 14;
            this.dtpPromisedDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpPromisedDate_KeyDown);
            // 
            // lblPromisedDate
            // 
            this.lblPromisedDate.AutoSize = true;
            this.lblPromisedDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromisedDate.ForeColor = System.Drawing.Color.Black;
            this.lblPromisedDate.Location = new System.Drawing.Point(5, 563);
            this.lblPromisedDate.Name = "lblPromisedDate";
            this.lblPromisedDate.Size = new System.Drawing.Size(200, 19);
            this.lblPromisedDate.TabIndex = 230;
            this.lblPromisedDate.Text = "Promised Date Of Payment :";
            // 
            // txtNetReceivable
            // 
            this.txtNetReceivable.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetReceivable.Location = new System.Drawing.Point(209, 525);
            this.txtNetReceivable.Name = "txtNetReceivable";
            this.txtNetReceivable.Size = new System.Drawing.Size(255, 29);
            this.txtNetReceivable.TabIndex = 13;
            this.txtNetReceivable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNetReceivable_KeyDown);
            this.txtNetReceivable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNetReceivable_KeyPress);
            // 
            // lblNetReceivable
            // 
            this.lblNetReceivable.AutoSize = true;
            this.lblNetReceivable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetReceivable.ForeColor = System.Drawing.Color.Black;
            this.lblNetReceivable.Location = new System.Drawing.Point(81, 532);
            this.lblNetReceivable.Name = "lblNetReceivable";
            this.lblNetReceivable.Size = new System.Drawing.Size(122, 19);
            this.lblNetReceivable.TabIndex = 229;
            this.lblNetReceivable.Text = "Net Receivable :";
            // 
            // txtGrossReceivable
            // 
            this.txtGrossReceivable.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossReceivable.Location = new System.Drawing.Point(209, 492);
            this.txtGrossReceivable.Name = "txtGrossReceivable";
            this.txtGrossReceivable.Size = new System.Drawing.Size(255, 29);
            this.txtGrossReceivable.TabIndex = 12;
            this.txtGrossReceivable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGrossReceivable_KeyDown);
            this.txtGrossReceivable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrossReceivable_KeyPress_1);
            // 
            // lblGrossReceivable
            // 
            this.lblGrossReceivable.AutoSize = true;
            this.lblGrossReceivable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossReceivable.ForeColor = System.Drawing.Color.Black;
            this.lblGrossReceivable.Location = new System.Drawing.Point(66, 501);
            this.lblGrossReceivable.Name = "lblGrossReceivable";
            this.lblGrossReceivable.Size = new System.Drawing.Size(137, 19);
            this.lblGrossReceivable.TabIndex = 228;
            this.lblGrossReceivable.Text = "Gross Receivable :";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Checked = false;
            this.dtpDueDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDueDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDueDate.Location = new System.Drawing.Point(210, 458);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.ShowCheckBox = true;
            this.dtpDueDate.Size = new System.Drawing.Size(254, 29);
            this.dtpDueDate.TabIndex = 11;
            this.dtpDueDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDueDate_KeyDown);
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.ForeColor = System.Drawing.Color.Black;
            this.lblDueDate.Location = new System.Drawing.Point(119, 464);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(83, 19);
            this.lblDueDate.TabIndex = 224;
            this.lblDueDate.Text = "Due Date :";
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.Checked = false;
            this.dtpInvoiceDate.CustomFormat = "dd/MM/yyyy";
            this.dtpInvoiceDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(210, 424);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.ShowCheckBox = true;
            this.dtpInvoiceDate.Size = new System.Drawing.Size(254, 29);
            this.dtpInvoiceDate.TabIndex = 10;
            this.dtpInvoiceDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpInvoiceDate_KeyDown);
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDate.ForeColor = System.Drawing.Color.Black;
            this.lblInvoiceDate.Location = new System.Drawing.Point(99, 430);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(104, 19);
            this.lblInvoiceDate.TabIndex = 223;
            this.lblInvoiceDate.Text = "Invoice Date :";
            // 
            // txtQuotation
            // 
            this.txtQuotation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuotation.Location = new System.Drawing.Point(202, 51);
            this.txtQuotation.Name = "txtQuotation";
            this.txtQuotation.Size = new System.Drawing.Size(267, 29);
            this.txtQuotation.TabIndex = 1;
            this.txtQuotation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuotation_KeyDown);
            // 
            // txtDeliveryNo
            // 
            this.txtDeliveryNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeliveryNo.Location = new System.Drawing.Point(202, 150);
            this.txtDeliveryNo.Name = "txtDeliveryNo";
            this.txtDeliveryNo.Size = new System.Drawing.Size(267, 29);
            this.txtDeliveryNo.TabIndex = 4;
            this.txtDeliveryNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDeliveryNo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 19);
            this.label1.TabIndex = 219;
            this.label1.Text = "Delivery Order/Chalan :";
            // 
            // txtWorkOrderNo
            // 
            this.txtWorkOrderNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkOrderNo.Location = new System.Drawing.Point(203, 116);
            this.txtWorkOrderNo.Name = "txtWorkOrderNo";
            this.txtWorkOrderNo.Size = new System.Drawing.Size(267, 29);
            this.txtWorkOrderNo.TabIndex = 3;
            this.txtWorkOrderNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWorkOrderNo_KeyDown);
            // 
            // lblWorkOrderNo
            // 
            this.lblWorkOrderNo.AutoSize = true;
            this.lblWorkOrderNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkOrderNo.ForeColor = System.Drawing.Color.Black;
            this.lblWorkOrderNo.Location = new System.Drawing.Point(44, 119);
            this.lblWorkOrderNo.Name = "lblWorkOrderNo";
            this.lblWorkOrderNo.Size = new System.Drawing.Size(157, 19);
            this.lblWorkOrderNo.TabIndex = 218;
            this.lblWorkOrderNo.Text = "Work Order Number :";
            // 
            // txtLandPhone
            // 
            this.txtLandPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLandPhone.Location = new System.Drawing.Point(205, 321);
            this.txtLandPhone.MaxLength = 9;
            this.txtLandPhone.Name = "txtLandPhone";
            this.txtLandPhone.Size = new System.Drawing.Size(268, 29);
            this.txtLandPhone.TabIndex = 7;
            this.txtLandPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLandPhone_KeyDown);
            this.txtLandPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLandPhone_KeyPress_1);
            // 
            // lblLandPhone
            // 
            this.lblLandPhone.AutoSize = true;
            this.lblLandPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLandPhone.ForeColor = System.Drawing.Color.Black;
            this.lblLandPhone.Location = new System.Drawing.Point(103, 328);
            this.lblLandPhone.Name = "lblLandPhone";
            this.lblLandPhone.Size = new System.Drawing.Size(97, 19);
            this.lblLandPhone.TabIndex = 217;
            this.lblLandPhone.Text = "Land Phone :";
            // 
            // txtInvoiceParty
            // 
            this.txtInvoiceParty.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceParty.Location = new System.Drawing.Point(203, 184);
            this.txtInvoiceParty.Name = "txtInvoiceParty";
            this.txtInvoiceParty.Size = new System.Drawing.Size(267, 29);
            this.txtInvoiceParty.TabIndex = 5;
            this.txtInvoiceParty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInvoiceParty_KeyDown);
            // 
            // lblInvoiceParty
            // 
            this.lblInvoiceParty.AutoSize = true;
            this.lblInvoiceParty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceParty.ForeColor = System.Drawing.Color.Black;
            this.lblInvoiceParty.Location = new System.Drawing.Point(8, 188);
            this.lblInvoiceParty.Name = "lblInvoiceParty";
            this.lblInvoiceParty.Size = new System.Drawing.Size(189, 19);
            this.lblInvoiceParty.TabIndex = 216;
            this.lblInvoiceParty.Text = "Invoice Party/Invoiced To :";
            // 
            // txtPayerAddress
            // 
            this.txtPayerAddress.BackColor = System.Drawing.Color.White;
            this.txtPayerAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayerAddress.Location = new System.Drawing.Point(202, 218);
            this.txtPayerAddress.Name = "txtPayerAddress";
            this.txtPayerAddress.Size = new System.Drawing.Size(268, 95);
            this.txtPayerAddress.TabIndex = 6;
            this.txtPayerAddress.Text = "";
            this.txtPayerAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPayerAddress_KeyDown);
            // 
            // lblPayerAddress
            // 
            this.lblPayerAddress.AutoSize = true;
            this.lblPayerAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayerAddress.ForeColor = System.Drawing.Color.Black;
            this.lblPayerAddress.Location = new System.Drawing.Point(70, 223);
            this.lblPayerAddress.Name = "lblPayerAddress";
            this.lblPayerAddress.Size = new System.Drawing.Size(126, 19);
            this.lblPayerAddress.TabIndex = 215;
            this.lblPayerAddress.Text = "Payer\'s Address :";
            // 
            // lblQuotation
            // 
            this.lblQuotation.AutoSize = true;
            this.lblQuotation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuotation.ForeColor = System.Drawing.Color.Black;
            this.lblQuotation.Location = new System.Drawing.Point(7, 55);
            this.lblQuotation.Name = "lblQuotation";
            this.lblQuotation.Size = new System.Drawing.Size(189, 19);
            this.lblQuotation.TabIndex = 214;
            this.lblQuotation.Text = "Quotation Id/Ref/Number :";
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCellPhone.Location = new System.Drawing.Point(208, 389);
            this.txtCellPhone.MaxLength = 11;
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(264, 29);
            this.txtCellPhone.TabIndex = 9;
            this.txtCellPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCellPhone_KeyDown);
            this.txtCellPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCellPhone_KeyPress);
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellPhone.ForeColor = System.Drawing.Color.Black;
            this.lblCellPhone.Location = new System.Drawing.Point(109, 396);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(90, 19);
            this.lblCellPhone.TabIndex = 213;
            this.lblCellPhone.Text = "Cell Phone :";
            // 
            // txtRP
            // 
            this.txtRP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRP.Location = new System.Drawing.Point(206, 355);
            this.txtRP.Name = "txtRP";
            this.txtRP.Size = new System.Drawing.Size(267, 29);
            this.txtRP.TabIndex = 8;
            this.txtRP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRP_KeyDown);
            // 
            // lblRespondentPerson
            // 
            this.lblRespondentPerson.AutoSize = true;
            this.lblRespondentPerson.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespondentPerson.ForeColor = System.Drawing.Color.Black;
            this.lblRespondentPerson.Location = new System.Drawing.Point(21, 360);
            this.lblRespondentPerson.Name = "lblRespondentPerson";
            this.lblRespondentPerson.Size = new System.Drawing.Size(179, 19);
            this.lblRespondentPerson.TabIndex = 212;
            this.lblRespondentPerson.Text = "Respondent Person(RP) :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Addbutton);
            this.groupBox2.Controls.Add(this.QtytextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.UnitPricetextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.UnitcomboBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.DescriptionrichTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(541, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 233);
            this.groupBox2.TabIndex = 222;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.Coral;
            this.Addbutton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.Location = new System.Drawing.Point(320, 160);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(95, 58);
            this.Addbutton.TabIndex = 4;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // QtytextBox
            // 
            this.QtytextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtytextBox.Location = new System.Drawing.Point(157, 189);
            this.QtytextBox.Name = "QtytextBox";
            this.QtytextBox.Size = new System.Drawing.Size(156, 29);
            this.QtytextBox.TabIndex = 3;
            this.QtytextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QtytextBox_KeyDown);
            this.QtytextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QtytextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(110, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 222;
            this.label4.Text = "Qty :";
            // 
            // UnitPricetextBox
            // 
            this.UnitPricetextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPricetextBox.Location = new System.Drawing.Point(158, 154);
            this.UnitPricetextBox.Name = "UnitPricetextBox";
            this.UnitPricetextBox.Size = new System.Drawing.Size(156, 29);
            this.UnitPricetextBox.TabIndex = 2;
            this.UnitPricetextBox.TextChanged += new System.EventHandler(this.UnitPricetextBox_TextChanged);
            this.UnitPricetextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UnitPricetextBox_KeyDown);
            this.UnitPricetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UnitPricetextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(70, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 221;
            this.label6.Text = "Unit Price :";
            // 
            // UnitcomboBox
            // 
            this.UnitcomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.UnitcomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.UnitcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitcomboBox.FormattingEnabled = true;
            this.UnitcomboBox.Location = new System.Drawing.Point(157, 116);
            this.UnitcomboBox.Name = "UnitcomboBox";
            this.UnitcomboBox.Size = new System.Drawing.Size(157, 32);
            this.UnitcomboBox.TabIndex = 1;
            this.UnitcomboBox.SelectedIndexChanged += new System.EventHandler(this.UnitcomboBox_SelectedIndexChanged_1);
            this.UnitcomboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UnitcomboBox_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(107, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 218;
            this.label5.Text = "Unit :";
            // 
            // DescriptionrichTextBox
            // 
            this.DescriptionrichTextBox.BackColor = System.Drawing.Color.White;
            this.DescriptionrichTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionrichTextBox.Location = new System.Drawing.Point(156, 15);
            this.DescriptionrichTextBox.Name = "DescriptionrichTextBox";
            this.DescriptionrichTextBox.Size = new System.Drawing.Size(255, 95);
            this.DescriptionrichTextBox.TabIndex = 0;
            this.DescriptionrichTextBox.Text = "";
            this.DescriptionrichTextBox.TextChanged += new System.EventHandler(this.DescriptionrichTextBox_TextChanged);
            this.DescriptionrichTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DescriptionrichTextBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 19);
            this.label3.TabIndex = 216;
            this.label3.Text = "Product Description :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Location = new System.Drawing.Point(541, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 346);
            this.groupBox3.TabIndex = 223;
            this.groupBox3.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(474, 327);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 1;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unit";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Unit Price";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Qty";
            this.columnHeader5.Width = 80;
            // 
            // NewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1135, 666);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewInvoice";
            this.Load += new System.EventHandler(this.NewInvoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpPromisedDate;
        private System.Windows.Forms.Label lblPromisedDate;
        private System.Windows.Forms.TextBox txtNetReceivable;
        private System.Windows.Forms.Label lblNetReceivable;
        private System.Windows.Forms.TextBox txtGrossReceivable;
        private System.Windows.Forms.Label lblGrossReceivable;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.TextBox txtQuotation;
        private System.Windows.Forms.TextBox txtDeliveryNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWorkOrderNo;
        private System.Windows.Forms.Label lblWorkOrderNo;
        private System.Windows.Forms.TextBox txtLandPhone;
        private System.Windows.Forms.Label lblLandPhone;
        private System.Windows.Forms.TextBox txtInvoiceParty;
        private System.Windows.Forms.Label lblInvoiceParty;
        private System.Windows.Forms.RichTextBox txtPayerAddress;
        private System.Windows.Forms.Label lblPayerAddress;
        private System.Windows.Forms.Label lblQuotation;
        private System.Windows.Forms.TextBox txtCellPhone;
        private System.Windows.Forms.Label lblCellPhone;
        private System.Windows.Forms.TextBox txtRP;
        private System.Windows.Forms.Label lblRespondentPerson;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.TextBox QtytextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UnitPricetextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox UnitcomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox DescriptionrichTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox WorkOrderRefcomboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CustomerIdcomboBox;
    }
}