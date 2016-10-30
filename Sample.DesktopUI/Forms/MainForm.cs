using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AddNewDopand AddNewForm = new AddNewDopand();
            AddNewMatrix AddNewForm = new AddNewMatrix();
            AddNewForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
