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
    public static class Dialogs
    {
        public static void ShowSuccessAndClose(Form form)
        {
            MessageBox.Show("New dopand was created.", "Success", MessageBoxButtons.OK);
            form.Close();
        }

        public static void CloseForm(Form form)
        {
            DialogResult dr = MessageBox.Show("Do you want cancel?", "Canceling", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                form.Close();
            }
        }
    }
}
