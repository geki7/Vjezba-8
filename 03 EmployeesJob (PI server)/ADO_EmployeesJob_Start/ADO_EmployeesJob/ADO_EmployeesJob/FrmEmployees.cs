using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_EmployeesJob
{
    public partial class FrmEmployees : Form
    {
        public FrmEmployees()
        {
            InitializeComponent();
        }

        private void FrmEmployees_Load(object sender, EventArgs e)
        {
            OsvjeziEmployees();
        }

        private void btnChangeJob_Click(object sender, EventArgs e)
        {

        }
        private void OsvjeziEmployees()
        {
            dgvEmployees.DataSource = null;
            dgvEmployees.DataSource = EmployeesRepository.DohvatiEmployeese();
        }
    }
}
