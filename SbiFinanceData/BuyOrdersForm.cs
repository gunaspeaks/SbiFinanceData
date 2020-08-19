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
    public partial class BuyOrdersForm : Form
    {
        private readonly ScriptsProcessor scriptsProcessor = null;
        private readonly BuyOrderProcessor dataProcessor = null;
        private readonly int _ContractID = 0;
        private List<BuyOrderModel> buyOrders;
        private readonly string _ContractNo = "";
        private readonly DateTime _TradedDate = DateTime.Today;

        public BuyOrdersForm()
        {
            InitializeComponent();
            scriptsProcessor = new ScriptsProcessor();
            dataProcessor = new BuyOrderProcessor();
            _ContractID = 0;
            buyOrders = new List<BuyOrderModel>();
        }

        public BuyOrdersForm(int contractID, string contractNo, DateTime tradedDate)
        {
            InitializeComponent();
            scriptsProcessor = new ScriptsProcessor();
            dataProcessor = new BuyOrderProcessor();
            _ContractID = contractID;
            _ContractNo = contractNo;
            buyOrders = new List<BuyOrderModel>();
            _TradedDate = tradedDate;
        }

        private void AddTransactionButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!UiValidator.IsValidMandatoryField(cmbScript, "Script Name")) return;
                if(cmbScript.SelectedIndex==0)
                {
                    MessageHelper.DisplayWarningMessage("Please select a Script");
                    cmbScript.Focus();
                    return;
                }

                if (!UiValidator.IsValidMandatoryField(txtQty, "Buy Quantity")) return;
                if (!UiValidator.IsValidMandatoryField(txtRate, "Buy Rate")) return;
                if (!UiValidator.IsValidNumericField(txtQty, "Buy Quantity")) return;
                if (!UiValidator.IsValidNumericField(txtRate, "Buy Rate")) return;
                if (!UiValidator.IsValidNumericField(txtBrokerage, "Brokerage")) return;
                int.TryParse(txtQty.Text, out int quantity);
                double.TryParse(txtRate.Text, out double rate);
                double.TryParse(txtBrokerage.Text, out double brokerage);
                BuyOrderModel model = new BuyOrderModel
                {
                    BalanceQty = quantity,
                    Brokerage = double.Parse(brokerage.ToString("#.00")),
                    DigitalContractID = _ContractID,
                    OrderNo = lblBuyOrderNo.Text,
                    Quantity = quantity,
                    Rate = double.Parse(rate.ToString("#.00")),
                    ScriptId = ((ScriptModel)cmbScript.SelectedItem).Id,
                };

                dataProcessor.AddNew(model);
                LoadBuyOrders();
                ResetForm();
            }
            catch (Exception exp)
            {
                MessageHelper.DisplayErrorMessage(exp.Message);
            }
        }

        private void BuyOrdersForm_Load(object sender, EventArgs e)
        {
            try
            {
                lblContractNo.Text = _ContractNo;
                LoadScripts();
                LoadBuyOrders();
                ResetForm();
            }
            catch (Exception exp)
            {
                MessageHelper.DisplayErrorMessage(exp.Message);
            }
        }

        private void LoadScripts()
        {
            var scripts = scriptsProcessor.GetAll();
            scripts.Insert(0, new ScriptModel { Id = 0, Name = "Please Select" });
            cmbScript.DataSource = scripts;
            cmbScript.DisplayMember = "Name";
            cmbScript.ValueMember = "Id";
        }
        private void Script_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sName = ((ScriptModel)cmbScript.SelectedItem).ShortName;
                lblBuyOrderNo.Text = $"{sName}-{_TradedDate.Day}{_TradedDate.Month}{_TradedDate.Year}-{buyOrders.Count() + 1}";
            }
            catch (Exception exp)
            {
                MessageHelper.DisplayErrorMessage(exp.Message);
            }
        }

        private void LoadBuyOrders()
        {
            gvBuyOrders.DataSource = null;
            buyOrders = dataProcessor.GetOrdersByContract(_ContractID);
            gvBuyOrders.DataSource = buyOrders;
            gvBuyOrders.Columns["Id"].Visible = false;
            gvBuyOrders.Columns["ScriptId"].Visible = false;
            gvBuyOrders.Columns["DigitalContractID"].Visible = false;

            gvBuyOrders.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gvBuyOrders.Columns["BalanceQty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gvBuyOrders.Columns["Rate"].DefaultCellStyle.Format = "#,#0.00";
            gvBuyOrders.Columns["Rate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gvBuyOrders.Columns["Brokerage"].DefaultCellStyle.Format = "#,#0.00";
            gvBuyOrders.Columns["Brokerage"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            gvBuyOrders.Refresh();
        }

        private void ResetForm()
        {
            cmbScript.SelectedIndex = 0;
            txtBrokerage.Text = "0";
            txtQty.Text = "";
            txtRate.Text = "";
            lblBuyOrderNo.Text = "";
            cmbScript.Focus();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(gvBuyOrders.SelectedRows.Count==0)
                {
                    MessageHelper.DisplayWarningMessage("Please select a Buy Order to delete");
                    return;
                }
                var script = gvBuyOrders.SelectedRows[0].Cells["Script"].Value.ToString();
                if (DialogResult.Yes != MessageHelper.DisplayConfirmMessage($"Are you sure about deleting this Order for {script}")) return;
                var id = int.Parse(gvBuyOrders.SelectedRows[0].Cells["Id"].Value.ToString());
                if(!dataProcessor.CanBeDeleted(id))
                {
                    MessageHelper.DisplayWarningMessage("Order can not be deleted as there is a Sell Order against this Buy Order");
                    return;
                }
                dataProcessor.Delete(id);
                LoadBuyOrders();
            }
            catch (Exception exp)
            {
                MessageHelper.DisplayErrorMessage(exp.Message);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Qty_TextChanged(object sender, EventArgs e)
        {
            CalculateBrokerage();
        }

        private void CalculateBrokerage()
        {
            if (string.IsNullOrWhiteSpace(txtRate.Text)) return;
            if (string.IsNullOrWhiteSpace(txtQty.Text)) return;
            double.TryParse(txtRate.Text, out double rate);
            int.TryParse(txtQty.Text, out int qty);
            double brokerage = AppCache.DeliveryBuyBrokerage * rate;
            txtBrokerage.Text = brokerage.ToString("0.00");
        }

        private void Rate_TextChanged(object sender, EventArgs e)
        {
            CalculateBrokerage();
        }
    }
}
