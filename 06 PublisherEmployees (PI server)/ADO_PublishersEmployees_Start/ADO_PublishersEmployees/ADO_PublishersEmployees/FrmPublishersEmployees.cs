using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_PublishersEmployees
{
    public partial class FrmPublishersEmployees : Form
    {
        public FrmPublishersEmployees()
        {
            InitializeComponent();
        }

        private void FrmPublishersEmployees_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void dgvPublishers_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            Publishers novi = new Publishers();
            novi.PubId = txtPubId.Text;
            novi.PubName = txtPubName.Text;
            novi.City = txtCity.Text;
            novi.State = txtState.Text;
            novi.Country = txtCountry.Text;

            PublisherRepository.Dodaj(novi);
            Osvjezi();
        }
        public void Osvjezi()
        {
            dgvEmployees.DataSource = EmployeesRepository.DohvatiEmployeese();
            dgvPublishers.DataSource = PublisherRepository.DohvatiPublishere();
        }
    }
}
