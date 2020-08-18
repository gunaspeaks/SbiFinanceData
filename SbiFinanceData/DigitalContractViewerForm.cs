using SbiDataProcessor.Processors;
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
    public partial class DigitalContractViewerForm : Form
    {
        private readonly DigitalContractProcessor processor = null;
        public DigitalContractViewerForm()
        {
            InitializeComponent();
            processor = new DigitalContractProcessor();
        }


        private void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception exp)
            {
                MessageHelper.DisplayErrorMessage(exp.Message);
            }
        }

        private void LoadData()
        {
            var contracts = processor.GetAll();
            gvContracts.DataSource = contracts;
            gvContracts.Columns["TradedDate"].DefaultCellStyle.Format = "dd-MMM-yyyy";
            gvContracts.Columns["STT"].DefaultCellStyle.Format = "#,#0.00";
            gvContracts.Columns["STT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gvContracts.Columns["ETC"].DefaultCellStyle.Format = "#,#0.00";
            gvContracts.Columns["ETC"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gvContracts.Columns["IGST"].DefaultCellStyle.Format = "#,#0.00";
            gvContracts.Columns["IGST"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gvContracts.Columns["Tax"].DefaultCellStyle.Format = "#,#0.00";
            gvContracts.Columns["Tax"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gvContracts.Columns["Brokerage"].DefaultCellStyle.Format = "#,#0.00";
            gvContracts.Columns["Brokerage"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gvContracts.Refresh();
        }

        private void DigitalContractViewerForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception exp)
            {
                MessageHelper.DisplayErrorMessage(exp.Message);
            }
        }

        private void ContractsGrid_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gvContracts.SelectedRows.Count == 0)
                {
                    MessageHelper.DisplayWarningMessage("Please select a contract to update");
                    gvContracts.Focus();
                    return;
                }
                var val = int.Parse(gvContracts.SelectedRows[0].Cells[0].Value.ToString());
                DigitalContractForm frm = new DigitalContractForm(val);
                frm.ShowDialog(this);
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
                if (gvContracts.SelectedRows.Count == 0)
                {
                    MessageHelper.DisplayWarningMessage("Please select a Contract to delete");
                    return;
                }
                if (DialogResult.Yes != MessageHelper.DisplayConfirmMessage($"Are you sure about deleting this Contract")) return;
                var id = int.Parse(gvContracts.SelectedRows[0].Cells["Id"].Value.ToString());
                processor.Delete(id);
                LoadData();
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

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            DigitalContractForm frm = new DigitalContractForm();
            frm.ShowDialog(this);
        }
    }
}
