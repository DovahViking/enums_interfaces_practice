using System;

namespace enums_and_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Caravan delivery_caravan = new Caravan(); // --- strings are just pre-requisites for now use references for for things that needs more data such as sender ---
            delivery_caravan.transport_time(2000);
            Console.WriteLine($"Caravan left the city at {DateTime.Now}");

            Trade first_trade = new Trade(780, "Horse", IGoods.TradeGoodsType.Steppe_Horse);
            Console.WriteLine("--- First Trade --- {0}", first_trade);
            Trade second_trade = new Trade(11, "Food", IGoods.TradeGoodsType.Grain);
            Console.WriteLine("--- Second Trade --- {0}", second_trade);

            Console.ReadKey(); // Lots of time wasted figuring out why the Timer didn't execute the EventHandler
        }
    }
}
