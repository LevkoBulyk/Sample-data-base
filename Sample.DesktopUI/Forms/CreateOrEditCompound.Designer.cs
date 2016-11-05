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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.tpChemicalComponents = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.matrixLabelPanel1 = new System.Windows.Forms.Panel();
            this.matrixControlPanel1 = new System.Windows.Forms.Panel();
            this.lblMatrix = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.cbxMatrix = new System.Windows.Forms.ComboBox();
            this.nudPercentage = new System.Windows.Forms.NumericUpDown();
            this.matrixButtonPanel1 = new System.Windows.Forms.Panel();
            this.btnRemoveCurrentMatrix = new System.Windows.Forms.Button();
            this.btnAddMoreMatrixes = new System.Windows.Forms.Button();
            this.tcMain.SuspendLayout();
            this.tpChemicalComponents.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.matrixLabelPanel1.SuspendLayout();
            this.matrixControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercentage)).BeginInit();
            this.matrixButtonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tpChemicalComponents);
            this.tcMain.Controls.Add(this.tabPage2);
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(542, 484);
            this.tcMain.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(534, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
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
            this.btnSaveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveAll.Location = new System.Drawing.Point(13, 492);
            this.btnSaveAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(85, 36);
            this.btnSaveAll.TabIndex = 4;
            this.btnSaveAll.Text = "Save all";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            // 
            // tpChemicalComponents
            // 
            this.tpChemicalComponents.AutoScroll = true;
            this.tpChemicalComponents.Controls.Add(this.tableLayoutPanel1);
            this.tpChemicalComponents.Location = new System.Drawing.Point(4, 28);
            this.tpChemicalComponents.Margin = new System.Windows.Forms.Padding(4);
            this.tpChemicalComponents.Name = "tpChemicalComponents";
            this.tpChemicalComponents.Padding = new System.Windows.Forms.Padding(4);
            this.tpChemicalComponents.Size = new System.Drawing.Size(534, 452);
            this.tpChemicalComponents.TabIndex = 0;
            this.tpChemicalComponents.Text = "Chemical components";
            this.tpChemicalComponents.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.15858F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.84142F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216F));
            this.tableLayoutPanel1.Controls.Add(this.matrixLabelPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.matrixControlPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.matrixButtonPanel1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddMoreMatrixes, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.15385F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.84615F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 216F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(526, 444);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // matrixLabelPanel1
            // 
            this.matrixLabelPanel1.Controls.Add(this.lblPercentage);
            this.matrixLabelPanel1.Controls.Add(this.lblMatrix);
            this.matrixLabelPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixLabelPanel1.Location = new System.Drawing.Point(3, 3);
            this.matrixLabelPanel1.Name = "matrixLabelPanel1";
            this.matrixLabelPanel1.Size = new System.Drawing.Size(115, 80);
            this.matrixLabelPanel1.TabIndex = 0;
            // 
            // matrixControlPanel1
            // 
            this.matrixControlPanel1.Controls.Add(this.nudPercentage);
            this.matrixControlPanel1.Controls.Add(this.cbxMatrix);
            this.matrixControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixControlPanel1.Location = new System.Drawing.Point(124, 3);
            this.matrixControlPanel1.Name = "matrixControlPanel1";
            this.matrixControlPanel1.Size = new System.Drawing.Size(182, 80);
            this.matrixControlPanel1.TabIndex = 1;
            // 
            // lblMatrix
            // 
            this.lblMatrix.AutoSize = true;
            this.lblMatrix.Location = new System.Drawing.Point(31, 12);
            this.lblMatrix.Name = "lblMatrix";
            this.lblMatrix.Size = new System.Drawing.Size(60, 19);
            this.lblMatrix.TabIndex = 0;
            this.lblMatrix.Text = "Matrix:";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(16, 46);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(90, 19);
            this.lblPercentage.TabIndex = 0;
            this.lblPercentage.Text = "Percentage:";
            // 
            // cbxMatrix
            // 
            this.cbxMatrix.FormattingEnabled = true;
            this.cbxMatrix.Location = new System.Drawing.Point(9, 9);
            this.cbxMatrix.Name = "cbxMatrix";
            this.cbxMatrix.Size = new System.Drawing.Size(141, 27);
            this.cbxMatrix.TabIndex = 0;
            // 
            // nudPercentage
            // 
            this.nudPercentage.Location = new System.Drawing.Point(9, 44);
            this.nudPercentage.Name = "nudPercentage";
            this.nudPercentage.Size = new System.Drawing.Size(64, 27);
            this.nudPercentage.TabIndex = 1;
            this.nudPercentage.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // matrixButtonPanel1
            // 
            this.matrixButtonPanel1.Controls.Add(this.btnRemoveCurrentMatrix);
            this.matrixButtonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixButtonPanel1.Location = new System.Drawing.Point(312, 3);
            this.matrixButtonPanel1.Name = "matrixButtonPanel1";
            this.matrixButtonPanel1.Size = new System.Drawing.Size(211, 80);
            this.matrixButtonPanel1.TabIndex = 2;
            // 
            // btnRemoveCurrentMatrix
            // 
            this.btnRemoveCurrentMatrix.Location = new System.Drawing.Point(62, 12);
            this.btnRemoveCurrentMatrix.Name = "btnRemoveCurrentMatrix";
            this.btnRemoveCurrentMatrix.Size = new System.Drawing.Size(136, 53);
            this.btnRemoveCurrentMatrix.TabIndex = 0;
            this.btnRemoveCurrentMatrix.Text = "Remove matrix from compound";
            this.btnRemoveCurrentMatrix.UseVisualStyleBackColor = true;
            // 
            // btnAddMoreMatrixes
            // 
            this.btnAddMoreMatrixes.Location = new System.Drawing.Point(124, 89);
            this.btnAddMoreMatrixes.Name = "btnAddMoreMatrixes";
            this.btnAddMoreMatrixes.Size = new System.Drawing.Size(150, 36);
            this.btnAddMoreMatrixes.TabIndex = 3;
            this.btnAddMoreMatrixes.Text = "Add more matrixes";
            this.btnAddMoreMatrixes.UseVisualStyleBackColor = true;
            this.btnAddMoreMatrixes.Click += new System.EventHandler(this.btnAddMoreMatrixes_Click);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(560, 586);
            this.Name = "CreateOrEditCompound";
            this.Text = "Add new compound";
            this.tcMain.ResumeLayout(false);
            this.tpChemicalComponents.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.matrixLabelPanel1.ResumeLayout(false);
            this.matrixLabelPanel1.PerformLayout();
            this.matrixControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPercentage)).EndInit();
            this.matrixButtonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.TabPage tpChemicalComponents;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel matrixLabelPanel1;
        private System.Windows.Forms.Label lblMatrix;
        private System.Windows.Forms.Panel matrixControlPanel1;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.NumericUpDown nudPercentage;
        private System.Windows.Forms.ComboBox cbxMatrix;
        private System.Windows.Forms.Panel matrixButtonPanel1;
        private System.Windows.Forms.Button btnRemoveCurrentMatrix;
        private System.Windows.Forms.Button btnAddMoreMatrixes;
    }
}