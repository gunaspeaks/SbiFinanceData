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
    public partial class DigitalContractForm : Form
    {
        private readonly DigitalContractProcessor dataProcessor = null;

        public DigitalContractForm()
        {
            InitializeComponent();
            _ContractID = 0;
            _IsNewContract = true;
            lnkBuyOrders.Enabled = false;
            lnkSellOrders.Enabled = false;
            lnkIOrders.Enabled = false;
            dataProcessor = new DigitalContractProcessor();
        }

        public DigitalContractForm(int contractID)
        {
            InitializeComponent();
            _ContractID = contractID;
            _IsNewContract = false;
            lnkBuyOrders.Enabled = true;
            lnkSellOrders.Enabled = true;
            lnkIOrders.Enabled = true;
            dataProcessor = new DigitalContractProcessor();
        }

        #region Public Properties

        private int _ContractID;
        private readonly bool _IsNewContract;

        #endregion

        private void DigitalContractForm_Load(object sender, EventArgs e)
        {
            if (_IsNewContract) return;
            try
            {
                var model = dataProcessor.GetById(_ContractID);
                if (model == null)
                {
                    MessageHelper.DisplayInfoMessage($"Looks like the Contract details are missing for ID{_ContractID}");
                    return;
                }
                txtBrokerage.Text = model.Brokerage.Value.ToString("#.00");
                txtContractNo.Text = model.DigitalContractNo.ToUpper().Trim();
                txtContractNoteNo.Text = model.ContractNoteNo.ToUpper().Trim();
                dtTradedDate.Value = model.TradedDate;
                txtEtc.Text = model.ETC.ToString("#.00");
                txtGst.Text = model.IGST.ToString("#.00");
                txtOtherTaxes.Text = model.Tax.ToString("#.00");
                txtStt.Text = model.STT.ToString("#.00");
                int buyOrders = dataProcessor.GetBuyOrdersCount(_ContractID);
                int sellOrders = dataProcessor.GetSellOrdersCount(_ContractID);
                int intraOrders = dataProcessor.GetIntradayOrdersCount(_ContractID);
                lnkBuyOrders.Text = $"&Buy Orders ({buyOrders})";
                lnkSellOrders.Text = $"Sell &Orders ({sellOrders})";
                lnkIOrders.Text = $"&Intraday Transactions ({intraOrders})";
            }
            catch (Exception exp)
            {
                MessageHelper.DisplayErrorMessage(exp.Message);
            }
        }

        private void SellOrders_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SellOrdersForm frm = new SellOrdersForm(_ContractID, txtContractNo.Text, dtTradedDate.Value);
            frm.ShowDialog(this);
        }

        private void BuyOrders_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BuyOrdersForm frm = new BuyOrdersForm(_ContractID, txtContractNo.Text, dtTradedDate.Value);
            frm.ShowDialog(this);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!UiValidator.IsValidMandatoryField(txtContractNoteNo, "Contract Note Number")) return;
                if (!UiValidator.IsValidNumericField(txtBrokerage, "Brokerage")) return;
                if (!UiValidator.IsValidNumericField(txtStt, "STT")) return;
                if (!UiValidator.IsValidNumericField(txtEtc, "ETC")) return;
                if (!UiValidator.IsValidNumericField(txtGst, "GST")) return;
                if (!UiValidator.IsValidNumericField(txtOtherTaxes, "Other Taxes")) return;
                float.TryParse(txtBrokerage.Text, out float brokerage);
                float.TryParse(txtEtc.Text, out float etc);
                float.TryParse(txtGst.Text, out float gst);
                float.TryParse(txtStt.Text, out float stt);
                float.TryParse(txtOtherTaxes.Text, out float tax);

                DigitalContractModel model = new DigitalContractModel
                {
                    Brokerage = double.Parse(brokerage.ToString("0.00")),
                    ContractNoteNo = txtContractNoteNo.Text.ToUpper().Trim(),
                    DigitalContractNo = txtContractNo.Text.ToUpper().Trim(),
                    ETC = double.Parse(etc.ToString("#.00")),
                    IGST = double.Parse(gst.ToString("#.00")),
                    STT = double.Parse(stt.ToString("#.00")),
                    Tax = double.Parse(tax.ToString("#.00")),
                    TradedDate = dtTradedDate.Value,
                    Id = _ContractID,
                };
                if (_IsNewContract)
                {
                    _ContractID = dataProcessor.AddNew(model);
                    lnkBuyOrders.Enabled = true;
                    lnkSellOrders.Enabled = true;
                    lnkIOrders.Enabled = true;
                }
                else
                {
                    dataProcessor.Update(model);
                }
                MessageHelper.DisplayInfoMessage("Contract details are stored successfully");
            }
            catch (Exception exp)
            {
                MessageHelper.DisplayErrorMessage(exp.Message);
            }
        }

        private void TradedDate_ValueChanged(object sender, EventArgs e)
        {
            GenerateContractNo();
        }

        private void ContractNoteNo_TextChanged(object sender, EventArgs e)
        {
            GenerateContractNo();
        }

        private void GenerateContractNo()
        {
            txtContractNo.Text = $"DC-{txtContractNoteNo.Text.ToUpper().Trim()}-{dtTradedDate.Value.Day.ToString("00")}{dtTradedDate.Value.Month.ToString("00")}{dtTradedDate.Value.Year.ToString("0000")}";
        }

        private void IntradayOrders_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IntradayForm frm = new IntradayForm(_ContractID, txtContractNo.Text, dtTradedDate.Value);
            frm.ShowDialog(this);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
