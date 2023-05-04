using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Titles
{
    public class Title
    {
        public string TitleId { get; set; }
        public string BookTitle { get; set; } //Title
        public string Type { get; set; }
        public string PubId { get; set; }
        public DateTime PubDate { get; set; }
    }
}
