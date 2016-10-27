using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample.DesktopUI
{
    public partial class AddNewDopand : Form
    {
        public AddNewDopand()
        {
            InitializeComponent();
        }

        private void AddNewDopand_Load(object sender, EventArgs e) { }

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
