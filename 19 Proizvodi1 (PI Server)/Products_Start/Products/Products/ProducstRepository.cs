using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    public static class ProducstRepository
    {
        public static Products DohvatiProdukte(SqlDataReader dr)
        {
            Products pro = null;
            if(dr != null)
            {
                pro = new Products();
                pro.Id = int.Parse(dr["Id"].ToString());
                pro.Name = dr["Name"].ToString();
                pro.InStock = int.Parse(dr["InStock"].ToString());
                pro.MinStock = int.Parse(dr["MinStock"].ToString());
                pro.UnitPrice = float.Parse(dr["UnitPrice"].ToString());
                pro.StockValue = double.Parse(dr["StockValue"].ToString());
                pro.Username = dr["Username"].ToString();
            }
            return pro;
        }

        public static List<Products> DohvatiSveProdukte()
        {
            List<Products> list = new List<Products>();
            string sql = "SELECT * FROM products";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sql);
            while (dr.Read())
            {
                Products pro = DohvatiProdukte(dr);
                list.Add(pro);
            }
            return list;
        }
    }
}
