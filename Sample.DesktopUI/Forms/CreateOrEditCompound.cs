using Sample.BusinessEntity;
using Sample.Entities;
using Sample.Repositories;
using Sample.Servises;
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
    public partial class CreateOrEditCompound : Form
    {

        #region Fields

        private string _connectionString = ConfigurationManager.ConnectionStrings["SampleDatabase"].ConnectionString;
        private CompoundServise _compoundServise;
        private BusinessCompound _currentCompound;

        #endregion

        #region Constructors

        public CreateOrEditCompound()
        {
            InitializeComponent();
            this._currentCompound = new BusinessCompound();
            this._compoundServise = new CompoundServise(this._connectionString);
        }

        public CreateOrEditCompound(BusinessCompound compound)
            : this()
        {
            this._currentCompound = compound;
        }

        #endregion

        #region Event hendlers

        private void CreateOrEditCompound_Load(object sender, EventArgs e)
        {
            btnAddMatrix_Click(null, null);
            this._currentCompound.CompoundWasModified += SetName;
        }

        private void btnSaveChemicalComponents_Click(object sender, EventArgs e)
        {
            this._currentCompound.Compound = new Compound()
            {
                Comment = "MyCompound"
            };
            //this._currentCompound = this._compoundServise.UpdateCompoundWithId(this._currentCompound.Compound.Id, this._currentCompound);
            this._compoundServise.UpdateCompoundWithId(this._currentCompound.Compound.Id, this._currentCompound);
        }

        #region Code of matrix panels

        private void btnAddMatrix_Click(object sender, EventArgs e)
        {
            this._currentCompound.Matrixes.Add(new Percentage(), new Matrix());
            FillMatrixesWithData();
        }

        private void MatrixPanelValueChanged(object sender, MatrixPanelEventArgs e)
        {
            var percentageLink = e.Link;
            if (percentageLink == null) return;

            var matrix = e.Matrix;
            var percentage = e.Percentage;

            this._currentCompound.Matrixes.Remove(percentageLink);
            this._currentCompound.Matrixes.Add(percentage, matrix);

            (sender as MatrixPanel).LinkToPercentage = percentage;
        }

        private void MatrixPanelDeleteClicked(object sender, EventArgs e)
        {
            this._currentCompound.Matrixes.Remove((sender as MatrixPanel).LinkToPercentage);
            FillMatrixesWithData();
        }

        #region Helping method

        private void FillMatrixesWithData()
        {
            this.panelMatrixes.Controls.Clear();

            foreach (var percentage in this._currentCompound.Matrixes.Keys)
            {
                var matrix = this._currentCompound.Matrixes[percentage];

                var scrolX = this.panelMatrixes.AutoScrollPosition.X;
                var scrolY = this.panelMatrixes.AutoScrollPosition.Y;

                var panel = new MatrixPanel(this.panelMatrixes.Controls.Count, scrolX, scrolY);

                panel.ValueChanged += MatrixPanelValueChanged;
                panel.DeleteClicked += MatrixPanelDeleteClicked;

                panel.SelectedMatrix = matrix;
                panel.SelectedPercentage = percentage;
                panel.LinkToPercentage = percentage;

                this.panelMatrixes.Controls.Add(panel);
            }
        }



        #endregion

        #endregion

        #endregion

        #region Helping methods

        private void SetName(BusinessCompound sender, EventArgs e)
        {
            this.Text = sender.Name;
            this.lblName.Text = string.Format("Mame: {0}", sender.Name);
        }

        #endregion

    }
}
