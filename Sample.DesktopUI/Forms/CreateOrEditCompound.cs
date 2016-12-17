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

        #region Helping fields

        #endregion

        private int _lastId = -1;

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
        }

        #region Code of matrix panels

        private void btnAddMatrix_Click(object sender, EventArgs e)
        {
            this._currentCompound.Matrixes.Add(new Percentage(this._lastId--, 0, null, null), new Matrix());
            FillMatrixesWithData();
        }

        private void MatrixPanelValueChanged(object sender, MatrixPanelEventArgs e)
        {
            var percentage = e.Percentage;
            var previousValueOfPercentage = e.PreviousValueOfPercentare;
            var matrix = e.Matrix;

            var n = this._currentCompound.Matrixes.Count;

            if (previousValueOfPercentage == null)
            {
                this._currentCompound.Matrixes[percentage] = matrix;
            }
            else
            {
                this._currentCompound.Matrixes.Remove(previousValueOfPercentage);
                this._currentCompound.Matrixes.Add(percentage, matrix);
            }
        }

        private void MatrixPanelDeleteClicked(object sender, EventArgs e)
        {
            this._currentCompound.Matrixes.Remove((sender as MatrixPanel).Percentage);
            FillMatrixesWithData();
        }

        #endregion

        #endregion

        #region Helping methods

        private void FillMatrixesWithData()
        {
            this.panelMatrixes.Controls.Clear();

            foreach (var percentage in this._currentCompound.Matrixes.Keys)
            {
                AddMatrixToMatrixesPanelWith(percentage, this._currentCompound.Matrixes[percentage]);
            }
        }

        private void AddMatrixToMatrixesPanelWith(Percentage percentage, Matrix matrix)
        {
            var scrolX = this.panelMatrixes.AutoScrollPosition.X;
            var scrolY = this.panelMatrixes.AutoScrollPosition.Y;

            var panel = new MatrixPanel(this.panelMatrixes.Controls.Count, scrolX, scrolY);

            panel.ValueChanged += MatrixPanelValueChanged;
            panel.DeleteClicked += MatrixPanelDeleteClicked;

            panel.Percentage = percentage;
            panel.Matrix = matrix;

            this.panelMatrixes.Controls.Add(panel);
        }

        #endregion

    }
}
