using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_Employees
{
    public partial class FrmAddEmployee : Form
    {
        public FrmAddEmployee()
        {
            InitializeComponent();
        }

        private void FrmAddEmployee_Load(object sender, EventArgs e)
        {
            cmbJob.DataSource = JobRepository.DohvatiJobs().ToList();
            cmbPublisher.DataSource = PublisherRepoistory.DohvatiPublishere().ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee novi = new Employee();
            novi.EmpId = txtEmpId.Text;
            novi.FName = txtFName.Text;
            novi.LName = txtLName.Text;
            Job job = cmbJob.SelectedItem as Job;
            Publisher publisher = cmbPublisher.SelectedItem as Publisher;
            novi.JobId = job.JobId;
            novi.PubId = publisher.PubId;

            EmployeeRepository.Dodaj(novi);
            DialogResult = DialogResult.OK;
            Close();

        }
    }
}
