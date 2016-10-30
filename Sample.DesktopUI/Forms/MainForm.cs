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

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.dgvData.DataSource = this._sourseOfData;
            FillDataGridView(null, null);
        }

        private void tbmiMatrix_Click(object sender, EventArgs e)
        {
            AddNewMatrix AddNewMatrixForm = new AddNewMatrix();
            if (AddNewMatrixForm.ShowDialog() == DialogResult.OK)
            {
                FillDataGridView(null, null);
            }
        }

        private void tbmiDopant_Click(object sender, EventArgs e)
        {
            AddNewDopand AddNewDopandForm = new AddNewDopand();
            if (AddNewDopandForm.ShowDialog() == DialogResult.OK)
            {
                FillDataGridView(null, null);
            }
        }

        private void FillDataGridView(object sender, EventArgs e)
        {
            switch (this.tbdropdShowSettings.Text)
            {
                case "Dopants":
                    FillWithDopantsData();
                    break;
                case "Matrixes":
                    FillWithMatrixesData();
                    break;
                default:
                    break;
            }
        }

        private void FillWithMatrixesData()
        {
            this._sourseOfData.Clear();

            SqlMatrixRepository matrixRepository = new SqlMatrixRepository(ConfigurationManager.ConnectionStrings["SampleDatabase"].ConnectionString);

            foreach (var item in matrixRepository.GetAllMatrixes())
            {
                this._sourseOfData.Add(item);
            }

            if (this._sourseOfData.Count > 0)
            {
                this.dgvData.Columns["Id"].Visible = false;

                this.dgvData.Columns.Remove("Comment");
                this.dgvData.Columns.Remove("EnergyGap");
                this.dgvData.Columns.Remove("MaxPhononEnergy");
                this.dgvData.Columns.Remove("Symmetry");
            }
        }

        private void FillWithDopantsData()
        {
            this._sourseOfData.Clear();

            SqlDopantRepository dopantRepository = new SqlDopantRepository(ConfigurationManager.ConnectionStrings["SampleDatabase"].ConnectionString);

            foreach (var item in dopantRepository.GetAllDopants())
            {
                this._sourseOfData.Add(item);
            }

            if (this._sourseOfData.Count > 0)
            {
                this.dgvData.Columns["Id"].Visible = false;
            }
        }
    }
}
