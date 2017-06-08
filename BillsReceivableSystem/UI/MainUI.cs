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
            this.Hide();
            NewInvoice frm5 = new NewInvoice();
            frm5.Show();
        }


        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistration frm2 = new frmRegistration();
            frm2.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {

        }

        private void btnInvoiceList_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBillEntry frm1 = new frmBillEntry();
            frm1.Show();
        }
    }
}
