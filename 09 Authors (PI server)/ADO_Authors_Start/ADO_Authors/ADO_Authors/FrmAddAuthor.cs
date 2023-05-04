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
    public partial class FrmAddAuthor : Form
    {
        public FrmAddAuthor()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Author a = new Author();
            a.AuId = txtAuId.Text;
            a.AuLname = txtAuLName.Text;
            a.AuFname = txtAuFName.Text;
            a.Phone = txtPhone.Text;
            AuthorRepository.Dodaj(a);
            Close();
        }

        private void FrmAddAuthor_Load(object sender, EventArgs e)
        {

        }
    }
}
