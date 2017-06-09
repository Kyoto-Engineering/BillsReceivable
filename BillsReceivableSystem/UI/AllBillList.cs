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
    public partial class AllBillList : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        private ConnectionString cs = new ConnectionString();

        public AllBillList()
        {
            InitializeComponent();
        }

        private void AllBillList_Load(object sender, EventArgs e)
        {
            GetAllBill();
        }

        private void GetAllBill()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                SqlDataAdapter sda = new SqlDataAdapter(
                    "SELECT BTransaction.BillTransactionId, BillsFrom.BillsFromName, BTransaction.Amount, BTransaction.DueDate, BillsName.BillName, BTransaction.ContactPersonName, BTransaction.PhoneNumber FROM BillsFrom INNER JOIN BTransaction ON BillsFrom.BillsFromId = BTransaction.BillsFromId INNER JOIN BillsName ON BTransaction.BillId = BillsName.BillId",
                    con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                allReceivableBillDataGridView.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = allReceivableBillDataGridView.Rows.Add();
                    allReceivableBillDataGridView.Rows[n].Cells[0].Value = item[0].ToString();
                    allReceivableBillDataGridView.Rows[n].Cells[1].Value = item[1].ToString();
                    allReceivableBillDataGridView.Rows[n].Cells[2].Value = item[2].ToString();
                    allReceivableBillDataGridView.Rows[n].Cells[3].Value = item[3].ToString();
                    allReceivableBillDataGridView.Rows[n].Cells[4].Value = item[4].ToString();
                    allReceivableBillDataGridView.Rows[n].Cells[5].Value = item[5].ToString();
                    allReceivableBillDataGridView.Rows[n].Cells[6].Value = item[6].ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT BTransaction.BillTransactionId, BillsFrom.BillsFromName, BTransaction.Amount, BTransaction.DueDate, BillsName.BillName, BTransaction.ContactPersonName, BTransaction.PhoneNumber FROM BillsFrom INNER JOIN BTransaction ON BillsFrom.BillsFromId = BTransaction.BillsFromId INNER JOIN BillsName ON BTransaction.BillId = BillsName.BillId WHERE (BillsFrom.BillsFromName LIKE '" + searchTextBox.Text + "%')", con);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            allReceivableBillDataGridView.Rows.Clear();
            foreach (DataRow item in dataTable.Rows)
            {
                int n = allReceivableBillDataGridView.Rows.Add();
                allReceivableBillDataGridView.Rows[n].Cells[0].Value = item[0].ToString();
                allReceivableBillDataGridView.Rows[n].Cells[1].Value = item[1].ToString();
                allReceivableBillDataGridView.Rows[n].Cells[2].Value = item[2].ToString();
                allReceivableBillDataGridView.Rows[n].Cells[3].Value = item[3].ToString();
                allReceivableBillDataGridView.Rows[n].Cells[4].Value = item[4].ToString();
                allReceivableBillDataGridView.Rows[n].Cells[5].Value = item[5].ToString();
                allReceivableBillDataGridView.Rows[n].Cells[6].Value = item[6].ToString();
            }
        }
    }
}