using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SbiFinanceData.Helpers
{
    public class MessageHelper
    {
        public static void DisplayErrorMessage(Exception exp)
        {
            ShowErrorMessage(exp.Message, MessageType.Error);
        }

        public static void DisplayErrorMessage(string message)
        {
            ShowErrorMessage(message, MessageType.Error);
        }

        public static void DisplayWarningMessage(string message)
        {
            ShowErrorMessage(message, MessageType.Warning);
        }

        public static void DisplayInfoMessage(string message)
        {
            ShowErrorMessage(message, MessageType.Information);
        }

        public static DialogResult DisplayConfirmMessage(string message)
        {
            return MessageBox.Show(message, "SBI Financial Transactions", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ;
        }

        private static void ShowErrorMessage(string message, MessageType messageType = MessageType.Information)
        {
            if (messageType == MessageType.Error)
            {
                MessageBox.Show(message, "SBI Financial Transactions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (messageType == MessageType.Warning)
            {
                MessageBox.Show(message, "SBI Financial Transactions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(message, "SBI Financial Transactions", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    public enum MessageType
    {
        Information,
        Warning,
        Error,
    }
}
