using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_PublishersEmployees
{
    public static class EmployeesRepository
    {
        public static Employee DohvatiEmployee(SqlDataReader dr)
        {
            Employee employees = null;
            if(dr != null)
            {
                employees = new Employee();
                employees.EmpId = dr["emp_id"].ToString();
                employees.FName = dr["fname"].ToString();
                employees.LName = dr["lname"].ToString();
                employees.JobId = int.Parse(dr["job_id"].ToString());
                employees.PubId = int.Parse(dr["pub_id"].ToString());
                employees.HireDate = DateTime.Parse(dr["hire_date"].ToString());
            }
            return employees;
        }

        public static List<Employee> DohvatiEmployeese()
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
    }
}
