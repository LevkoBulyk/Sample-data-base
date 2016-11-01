using Sample.Entities;
using Sample.Repositories;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace Sample.DesktopUI
{
    public partial class CreateOrEditMatrix : Form
    {
        private Matrix _currentMatrix;
        private SqlMatrixRepository _matrixRepository = new SqlMatrixRepository(ConfigurationManager.ConnectionStrings["SampleDatabase"].ConnectionString);

        public CreateOrEditMatrix(int Id = 0)
        {
            InitializeComponent();
            if (Id != 0)
            {
                this._currentMatrix = this._matrixRepository.GetMatrixById(Id);
            }
        }

        private void CreateOrEditMatrix_Load(object sender, EventArgs e)
        {
            if (this._currentMatrix.Id == 0)
            {
                this.btnCreateOrEdit.Text = "Create";
            }
            else
            {
                this.btnCreateOrEdit.Text = "Save";
                this.tbxName.Text = this._currentMatrix.Name;
                this.tbxEnergyGap.Text = this._currentMatrix.EnergyGap.ToString();
                this.tbxMaxPhononEnergy.Text = this._currentMatrix.MaxPhononEnergy.ToString();
                this.tbxSymmetry.Text = this._currentMatrix.Symmetry;
                this.tbxComment.Text = this._currentMatrix.Comment;
            }
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

            string message;
            if (this._currentMatrix.Id == 0)
            {
                _matrixRepository.InsertMatrix(matrix);
                message = "New matrix was created.";
            }
            else
            {
                message = "Changes were successfully saved.";
            }

            this.DialogResult = DialogResult.OK;
            DialogsManager.ShowSuccessAndClose(message, this);
        }

    }
}
