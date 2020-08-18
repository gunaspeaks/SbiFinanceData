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
    public partial class IntradayForm : Form
    {
        private readonly ScriptsProcessor scriptsProcessor = null;
        private readonly IntradayOrderProcessor dataProcessor = null;
        private readonly int _ContractID = 0;
        private List<IntradayOrderModel> intradayOrders;
        private readonly string _ContractNo = "";
        private readonly DateTime _TradedDate = DateTime.Today;

        public IntradayForm()
        {
            InitializeComponent();
            scriptsProcessor = new ScriptsProcessor();
            dataProcessor = new IntradayOrderProcessor();
            _ContractID = 0;
            intradayOrders = new List<IntradayOrderModel>();
        }

        public IntradayForm(int contractID, string contractNo, DateTime tradedDate)
        {
            InitializeComponent();
            scriptsProcessor = new ScriptsProcessor();
            dataProcessor = new IntradayOrderProcessor();
            _ContractID = contractID;
            _ContractNo = contractNo;
            lblContractNo.Text = contractNo;
            intradayOrders = new List<IntradayOrderModel>();
            _TradedDate = tradedDate;
        }

        private void AddTransactionButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!UiValidator.IsValidMandatoryField(cmbScript, "Script Name")) return;
                if (cmbScript.SelectedIndex == 0)
                {
                    MessageHelper.DisplayWarningMessage("Please select a Script");
                    cmbScript.Focus();
                    return;
                }

                if (!UiValidator.IsValidMandatoryField(txtQty, "Quantity")) return;
                if (!UiValidator.IsValidMandatoryField(txtBRate, "Buy Rate")) return;
                if (!UiValidator.IsValidMandatoryField(txtSRate, "Sell Rate")) return;
                if (!UiValidator.IsValidNumericField(txtQty, "Quantity")) return;
                if (!UiValidator.IsValidNumericField(txtBRate, "Buy Rate")) return;
                if (!UiValidator.IsValidNumericField(txtSRate, "Sell Rate")) return;
                if (!UiValidator.IsValidNumericField(txtBBrokerage, "Buy Brokerage")) return;
                if (!UiValidator.IsValidNumericField(txtSBrokerage, "Sell Brokerage")) return;
                int.TryParse(txtQty.Text, out int quantity);
                double.TryParse(txtBRate.Text, out double bRate);
                double.TryParse(txtSRate.Text, out double sRate);
                double.TryParse(txtBBrokerage.Text, out double bBrokerage);
                double.TryParse(txtSBrokerage.Text, out double sBrokerage);
                IntradayOrderModel model = new IntradayOrderModel
                {
                    BuyBrokerage = double.Parse(bBrokerage.ToString("#.00")),
                    SellBrokerage = double.Parse(sBrokerage.ToString("#.00")),
                    DigitalContractId = _ContractID,
                    Quantity = quantity,
                    BuyRate = double.Parse(bRate.ToString("#.00")),
                    SellRate = double.Parse(sRate.ToString("#.00")),
                    ScriptId = ((ScriptModel)cmbScript.SelectedItem).Id,
                };

                dataProcessor.AddNew(model);
                LoadIntradayOrders();
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
                LoadIntradayOrders();
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

        private void LoadIntradayOrders()
        {
            gvIntraOrders.DataSource = null;
            intradayOrders = dataProcessor.GetOrdersByContract(_ContractID);
            gvIntraOrders.DataSource = intradayOrders;
            gvIntraOrders.Columns["ScriptId"].Visible = false;
            gvIntraOrders.Columns["Id"].Visible = false;
            gvIntraOrders.Columns["DigitalContractID"].Visible = false;

            gvIntraOrders.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gvIntraOrders.Columns["SellRate"].DefaultCellStyle.Format = "#,#0.00";
            gvIntraOrders.Columns["SellRate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gvIntraOrders.Columns["BuyRate"].DefaultCellStyle.Format = "#,#0.00";
            gvIntraOrders.Columns["BuyRate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gvIntraOrders.Columns["SellBrokerage"].DefaultCellStyle.Format = "#,#0.00";
            gvIntraOrders.Columns["SellBrokerage"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gvIntraOrders.Columns["BuyBrokerage"].DefaultCellStyle.Format = "#,#0.00";
            gvIntraOrders.Columns["BuyBrokerage"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gvIntraOrders.Refresh();
        }

        private void ResetForm()
        {
            cmbScript.SelectedIndex = 0;
            txtBBrokerage.Text = "0";
            txtSBrokerage.Text = "0";
            txtQty.Text = "";
            txtBRate.Text = "";
            txtSRate.Text = "";
            cmbScript.Focus();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvIntraOrders.SelectedRows.Count == 0)
                {
                    MessageHelper.DisplayWarningMessage("Please select an Order to delete");
                    return;
                }
                var script = gvIntraOrders.SelectedRows[0].Cells["Script"].Value.ToString();
                if (DialogResult.Yes != MessageHelper.DisplayConfirmMessage($"Are you sure about deleting this Order for {script}")) return;
                var id = int.Parse(gvIntraOrders.SelectedRows[0].Cells["Id"].Value.ToString());
                dataProcessor.Delete(id);
                LoadIntradayOrders();
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

        private void BRate_TextChanged(object sender, EventArgs e)
        {
            CalculateBuyBrokerage();
        }

        private void SRate_TextChanged(object sender, EventArgs e)
        {
            CalculateSellBrokerage();
        }

        private void CalculateBuyBrokerage()
        {
            if (string.IsNullOrWhiteSpace(txtBRate.Text)) return;
            if (string.IsNullOrWhiteSpace(txtQty.Text)) return;
            double.TryParse(txtBRate.Text, out double rate);
            int.TryParse(txtQty.Text, out int qty);
            double brokerage = (0.075 / 100) * rate;
            txtBBrokerage.Text = brokerage.ToString("0.00");
        }

        private void CalculateSellBrokerage()
        {
            if (string.IsNullOrWhiteSpace(txtSRate.Text)) return;
            if (string.IsNullOrWhiteSpace(txtQty.Text)) return;
            double.TryParse(txtSRate.Text, out double rate);
            int.TryParse(txtQty.Text, out int qty);
            double brokerage = (0.075 / 100) * rate;
            txtSBrokerage.Text = brokerage.ToString("0.00");
        }

        private void Qty_TextChanged(object sender, EventArgs e)
        {
            CalculateSellBrokerage();
            CalculateSellBrokerage();
        }
    }
}
