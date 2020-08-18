using SbiDataProcessor.DbEntities;
using SbiDataProcessor.UiEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbiDataProcessor.Processors
{
    public class IntradayOrderProcessor
    {
        private readonly SbiDataEntities dataEntities = null;

        public IntradayOrderProcessor()
        {
            dataEntities = new SbiDataEntities();
        }

        public List<IntradayOrderModel> GetAll()
        {
            return (from b in dataEntities.IntradayOrders
                    orderby b.Id
                    select new IntradayOrderModel
                    {
                        Id = b.Id,
                        BuyBrokerage = b.BuyBrokerage,
                        SellBrokerage = b.SellBrokerage,
                        DigitalContractId = b.DigitalContractId,
                        BuyRate = b.BuyRate,
                        Quantity = b.Quantity,
                        SellRate = b.SellRate,
                        ScriptId = b.ScriptId,
                        Script = dataEntities.ScriptMasters.FirstOrDefault(s => s.Id == b.ScriptId).Name,
                    }).ToList();
        }

        public List<IntradayOrderModel> GetOrdersByContract(int contractID)
        {
            return (from b in dataEntities.IntradayOrders
                    where b.DigitalContractId == contractID
                    orderby b.Id
                    select new IntradayOrderModel
                    {
                        Id = b.Id,
                        BuyBrokerage = b.BuyBrokerage,
                        SellBrokerage = b.SellBrokerage,
                        DigitalContractId = b.DigitalContractId,
                        BuyRate = b.BuyRate,
                        Quantity = b.Quantity,
                        SellRate = b.SellRate,
                        ScriptId = b.ScriptId,
                        Script = dataEntities.ScriptMasters.FirstOrDefault(s => s.Id == b.ScriptId).Name,
                    }).ToList();
        }


        public void AddNew(IntradayOrderModel model)
        {
            IntradayOrder order = new IntradayOrder
            {
                Id = model.Id,
                BuyBrokerage = model.BuyBrokerage,
                SellBrokerage = model.SellBrokerage,
                DigitalContractId = model.DigitalContractId,
                BuyRate = model.BuyRate,
                Quantity = model.Quantity,
                SellRate = model.SellRate,
                ScriptId = model.ScriptId,
            };
            dataEntities.IntradayOrders.Add(order);
            dataEntities.SaveChanges();
        }

        public void Delete(int orderID)
        {
            dataEntities.IntradayOrders.Remove(dataEntities.IntradayOrders.FirstOrDefault(o => o.Id == orderID));
            dataEntities.SaveChanges();
        }
    }
}
