using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Products
{
    public static class CategoryRepository
    {
        public static Category DohvatiCategory(SqlDataReader dr)
        {
            Category category = null;
            if(dr != null)
            {
                category = new Category();
                category.CategoryID = int.Parse(dr["CategoryID"].ToString());
                category.CategoryName = dr["CategoryName"].ToString();
            }
            return category;
        }

        public static List<Category> DohvatiCatergorys()
        {
            List<Category> list = new List<Category>();
            string sql = "SELECT * FROM categories";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sql);
            while (dr.Read())
            {
                Category cat = DohvatiCategory(dr);
                list.Add(cat);
            }
            return list;
        }
    }
}
