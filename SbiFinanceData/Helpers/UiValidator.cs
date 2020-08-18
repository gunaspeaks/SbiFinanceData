using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SbiFinanceData.Helpers
{
    public class UiValidator
    {
        public static bool IsValidMandatoryField(TextBox textBox, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageHelper.DisplayInfoMessage($"Please enter \"{fieldName}\"");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsValidMandatoryField(ComboBox comboBox, string fieldName)
        {
            if (comboBox.SelectedItem == null)
            {
                MessageHelper.DisplayInfoMessage($"Please select a \"{fieldName}\"");
                comboBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsValidNumericField(TextBox textBox, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text)) return true;
            bool isValid = float.TryParse(textBox.Text, out float val);
            if (!isValid)
            {
                MessageHelper.DisplayWarningMessage($"Please enter a valid numeric value for \"{fieldName}\"");
                textBox.Focus();
                return false;
            }
            return true;
        }
    }
}
