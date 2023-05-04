using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Orders
{
    public static class CustomerRepository
    {
        public static Customer DohvatiCustomera(SqlDataReader dr)
        {
            Customer customer = null;
            if(dr != null)
            {
                customer = new Customer();
                customer.CustomerID = dr["CustomerID"].ToString();
                customer.CompanyName = dr["CompanyName"].ToString();
            }
            return customer;
        }

        public static List<Customer> DohvatiCustomere()
        {
            List<Customer> lista = new List<Customer>();
            string sql = "SELECT * FROM customers";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sql);
            while (dr.Read())
            {
                Customer customer = DohvatiCustomera(dr);
                lista.Add(customer);
            }
            return lista;
        }
    }
}
