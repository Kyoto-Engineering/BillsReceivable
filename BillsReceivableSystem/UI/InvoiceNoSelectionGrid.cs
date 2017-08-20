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
    public partial class InvoiceNoSelectionGrid : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        private ConnectionString cs = new ConnectionString();
        public string ReturnValue1 { get; set; }
        public InvoiceNoSelectionGrid()
        {
            InitializeComponent();
        }

        private void InvoiceNoSelectionGrid_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT RefInvoiceNo from RefNumForInvoice_New", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.Rows.Clear();
                //ManualInvoiceTextBox.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    //dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                this.Dispose();
                //frm1 frm = new frm1();


                //frm.Show();
                this.ReturnValue1 = dr.Cells[0].Value.ToString();
                //example
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InvoiceNoSearchtextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT RefInvoiceNo from RefNumForInvoice_New where (RefNumForInvoice_New.RefInvoiceNo LIKE '" + InvoiceNoSearchtextBox.Text + "%')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void InAddButton_Click(object sender, EventArgs e)
        //{
        //    dataGridView1.Rows.Add();
        //    dataGridView1.Rows[InAddButton_Click].Cells["Invoice_No"].Value = "Invoice " + (InAddButton_Click + 1).ToString();
        //}

       
        //private void InvoiceNoSelectComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrWhiteSpace(InvoiceNoSelectComboBox.Text))
        //    {
        //        if (InvoiceNoSelectComboBox.Text == @"Manual")
        //        {
        //            ManualInvoiceTextBox.Visible = true;
        //            InAddButton.Visible = true;
        //        }
        //        else
        //        {
        //            ManualInvoiceTextBox.Visible = false;
        //            InAddButton.Visible = false;
        //        }

        //    }
        //}


    }
}
