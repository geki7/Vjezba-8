using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_PublishersEmployees
{
    public static class PublisherRepository
    {
        public static Publishers DohvatiPublishera(SqlDataReader dr)
        {
            Publishers publishers = null;
            if(publishers != null)
            {
                publishers = new Publishers();
                publishers.PubId = dr["pub_id"].ToString();
                publishers.PubName = dr["pub_name"].ToString();
                publishers.City = dr["city"].ToString();
                publishers.State = dr["state"].ToString();
                publishers.Country = dr["country"].ToString();
            }
            return publishers;
        }

        public static List<Publishers> DohvatiPublishere()
        {
            List<Publishers> lista = new List<Publishers>();
            string sql = "SELECT * FROM publishers";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sql);
            while (dr.Read())
            {
                Publishers publishers = DohvatiPublishera(dr);
                lista.Add(publishers);
            }
            return lista;
            dr.Close();
        }

        public static int Dodaj(Publishers pub)
        {
            string sql = "INSERT INTO publishers (pub_id, pub_name, city, state, country)" + $"VALUES ('{pub.PubId}', '{pub.PubName}'. '{pub.City}', '{pub.State}', '{pub.Country}'";
            int i = DB.Instance.IzvrsiUpit(sql);
            return i;
        }
    }
}
