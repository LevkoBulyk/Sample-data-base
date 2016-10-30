using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample.DesktopUI
{
    /// <summary>
    /// Functionality of shoving dialogs and closing windows
    /// </summary>
    public static class DialogsManager
    {
        public static void ShowSuccessAndClose(string message, Form form)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK);
            form.Close();
        }

        public static void ShowError(string errorText)
        {
            MessageBox.Show(errorText, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
