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
    public partial class InvoiceList : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        private ConnectionString cs = new ConnectionString();
        public InvoiceList()
        {
            InitializeComponent();
        }

        private void GetInvoiceList()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Invoice.InvoiceId, Invoice.InvoiceDate, Products.ProductDescription, Unit.UnitName, Products.UnitPrice, Products.Qty,Invoice.GrossReceive, Invoice.NetReceive, Invoice.InvoiceTo, Invoice.Address, Invoice.LPhn, Invoice.RP, Invoice.CPhn, Invoice.DueDate, Invoice.PromisedDate, Invoice.QuotationNo, Invoice.WorkOrderNo, Invoice.DeliveryNo FROM  Invoice INNER JOIN Products ON Invoice.InvoiceId = Products.InvoiceId INNER JOIN Unit ON Products.UnitId = Unit.UnitId", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                InvoiceListdataGridView.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = InvoiceListdataGridView.Rows.Add();
                    InvoiceListdataGridView.Rows[n].Cells[0].Value = item[0].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[1].Value = item[1].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[2].Value = item[2].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[3].Value = item[3].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[4].Value = item[4].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[5].Value = item[5].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[6].Value = item[6].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[7].Value = item[7].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[8].Value = item[8].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[9].Value = item[9].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[10].Value = item[10].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[11].Value = item[11].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[12].Value = item[12].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[13].Value = item[13].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[14].Value = item[14].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[15].Value = item[15].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[16].Value = item[16].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[17].Value = item[17].ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void InvoiceList_Load(object sender, EventArgs e)
        {
            GetInvoiceList();

        }

        private void InvoiceList_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            MainUI frm3 = new MainUI();
            this.Visible = false;
            frm3.ShowDialog();
            this.Visible = true;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Invoice.InvoiceId, Invoice.InvoiceDate, Products.ProductDescription, Unit.UnitName, Products.UnitPrice, Products.Qty,Invoice.GrossReceive, Invoice.NetReceive, Invoice.InvoiceTo, Invoice.Address, Invoice.LPhn, Invoice.RP, Invoice.CPhn, Invoice.DueDate, Invoice.PromisedDate, Invoice.QuotationNo, Invoice.WorkOrderNo, Invoice.DeliveryNo FROM  Invoice INNER JOIN Products ON Invoice.InvoiceId = Products.InvoiceId INNER JOIN Unit ON Products.UnitId = Unit.UnitId WHERE (Invoice.InvoiceTo LIKE '" + searchTextBox.Text + "%') ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                InvoiceListdataGridView.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = InvoiceListdataGridView.Rows.Add();
                    InvoiceListdataGridView.Rows[n].Cells[0].Value = item[0].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[1].Value = item[1].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[2].Value = item[2].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[3].Value = item[3].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[4].Value = item[4].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[5].Value = item[5].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[6].Value = item[6].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[7].Value = item[7].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[8].Value = item[8].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[9].Value = item[9].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[10].Value = item[10].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[11].Value = item[11].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[12].Value = item[12].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[13].Value = item[13].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[14].Value = item[14].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[15].Value = item[15].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[16].Value = item[16].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[17].Value = item[17].ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SearchInvoiceIdtextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Invoice.InvoiceId, Invoice.InvoiceDate, Products.ProductDescription, Unit.UnitName, Products.UnitPrice, Products.Qty,Invoice.GrossReceive, Invoice.NetReceive, Invoice.InvoiceTo, Invoice.Address, Invoice.LPhn, Invoice.RP, Invoice.CPhn, Invoice.DueDate, Invoice.PromisedDate, Invoice.QuotationNo, Invoice.WorkOrderNo, Invoice.DeliveryNo FROM  Invoice INNER JOIN Products ON Invoice.InvoiceId = Products.InvoiceId INNER JOIN Unit ON Products.UnitId = Unit.UnitId WHERE (Invoice.InvoiceId LIKE '" + SearchInvoiceIdtextBox.Text + "%') ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                InvoiceListdataGridView.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = InvoiceListdataGridView.Rows.Add();
                    InvoiceListdataGridView.Rows[n].Cells[0].Value = item[0].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[1].Value = item[1].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[2].Value = item[2].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[3].Value = item[3].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[4].Value = item[4].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[5].Value = item[5].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[6].Value = item[6].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[7].Value = item[7].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[8].Value = item[8].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[9].Value = item[9].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[10].Value = item[10].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[11].Value = item[11].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[12].Value = item[12].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[13].Value = item[13].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[14].Value = item[14].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[15].Value = item[15].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[16].Value = item[16].ToString();
                    InvoiceListdataGridView.Rows[n].Cells[17].Value = item[17].ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchInvoiceIdtextBox_Leave(object sender, EventArgs e)
        {
            SearchInvoiceIdtextBox.Clear();
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            searchTextBox.Clear();
        }

        
    }
}
