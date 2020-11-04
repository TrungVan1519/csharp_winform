using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit2_ListView.Data
{
    class Data
    {
        public List<Job> listJob = new List<Job>();
        public void getData()
        {
            Job singer = new Job(1, "Singer");
            Job actor = new Job(2, "Actor");
            Job gamer = new Job(3, "Gamer");

            listJob.Add(singer);
            listJob.Add(actor);
            listJob.Add(gamer);

            People singer1 = new People(1, "Adam Levin", true, new DateTime(1995, 12, 12));
            People singer2 = new People(2, "Katy Perry", false, new DateTime(1992, 2, 1));
            People singer3 = new People(3, "Taylor Swift", false, new DateTime(1993, 3, 10));
            People singer4 = new People(4, "Justin Bieber", true, new DateTime(1899, 9, 9));
            singer.addData(singer1);
            singer.addData(singer2);
            singer.addData(singer3);
            singer.addData(singer4);

            People actor1 = new People(1, "Thủy Tiên", false, new DateTime(1987, 1, 12));
            People actor2 = new People(2, "Pichuu", false, new DateTime(1999, 12, 12));
            People actor3 = new People(3, "Chloe Bennet", false, new DateTime(1989, 3, 12));
            People actor4 = new People(4, "Christ Evan", true, new DateTime(1992, 1, 12));
            actor.addData(actor1);
            actor.addData(actor2);
            actor.addData(actor3);
            actor.addData(actor4);

            People gamer1 = new People(1, "Misthy", false, new DateTime(1987, 1, 12));
            People gamer2 = new People(2, "Win.D", true, new DateTime(1999, 2, 12));
            People gamer3 = new People(3, "PongTV", true, new DateTime(1989, 3, 12));
            People gamer4 = new People(4, "DungCT", true, new DateTime(1992, 4, 12));
            gamer.addData(gamer1);
            gamer.addData(gamer2);
            gamer.addData(gamer3);
            gamer.addData(gamer4);
        }
    }
}
