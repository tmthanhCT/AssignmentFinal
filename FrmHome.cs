using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentFinal
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void btnCusManage_Click(object sender, EventArgs e)
        {
            FrmCustomer frmCus = new FrmCustomer();
            frmCus.Show();
            this.Hide();
        }

        private void btnFruitManage_Click(object sender, EventArgs e)
        {
            FrmFruitManage frmFruit = new FrmFruitManage();
            frmFruit.Show();
            this.Hide();
        }
        private void btnBackToLogin_Click_1(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void btnFruitTypeManage_Click(object sender, EventArgs e)
        {
            FrmTypeFruit frmTypeFruit = new FrmTypeFruit();
            frmTypeFruit.Show();
            this.Hide();
        }

        private void btnEmployeeManage_Click(object sender, EventArgs e)
        {
            FrmEmployee fromEmployee = new FrmEmployee();
            fromEmployee.Show();
            this.Hide();
        }

        private void btnBillManage_Click(object sender, EventArgs e)
        {
            frmBIll fromBill = new frmBIll();
            fromBill.Show();
            this.Hide();

        }

        private void btnBillDetails_Click(object sender, EventArgs e)
        {
            frmBillDetails fromDetails = new frmBillDetails();
            fromDetails.Show();
            this.Hide();
        }

        private void btnSupplierManage_Click(object sender, EventArgs e)
        {
            frmSupplier fromSupplier = new frmSupplier();
            fromSupplier.Show();
            this.Hide();
        }

        private void btnRevenueManagement_Click(object sender, EventArgs e)
        {
            frmRevenueStatistics frmRevenue = new frmRevenueStatistics();
            frmRevenue.Show();
            this.Hide();
        }
    }
}
