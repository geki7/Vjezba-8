using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Jobs
{
    public class Employees
    {
        public string Id { get; set; }
        public string FName { get; set; }
        public string Lname { get; set; }
        public int JobId { get; set; }
        public string PublisherId { get; set; }
        public DateTime HireDate { get; set; }

        public Employees()
        {

        }
    }
}
