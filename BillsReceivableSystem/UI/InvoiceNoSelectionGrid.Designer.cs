﻿namespace BillsReceivableSystem.UI
{
    partial class InvoiceNoSelectionGrid
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchByCompanyNameGroupBox = new System.Windows.Forms.GroupBox();
            this.InvoiceNoSearchtextBox = new System.Windows.Forms.TextBox();
            this.InvoiceNoSelectiongroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNoSelectComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ManualInvoiceTextBox = new System.Windows.Forms.TextBox();
            this.InAddButton = new System.Windows.Forms.Button();
            this.SearchByCompanyNameGroupBox.SuspendLayout();
            this.InvoiceNoSelectiongroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Invoice Number Selection Form";
            // 
            // SearchByCompanyNameGroupBox
            // 
            this.SearchByCompanyNameGroupBox.Controls.Add(this.InvoiceNoSearchtextBox);
            this.SearchByCompanyNameGroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByCompanyNameGroupBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.SearchByCompanyNameGroupBox.Location = new System.Drawing.Point(78, 182);
            this.SearchByCompanyNameGroupBox.Name = "SearchByCompanyNameGroupBox";
            this.SearchByCompanyNameGroupBox.Size = new System.Drawing.Size(330, 63);
            this.SearchByCompanyNameGroupBox.TabIndex = 4;
            this.SearchByCompanyNameGroupBox.TabStop = false;
            this.SearchByCompanyNameGroupBox.Text = "Search By Invoice No";
            // 
            // InvoiceNoSearchtextBox
            // 
            this.InvoiceNoSearchtextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceNoSearchtextBox.Location = new System.Drawing.Point(26, 23);
            this.InvoiceNoSearchtextBox.Name = "InvoiceNoSearchtextBox";
            this.InvoiceNoSearchtextBox.Size = new System.Drawing.Size(286, 29);
            this.InvoiceNoSearchtextBox.TabIndex = 0;
            this.InvoiceNoSearchtextBox.TextChanged += new System.EventHandler(this.InvoiceNoSearchtextBox_TextChanged);
            // 
            // InvoiceNoSelectiongroupBox
            // 
            this.InvoiceNoSelectiongroupBox.Controls.Add(this.dataGridView1);
            this.InvoiceNoSelectiongroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceNoSelectiongroupBox.ForeColor = System.Drawing.Color.Blue;
            this.InvoiceNoSelectiongroupBox.Location = new System.Drawing.Point(79, 251);
            this.InvoiceNoSelectiongroupBox.Name = "InvoiceNoSelectiongroupBox";
            this.InvoiceNoSelectiongroupBox.Size = new System.Drawing.Size(331, 363);
            this.InvoiceNoSelectiongroupBox.TabIndex = 3;
            this.InvoiceNoSelectiongroupBox.TabStop = false;
            this.InvoiceNoSelectiongroupBox.Text = "Invoice Selection";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(17, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(296, 334);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Invoice No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            // 
            // InvoiceNoSelectComboBox
            // 
            this.InvoiceNoSelectComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceNoSelectComboBox.FormattingEnabled = true;
            this.InvoiceNoSelectComboBox.Items.AddRange(new object[] {
            "Manual",
            "POS"});
            this.InvoiceNoSelectComboBox.Location = new System.Drawing.Point(35, 19);
            this.InvoiceNoSelectComboBox.Name = "InvoiceNoSelectComboBox";
            this.InvoiceNoSelectComboBox.Size = new System.Drawing.Size(286, 28);
            this.InvoiceNoSelectComboBox.TabIndex = 6;
            this.InvoiceNoSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.InvoiceNoSelectComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InvoiceNoSelectComboBox);
            this.groupBox1.Location = new System.Drawing.Point(79, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 58);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // ManualInvoiceTextBox
            // 
            this.ManualInvoiceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManualInvoiceTextBox.Location = new System.Drawing.Point(114, 134);
            this.ManualInvoiceTextBox.Name = "ManualInvoiceTextBox";
            this.ManualInvoiceTextBox.Size = new System.Drawing.Size(286, 26);
            this.ManualInvoiceTextBox.TabIndex = 8;
            this.ManualInvoiceTextBox.Visible = false;
            // 
            // InAddButton
            // 
            this.InAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InAddButton.Location = new System.Drawing.Point(438, 125);
            this.InAddButton.Name = "InAddButton";
            this.InAddButton.Size = new System.Drawing.Size(92, 54);
            this.InAddButton.TabIndex = 9;
            this.InAddButton.Text = "Invoice Add";
            this.InAddButton.UseVisualStyleBackColor = true;
            this.InAddButton.Visible = false;
            // 
            // InvoiceNoSelectionGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(566, 632);
            this.Controls.Add(this.InAddButton);
            this.Controls.Add(this.ManualInvoiceTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchByCompanyNameGroupBox);
            this.Controls.Add(this.InvoiceNoSelectiongroupBox);
            this.Name = "InvoiceNoSelectionGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceNoSelectionGrid";
            this.Load += new System.EventHandler(this.InvoiceNoSelectionGrid_Load);
            this.SearchByCompanyNameGroupBox.ResumeLayout(false);
            this.SearchByCompanyNameGroupBox.PerformLayout();
            this.InvoiceNoSelectiongroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox SearchByCompanyNameGroupBox;
        private System.Windows.Forms.TextBox InvoiceNoSearchtextBox;
        private System.Windows.Forms.GroupBox InvoiceNoSelectiongroupBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ComboBox InvoiceNoSelectComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ManualInvoiceTextBox;
        private System.Windows.Forms.Button InAddButton;

    }
}