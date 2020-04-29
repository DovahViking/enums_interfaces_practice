using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace enums_and_interfaces
{
    interface ITransport
    {
        string sender { get; set; }
        string customer { get; set; }
        string city { get; set; }
        string cargo { get; set; }
        string caravan_master { get; set; }
        int guards { get; set; }
        void transport_time(int delivery_time);

    }
}
