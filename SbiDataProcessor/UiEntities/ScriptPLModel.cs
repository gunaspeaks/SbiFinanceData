using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbiDataProcessor.UiEntities
{
    public class ScriptPLModel
    {
        public int ScriptId { get; set; }

        [DisplayName("Script")]
        public string Script { get; set; }

        [DisplayName("Traded Qty - Intraday")]
        public int? IntradayQty { get; set; }

        [DisplayName("Profit & Loss - Intraday")]
        public double? IntradayProfit { get; set; }

        [DisplayName("Traded Qty - Delivery")] 
        public int? DeliveryQty { get; set; }

        [DisplayName("Profit & Loss - Delivery")]
        public double? DeliveryProfit { get; set; }

        [DisplayName("Profit & Loss - Overall")]
        public double OverallProfit { get; set; }
    }
}
