using SbiDataProcessor.DbEntities;
using SbiDataProcessor.UiEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbiDataProcessor.Processors
{
    public class SellOrderProcessor
    {
        private readonly SbiDataEntities dataEntities = null;

        public SellOrderProcessor()
        {
            dataEntities = new SbiDataEntities();
        }

        public List<SellOrderModel> GetAll()
        {
            return (from s in dataEntities.SellOrders
                    orderby s.Id
                    select new SellOrderModel
                    {
                        Brokerage = s.Brokerage,
                        BuyOrderNo = s.BuyOrderNo,
                        DigitalContractID = s.DigitalContractID,
                        Id = s.Id,
                        Quantity = s.Quantity,
                        Rate = s.Rate,
                        ScriptId = s.ScriptId,
                        Script = dataEntities.ScriptMasters.FirstOrDefault(ss => ss.Id == s.ScriptId).Name,
                    }).ToList();
        }

        public List<SellOrderModel> GetOrdersForContract(int contractID)
        {
            return (from s in dataEntities.SellOrders
                    where s.DigitalContractID == contractID
                    orderby s.Id
                    select new SellOrderModel
                    {
                        Brokerage = s.Brokerage,
                        BuyOrderNo = s.BuyOrderNo,
                        DigitalContractID = s.DigitalContractID,
                        Id = s.Id,
                        Quantity = s.Quantity,
                        Rate = s.Rate,
                        ScriptId = s.ScriptId,
                        Script = dataEntities.ScriptMasters.FirstOrDefault(ss => ss.Id == s.ScriptId).Name,
                    }).ToList();
        }

        public void AddNew(SellOrderModel model)
        {
            SellOrder entity = new SellOrder
            {
                Brokerage = model.Brokerage,
                BuyOrderNo = model.BuyOrderNo,
                DigitalContractID = model.DigitalContractID,
                Quantity = model.Quantity,
                Rate = model.Rate,
                ScriptId = model.ScriptId,
            };
            dataEntities.SellOrders.Add(entity);

            BuyOrder buyOrder = dataEntities.BuyOrders.FirstOrDefault(b => b.OrderNo == model.BuyOrderNo && b.ScriptId == model.ScriptId);
            if (buyOrder == null)
            {
                throw new InvalidOperationException($"Couldn't add sell transaction as the Buy Order \"{model.BuyOrderNo}\"");
            }
            buyOrder.BalanceQty -= model.Quantity.Value;
            dataEntities.SaveChanges();
        }

        public void Delte(int id)
        {
            SellOrder sellOrder= dataEntities.SellOrders.FirstOrDefault(s => s.Id == id);
            if (sellOrder == null)
            {
                throw new InvalidOperationException($"Couldn't find the Sell Order");
            }

            BuyOrder buyOrder = dataEntities.BuyOrders.FirstOrDefault(b => b.OrderNo == sellOrder.BuyOrderNo);
            if (buyOrder == null)
            {
                throw new InvalidOperationException($"Couldn't delete sell order as the Buy Order \"{sellOrder.BuyOrderNo}\" is missing");
            }
            buyOrder.BalanceQty += sellOrder.Quantity.Value;
            dataEntities.SellOrders.Remove(dataEntities.SellOrders.FirstOrDefault(s => s.Id == id));
            dataEntities.SaveChanges();
        }
    }
}
