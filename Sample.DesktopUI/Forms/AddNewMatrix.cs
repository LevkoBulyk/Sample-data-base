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
    public partial class AddNewMatrix : Form
    {
        public AddNewMatrix()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tbxName.Text.Length == 0)
            {
                DialogsManager.ShowError("Field 'Name' must be filled.");
                return;
            }

            double energyGap = 0;
            double maxPhononEnergy = 0;
            tbxEnergyGap.Text = tbxEnergyGap.Text.Replace('.', ',');
            tbxMaxPhononEnergy.Text = tbxMaxPhononEnergy.Text.Replace('.', ',');

            if (tbxEnergyGap.Text.Length != 0 && !double.TryParse(tbxEnergyGap.Text, out energyGap))
            {
                DialogsManager.ShowError("Value of energy gap was entered incorrectly");
                return;
            }

            if (tbxMaxPhononEnergy.Text.Length != 0 && !double.TryParse(tbxMaxPhononEnergy.Text, out maxPhononEnergy))
            {
                DialogsManager.ShowError("Value of maximum phonon energy was entered incorrectly");
                return;
            }

            Matrix matrix = new Matrix(0, tbxName.Text, energyGap, maxPhononEnergy, tbxSymmetry.Text, tbxComment.Text);

            SqlMatrixRepository matrixRepository = new SqlMatrixRepository(ConfigurationManager.ConnectionStrings["SampleDatabase"].ConnectionString);

            matrixRepository.InsertMatrix(matrix);

            this.DialogResult = DialogResult.OK;
            DialogsManager.ShowSuccessAndClose("New matrix was created.", this);
        }
    }
}
