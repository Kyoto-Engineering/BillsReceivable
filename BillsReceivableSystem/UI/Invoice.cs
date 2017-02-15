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
    public partial class Invoice : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        private ConnectionString cs = new ConnectionString();
        public int quotationId, sclientId;
        public Invoice()
        {
            InitializeComponent();
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            string ContactNo = txtLandPhone.Text;

            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char) Keys.Back;
            }
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            QuotationIdLoad();
        }

        public void SelectSclientId()
        {
            con = new SqlConnection(cs.DBConn);
            con.Open();
            cmd = con.CreateCommand();

            cmd.CommandText = "select SClientId from RefNumForQuotation WHERE ReferenceNo= '" + cmbQuotation.Text + "'";

            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                sclientId = rdr.GetInt32(0);
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
        private void cmbQuotation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtInvoiceParty.Clear();
            SelectSclientId();
            
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "select ClientName,CFlatNo,CHouseNo,CRoadNo,CBlock,CArea,CPS,CPSCode,CDistrict,CContactNo,ContactPersonName,CellNumber from SalesClient where SClientId= '" + sclientId + "'";
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    txtInvoiceParty.Text = rdr["ClientName"].ToString();
                    txtPayerAddress.Text = rdr["CFlatNo"] + ", " + rdr["CHouseNo"] + ", " + rdr["CRoadNo"] + ", " + rdr["CBlock"] + ", " + rdr["CArea"] + ", " + rdr["CPS"] + ", " + rdr["CPSCode"] + ", " + rdr["CDistrict"];
                    txtLandPhone.Text = rdr["CContactNo"].ToString();
                    txtRP.Text = rdr["ContactPersonName"].ToString();
                    txtCellPhone.Text = rdr["CellNumber"].ToString();
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

        private void QuotationIdLoad()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string query = "select ReferenceNo from RefNumForQuotation left join Invoice on RefNumForQuotation.RefId=Invoice.RefId EXCEPT select ReferenceNo from RefNumForQuotation right join Invoice on RefNumForQuotation.RefId=Invoice.RefId";

                cmd = new SqlCommand(query, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cmbQuotation.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
      
    }
}

