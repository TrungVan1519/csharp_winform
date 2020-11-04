using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit2_ListView.Data
{
    class People
    {
        public People(int ID, string name, bool gender, DateTime birthday)
        {
            this.ID = ID;
            this.name = name;
            this.gender = gender;
            this.birthday = birthday;
        }
        public int ID { get; set; }
        public string name { get; set; }
        public bool gender { get; set; }
        public DateTime birthday { get; set; }
        public Job theirJob { get; set; }
    }
}
