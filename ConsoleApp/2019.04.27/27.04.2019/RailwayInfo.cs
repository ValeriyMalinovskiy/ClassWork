using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019Apr27
{
    class RailwayInfo
    {
        private static Train[] GetTrainDataBase()
        {
            Train[] trainsDb =
            {
                new Train("Kharkiv-Odesa", 1, DateTime.Now + TimeSpan.FromMinutes(10)),
                new Train("Kharkiv-Lviv", 2, DateTime.Now + TimeSpan.FromMinutes(20)),
                new Train("Kharkiv-Kiyv", 3, DateTime.Now + TimeSpan.FromMinutes(30)),
                new Train("Kharkiv-Uman'", 4, DateTime.Now + TimeSpan.FromMinutes(40)),
                new Train("Kharkiv-Moscow", 5, DateTime.Now + TimeSpan.FromMinutes(50)),
                new Train("Kharkiv-Minsk", 6, DateTime.Now + TimeSpan.FromHours(1)),
                new Train("Kharkiv-Yasinya", 7, DateTime.Now + TimeSpan.FromHours(2)),
                new Train("Kharkiv-Belgorod", 8, DateTime.Now + TimeSpan.FromHours(3))
            };
            return trainsDb;
        }

        public void ShowTrainInfo()
        {
            Console.WriteLine("Enter the train number");
            string trainNum = Console.ReadLine();
            Console.Clear();
            Train[] trainsDb = GetTrainDataBase();
            Train tr = new Train();
            for (int i = 0; i < trainsDb.Length; i++)
            {
                if (int.Parse(trainNum) == trainsDb[i].GetTrainNumber())
                {
                    tr = trainsDb[i];
                }
            }
            if (tr.GetTrainNumber()!=0)
            {
                Console.WriteLine(tr.GetTrainNumber() + "\t" + tr.GetTrainName() +
                    "\t" + tr.GetDepartureTime().ToShortTimeString());
            }
            else Console.WriteLine("Such a train number does not exist in the database");
        }
    }
}
