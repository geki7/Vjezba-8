using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_EmployeesJob
{
    public static class JobsRepository
    {
        public static Jobs DohvatiJob(SqlDataReader dr)
        {
            Jobs job = null;
            if(dr != null)
            {
                job = new Jobs();
                job.Id = int.Parse(dr["job_id"].ToString());
                job.Description = dr["job_desc"].ToString();
                job.MinLvl = int.Parse(dr["min_lvl"].ToString());
                job.MaxLvl = int.Parse(dr["max_lvl"].ToString());
            }
            return job;
        }

        public static List<Jobs> DohvatiJobs()
        {
            List<Jobs> lista = new List<Jobs>();
            string sqlUpit = "SELECT * FROM jobs";
            SqlDataReader dr = DB.Instance.DohvatiDataReaded(sqlUpit);
            while (dr.Read())
            {
                Jobs jobs = DohvatiJob(dr);
                lista.Add(jobs);    
            }
            dr.Close();
            return lista;
        }

        public static int PromjeniJob(Employees employees, Jobs odabrani)
        {
            DB.Instance.Connect();
            string sqlUpit = $"UPDATE employee SET job_id = '{odabrani.Id}' WHERE emp_id = '{employees.Id}'";
            int i = DB.Instance.IzvriUpit(sqlUpit);
            DB.Instance.Disconnect();
            return i;
        }
    }
}
