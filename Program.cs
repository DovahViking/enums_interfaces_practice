using System;

namespace enums_and_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Trade first_trade = new Trade(780, "Horse", IGoods.TradeGoodsType.Steppe_Horse);
            Console.WriteLine("--- First Trade --- {0}", first_trade);
            Trade second_trade = new Trade(11, "Food", IGoods.TradeGoodsType.Grain);
            Console.WriteLine("--- Second Trade --- {0}", second_trade);
        }
    }
}
