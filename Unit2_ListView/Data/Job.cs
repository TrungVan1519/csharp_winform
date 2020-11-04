using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit2_ListView.Data
{
    class Job
    {
        public int ID { get; set; }
        public string name { get; set; }
        public List<People> listPeople { get; set; }
        public Job(int ID, string name)
        {
            listPeople = new List<People>();
            this.ID = ID;
            this.name = name;
        }
        public void addData(People existClass)
        {
            listPeople.Add(existClass);
            existClass.theirJob = this;
        }
    }
}
