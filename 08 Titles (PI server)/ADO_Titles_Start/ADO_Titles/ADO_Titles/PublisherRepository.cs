using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Titles
{
    public class PublisherRepository
    {
        public static Publisher DohvatiPublishera(SqlDataReader dr)
        {
            Publisher p = null;
            if(dr != null)
            {
                p = new Publisher();
                p.PubId = dr["pub_id"].ToString();
                p.PubName = dr["pub_name"].ToString();
            }
            return p;
        }

        public static List<Publisher> DohvatiPublishere()
        {
            List<Publisher> lista = new List<Publisher>();
            string sql = "SELECT * FROM publishers";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sql);
            while (dr.Read())
            {
                Publisher p = DohvatiPublishera(dr);
                lista.Add(p);
            }
            return lista;
        }
    }
}
