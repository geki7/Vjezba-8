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
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = CategoryRepository.DohvatiCatergorys().ToList();
            Osvjezi();
        }

        private void btnShowProducts_Click(object sender, EventArgs e)
        {
            Category category = cmbCategory.SelectedItem as Category;
            Product product = new Product();
            product.CategoryID = category.CategoryID;
            dgvProducts.DataSource = ProductRepository.DohvatiProductsFilter(product);
        }

        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            Product product = dgvProducts.CurrentRow.DataBoundItem as Product;
            FrmUpdateUnitPrice frmUpdateUnitPrice = new FrmUpdateUnitPrice(product);
            frmUpdateUnitPrice.ShowDialog();
            Osvjezi();
        }
        
        public void Osvjezi()
        {
            dgvProducts.DataSource = ProductRepository.DohvatiProducts();
        }
    }
}
