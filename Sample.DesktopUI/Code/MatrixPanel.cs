using Sample.Entities;
using Sample.Repositories;
using System;
using System.Configuration;
using System.Drawing;
using System.Linq;
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

        #region Current value

        private int _selectedMatrixId = -1;
        private int _selectedPercentageId = -1;
        private double _selectedPercentageNumber = 0;
        private Percentage _linkToPercentage;

        #endregion

        #region Repositoies

        private string _connectionString;
        private IMatrixRepository _sqlMatrixRepository;
        private ISqlPercentageRepository _sqlPercentageRepository;

        #endregion

        #endregion

        #region Delegates and events

        public delegate void ValueChangedEventHandler(object sender, MatrixPanelEventArgs args);
        public event ValueChangedEventHandler ValueChanged;

        public delegate void DeleteClickedEventHandler(object sender, MatrixPanelEventArgs args);
        public event DeleteClickedEventHandler DeleteClicked;

        #endregion

        #region Properties

        public Matrix SelectedMatrix
        {
            get
            {
                return this._sqlMatrixRepository.GetMatrixById(this._selectedMatrixId);
            }

            set
            {
                var matrix = this._sqlMatrixRepository.GetMatrixById(value.Id);

                if (matrix != null)
                {
                    this._selectedMatrixId = value.Id;
                    this._matrixComboBox.Text = matrix.Name;

                    this.SelectedPercentage = new Percentage()
                    {
                        Number = this._selectedPercentageNumber,
                        MatrixId = this._selectedMatrixId
                    };
                }
                else
                {
                    this._selectedMatrixId = -1;
                    this._matrixComboBox.Text = value.Name;

                    this._selectedPercentageId = -1;
                }
            }
        }

        public Percentage SelectedPercentage
        {
            get
            {
                var result = this._sqlPercentageRepository.GetPersentageById(this._selectedPercentageId);

                if (result == null)
                {
                    result = new Percentage(
                        -1,
                        this._selectedPercentageNumber > 0 ? this._selectedPercentageNumber : 0,
                        null,
                        this._selectedMatrixId >= 0 ? this._selectedMatrixId : (int?)null
                        );
                }

                return result;
            }

            set
            {
                var percentageById = this._sqlPercentageRepository.GetPersentageById(value.Id);

                if (percentageById != null &&
                    value.MatrixId == percentageById.MatrixId &&
                    value.Number == percentageById.Number)
                {
                    this._selectedPercentageId = value.Id;
                    this._selectedPercentageNumber = value.Number;
                }
                else
                {
                    var percentageByParams = this._sqlPercentageRepository.GetPercentageWithValues
                        (value.Number,
                        value.MatrixId,
                        value.DopantId);

                    if (percentageByParams != null &&
                        value.MatrixId == percentageByParams.MatrixId &&
                        value.Number == percentageByParams.Number)
                    {
                        this._selectedPercentageId = percentageById.Id;
                        this._selectedPercentageNumber = percentageById.Number;
                    }
                    else
                    {
                        this._selectedPercentageId = -1;
                        this._selectedPercentageNumber = value.Number;
                    }
                }

                this._percentageNumeric.Value = (decimal)this._selectedPercentageNumber;
            }
        }

        public Percentage LinkToPercentage
        {
            get { return _linkToPercentage; }
            set { this._linkToPercentage = value; }
        }

        #endregion

        #region Constructors

        public MatrixPanel(int currentNumber, int scrolX, int scrolY)
            : base()
        {
            this._connectionString = ConfigurationManager.ConnectionStrings["SampleDataBase"].ConnectionString;
            this._sqlMatrixRepository = new SqlMatrixRepository(this._connectionString);
            this._sqlPercentageRepository = new SqlPercentageRepository(this._connectionString);

            InitialiseComponents(currentNumber, scrolX, scrolY);
        }

        #endregion

        #region Methods

        #region Event handlers

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke(this, new MatrixPanelEventArgs()
            {
                Matrix = this.SelectedMatrix,
                Percentage = this.SelectedPercentage,
                Link = this._linkToPercentage
            });
        }

        private void Percentage_ValueChanged(object sender, EventArgs e)
        {
            this.SelectedPercentage = new Percentage(this._selectedPercentageId,
                (double)this._percentageNumeric.Value,
                null,
                this._selectedMatrixId);
            OnValueChanged();
        }

        private void Matrix_SelectedIndexChange(object sender, EventArgs e)
        {
            this.SelectedMatrix = new Matrix()
            {
                Id = (this._matrixComboBox.SelectedItem as MatrixItem).Id
            };
            OnValueChanged();
        }

        private void Matrix_TextChanged(object sender, EventArgs e)
        {
            var matrix = this._matrixComboBox;
            string text = matrix.Text;

            var matrixes = from m in _sqlMatrixRepository.SearchMatrixesByName(matrix.Text)
                           select new MatrixItem(m.Id, m.Name);

            matrix.Items.Clear();
            matrix.Items.AddRange(matrixes.ToArray());

            matrix.DroppedDown = false;
            matrix.DroppedDown = true;

            matrix.Text = text;
            matrix.SelectionStart = matrix.Text.Length;
            Cursor.Current = Cursors.Default;

            this._selectedMatrixId = -1;
        }

        #endregion

        #region Event raisers

        protected virtual void OnValueChanged()
        {
            ValueChanged?.Invoke(this, new MatrixPanelEventArgs()
            {
                Matrix = this.SelectedMatrix,
                Percentage = this.SelectedPercentage,
                Link = this._linkToPercentage
            });
        }

        #endregion

        #region Helping methods

        private void InitialiseComponents(int currentNumber, int scrolX, int scrolY)
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
        }

        #endregion

        #endregion

    }

    public class MatrixPanelEventArgs : EventArgs
    {
        public Matrix Matrix { get; set; }
        public Percentage Percentage { get; set; }
        public Percentage Link { get; set; }
    }

    public class MatrixItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public MatrixItem() { }
        public MatrixItem(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }

}
