using System;
using System.Collections.Generic;
using System.Text;

namespace enums_and_interfaces
{
    interface IGoods // I hate interfaces
    {
        int price { get; set; }
        string type { get; set; }
        enum TradeGoodsType // Everything in interfaces are ABSTRACT + PUBLIC by default
        {
            Grain,
            Wood,
            Meat,
            Wool,
            Cheese,
            Iron,
            Salt,
            Spice,
            Raw_Silk,
            Fish,
            Flax,
            Grape,
            Hides,
            Clay,
            Date_Fruit,
            Bread,
            Beer,
            Wine,
            Tools,
            Pottery,
            Cloth,
            Linen,
            Leather,
            Velvet,
            Saddle_Horse,
            Steppe_Horse,
            Hunter,
            Desert_Horse,
            Charger,
            War_Horse,
            Steppe_Charger,
            Desert_war_Horse,
            Unknown,
            NumberOfTradeItems
        }
    }
}
