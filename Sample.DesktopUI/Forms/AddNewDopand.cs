using Sample.Entities;
using Sample.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
            if (tbxName.Text.Length == 0 || tbxValence.Text.Length == 0)
            {
                DialogsManager.ShowError("Not all required fields are filled.");
                return;
            }

            SqlDopantRepository dopantRepository = new SqlDopantRepository(ConfigurationManager.ConnectionStrings["SampleDatabase"].ConnectionString);

            Dopant dopant = new Dopant(tbxName.Text, tbxValence.Text);
            dopantRepository.InsertDopant(dopant);

            DialogsManager.ShowSuccessAndClose(this);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogsManager.CloseForm(this);
        }
    }
}
