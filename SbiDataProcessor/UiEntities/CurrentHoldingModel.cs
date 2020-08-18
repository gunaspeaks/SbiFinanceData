using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbiDataProcessor.UiEntities
{
    public class CurrentHoldingModel
    {
        public int ScriptId { get; set; }
        public string Script { get; set; }

        [DisplayName("Holding Quantity")]
        public int HoldingQuantity { get; set; }

        [DisplayName("Average Buy Rate")]
        public double AverageBuyRate { get; set; }

        [DisplayName("Total Value")]
        public double TotalValue { get; set; }
    }
}
