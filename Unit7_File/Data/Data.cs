using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit7_File.Data
{
    class Data
    {
        public List<People> people = new List<People>();

        public void getData()
        {
            People p1 = new People(1, "Trung", new DateTime(1999, 01, 15));
            People p2 = new People(2, "Van", DateTime.Today);
            People p3 = new People(3, "Dao", DateTime.MaxValue);

            people.Add(p1);
            people.Add(p2);
            people.Add(p3);
        }
    }
}
