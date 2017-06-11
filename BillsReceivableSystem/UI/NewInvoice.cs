using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillsReceivableSystem.DbGateway;
using BillsReceivableSystem.LoginUI;
using BillsReceivableSystem.Report;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace BillsReceivableSystem.UI
{
    public partial class NewInvoice : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        private ConnectionString cs = new ConnectionString();        
        private delegate void ChangeFocusDelegate(Control ctl);
        public int unitid, invoiceId;
        public string userid;
        public NewInvoice()
        {
            InitializeComponent();
        }

        private void changeFocus(Control ctl)
        {
            ctl.Focus();
        }

        private void SaveInvoice()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                String query = "insert into Invoice(InvoiceDate, DueDate, QuotationNo, GrossReceive, NetReceive, PromisedDate, WorkOrderNo, DeliveryNo, InvoiceTo, Address, LPhn, RP, CPhn, UserId) values (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14)" + "SELECT CONVERT(int, SCOPE_IDENTITY())";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@d1",
                    !dtpInvoiceDate.Checked ? (object) DBNull.Value : dtpInvoiceDate.Value.Date));
                cmd.Parameters.Add(new SqlParameter("@d2",
                    !dtpDueDate.Checked ? (object) DBNull.Value : dtpDueDate.Value.Date));
                cmd.Parameters.Add(new SqlParameter("@d3",
                    string.IsNullOrWhiteSpace(txtQuotation.Text) ? (object) DBNull.Value : txtQuotation.Text));
               
                cmd.Parameters.AddWithValue("@d4", Convert.ToDecimal(txtGrossReceivable.Text));
               
                cmd.Parameters.AddWithValue("@d5", Convert.ToDecimal(txtNetReceivable.Text));
                cmd.Parameters.Add(new SqlParameter("@d6",
                    !dtpPromisedDate.Checked ? (object)DBNull.Value : dtpPromisedDate.Value.Date));
               
                cmd.Parameters.Add(new SqlParameter("@d7",
                    string.IsNullOrWhiteSpace(txtWorkOrderNo.Text) ? (object)DBNull.Value : txtWorkOrderNo.Text));
             
                cmd.Parameters.Add(new SqlParameter("@d8",
                    string.IsNullOrWhiteSpace(txtDeliveryNo.Text) ? (object)DBNull.Value : txtDeliveryNo.Text));
              
                cmd.Parameters.Add(new SqlParameter("@d9",
                    string.IsNullOrWhiteSpace(txtInvoiceParty.Text) ? (object)DBNull.Value : txtInvoiceParty.Text));
               
                cmd.Parameters.Add(new SqlParameter("@d10",
                    string.IsNullOrWhiteSpace(txtPayerAddress.Text) ? (object)DBNull.Value : txtPayerAddress.Text));
              
                cmd.Parameters.Add(new SqlParameter("@d11",
                    string.IsNullOrWhiteSpace(txtLandPhone.Text) ? (object)DBNull.Value : txtLandPhone.Text));
             
                cmd.Parameters.Add(new SqlParameter("@d12",
                    string.IsNullOrWhiteSpace(txtRP.Text) ? (object)DBNull.Value : txtRP.Text));
              
                cmd.Parameters.Add(new SqlParameter("@d13",
                    string.IsNullOrWhiteSpace(txtCellPhone.Text) ? (object)DBNull.Value : txtCellPhone.Text));
                cmd.Parameters.AddWithValue("@d14", userid);
                invoiceId = (int)cmd.ExecuteScalar();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validatecontrolls())
            {
                SaveInvoice();
                if (listView1.Items.Count == 0)
                {
                    MessageBox.Show("Please add to Chart first", "Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DescriptionrichTextBox.Focus();
                    return;
                }
              
                try
                {
                    for (int i = 0; i <= listView1.Items.Count - 1; i++)
                    {
                        con = new SqlConnection(cs.DBConn);
                        con.Open();
                        String query = "insert into Products(ProductDescription, UnitId, UnitPrice, Qty, InvoiceId) values (@d1,@d2,@d3,@d4,@d5)" + "SELECT CONVERT(int, SCOPE_IDENTITY())";
                        cmd = new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@d1", listView1.Items[i].SubItems[1].Text);
                        cmd.Parameters.AddWithValue("@d2", listView1.Items[i].SubItems[2].Text);
                        cmd.Parameters.AddWithValue("@d3", listView1.Items[i].SubItems[3].Text);
                        cmd.Parameters.AddWithValue("@d4", listView1.Items[i].SubItems[4].Text);
                        cmd.Parameters.AddWithValue("@d5", invoiceId);
                        cmd.ExecuteNonQuery();
                        con.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Successfully Generated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listView1.Items.Clear();
                ClearData();
                groupBox1.Enabled = true;
                GetInvoice();
            }
        }

        private bool validatecontrolls()
        {
            bool validate = true;
            if (string.IsNullOrWhiteSpace(txtInvoiceParty.Text))
            {
                MessageBox.Show("Please enter Invoice Party", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validate = false;
                this.BeginInvoke(new ChangeFocusDelegate(changeFocus), txtInvoiceParty);
            }

            else if (string.IsNullOrWhiteSpace(txtPayerAddress.Text))
            {
                MessageBox.Show("Please enter Payer Address", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validate = false;
                this.BeginInvoke(new ChangeFocusDelegate(changeFocus), txtPayerAddress);
            }

            //else if (string.IsNullOrWhiteSpace(txtLandPhone.Text))
            //{
            //    MessageBox.Show("Please enter Land Phone Number", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    validate = false;
            //    this.BeginInvoke(new ChangeFocusDelegate(changeFocus), txtLandPhone);
            //}

            else if (string.IsNullOrWhiteSpace(txtRP.Text))
            {
                MessageBox.Show("Please enter Respondent Person name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validate = false;
                this.BeginInvoke(new ChangeFocusDelegate(changeFocus), txtRP);
            }

            else if (string.IsNullOrWhiteSpace(txtCellPhone.Text))
            {
                MessageBox.Show("Please enter Cell Phone Number", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validate = false;
                this.BeginInvoke(new ChangeFocusDelegate(changeFocus), txtCellPhone);
            }

            else if (string.IsNullOrWhiteSpace(txtGrossReceivable.Text))
            {
                MessageBox.Show("Please  enter Gross Receivable", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validate = false;
                this.BeginInvoke(new ChangeFocusDelegate(changeFocus), txtGrossReceivable);
            }
            else if (string.IsNullOrWhiteSpace(txtNetReceivable.Text))
            {
                MessageBox.Show("Please  enter Net Receivable", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validate = false;
                this.BeginInvoke(new ChangeFocusDelegate(changeFocus), txtNetReceivable);
            }
           return validate;
        }
        private void ClearData()
        {
            txtQuotation.Clear();
            txtWorkOrderNo.Clear();
            txtDeliveryNo.Clear();
            txtInvoiceParty.Clear();
            txtPayerAddress.Clear();
            txtLandPhone.Clear();
            txtRP.Clear();
            txtCellPhone.Clear();
            dtpInvoiceDate.ResetText();
            dtpDueDate.ResetText();
            txtGrossReceivable.Clear();
            txtNetReceivable.Clear();
            dtpPromisedDate.ResetText();
        }

       
        private void dtpInvoiceDate_ValueChanged(object sender, EventArgs e)
        {
            //if (dtpInvoiceDate.Value > DateTime.Now)
            //{
            //    MessageBox.Show("Should not be exceed Date Time from today", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    dtpInvoiceDate.ResetText();
            //}
        }

        private void dtpDueDate_ValueChanged(object sender, EventArgs e)
        {
            //if (dtpInvoiceDate.Value > dtpDueDate.Value)
            //{
            //    MessageBox.Show("Due Date Should be grater than or Equal to Invoice Date", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    dtpDueDate.ResetText();
            //} 
        }

        private void dtpPromisedDate_ValueChanged(object sender, EventArgs e)
        {
            //if (dtpDueDate.Value > dtpPromisedDate.Value)
            //{
            //    MessageBox.Show("Promised Date Should be grater than or Equal to Due Date", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    dtpPromisedDate.ResetText();
            //} 
        }

        private void GetInvoice()
        {
            ParameterField paramField1 = new ParameterField();


            //creating an object of ParameterFields class
            ParameterFields paramFields1 = new ParameterFields();

            //creating an object of ParameterDiscreteValue class
            ParameterDiscreteValue paramDiscreteValue1 = new ParameterDiscreteValue();

            //set the parameter field name
            paramField1.Name = "id";

            //set the parameter value
            paramDiscreteValue1.Value = invoiceId;

            //add the parameter value in the ParameterField object
            paramField1.CurrentValues.Add(paramDiscreteValue1);

            //add the parameter in the ParameterFields object
            paramFields1.Add(paramField1);
            ReportViewer f2 = new ReportViewer();
            TableLogOnInfos reportLogonInfos = new TableLogOnInfos();
            TableLogOnInfo reportLogonInfo = new TableLogOnInfo();
            ConnectionInfo reportConInfo = new ConnectionInfo();
            Tables tables = default(Tables);
            //	Table table = default(Table);
            var with1 = reportConInfo;
            with1.ServerName = "tcp:KyotoServer,49172";
            with1.DatabaseName = "BillsReceivableDBDemo";
            with1.UserID = "sa";
            with1.Password = "SystemAdministrator";
            Invoices cr = new Invoices();
            tables = cr.Database.Tables;
            foreach (Table table in tables)
            {
                reportLogonInfo = table.LogOnInfo;
                reportLogonInfo.ConnectionInfo = reportConInfo;
                table.ApplyLogOnInfo(reportLogonInfo);
            }

            f2.crystalReportViewer1.ParameterFieldInfo = paramFields1;
            f2.crystalReportViewer1.ReportSource = cr;
            this.Visible = false;

            f2.ShowDialog();
            this.Visible = true;
        }
        

        private void NewInvoice_Load(object sender, EventArgs e)
        {
            userid = frmLogin.uId.ToString();
            this.BeginInvoke(new ChangeFocusDelegate(changeFocus), txtQuotation);
            Unit();
        }

        private void Unit()
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select UnitName from Unit";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    UnitcomboBox.Items.Add(rdr.GetValue(0).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewInvoice_FormClosed(object sender, FormClosedEventArgs e)
        {
          
            MainUI frm3 = new MainUI();
            this.Visible = false;
            frm3.ShowDialog();
            this.Visible = true;
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            if (string.IsNullOrWhiteSpace(DescriptionrichTextBox.Text))
            {
                MessageBox.Show(@"Please enter Product Description", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                this.BeginInvoke(new ChangeFocusDelegate(changeFocus), DescriptionrichTextBox);
            }

            else if (string.IsNullOrWhiteSpace(UnitcomboBox.Text))
            {
                MessageBox.Show(@"Please Select Unit", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
                this.BeginInvoke(new ChangeFocusDelegate(changeFocus), UnitcomboBox);
            }

            else if (string.IsNullOrWhiteSpace(UnitPricetextBox.Text))
            {
                MessageBox.Show(@"Please enter Unit Price", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                this.BeginInvoke(new ChangeFocusDelegate(changeFocus), UnitPricetextBox);
            }

            else if (string.IsNullOrWhiteSpace(QtytextBox.Text))
            {
                MessageBox.Show(@"Please enter Qty Here", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                this.BeginInvoke(new ChangeFocusDelegate(changeFocus), QtytextBox);
            }
            else
            {
                LoadUnitId();
                if (listView1.Items.Count == 0)
                {
                    ListViewItem lst = new ListViewItem();
                    lst.SubItems.Add(DescriptionrichTextBox.Text);
                    lst.SubItems.Add(unitid.ToString());
                    lst.SubItems.Add(UnitPricetextBox.Text);
                    lst.SubItems.Add(QtytextBox.Text);
                    listView1.Items.Add(lst);
                    DescriptionrichTextBox.Clear();
                    UnitcomboBox.SelectedIndex = -1;
                    UnitPricetextBox.Clear();
                    QtytextBox.Clear();
                    return;
                }


                else
               
                {
                    ListViewItem lst1 = new ListViewItem();
                    lst1.SubItems.Add(DescriptionrichTextBox.Text);
                    lst1.SubItems.Add(unitid.ToString());
                    lst1.SubItems.Add(UnitPricetextBox.Text);
                    lst1.SubItems.Add(QtytextBox.Text);
                    listView1.Items.Add(lst1);
                    DescriptionrichTextBox.Clear();
                    UnitcomboBox.SelectedIndex = -1;
                    UnitPricetextBox.Clear();
                    QtytextBox.Clear();
                    return;
                }
            }

        }

        private void UnitcomboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        public void LoadUnitId()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT UnitId from Unit WHERE UnitName= '" + UnitcomboBox.Text + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    unitid = rdr.GetInt32(0);
                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtLandPhone_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            string land_phone = txtLandPhone.Text;

            if (char.IsNumber(e.KeyChar))
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtCellPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Cell_Phone = txtCellPhone.Text;

            if (char.IsNumber(e.KeyChar))
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtGrossReceivable_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txtGrossReceivable.Text + ch, out x))
            {
                e.Handled = true;
            }
        }

        private void txtNetReceivable_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txtNetReceivable.Text + ch, out x))
            {
                e.Handled = true;
            }
        }

        private void UnitPricetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(UnitPricetextBox.Text + ch, out x))
            {
                e.Handled = true;
            }
        }

        private void QtytextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }
    }
}
