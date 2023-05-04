using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Titles
{
    public class TitleRepository
    {
        public static Title DohvatiTitle(SqlDataReader dr)
        {
            Title t = null;
            if(dr != null)
            {
                t = new Title();
                t.TitleId = dr["title_id"].ToString();
                t.BookTitle = dr["title"].ToString();
                t.Type = dr["type"].ToString();
                t.PubId = dr["pub_id"].ToString();
                t.PubDate = DateTime.Parse(dr["pubdate"].ToString());
            }
            return t;
        }

        public static List<Title> DohvatiTitlove()
        {
            List<Title> lista = new List<Title>();
            string sql = "SELECT * FROM titles";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sql);
            while (dr.Read())
            {
                Title title = DohvatiTitle(dr);
                lista.Add(title);
            }
            return lista;
        }

        public static List<Title> DohvatiTitloveTIPS()
        {
            List<Title> lista = new List<Title>();
            string sql = "SELECT DISTINCT type * FROM titles";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sql);
            while (dr.Read())
            {
                Title title = DohvatiTip(dr);
                lista.Add(title);
            }
            return lista;
        }

        public static Title DohvatiTip(SqlDataReader dr)
        {
            Title title = null;
            if(dr != null)
            {
                title = new Title();
                title.Type = dr["type"].ToString();
            }
            return title;
        }

        public static int Dodaj(Title novi)
        {
            string sql = "INSER INTO titles (title_id, title, type, pub_id" + $"VALUES ('{novi.TitleId}','{novi.BookTitle}','{novi.Type}','{novi.PubId}')";
            int i = DB.Instance.IzvrsiUpit(sql);
            return i;
        }
    }
}
