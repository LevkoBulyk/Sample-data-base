using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample.DesktopUI.Forms
{
    public partial class AddNewMatrix : Form
    {
        public AddNewMatrix()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Dialogs.ShowSuccessAndClose(this);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dialogs.CloseForm(this);
        }
    }
}
