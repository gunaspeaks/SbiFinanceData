using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbiDataProcessor.UiEntities
{
    public partial class SellOrderModel
    {
        public int Id { get; set; }
        public string BuyOrderNo { get; set; }
        public Nullable<int> ScriptId { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<double> Rate { get; set; }
        public Nullable<double> Brokerage { get; set; }
        public Nullable<int> DigitalContractID { get; set; }

        public string Script { get; set; }
    }
}
