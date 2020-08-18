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
    public partial class ScriptMasterForm : Form
    {
        private readonly ScriptsProcessor dataProcessor = null;

        public ScriptMasterForm()
        {
            InitializeComponent();
            dataProcessor = new ScriptsProcessor();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!UiValidator.IsValidMandatoryField(txtScriptName, "Script Name")) return;
                if (!UiValidator.IsValidMandatoryField(txtShortName, "Short Name")) return;
                ScriptModel model = new ScriptModel
                {
                    IsFandOScript = chkIsFandO.Checked,
                    ShortName = txtShortName.Text.Trim(),
                    Name = txtScriptName.Text.Trim(),
                };
                dataProcessor.AddNew(model);
                LoadData();
                txtScriptName.Text = "";
                txtShortName.Text = "";
                txtScriptName.Focus();
            }
            catch (Exception exp)
            {
                MessageHelper.DisplayErrorMessage(exp.Message);
            }
        }

        private void ScriptMasterForm_Load(object sender, EventArgs e)
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
            gvScripts.DataSource = null;
            List<ScriptModel> scripts = dataProcessor.GetAll();
            gvScripts.DataSource = scripts;
            gvScripts.Refresh();
        }
    }
}
