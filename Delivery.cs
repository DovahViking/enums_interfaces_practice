using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace enums_and_interfaces
{
    class Caravan : ITransport
    {
        public string sender { get; set; }
        public string city { get; set; }
        public string cargo { get; set; }
        public int guards { get; set; }

        public Caravan (string sender, string city, string cargo, int guards)
        {
            this.sender = sender;
            this.city = city;
            this.cargo = cargo;
            this.guards = guards;
        }

        public void transport_time(int delivery_time)
        {
            Timer time = new Timer(delivery_time);
            time.Elapsed += new ElapsedEventHandler(out_of_time);
            time.Start();
            time.AutoReset = false;
            time.Enabled = true;

        }

        private static void out_of_time(object source, ElapsedEventArgs e)
        {
            Console.WriteLine($"The Caravan didn't make the delivery in time... {e.SignalTime}");
        }
    }
}
