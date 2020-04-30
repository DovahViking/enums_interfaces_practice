using System;

namespace enums_and_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Lord lord_1 = new Lord("Dovah", "Viking", 24, "Sturgia");
            Lord lord_2 = new Lord("Raganvad", "Gundaroving", 45, "Sturgia");
            Lord.get_lords();

            Caravan delivery_caravan = new Caravan(lord_1.name, "Sibir", "Fish", 40); // --- strings are just pre-requisites for now use references for for things that needs more data such as sender ---
            delivery_caravan.transport_time(2000);
            Console.WriteLine($"\nCaravan left the city at {DateTime.Now}\n");

            Trade first_trade = new Trade(780, "Horse", IGoods.TradeGoodsType.Steppe_Horse);
            Console.WriteLine("--- First Trade --- {0}", first_trade);
            Trade second_trade = new Trade(11, "Food", IGoods.TradeGoodsType.Grain);
            Console.WriteLine("--- Second Trade --- {0}", second_trade);

            Console.ReadKey();
        }
    }
}
