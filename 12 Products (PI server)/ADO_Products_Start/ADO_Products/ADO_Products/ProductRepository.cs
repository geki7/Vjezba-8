using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Products
{
    public static class ProductRepository
    {
        public static Product DohvatiProduct(SqlDataReader dr)
        {
            Product pro = null;
            if(dr != null)
            {
                pro = new Product();
                pro.ProductID = int.Parse(dr["ProductID"].ToString());
                pro.ProductName = dr["ProductName"].ToString();
                pro.CategoryID = int.Parse(dr["CategoryID"].ToString());
                pro.UnitPrice = float.Parse(dr["UnitPrice"].ToString());
            }
            return pro;
        }

        public static List<Product> DohvatiProducts()
        {
            List<Product> list = new List<Product>();
            string sql = "SELECT * FROM products";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sql);
            while (dr.Read())
            {
                Product product = DohvatiProduct(dr);
                list.Add(product);
            }
            return list;
        }

        public static List<Product> DohvatiProductsFilter(Product pro)
        {
            List<Product> list = new List<Product>();
            string sql = $"SELECT * FROM products WHERE CategoryID = '{pro.CategoryID}'";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sql);
            while (dr.Read())
            {
                Product product = DohvatiProduct(dr);
                list.Add(product);
            }
            return list;
        }

        public static int Update(Product pro)
        {
            string sql = $"UPDATE Products SET UnitPrice = '{pro.UnitPrice}' WHERE ProductID = '{pro.ProductID}'";
            int i = DB.Instance.IzvrsiUpit(sql);
            return i;
        }
    }
}
