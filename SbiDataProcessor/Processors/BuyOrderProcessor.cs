using SbiDataProcessor.DbEntities;
using SbiDataProcessor.UiEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbiDataProcessor.Processors
{
    public class BuyOrderProcessor
    {
        private readonly SbiDataEntities dataEntities = null;

        public BuyOrderProcessor()
        {
            dataEntities = new SbiDataEntities();
        }

        public List<BuyOrderModel> GetAll()
        {
            return (from b in dataEntities.BuyOrders
                    orderby b.Id
                    select new BuyOrderModel
                    {
                        Id = b.Id,
                        BalanceQty = b.BalanceQty,
                        Brokerage = b.Brokerage,
                        DigitalContractID = b.DigitalContractID,
                        OrderNo = b.OrderNo,
                        Quantity = b.Quantity,
                        Rate = b.Rate,
                        ScriptId = b.ScriptId,
                        Script = dataEntities.ScriptMasters.FirstOrDefault(s => s.Id == b.ScriptId).Name,
                    }).ToList();
        }

        public List<BuyOrderModel> GetOrdersByContract(int contractID)
        {
            return (from b in dataEntities.BuyOrders
                    where b.DigitalContractID == contractID
                    orderby b.Id
                    select new BuyOrderModel
                    {
                        Id = b.Id,
                        BalanceQty = b.BalanceQty,
                        Brokerage = b.Brokerage,
                        DigitalContractID = b.DigitalContractID,
                        OrderNo = b.OrderNo,
                        Quantity = b.Quantity,
                        Rate = b.Rate,
                        ScriptId = b.ScriptId,
                        Script = dataEntities.ScriptMasters.FirstOrDefault(s => s.Id == b.ScriptId).Name,
                    }).ToList();
        }

        public List<BuyOrderModel> GetBendingOrdersForContract(int scriptID)
        {
            return (from s in dataEntities.BuyOrders
                    where s.BalanceQty > 0 && s.ScriptId == scriptID
                    orderby s.OrderNo
                    select new BuyOrderModel
                    {
                        Brokerage = s.Brokerage,
                        Id = s.Id,
                        OrderNo = s.OrderNo,
                        Quantity = s.Quantity,
                        Rate = s.Rate,
                        ScriptId = s.ScriptId,
                        BalanceQty = s.BalanceQty,
                    }).ToList();
        }

        public void AddNew(BuyOrderModel model)
        {
            BuyOrder order = new BuyOrder
            {
                BalanceQty = model.BalanceQty,
                Brokerage = model.Brokerage,
                DigitalContractID = model.DigitalContractID,
                OrderNo = model.OrderNo,
                Quantity = model.Quantity,
                Rate = model.Rate,
                ScriptId = model.ScriptId,
            };
            dataEntities.BuyOrders.Add(order);
            dataEntities.SaveChanges();
        }

        public void Delete(int orderID)
        {
            dataEntities.BuyOrders.Remove(dataEntities.BuyOrders.FirstOrDefault(o => o.Id == orderID));
            dataEntities.SaveChanges();
        }

        public bool CanBeDeleted(int orderID)
        {
            string buyOrderNo = dataEntities.BuyOrders.FirstOrDefault(b => b.Id == orderID)?.OrderNo;
            if (dataEntities.SellOrders.Any(s => s.BuyOrderNo == buyOrderNo)) return false;
            return true;
        }
    }
}
