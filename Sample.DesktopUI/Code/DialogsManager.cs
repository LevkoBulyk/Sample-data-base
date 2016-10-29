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
        public static void ShowSuccessAndClose(Form form)
        {
            MessageBox.Show("New dopand was created.", "Success", MessageBoxButtons.OK);
            form.Close();
        }

        public static void ShowError(string errorText)
        {
            MessageBox.Show(errorText, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool CloseForm(Form form)
        {
            DialogResult dr = MessageBox.Show("Do you want cancel?", "Canceling", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return dr == DialogResult.Yes;
        }
    }
}
