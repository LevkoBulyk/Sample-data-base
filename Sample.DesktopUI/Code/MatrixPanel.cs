using Sample.Entities;
using Sample.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample.DesktopUI
{
    public class MatrixPanel : Panel
    {

        #region Fields

        #region UI elements

        private Label _matrixLabel;
        private Label _percentageLabel;
        private ComboBox _matrixComboBox;
        private NumericUpDown _percentageNumeric;
        private Button _deleteButton;

        #endregion

        #region Value

        private Matrix _selectedMatrix;
        private Percentage _selectedPercentage;

        #endregion

        private IMatrixRepository _sqlMatrixRepository = new SqlMatrixRepository(ConfigurationManager.ConnectionStrings["SampleDataBase"].ConnectionString);

        #endregion

        #region Delegates and events

        public delegate void ValueChangedEventHandler(object sender, MatrixPanelEventArgs args);
        public event ValueChangedEventHandler ValueChanged;

        public delegate void DeleteClickedEventHandler(object sender, EventArgs args);
        public event DeleteClickedEventHandler DeleteClicked;

        #endregion

        #region Properties

        public Matrix Matrix
        {
            get { return this._selectedMatrix; }
            set
            {
                this._selectedMatrix = new Matrix()
                {
                    Id = value.Id,
                    Name = value.Name,
                    EnergyGap = value.EnergyGap,
                    MaxPhononEnergy = value.MaxPhononEnergy,
                    Symmetry = value.Symmetry,
                    Comment = value.Comment,
                    WasModified = true
                };
                this._matrixComboBox.Text = value.Name;
            }
        }
        public Percentage Percentage
        {
            get { return this._selectedPercentage; }
            set
            {
                this._selectedPercentage = new Percentage()
                {
                    Id = value.Id,
                    Number = value.Number,
                    DopantId = value.DopantId,
                    MatrixId = value.MatrixId,
                    WasModified = true
                };
                this._percentageNumeric.Value = (decimal)value.Number;
            }
        }

        #endregion

        #region Constructors

        public MatrixPanel(int currentNumber, int scrolX, int scrolY)
            : base()
        {
            const int X0 = 5;
            const int Y0 = 3;
            const int L0 = 15;
            const int panelW = 450;
            const int panelH = 93;

            this._matrixLabel = new Label();
            this._matrixLabel.Location = new Point(L0, L0);
            this._matrixLabel.AutoSize = true;
            this._matrixLabel.Text = "Matrix №" + (currentNumber + 1);

            this._percentageLabel = new Label();
            this._percentageLabel.Location = new Point(L0, 2 * L0 + this._matrixLabel.Size.Height);
            this._percentageLabel.AutoSize = true;
            this._percentageLabel.Text = "Percentage";

            this._matrixComboBox = new ComboBox();
            this._matrixComboBox.Location = new Point(3 * L0 + this._matrixLabel.Size.Width, L0 - 5);
            this._matrixComboBox.Name = "matrix";
            this._matrixComboBox.TextUpdate += Matrix_TextChanged;
            this._matrixComboBox.SelectedIndexChanged += Matrix_SelectedIndexChange;
            Matrix_TextChanged(this._matrixComboBox, EventArgs.Empty);

            this._percentageNumeric = new NumericUpDown();
            this._percentageNumeric.Location = new Point(this._matrixComboBox.Location.X, this._matrixComboBox.Location.Y + this._matrixComboBox.Size.Height + L0);
            this._percentageNumeric.DecimalPlaces = 3;
            this._percentageNumeric.ValueChanged += Percentage_ValueChanged;
            this._percentageNumeric.Name = "percentage";

            this._deleteButton = new Button();
            this._deleteButton.AutoSize = true;
            this._deleteButton.Text = "Delete";
            this._deleteButton.Location = new Point(this._percentageNumeric.Location.X + this._percentageNumeric.Size.Width + 5 * L0,
                (this._percentageNumeric.Location.Y + this._matrixComboBox.Location.Y) / 2);
            this._deleteButton.Click += OnDeleteClicked;

            this.Controls.AddRange(new Control[]
                {
                    this._matrixLabel,
                    this._percentageLabel,
                    this._matrixComboBox,
                    this._percentageNumeric,
                    this._deleteButton
                });

            this.Size = new Size(panelW, panelH);
            this.Name = "panel" + currentNumber;
            this.Location = new Point(X0, Y0 + this.Height * currentNumber);

            this.Percentage = new Percentage();
            this.Matrix = new Matrix();
        }

        #endregion

        #region Methods

        public void RefreshData()
        {
            this._matrixComboBox.Text = this.Matrix.Name;
            this._percentageNumeric.Value = (decimal)this.Percentage.Number;
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke(this, EventArgs.Empty);
        }

        private void Percentage_ValueChanged(object sender, EventArgs e)
        {
            var previousValueOfPercentage = this.Percentage;

            if (this.Percentage.Id >= 0)
            {
                this.Percentage.Id = -1;
            }

            this.Percentage.Number = (double)this._percentageNumeric.Value;

            OnValueChanged(previousValueOfPercentage);
        }

        private void Matrix_SelectedIndexChange(object sender, EventArgs e)
        {
            ComboBox matrix = this._matrixComboBox;
            var selectedItem = matrix.SelectedItem as Matrix;
            if (selectedItem != null)
            {
                this._selectedMatrix = selectedItem;
                OnValueChanged(null);
            }
        }

        private void Matrix_TextChanged(object sender, EventArgs e)
        {
            var matrix = this._matrixComboBox;
            string text = matrix.Text;
            var matrixes = _sqlMatrixRepository.SearchMatrixesByName(matrix.Text).ToArray();
            matrix.Items.Clear();
            matrix.Items.AddRange(matrixes);
            matrix.DroppedDown = false;
            matrix.DroppedDown = true;
            matrix.Text = text;
            matrix.SelectionStart = matrix.Text.Length;
            Cursor.Current = Cursors.Default;
        }

        #endregion

        #region Event raisers

        protected virtual void OnValueChanged(Percentage previousValueOfPercentage)
        {
            ValueChanged?.Invoke(this, new MatrixPanelEventArgs()
            {
                Matrix = this.Matrix,
                Percentage = this.Percentage,
                PreviousValueOfPercentare = previousValueOfPercentage
            });
        }

        #endregion

    }

    public class MatrixPanelEventArgs : EventArgs
    {
        public Matrix Matrix { get; set; }
        public Percentage Percentage { get; set; }
        public Percentage PreviousValueOfPercentare { get; set; }
    }
}
