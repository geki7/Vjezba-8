using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Authors
{
    public static class AuthorRepository
    {
        public static Author DohvatiAutora(SqlDataReader dr)
        {
            Author a = null;
            if(dr != null)
            {
                a = new Author();
                a.AuId = dr["au_id"].ToString();
                a.AuLname = dr["au_lname"].ToString();
                a.AuFname = dr["au_fname"].ToString();
                a.Phone = dr["phone"].ToString();
            }
            return a;
        }
        
        public static List<Author> DohvatiAutore()
        {
            List<Author> lista = new List<Author>();
            string sql = "SELECT * FROM authors";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sql);
            while (dr.Read())
            {
                Author a = DohvatiAutora(dr);
                lista.Add(a);
            }
            return lista;
        }

        public static int Dodaj(Author authors)
        {
            string sql = "INSERT INTO authors (au_id, au_lname, au_fname, phone)" + $"VALUES ('{authors.AuId}','{authors.AuLname}','{authors.AuFname}','{authors.Phone}')";
            int i = DB.Instance.IzvrsiUpit(sql);
            return i;
        }

        public static int Obrisi(Author a)
        {
            string sql = $"DELETE FROM authors WHERE au_id = '{a.AuId}'";
            int i = DB.Instance.IzvrsiUpit(sql);
            return i;
        }
    }
}
