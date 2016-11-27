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
                this.Text = "Edit matrix " + this._currentMatrix.Name;
            }
        }

        private void CreateOrEditMatrix_Load(object sender, EventArgs e)
        {
            if (this._currentMatrix == null)
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
            if (string.IsNullOrEmpty(tbxName.Text))
            {
                DialogsManager.ShowError("Field 'Name' must be filled.");
                return;
            }

            double energyGap = 0;
            double maxPhononEnergy = 0;
            tbxEnergyGap.Text = tbxEnergyGap.Text.Replace('.', ',');
            tbxMaxPhononEnergy.Text = tbxMaxPhononEnergy.Text.Replace('.', ',');

            if (!string.IsNullOrEmpty(tbxEnergyGap.Text) && !double.TryParse(tbxEnergyGap.Text, out energyGap))
            {
                DialogsManager.ShowError("Value of energy gap was entered incorrectly");
                return;
            }

            if (!string.IsNullOrEmpty(tbxMaxPhononEnergy.Text) && !double.TryParse(tbxMaxPhononEnergy.Text, out maxPhononEnergy))
            {
                DialogsManager.ShowError("Value of maximum phonon energy was entered incorrectly");
                return;
            }

            Matrix matrix = new Matrix(0, tbxName.Text, energyGap, maxPhononEnergy, tbxSymmetry.Text, tbxComment.Text);

            string message;
            if (this._currentMatrix == null)
            {
                _matrixRepository.InsertMatrix(matrix);
                message = "New matrix was created.";
            }
            else
            {
                _matrixRepository.UpdateMatrixWithId(this._currentMatrix.Id, matrix);
                message = "Changes were successfully saved.";
            }

            this.DialogResult = DialogResult.OK;
            DialogsManager.ShowSuccessAndClose(message, this);
        }

    }
}
