using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_Authors
{
    public partial class FrmAuthors : Form
    {
        public FrmAuthors()
        {
            InitializeComponent();
        }

        private void FrmAuthors_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            FrmAddAuthor frmAddAuthor = new FrmAddAuthor();
            frmAddAuthor.ShowDialog();
            Osvjezi();
        }

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            Author a = dgvAuthors.CurrentRow.DataBoundItem as Author;
            AuthorRepository.Obrisi(a);
            Osvjezi();
        }

        public void Osvjezi()
        {
            dgvAuthors.DataSource = AuthorRepository.DohvatiAutore();
        }
    }
}
