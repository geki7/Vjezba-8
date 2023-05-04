using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Employees
{
    public class PublisherRepoistory
    {
        public static Publisher DohavatiPublishera(SqlDataReader dr)
        {
            Publisher pub = null;
            if(dr != null)
            {
                pub = new Publisher();
                pub.PubId = dr["pub_id"].ToString();
                pub.PubName = dr["pub_name"].ToString();
            }
            return pub;
        }

        public static List<Publisher> DohvatiPublishere()
        {
            List<Publisher> lista = new List<Publisher>();
            string sql = "SELECT * FROM publishers";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sql);
            while (dr.Read())
            {
                Publisher publisher = DohavatiPublishera(dr);
                lista.Add(publisher);
            }
            return lista;
        }
    }
}
