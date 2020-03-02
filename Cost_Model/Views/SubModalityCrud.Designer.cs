namespace Cost_Model.Views
{
    partial class SubModalityCrud
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewModalities = new System.Windows.Forms.DataGridView();
            this.comboBoxModality = new System.Windows.Forms.ComboBox();
            this.txtSubmodality = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModalities)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(182, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 37);
            this.label3.TabIndex = 15;
            this.label3.Text = "Modalidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(127, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 37);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sub-Modalidad:";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::Cost_Model.Properties.Resources.DeleteIcon;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(403, 256);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(208, 141);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Borrar modalidad";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::Cost_Model.Properties.Resources.Update_Icon;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.Location = new System.Drawing.Point(189, 256);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(208, 141);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Editar modalidad";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::Cost_Model.Properties.Resources.SaveIcon;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(309, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(208, 141);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Agregar modalidad";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Cost_Model.Properties.Resources.SearchIcon;
            this.btnSearch.Location = new System.Drawing.Point(735, 451);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(51, 40);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(540, 451);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 40);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewModalities
            // 
            this.dataGridViewModalities.AllowUserToAddRows = false;
            this.dataGridViewModalities.AllowUserToDeleteRows = false;
            this.dataGridViewModalities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewModalities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewModalities.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewModalities.Location = new System.Drawing.Point(12, 497);
            this.dataGridViewModalities.Name = "dataGridViewModalities";
            this.dataGridViewModalities.ReadOnly = true;
            this.dataGridViewModalities.RowHeadersWidth = 51;
            this.dataGridViewModalities.RowTemplate.Height = 24;
            this.dataGridViewModalities.Size = new System.Drawing.Size(776, 256);
            this.dataGridViewModalities.TabIndex = 20;
            this.dataGridViewModalities.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewModalities_CellDoubleClick);
            // 
            // comboBoxModality
            // 
            this.comboBoxModality.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModality.FormattingEnabled = true;
            this.comboBoxModality.Location = new System.Drawing.Point(381, 98);
            this.comboBoxModality.Name = "comboBoxModality";
            this.comboBoxModality.Size = new System.Drawing.Size(338, 32);
            this.comboBoxModality.TabIndex = 23;
            // 
            // txtSubmodality
            // 
            this.txtSubmodality.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubmodality.Location = new System.Drawing.Point(381, 171);
            this.txtSubmodality.Name = "txtSubmodality";
            this.txtSubmodality.Size = new System.Drawing.Size(338, 40);
            this.txtSubmodality.TabIndex = 24;
            this.txtSubmodality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SubModalityCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 765);
            this.Controls.Add(this.txtSubmodality);
            this.Controls.Add(this.comboBoxModality);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridViewModalities);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "SubModalityCrud";
            this.Text = "SubModalityCrud";
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModalities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridViewModalities;
        private System.Windows.Forms.ComboBox comboBoxModality;
        private System.Windows.Forms.TextBox txtSubmodality;
    }
}