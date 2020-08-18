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
    public partial class SellOrdersForm : Form
    {
        private readonly ScriptsProcessor scriptsProcessor = null;
        private readonly BuyOrderProcessor boProcessor = null;
        private readonly SellOrderProcessor dataProcessor = null;
        private readonly int _ContractID = 0;
        private List<SellOrderModel> sellOrders;
        private readonly string _ContractNo = "";
        private readonly DateTime _TradedDate = DateTime.Today;

        public SellOrdersForm()
        {
            InitializeComponent();
        }

        public SellOrdersForm(int contractID, string contractNo, DateTime tradedDate)
        {
            InitializeComponent();
            _ContractID = contractID;
            _ContractNo = contractNo;
            _TradedDate = tradedDate;
            scriptsProcessor = new ScriptsProcessor();
            dataProcessor = new SellOrderProcessor();
            boProcessor = new BuyOrderProcessor();
            sellOrders = new List<SellOrderModel>();
        }

        private void InitializeForm()
        {
            lblContractNo.Text = _ContractNo;
            LoadScripts();
            LoadSellOrders();
            ResetForm();
        }

        private void SellOrdersForm_Load(object sender, EventArgs e)
        {
            try
            {
                InitializeForm();
            }
            catch (Exception exp)
            {
                MessageHelper.DisplayErrorMessage(exp.Message);
            }
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

                if (!UiValidator.IsValidMandatoryField(cmbBuyOrders, "Buy Order")) return;
                if (cmbBuyOrders.SelectedIndex == 0)
                {
                    MessageHelper.DisplayWarningMessage("Please select a Buy Order");
                    cmbBuyOrders.Focus();
                    return;
                }

                int.TryParse(txtAvailableQty.Text, out int availableQty);
                if (availableQty <= 0)
                {
                    MessageHelper.DisplayWarningMessage("Please check the Available quantity to sell");
                    cmbBuyOrders.Focus();
                    return;
                }

                if (!UiValidator.IsValidMandatoryField(txtSoldQty, "Sold Quantity")) return;
                if (!UiValidator.IsValidNumericField(txtSoldQty, "Sold Quantity")) return;
                if (!UiValidator.IsValidMandatoryField(txtSoldRate, "Sold Rate")) return;
                if (!UiValidator.IsValidNumericField(txtSoldRate, "Sold Rate")) return;
                if (!UiValidator.IsValidNumericField(txtBrokerage, "Brokerage")) return;
                int.TryParse(txtSoldQty.Text, out int quantity);
                if (quantity > availableQty)
                {
                    MessageHelper.DisplayWarningMessage("Available quantity is lesser than selling quantity");
                    txtSoldQty.Focus();
                    return;
                }

                if (quantity <= 0)
                {
                    MessageHelper.DisplayWarningMessage("Invalid Selling quantity");
                    txtSoldQty.Focus();
                    return;
                }

                double.TryParse(txtSoldRate.Text, out double rate);
                double.TryParse(txtBrokerage.Text, out double brokerage);
                SellOrderModel model = new SellOrderModel
                {
                    BuyOrderNo = ((BuyOrderModel)cmbBuyOrders.SelectedItem).OrderNo,
                    Brokerage = double.Parse(brokerage.ToString("0.00")),
                    DigitalContractID = _ContractID,
                    Quantity = quantity,
                    Rate = double.Parse(rate.ToString("0.00")),
                    ScriptId = ((ScriptModel)cmbScript.SelectedItem).Id,
                };

                dataProcessor.AddNew(model);
                LoadSellOrders();
                ResetForm();
            }
            catch (Exception exp)
            {
                MessageHelper.DisplayErrorMessage(exp.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(gvSellOrders.SelectedRows.Count==0)
                {
                    MessageHelper.DisplayWarningMessage("Please select a row to delete");
                    return;
                }
                var script = gvSellOrders.SelectedRows[0].Cells["Script"].Value.ToString();
                if (DialogResult.Yes != MessageHelper.DisplayConfirmMessage($"Are you sure about deleting this Order for {script}")) return;
                int id = int.Parse(gvSellOrders.SelectedRows[0].Cells["Id"].Value.ToString());
                dataProcessor.Delte(id);
                LoadSellOrders();
            }
            catch(Exception exp)
            {
                MessageHelper.DisplayErrorMessage(exp.Message);
            }
        }

        private void Script_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadBuyOrders();
            }
            catch (Exception exp)
            {
                MessageHelper.DisplayErrorMessage(exp.Message);
            }
        }

        private void BuyOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBuyOrders.SelectedIndex == 0) return;
                var buyOrder = ((BuyOrderModel)cmbBuyOrders.SelectedItem);
                txtBuyRate.Text = buyOrder.Rate.ToString();
                txtAvailableQty.Text = buyOrder.BalanceQty.ToString();
                txtSoldQty.Text = buyOrder.BalanceQty.ToString();
            }
            catch (Exception exp)
            {
                MessageHelper.DisplayErrorMessage(exp.Message);
            }
        }

        private void Scripts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                LoadScripts();
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

        private void LoadBuyOrders()
        {
            List<BuyOrderModel> buyOrders = new List<BuyOrderModel>();

            if (cmbScript.SelectedIndex <= 0)
            {
                buyOrders.Insert(0, new BuyOrderModel { Id = 0, OrderNo = "Please Select" });
                cmbBuyOrders.DataSource = buyOrders;
                cmbBuyOrders.DisplayMember = "OrderNo";
                cmbBuyOrders.ValueMember = "Id";
                return;
            }
            int scriptID = ((ScriptModel)cmbScript.SelectedItem).Id;
            buyOrders = boProcessor.GetBendingOrdersForContract(scriptID);
            buyOrders.Insert(0, new BuyOrderModel { Id = 0, OrderNo = "Please Select" });
            cmbBuyOrders.DataSource = buyOrders;
            cmbBuyOrders.DisplayMember = "OrderNo";
            cmbBuyOrders.ValueMember = "Id";
        }

        private void ResetForm()
        {
            cmbScript.SelectedIndex = 0;
            cmbBuyOrders.SelectedIndex = 0;
            txtAvailableQty.Text = "";
            txtBrokerage.Text = "";
            txtBuyRate.Text = "";
            txtSoldQty.Text = "";
            txtSoldRate.Text = "";
            cmbScript.Focus();
        }

        private void LoadSellOrders()
        {
            gvSellOrders.DataSource = null;
            sellOrders = dataProcessor.GetOrdersForContract(_ContractID);
            gvSellOrders.DataSource = sellOrders;
            gvSellOrders.Columns["Id"].Visible = false;
            gvSellOrders.Columns["ScriptId"].Visible = false;
            gvSellOrders.Columns["DigitalContractID"].Visible = false;

            gvSellOrders.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gvSellOrders.Columns["Rate"].DefaultCellStyle.Format = "#,#0.00";
            gvSellOrders.Columns["Rate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gvSellOrders.Columns["Brokerage"].DefaultCellStyle.Format = "#,#0.00";
            gvSellOrders.Columns["Brokerage"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            gvSellOrders.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SoldQty_TextChanged(object sender, EventArgs e)
        {
            CalculateSellBrokerage();
        }

        private void SoldRate_TextChanged(object sender, EventArgs e)
        {
            CalculateSellBrokerage();
        }

        private void CalculateSellBrokerage()
        {
            if (string.IsNullOrWhiteSpace(txtSoldRate.Text)) return;
            if (string.IsNullOrWhiteSpace(txtSoldQty.Text)) return;
            double.TryParse(txtSoldRate.Text, out double rate);
            int.TryParse(txtSoldQty.Text, out int qty);
            double brokerage = (0.5 / 100) * rate;
            txtBrokerage.Text = brokerage.ToString("0.00");
        }
    }
}
