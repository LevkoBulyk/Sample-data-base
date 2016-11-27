namespace Sample.DesktopUI
{
    partial class CreateOrEditCompound
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpChemicalComponents = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveChemicalComponents = new System.Windows.Forms.Button();
            this.gbDopants = new System.Windows.Forms.GroupBox();
            this.gbMatrixes = new System.Windows.Forms.GroupBox();
            this.tbxSearchDopants = new System.Windows.Forms.TextBox();
            this.lblSearchDopants = new System.Windows.Forms.Label();
            this.dgvDopants = new System.Windows.Forms.DataGridView();
            this.dgvMatrixes = new System.Windows.Forms.DataGridView();
            this.tbxSearchMatrix = new System.Windows.Forms.TextBox();
            this.lblSearchMatrixes = new System.Windows.Forms.Label();
            this.tcMain.SuspendLayout();
            this.tpChemicalComponents.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.gbDopants.SuspendLayout();
            this.gbMatrixes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDopants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(444, 492);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 36);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveAll.Location = new System.Drawing.Point(13, 492);
            this.btnSaveAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(85, 36);
            this.btnSaveAll.TabIndex = 4;
            this.btnSaveAll.Text = "Save all";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(534, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tpChemicalComponents);
            this.tcMain.Controls.Add(this.tabPage2);
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Margin = new System.Windows.Forms.Padding(4);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(542, 484);
            this.tcMain.TabIndex = 0;
            // 
            // tpChemicalComponents
            // 
            this.tpChemicalComponents.AutoScroll = true;
            this.tpChemicalComponents.Controls.Add(this.tableLayoutPanel);
            this.tpChemicalComponents.Location = new System.Drawing.Point(4, 28);
            this.tpChemicalComponents.Margin = new System.Windows.Forms.Padding(4);
            this.tpChemicalComponents.Name = "tpChemicalComponents";
            this.tpChemicalComponents.Padding = new System.Windows.Forms.Padding(4);
            this.tpChemicalComponents.Size = new System.Drawing.Size(534, 452);
            this.tpChemicalComponents.TabIndex = 0;
            this.tpChemicalComponents.Text = "Chemical components";
            this.tpChemicalComponents.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.gbMatrixes, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.gbDopants, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.btnSaveChemicalComponents, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(526, 444);
            this.tableLayoutPanel.TabIndex = 8;
            // 
            // btnSaveChemicalComponents
            // 
            this.btnSaveChemicalComponents.Location = new System.Drawing.Point(3, 407);
            this.btnSaveChemicalComponents.Name = "btnSaveChemicalComponents";
            this.btnSaveChemicalComponents.Size = new System.Drawing.Size(295, 34);
            this.btnSaveChemicalComponents.TabIndex = 8;
            this.btnSaveChemicalComponents.Text = "Save changes in chemical components";
            this.btnSaveChemicalComponents.UseVisualStyleBackColor = true;
            // 
            // gbDopants
            // 
            this.gbDopants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDopants.Controls.Add(this.tbxSearchDopants);
            this.gbDopants.Controls.Add(this.lblSearchDopants);
            this.gbDopants.Controls.Add(this.dgvDopants);
            this.gbDopants.Location = new System.Drawing.Point(3, 205);
            this.gbDopants.Name = "gbDopants";
            this.gbDopants.Size = new System.Drawing.Size(520, 196);
            this.gbDopants.TabIndex = 7;
            this.gbDopants.TabStop = false;
            this.gbDopants.Text = "Dopants";
            // 
            // gbMatrixes
            // 
            this.gbMatrixes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMatrixes.Controls.Add(this.tbxSearchMatrix);
            this.gbMatrixes.Controls.Add(this.lblSearchMatrixes);
            this.gbMatrixes.Controls.Add(this.dgvMatrixes);
            this.gbMatrixes.Location = new System.Drawing.Point(3, 3);
            this.gbMatrixes.Name = "gbMatrixes";
            this.gbMatrixes.Size = new System.Drawing.Size(520, 196);
            this.gbMatrixes.TabIndex = 7;
            this.gbMatrixes.TabStop = false;
            this.gbMatrixes.Text = "Matrixes";
            // 
            // tbxSearchDopants
            // 
            this.tbxSearchDopants.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSearchDopants.Location = new System.Drawing.Point(414, 22);
            this.tbxSearchDopants.Name = "tbxSearchDopants";
            this.tbxSearchDopants.Size = new System.Drawing.Size(100, 27);
            this.tbxSearchDopants.TabIndex = 8;
            this.tbxSearchDopants.TextChanged += new System.EventHandler(this.tbxSearchMatrix_TextChanged);
            // 
            // lblSearchDopants
            // 
            this.lblSearchDopants.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchDopants.AutoSize = true;
            this.lblSearchDopants.Location = new System.Drawing.Point(348, 25);
            this.lblSearchDopants.Name = "lblSearchDopants";
            this.lblSearchDopants.Size = new System.Drawing.Size(60, 19);
            this.lblSearchDopants.TabIndex = 7;
            this.lblSearchDopants.Text = "Search:";
            // 
            // dgvDopants
            // 
            this.dgvDopants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDopants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDopants.Location = new System.Drawing.Point(6, 57);
            this.dgvDopants.Name = "dgvDopants";
            this.dgvDopants.RowTemplate.Height = 24;
            this.dgvDopants.Size = new System.Drawing.Size(508, 131);
            this.dgvDopants.TabIndex = 6;
            this.dgvDopants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDopants_CellClick);
            // 
            // dgvMatrixes
            // 
            this.dgvMatrixes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMatrixes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrixes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvMatrixes.Location = new System.Drawing.Point(6, 57);
            this.dgvMatrixes.Name = "dgvMatrixes";
            this.dgvMatrixes.RowTemplate.Height = 24;
            this.dgvMatrixes.Size = new System.Drawing.Size(508, 131);
            this.dgvMatrixes.TabIndex = 6;
            this.dgvMatrixes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatrixes_CellClick);
            // 
            // tbxSearchMatrix
            // 
            this.tbxSearchMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSearchMatrix.Location = new System.Drawing.Point(414, 22);
            this.tbxSearchMatrix.Name = "tbxSearchMatrix";
            this.tbxSearchMatrix.Size = new System.Drawing.Size(100, 27);
            this.tbxSearchMatrix.TabIndex = 8;
            this.tbxSearchMatrix.TextChanged += new System.EventHandler(this.tbxSearchMatrix_TextChanged);
            // 
            // lblSearchMatrixes
            // 
            this.lblSearchMatrixes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchMatrixes.AutoSize = true;
            this.lblSearchMatrixes.Location = new System.Drawing.Point(348, 25);
            this.lblSearchMatrixes.Name = "lblSearchMatrixes";
            this.lblSearchMatrixes.Size = new System.Drawing.Size(60, 19);
            this.lblSearchMatrixes.TabIndex = 7;
            this.lblSearchMatrixes.Text = "Search:";
            // 
            // CreateOrEditCompound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 541);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.tcMain);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(560, 586);
            this.Name = "CreateOrEditCompound";
            this.Text = "Add new compound";
            this.Load += new System.EventHandler(this.CreateOrEditCompound_Load);
            this.tcMain.ResumeLayout(false);
            this.tpChemicalComponents.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.gbDopants.ResumeLayout(false);
            this.gbDopants.PerformLayout();
            this.gbMatrixes.ResumeLayout(false);
            this.gbMatrixes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDopants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrixes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpChemicalComponents;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button btnSaveChemicalComponents;
        private System.Windows.Forms.GroupBox gbMatrixes;
        private System.Windows.Forms.TextBox tbxSearchMatrix;
        private System.Windows.Forms.Label lblSearchMatrixes;
        private System.Windows.Forms.DataGridView dgvMatrixes;
        private System.Windows.Forms.GroupBox gbDopants;
        private System.Windows.Forms.TextBox tbxSearchDopants;
        private System.Windows.Forms.Label lblSearchDopants;
        private System.Windows.Forms.DataGridView dgvDopants;
    }
}