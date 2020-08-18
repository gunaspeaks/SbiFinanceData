using SbiDataProcessor.DbEntities;
using SbiDataProcessor.UiEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbiDataProcessor.Processors
{
    public class DigitalContractProcessor
    {
        private SbiDataEntities dataEntities = null;

        public DigitalContractProcessor()
        {
            dataEntities = new SbiDataEntities();
        }

        public List<DigitalContractModel> GetAll()
        {
            return (from c in dataEntities.DigitalContracts
                    orderby c.TradedDate descending
                    select new DigitalContractModel
                    {
                        Id = c.Id,
                        Brokerage = c.Brokerage,
                        ETC = c.ETC,
                        ContractNoteNo = c.ContractNoteNo,
                        IGST = c.IGST,
                        STT = c.STT,
                        Tax = c.Tax,
                        TradedDate = c.TradedDate,
                        DigitalContractNo = c.DigitalContractNo,
                    }).ToList();
        }

        public int AddNew(DigitalContractModel model)
        {
            DigitalContract entity = new DigitalContract
            {
                Id = model.Id,
                Brokerage = model.Brokerage,
                ETC = model.ETC,
                ContractNoteNo = model.ContractNoteNo,
                IGST = model.IGST,
                STT = model.STT,
                Tax = model.Tax,
                TradedDate = model.TradedDate,
                DigitalContractNo = model.DigitalContractNo,
            };
            dataEntities.DigitalContracts.Add(entity);
            dataEntities.SaveChanges();
            return dataEntities.DigitalContracts.FirstOrDefault(c => c.DigitalContractNo == model.DigitalContractNo).Id;
        }

        public void Update(DigitalContractModel model)
        {
            DigitalContract entity = dataEntities.DigitalContracts.FirstOrDefault(c => c.Id == model.Id);
            if (entity == null)
            {
                throw new InvalidOperationException("Digital Contract not found");
            }
            entity.Brokerage = model.Brokerage;
            entity.ContractNoteNo = model.ContractNoteNo;
            entity.DigitalContractNo = model.DigitalContractNo;
            entity.ETC = model.ETC;
            entity.IGST = model.IGST;
            entity.STT = model.STT;
            entity.Tax = model.Tax;
            entity.TradedDate = model.TradedDate;
            dataEntities.SaveChanges();
        }

        public void Delete(int id)
        {
            dataEntities.DigitalContracts.Remove(dataEntities.DigitalContracts.FirstOrDefault(c => c.Id == id));
            dataEntities.SaveChanges();
        }

        public DigitalContractModel GetById(int id)
        {
            return (from c in dataEntities.DigitalContracts
                    where c.Id == id
                    select new DigitalContractModel
                    {
                        Id = c.Id,
                        Brokerage = c.Brokerage,
                        ETC = c.ETC,
                        ContractNoteNo = c.ContractNoteNo,
                        IGST = c.IGST,
                        STT = c.STT,
                        Tax = c.Tax,
                        TradedDate = c.TradedDate,
                        DigitalContractNo = c.DigitalContractNo,
                    }).FirstOrDefault();
        }

        public DigitalContractModel GetByContractNo(string contractNo)
        {
            return (from c in dataEntities.DigitalContracts
                    where c.DigitalContractNo == contractNo
                    select new DigitalContractModel
                    {
                        Id = c.Id,
                        Brokerage = c.Brokerage,
                        ETC = c.ETC,
                        ContractNoteNo = c.ContractNoteNo,
                        IGST = c.IGST,
                        STT = c.STT,
                        Tax = c.Tax,
                        TradedDate = c.TradedDate,
                        DigitalContractNo = c.DigitalContractNo,
                    }).FirstOrDefault();
        }

        public int GetBuyOrdersCount(int contractID)
        {
            return dataEntities.BuyOrders.Count(c => c.DigitalContractID == contractID);
        }
        public int GetSellOrdersCount(int contractID)
        {
            return dataEntities.SellOrders.Count(c => c.DigitalContractID == contractID);
        }
        public int GetIntradayOrdersCount(int contractID)
        {
            return dataEntities.IntradayOrders.Count(c => c.DigitalContractId == contractID);
        }
    }
}
