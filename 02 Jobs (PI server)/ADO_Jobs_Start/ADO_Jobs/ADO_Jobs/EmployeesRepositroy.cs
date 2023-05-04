using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Jobs
{
    public class EmployeesRepositroy
    {
        public static Employees DohvatiEmploye(SqlDataReader dr)
        {
            Employees employees = null;
            if(dr != null)
            {
                employees = new Employees();
                employees.Id = dr["emp_id"].ToString();
                employees.FName = dr["fname"].ToString();
                employees.Lname = dr["lname"].ToString();
                employees.JobId = int.Parse(dr["job_id"].ToString());
                employees.PublisherId = dr["pub_id"].ToString();
                employees.HireDate = Convert.ToDateTime(dr["hire_date"].ToString());
            }
            return employees;
        }

        public static List<Employees> DohvatiEmployees(Jobs jobs)
        {
            List<Employees> lista = new List<Employees>();
            string sqlUpit = $"SELECT * FROM employee WHERE job_id = {jobs.Id}";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Employees employees = DohvatiEmploye(dr);
                lista.Add(employees);
            }
            dr.Close();
            return lista;
        }
    }
}
