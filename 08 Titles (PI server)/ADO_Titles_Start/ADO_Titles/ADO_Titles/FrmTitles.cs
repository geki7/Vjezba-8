using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_Titles
{
    public partial class FrmTitles : Form
    {
        public FrmTitles()
        {
            InitializeComponent();
        }

        private void FrmTitles_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }


        private void btnAddTitle_Click(object sender, EventArgs e)
        {
            FrmAddTitle frmAddTitle = new FrmAddTitle();
            frmAddTitle.ShowDialog();
            Osvjezi();
        }

        public void Osvjezi()
        {
            dgvTitles.DataSource = TitleRepository.DohvatiTitlove();
        }
    }
}
