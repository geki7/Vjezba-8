using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Employees
{
    public static class EmployeeRepository
    {
        public static Employee DohvatiEmployee(SqlDataReader dr)
        {
            Employee emp = new Employee();
            if(dr != null)
            {
                emp = new Employee();
                emp.EmpId = dr["emp_id"].ToString();
                emp.FName = dr["fname"].ToString();
                emp.LName = dr["lname"].ToString();
                emp.JobId = int.Parse(dr["job_id"].ToString());
                emp.PubId = dr["pub_id"].ToString();
                emp.HireDate = DateTime.Parse(dr["hire_date"].ToString());
            }
            return emp;
        }

        public static List<Employee> DohvatiEmployees()
        {
            List<Employee> lista = new List<Employee>();
            string sql = "SELECT * FROM employee";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sql);
            while (dr.Read())
            {
                Employee employee = DohvatiEmployee(dr);
                lista.Add(employee);
            }
            return lista;
        }

        public static int Dodaj(Employee employee)
        {
            string sql = "INSERT INTO employee (emp_id, fname, lname, job_id, pub_id)" + $"VALUES ('{employee.EmpId}','{employee.FName}','{employee.LName}','{employee.JobId}','{employee.PubId}')";
            int i = DB.Instance.IzvrsiUpit(sql);
            return i;
        }
    }
}
