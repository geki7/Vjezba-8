using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Jobs
{
    public static class JobsRepositroy
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
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Jobs jobs = DohvatiJob(dr);
                lista.Add(jobs);
            }
            dr.Close();
            return lista;
        }

        public static int Spremi(Jobs jobs)
        {
            DB.Instance.Connect();
            string sqlUpit = "";
            sqlUpit = $"INSERT INTO jobs (job_desc, min_lvl, max_lvl) " + $"VALUES ('{jobs.Description}', '{jobs.MinLvl}', '{jobs.MaxLvl}'";
            int i = DB.Instance.IzvrsiUpit(sqlUpit);
            DB.Instance.CloseConetion();
            return i;
        }
    }
}
