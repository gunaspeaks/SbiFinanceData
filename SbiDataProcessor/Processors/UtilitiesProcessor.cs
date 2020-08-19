using SbiDataProcessor.DbEntities;
using SbiDataProcessor.UiEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbiDataProcessor.Processors
{
    public class UtilitiesProcessor
    {
        private readonly SbiDataEntities dataEntities = null;

        public UtilitiesProcessor()
        {
            dataEntities = new SbiDataEntities();
        }

        public List<AppSettingModel> GetAll()
        {
            return (from a in dataEntities.AppSettings
                    select new AppSettingModel
                    {
                        Id = a.Id,
                        Name = a.Name,
                        Value = a.Value,
                    }).ToList();
        }

        public void AddNew(AppSettingModel model)
        {
            AppSetting appSetting = new AppSetting
            {
                Name = model.Name,
                Value = model.Value,
            };
            dataEntities.AppSettings.Add(appSetting);
            dataEntities.SaveChanges();
        }

        public void Update(AppSettingModel model)
        {
            AppSetting appSetting = dataEntities.AppSettings.FirstOrDefault(a => a.Id == model.Id);
            if(appSetting==null)
            {
                throw new InvalidOperationException($"Application settings entry with ID: {model.Id} is missing");
            }
            appSetting.Name = model.Name;
            appSetting.Value = model.Value;
            dataEntities.SaveChanges();
        }

        public void Delete(int id)
        {
            AppSetting appSetting = dataEntities.AppSettings.FirstOrDefault(a => a.Id == id);
            if (appSetting == null)
            {
                throw new InvalidOperationException($"Application settings entry with ID: {id} is missing");
            }
            dataEntities.AppSettings.Remove(appSetting);
            dataEntities.SaveChanges();
        }
    }
}
