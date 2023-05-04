using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Employees
{
    public class JobRepository
    {
        public static Job DohvatiJob(SqlDataReader dr)
        {
            Job job = null;
            if(dr != null)
            {
                job = new Job();
                job.JobDesc = dr["job_desc"].ToString();
                job.JobId = int.Parse(dr["job_id"].ToString());
            }
            return job;
        }

        public static List<Job> DohvatiJobs()
        {
            List<Job> lista = new List<Job>();
            string sql = "SELECT * FROM jobs";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sql);
            while (dr.Read())
            {
                Job jobs = DohvatiJob(dr);
                lista.Add(jobs);
            }
            return lista;
        }
    }
}
