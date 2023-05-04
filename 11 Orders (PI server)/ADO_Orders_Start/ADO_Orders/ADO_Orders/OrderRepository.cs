using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Orders
{
    public static class OrderRepository
    {
        public static Order DohvatiOrder(SqlDataReader dr)
        {
            Order order = null;
            if(dr != null)
            {
                order = new Order();
                order.OrderID = int.Parse(dr["OrderID"].ToString());
                order.CustomerID = dr["CustomerID"].ToString();
                order.EmployeeID = int.Parse(dr["EmployeeID"].ToString());
                order.ShipCity = dr["ShipCity"].ToString();
                order.ShipCountry = dr["ShipCountry"].ToString();
            }
            return order;
        }

        public static List<Order> DohvatiOrdere()
        {
            List<Order> lista = new List<Order>();
            string sql = "SELECT * FROM orders";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sql);
            while (dr.Read())
            {
                Order order = DohvatiOrder(dr);
                lista.Add(order);
            }
            return lista;
        }

        public static int Dodaj(Order nova)
        {
            string sql = "INSERT INTO Orders (CustomerID, EmployeeID, ShipCity, ShipCountry)" + $"VALUES ('{nova.CustomerID}','{nova.EmployeeID}','{nova.ShipCity}','{nova.ShipCountry}')";
            int i = DB.Instance.IzvrsiUpit(sql);
            return i;
        }
    }
}
