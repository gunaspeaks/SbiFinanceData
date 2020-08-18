using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbiDataProcessor.UiEntities
{
    public partial class BuyOrderModel
    {
        public int Id { get; set; }
        public int ScriptId { get; set; }
        public int Quantity { get; set; }
        public double Rate { get; set; }
        public Nullable<double> Brokerage { get; set; }
        public int BalanceQty { get; set; }
        public string OrderNo { get; set; }
        public Nullable<int> DigitalContractID { get; set; }

        public string Script { get; set; }
    }
}
