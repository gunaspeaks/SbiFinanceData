using SbiDataProcessor.DbEntities;
using SbiDataProcessor.UiEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbiDataProcessor.Processors
{
    public class ScriptsProcessor
    {
        private SbiDataEntities dataEntities = null;

        public ScriptsProcessor()
        {
            dataEntities = new SbiDataEntities();
        }

        public List<ScriptModel> GetAll()
        {
            return (from s in dataEntities.ScriptMasters
                    orderby s.Name
                    select new ScriptModel
                    {
                        Id = s.Id,
                        IsFandOScript = s.IsFandOScript,
                        Name = s.Name,
                        ShortName = s.ShortName,
                    }).ToList();
        }

        public void AddNew(ScriptModel script)
        {
            if(dataEntities.ScriptMasters.Any(s=>s.Name.ToLower().Trim()==script.Name.ToLower().Trim()))
            {
                throw new InvalidOperationException("Script Name does exist already");
            }

            ScriptMaster scriptMaster = new ScriptMaster
            {
                IsFandOScript = script.IsFandOScript,
                Name = script.Name,
                ShortName = script.ShortName,
            };
            dataEntities.ScriptMasters.Add(scriptMaster);
            dataEntities.SaveChanges();
        }
    }
}
