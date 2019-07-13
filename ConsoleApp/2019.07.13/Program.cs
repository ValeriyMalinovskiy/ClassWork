using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019._07._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            m.Manage();
        }
    }

    internal class Manager
    {
        Ping ping = new Ping();
        Pong pong = new Pong();
        public void Manage()
        {
            ping.PingEvent += OnPingInvoke;
            pong.PongEvent += OnPongInvoke;
            ping.DoPing();
        }

        private void OnPingInvoke(EventArgs e)
        {
            pong.DoPong();
        }
        private void OnPongInvoke(EventArgs e)
        {
            ping.DoPing();
        }

        internal class Ping
        {
            public delegate void PingCompletedDelegate(EventArgs eventArgs);
            public event PingCompletedDelegate PingEvent;
            private void OnPingInvoke(EventArgs e)
            {
                this.PingEvent?.Invoke(e);
            }
            public virtual void DoPing()
            {
                Console.WriteLine(this.GetType().Name);
                System.Threading.Thread.Sleep(1000);
                this.OnPingInvoke(new EventArgs());
            }
        }

        internal class Pong
        {
            public delegate void PongCompletedDelegate(EventArgs eventArgs);
            public event PongCompletedDelegate PongEvent;
            private void OnPongInvoke(EventArgs e)
            {
                this.PongEvent?.Invoke(e);
            }
            public virtual void DoPong()
            {
                Console.WriteLine(this.GetType().Name);
                System.Threading.Thread.Sleep(1000);
                this.OnPongInvoke(new EventArgs());
            }
        }
    }
}
