﻿using System;

namespace _2019._06._22
{
    internal class Task
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