using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._09._29
{
    class Year
    {
        public int YearNumber { get; set; }

        public Year(int year)
        {
            this.YearNumber = year;
        }

        private bool IsLeapYear()
        {
            if (this.YearNumber % 4 == 0 && this.YearNumber % 100 == 0 && this.YearNumber % 400 != 0)
            {
                return true;
            }
            return false;
        }

        public int GetNumberOfDays()
        {
            if (this.IsLeapYear())
            {
                return 366;
            }
            return 365;
        }
    }
}
