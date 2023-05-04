using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_EmployeesJob
{
    public static class EmployeesRepository
    {
        public static Employees DohvatiEmployee(SqlDataReader dr)
        {
            Employees emoployee = null;
            if(dr != null)
            {
                emoployee = new Employees();
                emoployee.Id = dr["emp_id"].ToString();
                emoployee.FName = dr["fname"].ToString();
                emoployee.Lname = dr["lanme"].ToString();
                emoployee.JobId = int.Parse(dr["job_id"].ToString());
                emoployee.PubId = dr["pub_id"].ToString();
                emoployee.HireDate = DateTime.Parse(dr["hire_date"].ToString());
            }
            return emoployee;
        }

        public static List<Employees> DohvatiEmployeese()
        {
            List<Employees> lista = new List<Employees>();
            string sqlUpit = "SELECT * FROM employee";
            SqlDataReader dr = DB.Instance.DohvatiDataReaded(sqlUpit);
            while (dr.Read())
            {
                Employees employee = DohvatiEmployee(dr);
                lista.Add(employee);
            }
            return lista;
        }
    }
}
