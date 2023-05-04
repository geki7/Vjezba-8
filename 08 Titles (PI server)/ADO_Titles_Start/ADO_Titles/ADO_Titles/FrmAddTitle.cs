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
    public partial class FrmAddTitle : Form
    {
        public FrmAddTitle()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAddTitle_Load(object sender, EventArgs e)
        {
            
            cmbPublisher.DataSource = PublisherRepository.DohvatiPublishere().ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Title novi = new Title();
            novi.TitleId = txtTitleId.Text;
            novi.BookTitle = txtBookTitle.Text;
            Publisher publisher = cmbPublisher.SelectedItem as Publisher;
            novi.PubId = publisher.PubId;

            TitleRepository.Dodaj(novi);
            Close();
        }
    }
}
