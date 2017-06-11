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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using BillsReceivableSystem.Report;

namespace BillsReceivableSystem.Report
{
    public partial class ReportForInvoice : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        public int invoiceid;
        public ReportForInvoice()
        {
            InitializeComponent();
        }

        private void invoiceIdcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
                {

                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string ctk = "SELECT InvoiceId FROM Invoice WHERE InvoiceId = @d1";

                    cmd = new SqlCommand(ctk);
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@d1", invoiceIdcomboBox.Text);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        invoiceid = Convert.ToInt32(rdr["InvoiceId"]);

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

        private void ReportForInvoice_Load(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "SELECT InvoiceId FROM Invoice ORDER BY InvoiceId";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    invoiceIdcomboBox.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            paramDiscreteValue1.Value = invoiceid;

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

        private void Getbutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(invoiceIdcomboBox.Text))
            {
                  GetInvoice();
                    Clear();
            }
            else
            {
                MessageBox.Show(@"Please Select Invoice Id");
            }
        }

        private void Clear()
        {
            invoiceIdcomboBox.SelectedIndex = -1;
            
        }
    }
}
