using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Employees
{
    public  class Publisher
    {
        public string PubId { get; set; }
        public string PubName { get; set; }

        public override string ToString()
        {
            return PubName;
        }
    }
}
