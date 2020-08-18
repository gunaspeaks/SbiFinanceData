using SbiDataProcessor.DbEntities;
using SbiDataProcessor.UiEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbiDataProcessor.Processors
{
    public class ReportsProcessor
    {
        private readonly SbiDataEntities dataEntities = null;

        public ReportsProcessor()
        {
            dataEntities = new SbiDataEntities();
        }

        public List<CurrentHoldingModel> GetCurrentHoldings()
        {
            List<CurrentHoldingModel> holdings = (from b in dataEntities.BuyOrders
                                                  where b.BalanceQty > 0
                                                  group b by b.ScriptId into bg
                                                  select new CurrentHoldingModel
                                                  {
                                                      ScriptId = bg.Key,
                                                      Script = dataEntities.ScriptMasters.FirstOrDefault(s => s.Id == bg.Key).Name,
                                                      HoldingQuantity = bg.Sum(g => g.BalanceQty),
                                                      TotalValue = bg.Sum(g => g.BalanceQty * (g.Rate + (g.Brokerage.HasValue ? g.Brokerage.Value : 0))),
                                                      AverageBuyRate = bg.Sum(g => g.BalanceQty * (g.Rate + (g.Brokerage.HasValue ? g.Brokerage.Value : 0))) / bg.Sum(g => g.BalanceQty),
                                                  }).ToList();
            return holdings;
        }

        public List<ScriptPLModel> GetScriptwisePL()
        {
            List<ScriptPLModel> scriptPLs = (from s in dataEntities.ScriptMasters
                                             orderby s.Name
                                             select new ScriptPLModel
                                             {
                                                 Script = s.Name,
                                                 ScriptId = s.Id,
                                             }).ToList();

            foreach (var pl in scriptPLs)
            {
                double? iProfit = 0;
                if (dataEntities.IntradayOrders.Any(s => s.ScriptId == pl.ScriptId))
                {
                    iProfit = dataEntities.IntradayOrders.Where(f => f.ScriptId == pl.ScriptId).Sum(i => i.Quantity * ((i.SellRate - i.SellBrokerage) - (i.BuyBrokerage + i.BuyRate)));
                    pl.IntradayQty = dataEntities.IntradayOrders.Where(f => f.ScriptId == pl.ScriptId).Sum(i => i.Quantity);
                }
                var sellOrders = (from so in dataEntities.SellOrders
                                  where so.ScriptId == pl.ScriptId
                                  select so).ToList();
                int tradedQty = 0;
                double profit = 0;
                foreach (var so in sellOrders)
                {
                    tradedQty += so.Quantity ?? 0;
                    double sellValue = so.Quantity.Value * (so.Rate.Value - so.Brokerage.Value);
                    var buyOrder = dataEntities.BuyOrders.FirstOrDefault(b => b.OrderNo == so.BuyOrderNo);
                    double buyValue = 0;
                    if (buyOrder != null)
                    {
                        buyValue = so.Quantity.Value * (buyOrder.Rate + buyOrder.Brokerage.Value);
                    }
                    profit += sellValue - buyValue;
                }
                pl.DeliveryQty = tradedQty;
                pl.DeliveryProfit = profit;
                pl.IntradayProfit = iProfit;
                pl.OverallProfit = pl.IntradayProfit.Value + profit;
            }

            return scriptPLs;
        }
    }
}
