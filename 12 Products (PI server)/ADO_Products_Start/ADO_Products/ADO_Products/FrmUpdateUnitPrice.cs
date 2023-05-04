using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_Products
{
    public partial class FrmUpdateUnitPrice : Form
    {
        Product product = null;
        public FrmUpdateUnitPrice(Product pro)
        {
            product = pro;
            InitializeComponent();
        }

        private void FrmUpdateUnitPrice_Load(object sender, EventArgs e)
        {
            txtOldUnitPrice.Text = product.UnitPrice.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            product.UnitPrice = float.Parse(txtNewUnitPrice.Text);
            ProductRepository.Update(product);
            Close();
        }
    }
}
