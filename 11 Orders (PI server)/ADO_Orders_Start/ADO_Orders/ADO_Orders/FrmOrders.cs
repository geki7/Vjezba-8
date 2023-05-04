using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_Orders
{
    public partial class FrmOrders : Form
    {
        public FrmOrders()
        {
            InitializeComponent();
        }

        private void FrmOrders_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void DisplayOrders()
        {

        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            FrmAddOrder frmAddOrder = new FrmAddOrder();
            frmAddOrder.ShowDialog();
            Osvjezi();
        }
        
        public void Osvjezi()
        {
            dgvOrders.DataSource = OrderRepository.DohvatiOrdere();
        }
    }
}
