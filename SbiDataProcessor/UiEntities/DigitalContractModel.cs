using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbiDataProcessor.UiEntities
{
    public partial class DigitalContractModel
    {
        public int Id { get; set; }
        public string ContractNoteNo { get; set; }
        public System.DateTime TradedDate { get; set; }
        public Nullable<double> Brokerage { get; set; }
        public double STT { get; set; }
        public double ETC { get; set; }
        public double IGST { get; set; }
        public double Tax { get; set; }

        public string DigitalContractNo { get; set; }
    }
}
