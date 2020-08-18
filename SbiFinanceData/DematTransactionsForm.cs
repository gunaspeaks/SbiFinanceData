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
    public partial class DematTransactionsForm : Form
    {
        private readonly DematTransactionsProcessor dataProcessor = null;
        private List<DematTransactionModel> transactions;

        public DematTransactionsForm()
        {
            InitializeComponent();
            dataProcessor = new DematTransactionsProcessor();
            transactions = new List<DematTransactionModel>();
        }


        private void AddTransactionButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!UiValidator.IsValidMandatoryField(cmbVoucherType, "Script Name")) return;
                if(cmbVoucherType.SelectedIndex==0)
                {
                    MessageHelper.DisplayWarningMessage("Please select a Script");
                    cmbVoucherType.Focus();
                    return;
                }

                if (!UiValidator.IsValidMandatoryField(cmbVoucherType, "Voucher Type")) return;
                if (!UiValidator.IsValidNumericField(txtDebit, "Debit")) return;
                if (!UiValidator.IsValidNumericField(txtCredit, "Credit")) return;
                double.TryParse(txtDebit.Text, out double debit);
                double.TryParse(txtCredit.Text, out double credit);
                DematTransactionModel model = new DematTransactionModel
                {
                    Credit = double.Parse(credit.ToString("0.00")),
                    Debit = double.Parse(debit.ToString("0.00")),
                    VoucherType = cmbVoucherType.SelectedItem.ToString(),
                    Particulars = txtParticulars.Text.Trim(),
                    TransactionDate = dtTransDate.Value,
                };

                dataProcessor.AddNew(model);
                ResetForm();
                LoadTransactions();
            }
            catch (Exception exp)
            {
                MessageHelper.DisplayErrorMessage(exp.Message);
            }
        }

        private void TransactionsForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTransactions();
                ResetForm();
            }
            catch (Exception exp)
            {
                MessageHelper.DisplayErrorMessage(exp.Message);
            }
        }

        private void LoadTransactions()
        {
            gvTransactions.DataSource = null;
            transactions = dataProcessor.GetAll();
            gvTransactions.DataSource = transactions;
            gvTransactions.Columns["Id"].Visible = false;
            gvTransactions.Columns["Debit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gvTransactions.Columns["Debit"].DefaultCellStyle.Format = "#,#0.00";
            gvTransactions.Columns["Credit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gvTransactions.Columns["Credit"].DefaultCellStyle.Format = "#,#0.00";
            gvTransactions.Columns["TransactionDate"].DefaultCellStyle.Format = "dd-MMM-yyyy";
            gvTransactions.Refresh();
        }

        private void ResetForm()
        {
            cmbVoucherType.SelectedIndex = 0;
            txtParticulars.Text = "";
            txtDebit.Text = "";
            txtCredit.Text = "";
            dtTransDate.Focus();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(gvTransactions.SelectedRows.Count==0)
                {
                    MessageHelper.DisplayWarningMessage("Please select a Transaction to delete");
                    return;
                }
                if (DialogResult.Yes != MessageHelper.DisplayConfirmMessage($"Are you sure about deleting this Transaction")) return;
                var id = int.Parse(gvTransactions.SelectedRows[0].Cells["Id"].Value.ToString());
                dataProcessor.Delete(id);
                LoadTransactions();
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
    }
}
