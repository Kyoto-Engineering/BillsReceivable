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


namespace BillsReceivableSystem
{
    public partial class Form1 : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BillsPayable();
        }

        private void BillsPayable()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string query = "select BPName from BillsPayable";
                cmd = new SqlCommand(query, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cmbBillPayable.Items.Add(rdr.GetValue(0).ToString());
                }
                cmbBillPayable.Items.Add("Not In The List");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtInvoiceAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char) Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txtInvoiceAmount.Text + ch, out x))
            {
                e.Handled = true;
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            try
            {
                var com = openFileDialog1;

                com.Filter = ("Image Files|*.png;*.bmp;*.jpg;*.jpeg;*.gif;");
                com.FilterIndex = 4;

                openFileDialog1.FileName = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtpictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            string ContactNo = txtContactNo.Text;
           
            if (char.IsNumber(e.KeyChar))
            { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void cmbBillPayable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBillPayable.Text == "Not In The List")
            {
                string inpt = Microsoft.VisualBasic.Interaction.InputBox("Please Input Payable Name Here", "Input Here","", -1, -1);
            }
        }
    }
}
