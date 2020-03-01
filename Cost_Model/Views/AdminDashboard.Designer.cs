namespace Cost_Model.Views
{
    partial class AdminDashboard
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnSecurity = new System.Windows.Forms.Button();
            this.btnModel = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.SteelBlue;
            this.panelSidebar.Controls.Add(this.btnSecurity);
            this.panelSidebar.Controls.Add(this.btnModel);
            this.panelSidebar.Controls.Add(this.btnHome);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(384, 653);
            this.panelSidebar.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(384, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(741, 102);
            this.panelTop.TabIndex = 1;
            // 
            // btnSecurity
            // 
            this.btnSecurity.FlatAppearance.BorderSize = 0;
            this.btnSecurity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecurity.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecurity.ForeColor = System.Drawing.Color.White;
            this.btnSecurity.Image = global::Cost_Model.Properties.Resources.SecurityIcon;
            this.btnSecurity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecurity.Location = new System.Drawing.Point(3, 474);
            this.btnSecurity.Name = "btnSecurity";
            this.btnSecurity.Size = new System.Drawing.Size(381, 101);
            this.btnSecurity.TabIndex = 2;
            this.btnSecurity.Text = "Controles";
            this.btnSecurity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSecurity.UseVisualStyleBackColor = true;
            // 
            // btnModel
            // 
            this.btnModel.FlatAppearance.BorderSize = 0;
            this.btnModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModel.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModel.ForeColor = System.Drawing.Color.White;
            this.btnModel.Image = global::Cost_Model.Properties.Resources.InfoIcon;
            this.btnModel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModel.Location = new System.Drawing.Point(3, 338);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(381, 101);
            this.btnModel.TabIndex = 1;
            this.btnModel.Text = "Modelo de costo";
            this.btnModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModel.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::Cost_Model.Properties.Resources.HomeIcon;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 210);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(381, 101);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Inicio";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 653);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSidebar);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnModel;
        private System.Windows.Forms.Button btnSecurity;
    }
}