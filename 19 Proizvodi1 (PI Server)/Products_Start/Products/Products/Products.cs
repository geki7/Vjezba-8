using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public int MinStock { get; set; }
        public float UnitPrice { get; set; }
        public double StockValue { get; set; }
        public string Username { get; set; }

        public Products()
        {
                
        }
    }
}
