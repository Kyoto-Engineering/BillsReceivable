using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.InteropServices;
using BillsReceivableSystem.DbGateway;
using BillsReceivableSystem.LoginUI;
using BillsReceivableSystem.Models;
using BillsReceivableSystem.UI;


namespace BillsReceivableSystem
{
    public partial class frmBillEntry : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        public int btype_id, nameOfBillId, bReceivableFromId, billId, billTransactionId; 
        public string user_id,inpb=null;
        private delegate void ChangeFocusDelegate(Control ctl);
        

        public frmBillEntry()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            user_id = frmLogin.uId.ToString();
            BillsType();
            ReceivableFrom();
            BillPurposeLoad();
        }

        private void changeFocus(Control ctl)
        {
            ctl.Focus();
        }
       
        private void ClearData()
        {        
            cmbReceivableFrom.Items.Clear();
            cmbReceivableFrom.SelectedIndex = -1;
            txtInvoiceNo.Clear();
            txtAmount.Clear();
            cmbPaymentMethod.SelectedIndex = -1;
            cmbBillType.SelectedIndex = -1;
            cmbBillPurpose.Items.Clear(); 
            cmbBillPurpose.Items.Clear();
            cmbBillPurpose.SelectedIndex = -1;
            ContactPersontextBox.Clear();
            DesignationtextBox.Clear();
            PhonetextBox.Clear();
            txtpictureBox.Image = null;
            txtBillNarrative.Clear();
            txtNote.Clear();
        }
        
        private void BillsType()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select BillTypeName from BillsType";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cmbBillType.Items.Add(rdr.GetValue(0).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReceivableFrom()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ctt = "select BillsFromName from BillsFrom";
                cmd = new SqlCommand(ctt);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cmbReceivableFrom.Items.Add(rdr.GetValue(0).ToString());
                }
                cmbReceivableFrom.Items.Add("Not In The List");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BillPurposeLoad()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT BillTypeId from BillsType WHERE BillTypeName= '" + cmbBillType.Text + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    btype_id = rdr.GetInt32(0);
                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select distinct RTRIM(BillName) from BillsName where BillTypeId= " + btype_id + "";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbBillPurpose.Items.Add(rdr[0]);
                }
                cmbBillPurpose.Items.Add("Not In The List");

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

       
        private void cmbBillsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBillPurpose.Text = "";
            cmbBillPurpose.Items.Clear();
            cmbBillPurpose.SelectedIndex = -1;
            txtBillNarrative.Clear();

            if (cmbBillType.Text == "Recurrent")
            { 
                lblFrom.Visible = true;
                dtpFrom.Visible = true;
                lblTo.Visible = true;
                dtpTo.Visible = true;
            }
            else
            {
                lblFrom.Visible = false;
                dtpFrom.Visible = false;
                lblTo.Visible = false;
                dtpTo.Visible = false;
            }
               BillPurposeLoad();
        }
        
        
      
        private void RecurrentLoad()
        {          
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                String query = "insert into RecurrentInfo(BillTransactionId, PeriodFrom, PeriodTo) values (@d1,@d2,@d3)" + "SELECT CONVERT(int, SCOPE_IDENTITY())";
              
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@d1", billTransactionId);
                cmd.Parameters.AddWithValue("@d2", dtpFrom.Value);
                cmd.Parameters.AddWithValue("@d3", dtpTo.Value);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NoteForBillTransactions()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                String query5 = "insert into NoteForBillTransaction(Note, BillTransactionId) values (@d1,@d2)" + "SELECT CONVERT(int, SCOPE_IDENTITY())";

                cmd = new SqlCommand(query5, con);
                //cmd.Parameters.AddWithValue("@d1", txtNote.Text);
                cmd.Parameters.Add(new SqlParameter("@d1",
                    string.IsNullOrEmpty(txtNote.Text) ? (object)DBNull.Value : txtNote.Text));
                cmd.Parameters.AddWithValue("@d2", billTransactionId);
               
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SaveBillTransaction()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                String query = "insert into BTransaction(BillId, Narrative, PaymentMethod, Amount, BIssueDate, BReceivedDate, DueDate, BillsFromId, InvoiceNo, UserId, BillImage,DateTime,ContactPersonName,Designation,PhoneNumber) values (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15)" + "SELECT CONVERT(int, SCOPE_IDENTITY())";
                cmd = new SqlCommand(query, con);
                //cmd.Parameters.AddWithValue("@d1", (object)billId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@d1", billId);
                //cmd.Parameters.AddWithValue("@d2", txtBillNarrative.Text);
                cmd.Parameters.Add(new SqlParameter("@d2",
                    string.IsNullOrEmpty(txtBillNarrative.Text) ? (object)DBNull.Value : txtBillNarrative.Text));
                //cmd.Parameters.AddWithValue("@d3", cmbPaymentMethod.Text);
                cmd.Parameters.Add(new SqlParameter("@d3",
                    string.IsNullOrEmpty(cmbPaymentMethod.Text) ? (object)DBNull.Value : cmbPaymentMethod.Text));

                cmd.Parameters.AddWithValue("@d4", Convert.ToDecimal(txtAmount.Text));
                cmd.Parameters.AddWithValue("@d5", dtpBillDate.Value);
                cmd.Parameters.AddWithValue("@d6", dtpBillReceivedDate.Value);
                cmd.Parameters.AddWithValue("@d7", dtpDueDate.Value);
                //cmd.Parameters.AddWithValue("@d8", (object)bReceivableFromId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@d8", bReceivableFromId);

                cmd.Parameters.AddWithValue("@d9", txtInvoiceNo.Text);
                cmd.Parameters.Add(new SqlParameter("@d3",
                    string.IsNullOrEmpty(cmbPaymentMethod.Text) ? (object)DBNull.Value : cmbPaymentMethod.Text));
                cmd.Parameters.AddWithValue("@d10", user_id);
                
                             
                if (txtpictureBox.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    Bitmap bmpImage = new Bitmap(txtpictureBox.Image);
                    bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] data = ms.GetBuffer();
                    SqlParameter p = new SqlParameter("@d11", SqlDbType.Image);
                    p.Value = data;
                    cmd.Parameters.Add(p);
                }
                else
                {
                    cmd.Parameters.Add("@d11", SqlDbType.VarBinary, -1);
                    cmd.Parameters["@d11"].Value = DBNull.Value;
                }
                cmd.Parameters.AddWithValue("@d12", DateTime.UtcNow.ToLocalTime());
                cmd.Parameters.Add(new SqlParameter("@d13",
                    string.IsNullOrEmpty(ContactPersontextBox.Text) ? (object)DBNull.Value : ContactPersontextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@d14",
                    string.IsNullOrEmpty(DesignationtextBox.Text) ? (object)DBNull.Value : DesignationtextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@d15",
                    string.IsNullOrEmpty(PhonetextBox.Text) ? (object)DBNull.Value : PhonetextBox.Text));
                billTransactionId = (int) cmd.ExecuteScalar();
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbReceivableFrom.Text))
            {
                MessageBox.Show("Please  enter receivable From Name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            else if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Please  enter Amount", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            else if (string.IsNullOrWhiteSpace(cmbPaymentMethod.Text))
            {
                MessageBox.Show("Please Select Payment Method", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            else if (string.IsNullOrWhiteSpace(cmbBillType.Text))
            {
                MessageBox.Show("Please Select Type of Bill", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            else if (string.IsNullOrWhiteSpace(cmbBillPurpose.Text))
            {
                MessageBox.Show("Please Select Bill Purpose", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }

            else if (string.IsNullOrWhiteSpace(txtBillNarrative.Text))
            {
                MessageBox.Show("Please  enter Bill Narrative", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            else if (string.IsNullOrWhiteSpace(ContactPersontextBox.Text))
            {
                MessageBox.Show("Please enter Contact Person Name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else if (string.IsNullOrWhiteSpace(PhonetextBox.Text))
            {
                MessageBox.Show("Please enter Phone Number", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                SaveBillTransaction();

                if (!string.IsNullOrWhiteSpace(txtNote.Text))
                {
                    NoteForBillTransactions();
                    
                }
                if (cmbBillType.Text == "Recurrent")
                {
                    RecurrentLoad();
                }
                MessageBox.Show("Saved successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
                ReceivableFrom();
                cmbReceivableFrom.ResetText();
            }            
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txtAmount.Text + ch, out x))
            {
                e.Handled = true;
            }
        }

        private void cmbPayableTo_Leave(object sender, EventArgs e)
        {

        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //private void browseButton_Click(object sender, EventArgs e)
        //{
            //try
            //{
            //    var _with1 = openFileDialog1;

            //    _with1.Filter = ("Image Files |*.png; *.bmp; *.jpg;*.jpeg; *.gif;");
            //    _with1.FilterIndex = 4;

            //    openFileDialog1.FileName = "";

            //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        txtpictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        //}

        private void frmBillEntry_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            MainUI frm3 = new MainUI();
            frm3.Show();
        }

        private void cmbBillPurpose_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbBillPurpose.Text) && !cmbBillPurpose.Items.Contains(cmbBillPurpose.Text))
            {
                MessageBox.Show("Please Select A Valid Bill Purpose", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBillPurpose.ResetText();
                this.BeginInvoke(new ChangeFocusDelegate(changeFocus), cmbBillPurpose);
            }
        }

        private void cmbReceivableFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReceivableFrom.Text == "Not In The List")
            {
                //string input = Microsoft.VisualBasic.Interaction.InputBox("Please Input Receivable From Here", "Input Here", "", -1, -1);

                string input= null;
                InputBox.Show("Please Input Receivable From Here", "Inpute Here", ref input);
                if (string.IsNullOrWhiteSpace(input))
                {
                    cmbReceivableFrom.SelectedIndex = -1;
                }
                else
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string ct2 = "select BillsFromName from BillsFrom where BillsFromName='" + input + "'";
                    cmd = new SqlCommand(ct2, con);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read() && !rdr.IsDBNull(0))
                    {
                        MessageBox.Show("This Receivable From Name Already Exists,Please Select From List", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                        cmbReceivableFrom.SelectedIndex = -1;
                    }
                    else
                    {
                        try
                        {
                            con = new SqlConnection(cs.DBConn);
                            con.Open();
                            string query1 = "insert into BillsFrom (BillsFromName, UserId,DateTime) values (@d1,@d2,@d3)" + "SELECT CONVERT(int, SCOPE_IDENTITY())";
                            cmd = new SqlCommand(query1, con);
                            cmd.Parameters.AddWithValue("@d1", input);
                            cmd.Parameters.AddWithValue("@d2", user_id);
                            cmd.Parameters.AddWithValue("@d3", DateTime.UtcNow.ToLocalTime());

                            cmd.ExecuteNonQuery();

                            con.Close();
                            cmbReceivableFrom.Items.Clear();
                            ReceivableFrom();
                            cmbReceivableFrom.SelectedText = input;
                            txtAmount.Focus();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                try
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT BillsFromName from BillsFrom WHERE BillsFromName= '" + cmbReceivableFrom.Text + "'";

                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        bReceivableFromId = rdr.GetInt32(0);
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
        }

        private void cmbReceivableFrom_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cmbReceivableFrom.Text) && !cmbReceivableFrom.Items.Contains(cmbReceivableFrom.Text))
            {
                MessageBox.Show("Please Select A Valid Receivable From", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbReceivableFrom.ResetText();
                this.BeginInvoke(new ChangeFocusDelegate(changeFocus), cmbReceivableFrom);
            }
        }

        private void txtpictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                var _with1 = openFileDialog1;

                _with1.Filter = ("Image Files |*.png; *.bmp; *.jpg;*.jpeg; *.gif;");
                _with1.FilterIndex = 4;

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

        private void cmbBillPurpose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBillPurpose.Text == "Not In The List")
            {
                //inpb = Microsoft.VisualBasic.Interaction.InputBox("Please Input Bill Purpose Here", "Input Here", "", -1, -1);
                string inpb = null;
                InputBox.Show("Please Input Bill Purpose Here", "Inpute Here", ref inpb);

                if (string.IsNullOrWhiteSpace(inpb))
                {
                    cmbBillPurpose.SelectedIndex = -1;
                }
                else
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string ct3 = "select BillName from BillsName where BillName='" + inpb + "' AND BillTypeId='" + btype_id + "'";
                    cmd = new SqlCommand(ct3, con);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read() && !rdr.IsDBNull(0))
                    {
                        MessageBox.Show("This Bill Purpose Name Already Exists,Please Select From List", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                        cmbBillPurpose.SelectedIndex = -1;
                    }
                    else
                    {
                        try
                        {
                            con = new SqlConnection(cs.DBConn);
                            con.Open();
                            string query4 = "insert into BillsName (BillName, BillTypeId, UserId,DateTime) values (@d1,@d2,@d3,@d4)" + "SELECT CONVERT(int, SCOPE_IDENTITY())";
                            cmd = new SqlCommand(query4, con);
                            cmd.Parameters.AddWithValue("@d1", inpb);
                            cmd.Parameters.AddWithValue("@d2", btype_id);
                            cmd.Parameters.AddWithValue("@d3", user_id);
                            cmd.Parameters.AddWithValue("@d4", DateTime.UtcNow.ToLocalTime());
                            cmd.ExecuteNonQuery();
                            con.Close();

                            cmbBillPurpose.Items.Clear();
                            BillPurposeLoad();
                            cmbBillPurpose.SelectedText = inpb;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                try
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT BillId from BillsName WHERE BillName= '" + cmbBillPurpose.Text + "'";

                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        billId = rdr.GetInt32(0);
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
        }

       

       

       
     
    }
 }

      
    
