using Sample.Entities;
using Sample.Repositories;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace Sample.DesktopUI
{
    public partial class CreateOrEditDopand : Form
    {
        private Dopant _currentDopant;
        private SqlDopantRepository _dopantRepository = new SqlDopantRepository(ConfigurationManager.ConnectionStrings["SampleDatabase"].ConnectionString);

        public CreateOrEditDopand(int Id = 0)
        {
            InitializeComponent();

            if (Id != 0)
            {
                this._currentDopant = this._dopantRepository.GetDopantById(Id);
            }
        }

        private void CreateOrEditDopand_Load(object sender, EventArgs e)
        {
            if (this._currentDopant == null)
            {
                this.btnCreateOrEdit.Text = "Create";
            }
            else
            {
                this.btnCreateOrEdit.Text = "Save";
                this.tbxName.Text = this._currentDopant.Name;
                this.tbxValence.Text = this._currentDopant.Valence;
            }
        }

        private void btnCreateOrEdit_Click(object sender, EventArgs e)
        {
            if (tbxName.Text.Length == 0 || tbxValence.Text.Length == 0)
            {
                DialogsManager.ShowError("Not all required fields are filled.");
                return;
            }

            Dopant dopant = new Dopant(0, tbxName.Text, tbxValence.Text);

            string message;
            if (this._currentDopant == null)
            {
                this._dopantRepository.InsertDopant(dopant);
                message = "New dopant was created.";
            }
            else
            {
                this._dopantRepository.UpdateDopantWithId(this._currentDopant.Id, dopant);
                message = "Changes were successfully saved.";
            }

            this.DialogResult = DialogResult.OK;
            DialogsManager.ShowSuccessAndClose(message, this);
        }
    }
}
