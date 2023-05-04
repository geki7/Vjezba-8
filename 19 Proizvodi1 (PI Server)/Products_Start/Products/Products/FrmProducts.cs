using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        public void Osvjezi()
        {
            dgvProducts.DataSource = ProducstRepository.DohvatiSveProdukte();
        }
    }
}
