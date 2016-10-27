namespace Sample.DesktopUI.Forms
{
    partial class AddNewMatrix
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxEnergyGap = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblEnergyGap = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMaxPhononEnergy = new System.Windows.Forms.Label();
            this.tbxMaxPhononEnergy = new System.Windows.Forms.TextBox();
            this.lblSymmetry = new System.Windows.Forms.Label();
            this.tbxSymmetry = new System.Windows.Forms.TextBox();
            this.chbName = new System.Windows.Forms.CheckBox();
            this.chbEnergyGap = new System.Windows.Forms.CheckBox();
            this.chbMaxPhononEnergy = new System.Windows.Forms.CheckBox();
            this.chbSymmetry = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbSymmetry);
            this.groupBox1.Controls.Add(this.chbMaxPhononEnergy);
            this.groupBox1.Controls.Add(this.chbEnergyGap);
            this.groupBox1.Controls.Add(this.chbName);
            this.groupBox1.Controls.Add(this.tbxSymmetry);
            this.groupBox1.Controls.Add(this.tbxMaxPhononEnergy);
            this.groupBox1.Controls.Add(this.tbxEnergyGap);
            this.groupBox1.Controls.Add(this.lblSymmetry);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Controls.Add(this.lblMaxPhononEnergy);
            this.groupBox1.Controls.Add(this.lblEnergyGap);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matrix data";
            // 
            // tbxEnergyGap
            // 
            this.tbxEnergyGap.Location = new System.Drawing.Point(141, 77);
            this.tbxEnergyGap.Name = "tbxEnergyGap";
            this.tbxEnergyGap.Size = new System.Drawing.Size(138, 27);
            this.tbxEnergyGap.TabIndex = 1;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(141, 35);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(138, 27);
            this.tbxName.TabIndex = 1;
            // 
            // lblEnergyGap
            // 
            this.lblEnergyGap.AutoSize = true;
            this.lblEnergyGap.Location = new System.Drawing.Point(25, 80);
            this.lblEnergyGap.Name = "lblEnergyGap";
            this.lblEnergyGap.Size = new System.Drawing.Size(84, 19);
            this.lblEnergyGap.TabIndex = 0;
            this.lblEnergyGap.Text = "Energy gap";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(43, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblMaxPhononEnergy
            // 
            this.lblMaxPhononEnergy.AutoSize = true;
            this.lblMaxPhononEnergy.Location = new System.Drawing.Point(14, 122);
            this.lblMaxPhononEnergy.Name = "lblMaxPhononEnergy";
            this.lblMaxPhononEnergy.Size = new System.Drawing.Size(107, 19);
            this.lblMaxPhononEnergy.TabIndex = 0;
            this.lblMaxPhononEnergy.Text = "Max phonon E";
            // 
            // tbxMaxPhononEnergy
            // 
            this.tbxMaxPhononEnergy.Location = new System.Drawing.Point(141, 119);
            this.tbxMaxPhononEnergy.Name = "tbxMaxPhononEnergy";
            this.tbxMaxPhononEnergy.Size = new System.Drawing.Size(138, 27);
            this.tbxMaxPhononEnergy.TabIndex = 1;
            // 
            // lblSymmetry
            // 
            this.lblSymmetry.AutoSize = true;
            this.lblSymmetry.Location = new System.Drawing.Point(28, 164);
            this.lblSymmetry.Name = "lblSymmetry";
            this.lblSymmetry.Size = new System.Drawing.Size(79, 19);
            this.lblSymmetry.TabIndex = 0;
            this.lblSymmetry.Text = "Symmetry";
            // 
            // tbxSymmetry
            // 
            this.tbxSymmetry.Location = new System.Drawing.Point(141, 161);
            this.tbxSymmetry.Name = "tbxSymmetry";
            this.tbxSymmetry.Size = new System.Drawing.Size(138, 27);
            this.tbxSymmetry.TabIndex = 1;
            // 
            // chbName
            // 
            this.chbName.AutoSize = true;
            this.chbName.Enabled = false;
            this.chbName.Location = new System.Drawing.Point(295, 40);
            this.chbName.Name = "chbName";
            this.chbName.Size = new System.Drawing.Size(18, 17);
            this.chbName.TabIndex = 2;
            this.chbName.UseVisualStyleBackColor = true;
            // 
            // chbEnergyGap
            // 
            this.chbEnergyGap.AutoSize = true;
            this.chbEnergyGap.Enabled = false;
            this.chbEnergyGap.Location = new System.Drawing.Point(295, 82);
            this.chbEnergyGap.Name = "chbEnergyGap";
            this.chbEnergyGap.Size = new System.Drawing.Size(18, 17);
            this.chbEnergyGap.TabIndex = 2;
            this.chbEnergyGap.UseVisualStyleBackColor = true;
            // 
            // chbMaxPhononEnergy
            // 
            this.chbMaxPhononEnergy.AutoSize = true;
            this.chbMaxPhononEnergy.Enabled = false;
            this.chbMaxPhononEnergy.Location = new System.Drawing.Point(295, 124);
            this.chbMaxPhononEnergy.Name = "chbMaxPhononEnergy";
            this.chbMaxPhononEnergy.Size = new System.Drawing.Size(18, 17);
            this.chbMaxPhononEnergy.TabIndex = 2;
            this.chbMaxPhononEnergy.UseVisualStyleBackColor = true;
            // 
            // chbSymmetry
            // 
            this.chbSymmetry.AutoSize = true;
            this.chbSymmetry.Enabled = false;
            this.chbSymmetry.Location = new System.Drawing.Point(295, 166);
            this.chbSymmetry.Name = "chbSymmetry";
            this.chbSymmetry.Size = new System.Drawing.Size(18, 17);
            this.chbSymmetry.TabIndex = 2;
            this.chbSymmetry.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(247, 237);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 36);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.Location = new System.Drawing.Point(19, 237);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(85, 36);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // AddNewMatrix
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(359, 284);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(377, 329);
            this.MinimumSize = new System.Drawing.Size(377, 329);
            this.Name = "AddNewMatrix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new matrix";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxEnergyGap;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblEnergyGap;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxMaxPhononEnergy;
        private System.Windows.Forms.Label lblMaxPhononEnergy;
        private System.Windows.Forms.CheckBox chbName;
        private System.Windows.Forms.TextBox tbxSymmetry;
        private System.Windows.Forms.Label lblSymmetry;
        private System.Windows.Forms.CheckBox chbSymmetry;
        private System.Windows.Forms.CheckBox chbMaxPhononEnergy;
        private System.Windows.Forms.CheckBox chbEnergyGap;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
    }
}