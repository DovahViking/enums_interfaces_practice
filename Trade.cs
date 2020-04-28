using System;
using System.Collections.Generic;
using System.Text;

namespace enums_and_interfaces
{
    class Trade : IGoods
    {
        public int price { get; set; }
        public string type { get; set; }

        IGoods.TradeGoodsType trade_goods_type; // init enum

        public Trade(int price, string type, IGoods.TradeGoodsType trade_goods_type)
        {
            this.price = price;
            this.type = type;
            this.trade_goods_type = trade_goods_type;
        }

        public override string ToString() // Override ToString(), with the values inside, else main will print out the namespace.classname in console
        {
            return string.Format("\nPrice: {0} \nType: {1} \nGoods type: {2}\n", price, type, trade_goods_type);
        }
    }
}
