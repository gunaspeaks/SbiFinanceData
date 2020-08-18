using SbiDataProcessor.DbEntities;
using SbiDataProcessor.UiEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbiDataProcessor.Processors
{
    public class DematTransactionsProcessor
    {
        private readonly SbiDataEntities dataEntities = null;

        public DematTransactionsProcessor()
        {
            dataEntities = new SbiDataEntities();
        }

        public List<DematTransactionModel> GetAll()
        {
            return (from b in dataEntities.DematTransactions
                    orderby b.TransactionDate descending
                    select new DematTransactionModel
                    {
                        Id = b.Id,
                        Credit=b.Credit,
                        Debit=b.Debit,
                        Particulars=b.Particulars,
                        TransactionDate=b.TransactionDate,
                        VoucherType=b.VoucherType,
                    }).ToList();
        }

        public void AddNew(DematTransactionModel model)
        {
            DematTransaction order = new DematTransaction
            {
                Credit = model.Credit,
                Debit = model.Debit,
                Particulars = model.Particulars,
                TransactionDate = model.TransactionDate,
                VoucherType = model.VoucherType,
            };
            dataEntities.DematTransactions.Add(order);
            dataEntities.SaveChanges();
        }

        public void Delete(int transactionID)
        {
            dataEntities.DematTransactions.Remove(dataEntities.DematTransactions.FirstOrDefault(o => o.Id == transactionID));
            dataEntities.SaveChanges();
        }
    }
}