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

        public CreateOrEditCompound()
        {
            InitializeComponent();
        }

        #region Event hendlers

        private void CreateOrEditCompound_Load(object sender, EventArgs e)
        {
            FillDGVWithColumns("matrix", this.dgvMatrixes);
            FillDGVWithColumns("dopant", this.dgvDopants);

            tbxSearchMatrix_TextChanged(null, null);
        }

        private void dgvMatrixes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvMatrixes.RowCount <= 1)
            {
                return;
            }

            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
            {
                return;
            }

            int columnIndex = e.ColumnIndex;
            if (columnIndex != this.dgvMatrixes.Columns["Delete"].Index)
            {
                return;
            }

            this.dgvMatrixes.Rows.Remove(this.dgvMatrixes.Rows[rowIndex]);
        }

        private void dgvDopants_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxSearchMatrix_TextChanged(object sender, EventArgs e)
        {
            string matrixName = "";

            /*if (string.IsNullOrEmpty(tbxSearchMatrix.Text))
            {
                
            }*/

            matrixName = tbxSearchMatrix.Text;

            //DataGridViewComboBoxColumn column = this.dgvMatrixes.Columns["Matrix"] as DataGridViewComboBoxColumn;
            var cell = this.dgvMatrixes[this.dgvMatrixes.Columns["matrix"].Index, this.dgvMatrixes.RowCount - 1] as DataGridViewComboBoxCell;
            cell.Items.Clear();
            cell.Items.AddRange(this._sqlMatrixRepository.SearchMatrixesByName(matrixName).Select(item => item.Name).ToArray());

            //column.Items.Clear();
            //column.Items.AddRange(this._sqlMatrixRepository.SearchMatrixesByName(matrixName).Select(item => item.Name).ToArray());
        }

        #endregion

        #region Helping methods

        private void AddButtonColumn(string buttonsText, DataGridView dgv)
        {
            DataGridViewColumn column = new DataGridViewButtonColumn();

            column.Name = buttonsText;
            column.HeaderCell.Value = buttonsText;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgv.Columns.Add(column);
        }

        private void FillDGVWithColumns(string name, DataGridView dgv)
        {
            var column = new DataGridViewComboBoxColumn();
            column.Name = name;
            column.HeaderCell.Value = "Name of " + name;
            column.Width = 240;

            var percentageColumn = new DataGridViewTextBoxColumn();
            percentageColumn.Name = "Percentage";
            percentageColumn.HeaderCell.Value = "Percents";
            percentageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgv.Columns.Add(column);
            dgv.Columns.Add(percentageColumn);
            AddButtonColumn("Delete", dgv);
        }

        #endregion
    }
}
