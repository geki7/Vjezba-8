using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ADO_Jobs
{
    public partial class FrmJobsEmployees : Form
    {
        public FrmJobsEmployees()
        {
            InitializeComponent();
        }

        private void FrmJobsEmployees_Load(object sender, EventArgs e)
        {
            OsvjeziJobs();
            OsvjeziEmployees();
        }

        private void dgvJobs_SelectionChanged(object sender, EventArgs e)
        {
    
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {

        }

        private void OsvjeziJobs()
        {
            List<Jobs> lista = JobsRepositroy.DohvatiJobs();
            dgvJobs.DataSource = lista;
        }

        private void OsvjeziEmployees()
        {
            dgvEmployees.DataSource = null;
            Jobs odabrani = dgvJobs.CurrentRow.DataBoundItem as Jobs;
            if(odabrani != null)
            {
                List<Employees> lista = EmployeesRepositroy.DohvatiEmployees(odabrani);
                dgvEmployees.DataSource = lista;
            }
        }
       
    }
}
