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

namespace BillsReceivableSystem.UI
{
    public partial class NewInvoice : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        private ConnectionString cs = new ConnectionString();
        
        private delegate void ChangeFocusDelegate(Control ctl);
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
                String query = "insert into Invoice(InvoiceDate, DueDate, QuotationNo, GrossReceive, NetReceive, PromisedDate, WorkOrderNo, DeliveryNo, InvoiceTo, Address, LPhn, RP, CPhn) values (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13)" + "SELECT CONVERT(int, SCOPE_IDENTITY())";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@d1", dtpInvoiceDate.Value);
                cmd.Parameters.AddWithValue("@d2", dtpDueDate.Value);
                //cmd.Parameters.AddWithValue("@d3", user_id);
                cmd.Parameters.AddWithValue("@d3", txtQuotation.Text);
                cmd.Parameters.AddWithValue("@d4", Convert.ToDecimal(txtGrossReceivable.Text));
                cmd.Parameters.AddWithValue("@d5", Convert.ToDecimal(txtNetReceivable.Text));
                cmd.Parameters.AddWithValue("@d6", dtpPromisedDate.Value);
                cmd.Parameters.AddWithValue("@d7", txtWorkOrderNo.Text);
                cmd.Parameters.AddWithValue("@d8", txtDeliveryNo.Text);
                cmd.Parameters.AddWithValue("@d9", txtInvoiceParty.Text);
                cmd.Parameters.AddWithValue("@d10", txtPayerAddress.Text);
                cmd.Parameters.AddWithValue("@d11", txtLandPhone.Text);
                cmd.Parameters.AddWithValue("@d12", txtRP.Text);
                cmd.Parameters.AddWithValue("@d13", txtCellPhone.Text);

                //invoiceId = (int)cmd.ExecuteScalar();
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInvoiceParty.Text))
            {
                MessageBox.Show("Please enter Invoice Party", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new ChangeFocusDelegate(changeFocus), txtInvoiceParty);
            }
            
            else if (string.IsNullOrWhiteSpace(txtPayerAddress.Text))
            {
                MessageBox.Show("Please enter Payer Address","error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new ChangeFocusDelegate(changeFocus), txtPayerAddress);
            }

            else if (string.IsNullOrWhiteSpace(txtLandPhone.Text))
            {
                MessageBox.Show("Please enter Land Phone Number", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new ChangeFocusDelegate(changeFocus), txtLandPhone);
            }

            else if (string.IsNullOrWhiteSpace(txtRP.Text))
            {
                MessageBox.Show("Please enter Respondent Person name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new ChangeFocusDelegate(changeFocus), txtRP);
            }

            else if (string.IsNullOrWhiteSpace(txtCellPhone.Text))
            {
                MessageBox.Show("Please enter Cell Phone Number", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new ChangeFocusDelegate(changeFocus), txtCellPhone);
            }

            else if (string.IsNullOrWhiteSpace(txtGrossReceivable.Text))
            {
                MessageBox.Show("Please  enter Gross Receivable", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new ChangeFocusDelegate(changeFocus), txtGrossReceivable);

            }

            else if (string.IsNullOrWhiteSpace(txtNetReceivable.Text))
            {
                MessageBox.Show("Please  enter Net Receivable", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new ChangeFocusDelegate(changeFocus), txtNetReceivable);

            }

            else
            {
                SaveInvoice();
                MessageBox.Show("Successfully Generated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                ClearData();                
            }
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

        private void txtGrossReceivable_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dtpInvoiceDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpInvoiceDate.Value > DateTime.Now)
            {
                MessageBox.Show("Should not be exceed Date Time from today", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpInvoiceDate.ResetText();
            }
        }

        private void dtpDueDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpInvoiceDate.Value > dtpDueDate.Value)
            {
                MessageBox.Show("Due Date Should be grater than or Equal to Invoice Date", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDueDate.ResetText();
            } 
        }

        private void dtpPromisedDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDueDate.Value > dtpPromisedDate.Value)
            {
                MessageBox.Show("Promised Date Should be grater than or Equal to Due Date", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpPromisedDate.ResetText();
            } 
        }

        private void txtLandPhone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void NewInvoice_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new ChangeFocusDelegate(changeFocus), txtQuotation);
        }

        private void NewInvoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            MainUI frm3 = new MainUI();
            frm3.Show();
        }

        
    }
}
