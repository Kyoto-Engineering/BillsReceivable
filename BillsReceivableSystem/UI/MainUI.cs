using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillsReceivableSystem.LoginUI;
using BillsReceivableSystem.Report;

namespace BillsReceivableSystem.UI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
         
            NewInvoice frm5 = new NewInvoice();
            this.Visible = false;
            frm5.ShowDialog();
            this.Visible = true;
        }


        private void btnRegistration_Click(object sender, EventArgs e)
        {
          
            frmRegistration frm2 = new frmRegistration();
            this.Visible = false;
            frm2.ShowDialog();
            this.Visible = true;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //frmLogin frm = new frmLogin();
            //this.Visible = false;
            //frm.ShowDialog();
            //this.Visible = true;
        }     
        private void billEntrybutton_Click(object sender, EventArgs e)
        {
            frmBillEntry frm1 = new frmBillEntry();
            this.Visible = false;
            frm1.ShowDialog();
            this.Visible = true;
        }

        private void invoiceListbutton_Click(object sender, EventArgs e)
        {
            InvoiceList invlst = new InvoiceList();
            this.Visible = false;
            invlst.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllBillList invlst = new AllBillList();
            this.Visible = false;
            invlst.ShowDialog();
            this.Visible = true;
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    ReportForInvoice f2 = new ReportForInvoice();
        //    this.Visible = false;
        //    f2.ShowDialog();
        //    this.Visible = true;
        //}

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportsUI f2 = new ReportsUI();
            this.Visible = false;
            f2.ShowDialog();
            this.Visible = true;
        }

        

        
    }
}
