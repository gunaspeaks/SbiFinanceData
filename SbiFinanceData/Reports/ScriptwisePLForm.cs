using SbiDataProcessor.Processors;
using SbiDataProcessor.UiEntities;
using SbiFinanceData.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SbiFinanceData.Reports
{
    public partial class ScriptwisePLForm : Form
    {
        private readonly ReportsProcessor reportsProcessor;

        public ScriptwisePLForm()
        {
            InitializeComponent();
            reportsProcessor = new ReportsProcessor();
        }

        private void RetrieveDataButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadData()
        {
            try
            {
                gvPLData.DataSource = null;
                var res = reportsProcessor.GetScriptwisePL();
                if (res == null)
                {
                    res = new List<ScriptPLModel>();
                }

                res = res.OrderBy(c => c.OverallProfit).ToList();
                double totalVal = res.Sum(c => c.OverallProfit);
                res.Add(new ScriptPLModel
                {
                    Script = "",
                });
                res.Add(new ScriptPLModel
                {
                    Script = "Overall Profit",
                    OverallProfit = totalVal,
                });

                gvPLData.DataSource = res;
                gvPLData.Columns["ScriptId"].Visible = false;
                gvPLData.Columns["IntradayQty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                gvPLData.Columns["IntradayProfit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                gvPLData.Columns["IntradayProfit"].DefaultCellStyle.Format = "#,#0.00";
                gvPLData.Columns["DeliveryQty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                gvPLData.Columns["DeliveryProfit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                gvPLData.Columns["DeliveryProfit"].DefaultCellStyle.Format = "#,#0.00";
                gvPLData.Columns["OverallProfit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                gvPLData.Columns["OverallProfit"].DefaultCellStyle.Format = "#,#0.00";
                gvPLData.Refresh();
                gvPLData.Visible = true;
            }
            catch (Exception exp)
            {
                MessageHelper.DisplayErrorMessage(exp.Message);
            }
        }

        private void ScriptwisePLForm_Shown(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
