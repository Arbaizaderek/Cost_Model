namespace Cost_Model.Views
{
    partial class UserCrud
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.checkBoxAdministrator = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(171, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(127, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(309, 60);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(313, 40);
            this.txtUser.TabIndex = 2;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(309, 134);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(313, 40);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToAddRows = false;
            this.dataGridViewUser.AllowUserToDeleteRows = false;
            this.dataGridViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUser.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUser.Location = new System.Drawing.Point(12, 502);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.ReadOnly = true;
            this.dataGridViewUser.RowHeadersWidth = 51;
            this.dataGridViewUser.RowTemplate.Height = 24;
            this.dataGridViewUser.Size = new System.Drawing.Size(776, 256);
            this.dataGridViewUser.TabIndex = 7;
            this.dataGridViewUser.DoubleClick += new System.EventHandler(this.dataGridViewUser_DoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(515, 456);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 40);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Cost_Model.Properties.Resources.SearchIcon;
            this.btnSearch.Location = new System.Drawing.Point(710, 456);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(51, 40);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::Cost_Model.Properties.Resources.DeleteIcon;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(403, 280);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(208, 141);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Borrar usuario";
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
            this.btnUpdate.Location = new System.Drawing.Point(189, 280);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(208, 141);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Editar usuario";
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
            this.btnSave.Location = new System.Drawing.Point(309, 280);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(208, 141);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Agregar usuario";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // checkBoxAdministrator
            // 
            this.checkBoxAdministrator.AutoSize = true;
            this.checkBoxAdministrator.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAdministrator.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdministrator.ForeColor = System.Drawing.Color.White;
            this.checkBoxAdministrator.Location = new System.Drawing.Point(134, 203);
            this.checkBoxAdministrator.Name = "checkBoxAdministrator";
            this.checkBoxAdministrator.Size = new System.Drawing.Size(242, 41);
            this.checkBoxAdministrator.TabIndex = 10;
            this.checkBoxAdministrator.Text = "Administrador:   ";
            this.checkBoxAdministrator.UseVisualStyleBackColor = true;
            // 
            // UserCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 765);
            this.Controls.Add(this.checkBoxAdministrator);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserCrud";
            this.Text = "UserCrud";
            this.Load += new System.EventHandler(this.UserCrud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.CheckBox checkBoxAdministrator;
    }
}