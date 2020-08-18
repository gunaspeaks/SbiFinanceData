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

namespace SbiFinanceData
{
    public partial class MainForm : Form
    {
        private readonly ReportsProcessor reportsProcessor;

        public MainForm()
        {
            InitializeComponent();
            reportsProcessor = new ReportsProcessor();
        }

        private void ViewAllContractsMenu_Click(object sender, EventArgs e)
        {
            DigitalContractViewerForm frm = new DigitalContractViewerForm();
            frm.Show(this);
        }

        private void AddNewContractMenu_Click(object sender, EventArgs e)
        {
            DigitalContractForm frm = new DigitalContractForm();
            frm.Show(this);
        }

        private void ManageScriptsMenu_Click(object sender, EventArgs e)
        {
            ScriptMasterForm frm = new ScriptMasterForm();
            frm.ShowDialog(this);
        }

        private void ManageDematTransactionsMenu_Click(object sender, EventArgs e)
        {
            DematTransactionsForm frm = new DematTransactionsForm();
            frm.ShowDialog(this);
        }

        private void RefreshMenuItem_Click(object sender, EventArgs e)
        {
            RefreshCurrentHoldings();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            RefreshCurrentHoldings();
        }

        private void RefreshCurrentHoldings()
        {
            try
            {
                gvHoldings.DataSource = null;
                var res = reportsProcessor.GetCurrentHoldings();
                if (res == null)
                {
                    res = new List<CurrentHoldingModel>();
                }

                res = res.OrderBy(c => c.Script).ToList();
                double totalVal = res.Sum(c => c.TotalValue);
                res.Add(new CurrentHoldingModel
                {
                    Script = "",
                });
                res.Add(new CurrentHoldingModel
                {
                    Script = "Total Value",
                    TotalValue = res.Sum(c => c.TotalValue),
                });

                gvHoldings.DataSource = res;
                gvHoldings.Columns["ScriptId"].Visible = false;
                gvHoldings.Columns["HoldingQuantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                gvHoldings.Columns["AverageBuyRate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                gvHoldings.Columns["AverageBuyRate"].DefaultCellStyle.Format = "#,#0.00";
                gvHoldings.Columns["TotalValue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                gvHoldings.Columns["TotalValue"].DefaultCellStyle.Format = "#,#0.00";
                gvHoldings.Refresh();
                gvHoldings.Visible = true;
            }
            catch (Exception exp)
            {
                MessageHelper.DisplayErrorMessage(exp.Message);
            }
        }

        private void ScriptwiseProfitLossMenu_Click(object sender, EventArgs e)
        {
            Reports.ScriptwisePLForm frm = new Reports.ScriptwisePLForm();
            frm.Show(this);
        }

        private void CurrentHoldingsMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
