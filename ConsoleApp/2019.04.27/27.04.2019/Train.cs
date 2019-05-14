using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019Apr27
{
    public struct Train
    {
        private string trainName;

        private int trainNumber;

        private DateTime departureTime;

        public Train(string trainName, int trainNumber, DateTime departureTime)
        {
            this.trainName = trainName;
            this.trainNumber = trainNumber;
            this.departureTime = departureTime;
        }

        public int GetTrainNumber()
        {
            return this.trainNumber;
        }
        public string GetTrainName()
        {
            return this.trainName;
        }
        public DateTime GetDepartureTime()
        {
            return this.departureTime;
        }
    }
}
