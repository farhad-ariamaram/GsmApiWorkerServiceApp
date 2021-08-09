using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsmApiApp.Models
{
    public class SMS
    {
        public int Index { get; set; }
        public string Status { get; set; }
        public string Phone { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Body { get; set; }
    }
}
