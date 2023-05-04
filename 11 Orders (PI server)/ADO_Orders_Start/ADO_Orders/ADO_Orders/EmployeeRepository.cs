using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Orders
{
    public static class EmployeeRepository
    {
        public static Employee DohvatiEmployee(SqlDataReader dr)
        {
            Employee emp = null;
            if(dr != null)
            {
                emp = new Employee();
                emp.EmployeeID = int.Parse(dr["EmployeeID"].ToString());
                emp.LastName = dr["LastName"].ToString();
                emp.FirstName = dr["FirstName"].ToString();
            }
            return emp;
        }

        public static List<Employee> DohvatiEmployees()
        {
            List<Employee> lista = new List<Employee>();
            string sql = "SELECT * FROM employees";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sql);
            while (dr.Read())
            {
                Employee emp = DohvatiEmployee(dr);
                lista.Add(emp);
            }
            return lista;
        }
    }
}
