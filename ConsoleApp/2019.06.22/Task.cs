using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._06._22
{
    class Task
    {
        public string CreationDate { get; private set; }

        public Task()
        {
            System.Threading.Thread.Sleep(10);
            this.CreationDate = DateTime.Now.TimeOfDay.ToString();
        }

        public string CompleteTask()
        {
            return $"Task from {this.CreationDate} is cleared from the backlog";
        }
    }
}
