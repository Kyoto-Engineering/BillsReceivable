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
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Invoice.InvoiceDate, Invoice.DueDate, Invoice.GrossReceive, Invoice.NetReceive, Invoice.PromisedDate, RefNumForInvoice.QuotationId, RefNumForInvoice.InvoiceId, RefNumForInvoice.RefInvoiceNo FROM Invoice INNER JOIN RefNumForInvoice ON Invoice.InvoiceId = RefNumForInvoice.InvoiceId", con);
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
            this.Dispose();
            MainUI frm3 = new MainUI();
            frm3.Show();
        }

        
    }
}
