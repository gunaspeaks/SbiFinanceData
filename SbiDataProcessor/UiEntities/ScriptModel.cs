using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbiDataProcessor.UiEntities
{
    public partial class ScriptModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        public Nullable<bool> IsFandOScript { get; set; }
    }
}
