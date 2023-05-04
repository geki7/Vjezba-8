using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_Orders
{
    public partial class FrmAddOrder : Form
    {
        public FrmAddOrder()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAddOrder_Load(object sender, EventArgs e)
        {
            cmbCustomer.DataSource = CustomerRepository.DohvatiCustomere().ToList();
            cmbEmployee.DataSource = EmployeeRepository.DohvatiEmployees().ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer customer = cmbCustomer.SelectedItem as Customer;
            Employee employee = cmbEmployee.SelectedItem as Employee;
            Order novi = new Order();
            novi.CustomerID = customer.CustomerID;
            novi.EmployeeID = employee.EmployeeID;
            novi.ShipCity = txtShipCity.Text;
            novi.ShipCountry = txtShipCity.Text;

            OrderRepository.Dodaj(novi);
            Close();
        }
    }
}
