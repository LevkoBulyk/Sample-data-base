namespace Sample.DesktopUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainToolBar = new System.Windows.Forms.ToolStrip();
            this.tbbtnCreate = new System.Windows.Forms.ToolStripDropDownButton();
            this.tbmiMatrix = new System.Windows.Forms.ToolStripMenuItem();
            this.tbmiDopant = new System.Windows.Forms.ToolStripMenuItem();
            this.tbbtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tbtbxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbdropdShowSettings = new System.Windows.Forms.ToolStripComboBox();
            this.tbbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lblNoData = new System.Windows.Forms.Label();
            this.mainToolBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // mainToolBar
            // 
            this.mainToolBar.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.mainToolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbbtnCreate,
            this.tbbtnSearch,
            this.tbtbxSearch,
            this.toolStripSeparator1,
            this.tbdropdShowSettings,
            this.tbbtnRefresh});
            this.mainToolBar.Location = new System.Drawing.Point(0, 0);
            this.mainToolBar.Name = "mainToolBar";
            this.mainToolBar.Size = new System.Drawing.Size(882, 27);
            this.mainToolBar.TabIndex = 2;
            this.mainToolBar.Text = "Main tool bar";
            // 
            // tbbtnCreate
            // 
            this.tbbtnCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbbtnCreate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbmiMatrix,
            this.tbmiDopant});
            this.tbbtnCreate.Image = ((System.Drawing.Image)(resources.GetObject("tbbtnCreate.Image")));
            this.tbbtnCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbtnCreate.Name = "tbbtnCreate";
            this.tbbtnCreate.ShowDropDownArrow = false;
            this.tbbtnCreate.Size = new System.Drawing.Size(58, 24);
            this.tbbtnCreate.Text = "Create";
            this.tbbtnCreate.ToolTipText = "Create new record in database";
            // 
            // tbmiMatrix
            // 
            this.tbmiMatrix.Name = "tbmiMatrix";
            this.tbmiMatrix.ShortcutKeyDisplayString = "(Ctrl+M)";
            this.tbmiMatrix.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.tbmiMatrix.Size = new System.Drawing.Size(203, 26);
            this.tbmiMatrix.Text = "Matrix";
            this.tbmiMatrix.Click += new System.EventHandler(this.CreateMatrix);
            // 
            // tbmiDopant
            // 
            this.tbmiDopant.Name = "tbmiDopant";
            this.tbmiDopant.ShortcutKeyDisplayString = "(Ctrl+D)";
            this.tbmiDopant.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.tbmiDopant.Size = new System.Drawing.Size(203, 26);
            this.tbmiDopant.Text = "Dopant";
            this.tbmiDopant.Click += new System.EventHandler(this.CreateDopant);
            // 
            // tbbtnSearch
            // 
            this.tbbtnSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbbtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("tbbtnSearch.Image")));
            this.tbbtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbtnSearch.Name = "tbbtnSearch";
            this.tbbtnSearch.Size = new System.Drawing.Size(24, 24);
            this.tbbtnSearch.Text = "Search";
            this.tbbtnSearch.ToolTipText = "Search in database";
            this.tbbtnSearch.Click += new System.EventHandler(this.FillDataGridView);
            // 
            // tbtbxSearch
            // 
            this.tbtbxSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbtbxSearch.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.tbtbxSearch.Name = "tbtbxSearch";
            this.tbtbxSearch.Size = new System.Drawing.Size(100, 27);
            this.tbtbxSearch.ToolTipText = "Enter text for searching in database";
            this.tbtbxSearch.TextChanged += new System.EventHandler(this.FillDataGridView);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tbdropdShowSettings
            // 
            this.tbdropdShowSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbdropdShowSettings.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbdropdShowSettings.Items.AddRange(new object[] {
            "Compounds",
            "Dopants",
            "Matrixes"});
            this.tbdropdShowSettings.Name = "tbdropdShowSettings";
            this.tbdropdShowSettings.Size = new System.Drawing.Size(121, 27);
            this.tbdropdShowSettings.Text = "Compounds";
            this.tbdropdShowSettings.ToolTipText = "Choose where to search and what to display";
            this.tbdropdShowSettings.TextChanged += new System.EventHandler(this.FillDataGridView);
            // 
            // tbbtnRefresh
            // 
            this.tbbtnRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbbtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tbbtnRefresh.Image")));
            this.tbbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbtnRefresh.Name = "tbbtnRefresh";
            this.tbbtnRefresh.Size = new System.Drawing.Size(24, 24);
            this.tbbtnRefresh.Text = "Refresh";
            this.tbbtnRefresh.Click += new System.EventHandler(this.FillDataGridView);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Controls.Add(this.dgvData);
            this.panel1.Controls.Add(this.lblNoData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 498);
            this.panel1.TabIndex = 4;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.SystemColors.Control;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.Location = new System.Drawing.Point(0, 477);
            this.lblInfo.MaximumSize = new System.Drawing.Size(630, 19);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Padding = new System.Windows.Forms.Padding(3);
            this.lblInfo.Size = new System.Drawing.Size(90, 19);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "Selected:";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(14, 13);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(854, 461);
            this.dgvData.TabIndex = 2;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // lblNoData
            // 
            this.lblNoData.AutoSize = true;
            this.lblNoData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNoData.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNoData.Location = new System.Drawing.Point(22, 23);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(102, 22);
            this.lblNoData.TabIndex = 5;
            this.lblNoData.Text = "No data . . .";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainToolBar);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(420, 320);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Samples database manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainToolBar.ResumeLayout(false);
            this.mainToolBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip mainToolBar;
        private System.Windows.Forms.ToolStripDropDownButton tbbtnCreate;
        private System.Windows.Forms.ToolStripMenuItem tbmiMatrix;
        private System.Windows.Forms.ToolStripMenuItem tbmiDopant;
        private System.Windows.Forms.ToolStripButton tbbtnSearch;
        private System.Windows.Forms.ToolStripTextBox tbtbxSearch;
        private System.Windows.Forms.ToolStripComboBox tbdropdShowSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbbtnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblNoData;
    }
}