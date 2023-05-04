using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Jobs
{
    public class Jobs
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int MinLvl { get; set; }
        public int MaxLvl { get; set; }

        public Jobs()
        {

        }
    }
}
