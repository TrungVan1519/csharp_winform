using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7_File.Data
{
    class People
    {
        public int Rank { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public People(int Rank, string Name, DateTime Birthday)
        {
            this.Rank = Rank;
            this.Name = Name;
            this.Birthday = Birthday;
        }
    }
}
