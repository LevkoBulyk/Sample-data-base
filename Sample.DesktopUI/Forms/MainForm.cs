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
    public partial class MainForm : Form
    {
        private BindingSource _sourseOfData = new BindingSource();
        private SqlDopantRepository _dopantRepository = new SqlDopantRepository(ConfigurationManager.ConnectionStrings["SampleDatabase"].ConnectionString);
        private SqlMatrixRepository _matrixRepository = new SqlMatrixRepository(ConfigurationManager.ConnectionStrings["SampleDatabase"].ConnectionString);

        public MainForm()
        {
            InitializeComponent();
        }

        #region Methods subscribed to events

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.dgvData.DataSource = this._sourseOfData;
            FillDataGridView(null, null);
        }

        private void CreateMatrix(object sender, EventArgs e)
        {
            CreateOrEditMatrix AddNewMatrixForm = new CreateOrEditMatrix(0);
            if (AddNewMatrixForm.ShowDialog() == DialogResult.OK)
            {
                FillDataGridView(null, null);
            }
        }

        private void CreateDopant(object sender, EventArgs e)
        {
            CreateOrEditDopand AddNewDopandForm = new CreateOrEditDopand(0);
            if (AddNewDopandForm.ShowDialog() == DialogResult.OK)
            {
                FillDataGridView(null, null);
            }
        }

        private void FillDataGridView(object sender, EventArgs e)
        {
            this.dgvData.Rows.Clear();
            this.dgvData.Columns.Clear();
            this.dgvData.Visible = true;
            AddButtonColumn("View");

            {
                string name = "";
                if (this.tbtbxSearch.Text != null)
                {
                    name = this.tbtbxSearch.Text;
                }

                switch (this.tbdropdShowSettings.Text)
                {
                    case "Dopants":
                        FillWithDopantsWithName(name);
                        break;
                    case "Matrixes":
                        FillWithMatrixesWithName(name);
                        break;
                    default:
                        break;
                }
            }

            AddButtonColumn("Edit");
            AddButtonColumn("Delete");

            for (int i = 0; i < this.dgvData.RowCount; i++)
            {
                this.dgvData.Rows[i].Cells["View"].Value = "View";
                this.dgvData.Rows[i].Cells["Edit"].Value = "Edit";
                this.dgvData.Rows[i].Cells["Delete"].Value = "Delete";
            }

            if (this.dgvData.RowCount == 0)
            {
                this.dgvData.Columns.Clear();
                this.dgvData.Visible = false;
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = this.dgvData.CurrentCell.RowIndex;
            int currentId = (int)this.dgvData.Rows[rowIndex].Cells["Id"].Value;

            if (this.tbdropdShowSettings.Text == "Matrixes")
            {
                Matrix matrix = _matrixRepository.GetMatrixById(currentId);

                this.lblInfo.Text = "Selected: " + matrix.ToString();
            }
            else if(this.tbdropdShowSettings.Text == "Dopants")
            {
                Dopant dopant = _dopantRepository.GetDopantById(currentId);

                this.lblInfo.Text = "Selected: " + dopant.ToString();
            }
            else if(this.tbdropdShowSettings.Text == "Compounds")
            {

            }
        }

        #endregion

        #region Helping methods

        private void FillWithMatrixesWithName(string name)
        {
            this._sourseOfData.Clear();

            foreach (var item in _matrixRepository.SearchMatrixesByName("%" + name + "%"))
            {
                this._sourseOfData.Add(item);
            }

            if (this._sourseOfData.Count > 0)
            {

                this.dgvData.Columns["Id"].Visible = false;
                /*
                this.dgvData.Columns.Remove("Comment");
                this.dgvData.Columns.Remove("EnergyGap");
                this.dgvData.Columns.Remove("MaxPhononEnergy");
                this.dgvData.Columns.Remove("Symmetry");
                */
            }
        }

        private void FillWithDopantsWithName(string name)
        {
            this._sourseOfData.Clear();

            foreach (var item in _dopantRepository.SeachDopantsByName("%" + name + "%"))
            {
                this._sourseOfData.Add(item);
            }

            if (this._sourseOfData.Count > 0)
            {
                this.dgvData.Columns["Id"].Visible = false;
            }
        }

        private void AddButtonColumn(string buttonsText)
        {
            DataGridViewColumn column = new DataGridViewButtonColumn();

            column.Name = buttonsText;
            column.HeaderCell.Value = "";
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            this.dgvData.Columns.Add(column);
        }

        #endregion

    }
}
