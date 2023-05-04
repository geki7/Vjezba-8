using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_PublishersEmployees
{
    public class Employee
    {
        public string EmpId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int JobId { get; set; }
        public int PubId { get; set; }
        public DateTime HireDate { get; set; }

        public Employee()
        {

        }
    }
}
