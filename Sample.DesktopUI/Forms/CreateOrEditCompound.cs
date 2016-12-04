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
    public partial class CreateOrEditCompound : Form
    {
        private SqlMatrixRepository _sqlMatrixRepository = new SqlMatrixRepository(ConfigurationManager.ConnectionStrings["SampleDatabase"].ConnectionString);
        private List<MatrixItem> _listOfMatrixes = new List<MatrixItem>();

        public CreateOrEditCompound()
        {
            InitializeComponent();
        }

        #region Event hendlers

        private void CreateOrEditCompound_Load(object sender, EventArgs e)
        {
            btnAddMatrix_Click(null, null);
        }

        #region Code of matrix panels

        private void btnAddMatrix_Click(object sender, EventArgs e)
        {
            var count = this._listOfMatrixes.Count;
            var scrolX = this.panelMatrixes.AutoScrollPosition.X;
            var scrolY = this.panelMatrixes.AutoScrollPosition.Y;

            const int X0 = 5;
            const int Y0 = 3;
            const int L0 = 15;
            const int panelW = 450;
            const int panelH = 93;

            var matrixLbl = new Label();
            matrixLbl.Location = new Point(L0, L0);
            matrixLbl.AutoSize = true;
            matrixLbl.Text = "Matrix №" + (count + 1);

            var percentsgeLbl = new Label();
            percentsgeLbl.Location = new Point(L0, 2 * L0 + matrixLbl.Size.Height);
            percentsgeLbl.AutoSize = true;
            percentsgeLbl.Text = "Percentage";

            var matrix = new ComboBox();
            matrix.Location = new Point(3 * L0 + matrixLbl.Size.Width, L0 - 5);
            matrix.Name = "matrix" + count;
            matrix.TextUpdate += Matrix_TextChanged;
            matrix.SelectedIndexChanged += Matrix_SelectedIndexChange;
            Matrix_TextChanged(matrix, null);

            var percentage = new NumericUpDown();
            percentage.Location = new Point(matrix.Location.X, matrix.Location.Y + matrix.Size.Height + L0);
            percentage.DecimalPlaces = 3;
            percentage.ValueChanged += Percentage_ValueChanged;
            percentage.Name = "percentage" + count;

            var delete = new Button();
            delete.AutoSize = true;
            delete.Text = "Delete";
            delete.Location = new Point(percentage.Location.X + percentage.Size.Width + 5 * L0,
                (percentage.Location.Y + matrix.Location.Y) / 2);
            delete.Name = count.ToString();
            delete.Click += Delete_Click;

            var panel = new Panel();
            panel.Controls.AddRange(new Control[]
                {
                    matrixLbl,
                    percentsgeLbl,
                    matrix,
                    percentage,
                    delete
                });
            panel.Location = new Point(X0 + scrolX, Y0 + scrolY + count * (panelH + Y0));
            panel.Size = new Size(panelW, panelH);
            panel.Name = "panel" + count;

            this.panelMatrixes.Controls.Add(panel);
            this._listOfMatrixes.Add(new MatrixItem());
        }

        private void Matrix_SelectedIndexChange(object sender, EventArgs e)
        {
            ComboBox matrix = sender as ComboBox;
            if (matrix != null)
            {
                int number = -1;
                int.TryParse(matrix.Name.Substring(6), out number);
                if (number != -1)
                {
                    var selectedItem = matrix.SelectedItem as MatrixItem;
                    if (selectedItem != null)
                    {
                        this._listOfMatrixes[number].MatrixName = selectedItem.MatrixName;
                        this._listOfMatrixes[number].MatrixId = selectedItem.MatrixId;
                    }
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                int number;
                if (int.TryParse(button.Name, out number))
                {
                    this.panelMatrixes.Controls.RemoveAt(this.panelMatrixes.Controls.Count - 1);
                    this._listOfMatrixes.RemoveAt(number);
                    FillMatrixesWithData(number - 1);
                }
            }
        }

        private void Percentage_ValueChanged(object sender, EventArgs e)
        {
            var percentage = sender as NumericUpDown;
            if (percentage != null)
            {
                int number = -1;
                int.TryParse(percentage.Name.Substring(10), out number);
                if (number != -1)
                {
                    this._listOfMatrixes[number].Percentage = (double)percentage.Value;
                }
            }
        }

        private void Matrix_TextChanged(object sender, EventArgs e)
        {
            var matrix = sender as ComboBox;
            if (matrix != null)
            {
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
            }
        }

        #endregion

        #endregion

        #region Helping methods

        private void FillMatrixesWithData(int startIndex = 0)
        {
            int i = 0;
            foreach (var item in this._listOfMatrixes)
            {
                if (i > startIndex && item != null)
                {
                    Panel panel = this.panelMatrixes.Controls.Find("panel" + i, false)[0] as Panel;
                    if (panel != null)
                    {
                        ComboBox matrix = panel.Controls[2] as ComboBox;
                        NumericUpDown percentage = panel.Controls[3] as NumericUpDown;

                        if (matrix != null)
                        {
                            matrix.Text = item.MatrixName;
                            matrix.SelectedItem = new MatrixItem(item.MatrixId, item.MatrixName);
                        }

                        if (percentage != null)
                        {
                            percentage.Value = (decimal)item.Percentage;
                        }
                    }
                }
                i++;
            }
        }

        #endregion

    }
}
