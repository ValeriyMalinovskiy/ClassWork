using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Task4
    {
        public static void PrintPupilTable()
        {
            Pupil[] pupilsTable =
            {
            new Pupil("Вася","Пупкин", (new DateTime(2013, 1, 10))),
            new Pupil("Иван","Петров", (new DateTime(2012, 12, 6))),
            new Pupil("Пётр","Иванов", (new DateTime(2013, 2, 1))),
            new Pupil("Наташа","Иванова", (new DateTime(2013, 1, 1))),
            new Pupil("Катя","Петрова", (new DateTime(2012, 11, 10)))
            };

            pupilsTable[0].ClassName = "2А";
            pupilsTable[1].ClassName = "2Б";
            pupilsTable[2].ClassName = "1А";
            pupilsTable[3].ClassName = "2В";
            pupilsTable[4].ClassName = "2А";

            pupilsTable[0].SchoolNumber = 162;
            pupilsTable[1].SchoolNumber = 86;
            pupilsTable[2].SchoolNumber = 162;
            pupilsTable[3].SchoolNumber = 162;
            pupilsTable[4].SchoolNumber = 87;

            String s = String.Format("{0,-15} {1,-15} {2,-7} {3,-8} {4,-10} \n\n", "Name", "Year of birth", "Age", "School", "Class");

            for (int i = 0; i < pupilsTable.Length; i++)
            {
                s += String.Format("{0,-15} {1,-15} {2,-7} {3,-8} {4,-10} \n", pupilsTable[i].GetName(), pupilsTable[i].GetYear(), pupilsTable[i].GetAge(), pupilsTable[i].SchoolNumber, pupilsTable[i].ClassName);
            }
            Console.WriteLine(s);
        }
    }
}
