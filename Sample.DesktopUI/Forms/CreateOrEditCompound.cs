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
