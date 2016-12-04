using Sample.Entities;
using Sample.Repositories;
using System;
using System.Configuration;
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

        private void CreateCompound(object sender, EventArgs e)
        {
            CreateOrEditCompound createNewCompound = new CreateOrEditCompound();
            createNewCompound.Show();
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
                    case "Compounds":
                        // TODO: Fill data grid view with compounds must be realised
                        break;
                    default:
                        DialogsManager.ShowError("Wrong settings where to search and what to display is setted");
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
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
            {
                return;
            }
            int columnIndex = e.ColumnIndex;
            int currentId = (int)this.dgvData.Rows[rowIndex].Cells["Id"].Value;

            FillInfoLabelText(currentId);

            if (columnIndex >= 0 && this.dgvData.Columns[columnIndex] is DataGridViewButtonColumn
                && rowIndex >= 0)
            {
                switch (this.dgvData.Columns[columnIndex].Name)
                {
                    case "View":
                        DataViewButton_Cliked(currentId);
                        break;
                    case "Edit":
                        DataEditButton_Cliked(currentId);
                        break;
                    case "Delete":
                        DataDeleteButton_Cliked(currentId);
                        break;
                    default:
                        break;
                }
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

        private void FillInfoLabelText(int currentId)
        {
            if (this.tbdropdShowSettings.Text == "Matrixes")
            {
                Matrix matrix = _matrixRepository.GetMatrixById(currentId);

                this.lblInfo.Text = "Selected: " + matrix.ToString();
            }
            else if (this.tbdropdShowSettings.Text == "Dopants")
            {
                Dopant dopant = _dopantRepository.GetDopantById(currentId);

                this.lblInfo.Text = "Selected: " + dopant.ToString();
            }
            else if (this.tbdropdShowSettings.Text == "Compounds")
            {
                Matrix matrix = _matrixRepository.GetMatrixById(currentId);

                this.lblInfo.Text = "Selected: " + matrix.ToString();
            }
        }

        private void DataViewButton_Cliked(int currentId)
        {
            // TODO: Realise DataViewButton_Cliked() method
            switch (this.tbdropdShowSettings.Text)
            {
                case "Dopants":
                    break;
                case "Matrixes":
                    break;
                case "Compuonds":
                    break;
                default:
                    DialogsManager.ShowError("Wrong settings where to search and what to display is setted");
                    break;
            }
        }

        private void DataEditButton_Cliked(int currentId)
        {
            switch (this.tbdropdShowSettings.Text)
            {
                case "Dopants":
                    CreateOrEditDopand EditDopantForm = new CreateOrEditDopand(currentId);

                    if (EditDopantForm.ShowDialog() == DialogResult.OK)
                    {
                        FillDataGridView(null, null);
                    }
                    break;
                case "Matrixes":
                    CreateOrEditMatrix EditMatrixForm = new CreateOrEditMatrix(currentId);

                    if (EditMatrixForm.ShowDialog() == DialogResult.OK)
                    {
                        FillDataGridView(null, null);
                    }
                    break;
                case "Compuonds":
                    // TODO: Realise compound editing
                    break;
                default:
                    DialogsManager.ShowError("Wrong settings where to search and what to display is setted");
                    break;
            }
        }

        private void DataDeleteButton_Cliked(int currentId)
        {
            // TODO: Realise DataDeleteButton_Cliked() method
            switch (this.tbdropdShowSettings.Text)
            {
                case "Dopants":
                    if (DialogsManager.DeletingConfirmation("dopant"))
                    {
                        this._dopantRepository.DeleteDopant(currentId);
                        FillDataGridView(null, null);
                    }
                    break;
                case "Matrixes":
                    if (DialogsManager.DeletingConfirmation("matrix"))
                    {
                        this._matrixRepository.DeleteMatrixWithId(currentId);
                        FillDataGridView(null, null);
                    }
                    break;
                case "Compuonds":
                    if (DialogsManager.DeletingConfirmation("compound"))
                    {
                        // TODO: Realise compound deleting
                        FillDataGridView(null, null);
                    }
                    break;
                default:
                    DialogsManager.ShowError("Wrong settings where to search and what to display is setted");
                    break;
            }
        }

        #endregion

    }
}
