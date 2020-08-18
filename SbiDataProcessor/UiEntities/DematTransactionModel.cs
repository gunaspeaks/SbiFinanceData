using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbiDataProcessor.UiEntities
{
    public partial class DematTransactionModel
    {
        public int Id { get; set; }

        public System.DateTime TransactionDate { get; set; }

        public string VoucherType { get; set; }

        public double Debit { get; set; }

        public double Credit { get; set; }

        public string Particulars { get; set; }
    }
}
