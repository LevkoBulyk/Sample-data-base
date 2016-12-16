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

        private int _idCounter = -1;
        private int _rowCounter = 0;

        #endregion

        #endregion

        #region Constructors

        public CreateOrEditCompound()
        {
            InitializeComponent();
            this._currentCompound = new BusinessCompound();
            this._compoundServise = new CompoundServise(this._connectionString);
            btnAddMatrix_Click(null, null);
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

        }

        #region Code of matrix panels

        private void btnAddMatrix_Click(object sender, EventArgs e)
        {
            var scrolX = this.panelMatrixes.AutoScrollPosition.X;
            var scrolY = this.panelMatrixes.AutoScrollPosition.Y;

            var panel = new MatrixPanel(this._currentCompound.Matrixes.Count - 1, scrolX, scrolY);

            panel.ValueChanged += MatrixPanelValueChanged;
            panel.DeleteClicked += MatrixPanelDeleteClicked;

            var perc = new Percentage(_idCounter--, 0, null, null);

            panel.Percentage = perc;

            this.panelMatrixes.Controls.Add(panel, 0, this._rowCounter++);

            this._currentCompound.Matrixes.Add(perc, new Matrix());
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
            var panel = sender as MatrixPanel;

            this._currentCompound.Matrixes.Remove(panel.Percentage);
            this.panelMatrixes.Controls.Remove(panel);
            var i = this._currentCompound.Matrixes.Count;
            this._rowCounter--;

            //FillMatrixesWithData();
        }

        #endregion

        #endregion

        #region Helping methods

        private void FillMatrixesWithData()
        {
            int i = 0;
            foreach (var control in this.panelMatrixes.Controls)
            {
                var key = this._currentCompound.Matrixes.Keys.ToArray()[i] as Percentage;

                var panel = control as MatrixPanel;

                if (panel != null)
                {
                    panel.Percentage = key;
                    panel.Matrix = this._currentCompound.Matrixes[key];
                }
                i++;
            }
        }

        #endregion

    }
}
