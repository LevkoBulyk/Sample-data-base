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
            this.tpCompound = new System.Windows.Forms.TabPage();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpChemicalComponents = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.gbDopants = new System.Windows.Forms.GroupBox();
            this.panelDopants = new System.Windows.Forms.Panel();
            this.gbMatrixes = new System.Windows.Forms.GroupBox();
            this.panelMatrixes = new System.Windows.Forms.Panel();
            this.btnSaveChemicalComponents = new System.Windows.Forms.Button();
            this.btnAddDopant = new System.Windows.Forms.Button();
            this.btnAddMatrix = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tpCompound.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpChemicalComponents.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.gbDopants.SuspendLayout();
            this.gbMatrixes.SuspendLayout();
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
            // tpCompound
            // 
            this.tpCompound.AutoScroll = true;
            this.tpCompound.Controls.Add(this.lblName);
            this.tpCompound.Location = new System.Drawing.Point(4, 28);
            this.tpCompound.Margin = new System.Windows.Forms.Padding(4);
            this.tpCompound.Name = "tpCompound";
            this.tpCompound.Padding = new System.Windows.Forms.Padding(4);
            this.tpCompound.Size = new System.Drawing.Size(534, 452);
            this.tpCompound.TabIndex = 1;
            this.tpCompound.Text = "Compound";
            this.tpCompound.UseVisualStyleBackColor = true;
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tpCompound);
            this.tcMain.Controls.Add(this.tpChemicalComponents);
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
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.gbDopants, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.gbMatrixes, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.btnSaveChemicalComponents, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.btnAddDopant, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.btnAddMatrix, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(526, 444);
            this.tableLayoutPanel.TabIndex = 8;
            // 
            // gbDopants
            // 
            this.gbDopants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDopants.Controls.Add(this.panelDopants);
            this.gbDopants.Location = new System.Drawing.Point(3, 205);
            this.gbDopants.Name = "gbDopants";
            this.gbDopants.Size = new System.Drawing.Size(520, 156);
            this.gbDopants.TabIndex = 10;
            this.gbDopants.TabStop = false;
            this.gbDopants.Text = "Dopants";
            // 
            // panelDopants
            // 
            this.panelDopants.AutoScroll = true;
            this.panelDopants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDopants.Location = new System.Drawing.Point(3, 23);
            this.panelDopants.Name = "panelDopants";
            this.panelDopants.Size = new System.Drawing.Size(514, 130);
            this.panelDopants.TabIndex = 0;
            // 
            // gbMatrixes
            // 
            this.gbMatrixes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMatrixes.Controls.Add(this.panelMatrixes);
            this.gbMatrixes.Location = new System.Drawing.Point(3, 3);
            this.gbMatrixes.Name = "gbMatrixes";
            this.gbMatrixes.Size = new System.Drawing.Size(520, 156);
            this.gbMatrixes.TabIndex = 7;
            this.gbMatrixes.TabStop = false;
            this.gbMatrixes.Text = "Matrixes";
            // 
            // panelMatrixes
            // 
            this.panelMatrixes.AutoScroll = true;
            this.panelMatrixes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMatrixes.Location = new System.Drawing.Point(3, 23);
            this.panelMatrixes.Name = "panelMatrixes";
            this.panelMatrixes.Size = new System.Drawing.Size(514, 130);
            this.panelMatrixes.TabIndex = 1;
            // 
            // btnSaveChemicalComponents
            // 
            this.btnSaveChemicalComponents.AutoSize = true;
            this.btnSaveChemicalComponents.Location = new System.Drawing.Point(3, 407);
            this.btnSaveChemicalComponents.Name = "btnSaveChemicalComponents";
            this.btnSaveChemicalComponents.Size = new System.Drawing.Size(278, 29);
            this.btnSaveChemicalComponents.TabIndex = 11;
            this.btnSaveChemicalComponents.Text = "Save changes in chemical components";
            this.btnSaveChemicalComponents.UseVisualStyleBackColor = true;
            this.btnSaveChemicalComponents.Click += new System.EventHandler(this.btnSaveChemicalComponents_Click);
            // 
            // btnAddDopant
            // 
            this.btnAddDopant.AutoSize = true;
            this.btnAddDopant.Location = new System.Drawing.Point(3, 367);
            this.btnAddDopant.Name = "btnAddDopant";
            this.btnAddDopant.Size = new System.Drawing.Size(257, 29);
            this.btnAddDopant.TabIndex = 11;
            this.btnAddDopant.Text = "Add one more dopant to compound";
            this.btnAddDopant.UseVisualStyleBackColor = true;
            // 
            // btnAddMatrix
            // 
            this.btnAddMatrix.AutoSize = true;
            this.btnAddMatrix.Location = new System.Drawing.Point(3, 165);
            this.btnAddMatrix.Name = "btnAddMatrix";
            this.btnAddMatrix.Size = new System.Drawing.Size(256, 29);
            this.btnAddMatrix.TabIndex = 11;
            this.btnAddMatrix.Text = "Add one more matrix to compound";
            this.btnAddMatrix.UseVisualStyleBackColor = true;
            this.btnAddMatrix.Click += new System.EventHandler(this.btnAddMatrix_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(45, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
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
            this.tpCompound.ResumeLayout(false);
            this.tpCompound.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tpChemicalComponents.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.gbDopants.ResumeLayout(false);
            this.gbMatrixes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.TabPage tpCompound;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpChemicalComponents;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.GroupBox gbMatrixes;
        private System.Windows.Forms.GroupBox gbDopants;
        private System.Windows.Forms.Button btnSaveChemicalComponents;
        private System.Windows.Forms.Button btnAddDopant;
        private System.Windows.Forms.Button btnAddMatrix;
        private System.Windows.Forms.Panel panelDopants;
        private System.Windows.Forms.Panel panelMatrixes;
        private System.Windows.Forms.Label lblName;
    }
}