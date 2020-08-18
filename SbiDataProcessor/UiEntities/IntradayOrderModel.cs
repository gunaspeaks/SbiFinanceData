using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbiDataProcessor.UiEntities
{
    public class IntradayOrderModel
    {
        public int Id { get; set; }
        public int DigitalContractId { get; set; }
        public int ScriptId { get; set; }
        public int Quantity { get; set; }
        public double BuyRate { get; set; }
        public double SellRate { get; set; }
        public Nullable<double> BuyBrokerage { get; set; }
        public Nullable<double> SellBrokerage { get; set; }

        public string Script { get; set; }
    }
}
