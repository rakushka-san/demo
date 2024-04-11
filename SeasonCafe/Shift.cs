using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasonCafe
{
    internal class Shift
    {
        public int id { get; set; }
        public string date { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public List<Staff> staff { get; set; }

        public Shift(int id, string date, string start, string end, List<Staff> staff)
        {
            this.id = id;
            this.date = date;
            this.start = start;
            this.end = end;
            this.staff = staff;
        }

        public Shift(string date, string start, string end)
        {
            this.date = date;
            this.start = start;
            this.end = end;
        }
    }
}
