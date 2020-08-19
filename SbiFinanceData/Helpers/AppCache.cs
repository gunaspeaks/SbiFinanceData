using SbiDataProcessor.Processors;
using SbiDataProcessor.UiEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SbiFinanceData.Helpers
{
    public static class AppCache
    {
        private static UtilitiesProcessor processor = null;
        private static List<AppSettingModel> appSettings;

        public static void InitializeAppSettings()
        {
            processor = new UtilitiesProcessor();
            appSettings = processor.GetAll();
        }

        private static string GetAppSetting(string settingName)
        {
            return appSettings.FirstOrDefault(a => a.Name == settingName)?.Value;
        }

        public static double IntradayBuyBrokerage
        {
            get
            {
                string val = GetAppSetting("IntradayBuyBrokerage");
                return double.Parse(val);
            }
        }

        public static double IntradaySellBrokerage
        {
            get
            {
                string val = GetAppSetting("IntradaySellBrokerage");
                return double.Parse(val);
            }
        }

        public static double DeliverySellBrokerage
        {
            get
            {
                string val = GetAppSetting("DeliverySellBrokerage");
                return double.Parse(val);
            }
        }

        public static double DeliveryBuyBrokerage
        {
            get
            {
                string val = GetAppSetting("DeliveryBuyBrokerage");
                return double.Parse(val);
            }
        }
    }
}
