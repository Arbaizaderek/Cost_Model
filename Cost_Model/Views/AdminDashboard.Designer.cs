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
            this.panelHome = new System.Windows.Forms.Panel();
            this.labelLocation = new System.Windows.Forms.Label();
            this.panelModel = new System.Windows.Forms.Panel();
            this.panelSecurity = new System.Windows.Forms.Panel();
            this.btnShelter = new System.Windows.Forms.Button();
            this.btnIntervention = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnHogar = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnUnities = new System.Windows.Forms.Button();
            this.btnSubModalities = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelModel.SuspendLayout();
            this.panelSecurity.SuspendLayout();
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
            this.panelSidebar.Size = new System.Drawing.Size(384, 729);
            this.panelSidebar.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTop.Controls.Add(this.labelLocation);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(384, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(934, 102);
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
            this.btnSecurity.Location = new System.Drawing.Point(2, 474);
            this.btnSecurity.Name = "btnSecurity";
            this.btnSecurity.Size = new System.Drawing.Size(381, 101);
            this.btnSecurity.TabIndex = 2;
            this.btnSecurity.Text = "Controles";
            this.btnSecurity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSecurity.UseVisualStyleBackColor = true;
            this.btnSecurity.Click += new System.EventHandler(this.btnSecurity_Click);
            // 
            // btnModel
            // 
            this.btnModel.FlatAppearance.BorderSize = 0;
            this.btnModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModel.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModel.ForeColor = System.Drawing.Color.White;
            this.btnModel.Image = global::Cost_Model.Properties.Resources.InfoIcon;
            this.btnModel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModel.Location = new System.Drawing.Point(2, 311);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(381, 101);
            this.btnModel.TabIndex = 1;
            this.btnModel.Text = "Modelo de costo";
            this.btnModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModel.UseVisualStyleBackColor = true;
            this.btnModel.Click += new System.EventHandler(this.btnModel_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::Cost_Model.Properties.Resources.HomeIcon;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(2, 159);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(381, 101);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Inicio";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(233)))), ((int)(((byte)(241)))));
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(384, 102);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(934, 627);
            this.panelHome.TabIndex = 2;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.ForeColor = System.Drawing.Color.White;
            this.labelLocation.Location = new System.Drawing.Point(622, 63);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(113, 35);
            this.labelLocation.TabIndex = 0;
            this.labelLocation.Text = "Location";
            // 
            // panelModel
            // 
            this.panelModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(206)))), ((int)(((byte)(226)))));
            this.panelModel.Controls.Add(this.button3);
            this.panelModel.Controls.Add(this.button4);
            this.panelModel.Controls.Add(this.btnHogar);
            this.panelModel.Controls.Add(this.button2);
            this.panelModel.Controls.Add(this.btnIntervention);
            this.panelModel.Controls.Add(this.btnShelter);
            this.panelModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelModel.Location = new System.Drawing.Point(384, 102);
            this.panelModel.Name = "panelModel";
            this.panelModel.Size = new System.Drawing.Size(934, 627);
            this.panelModel.TabIndex = 0;
            // 
            // panelSecurity
            // 
            this.panelSecurity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(179)))), ((int)(((byte)(209)))));
            this.panelSecurity.Controls.Add(this.btnSubModalities);
            this.panelSecurity.Controls.Add(this.btnUnities);
            this.panelSecurity.Controls.Add(this.btnUser);
            this.panelSecurity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSecurity.Location = new System.Drawing.Point(384, 102);
            this.panelSecurity.Name = "panelSecurity";
            this.panelSecurity.Size = new System.Drawing.Size(934, 627);
            this.panelSecurity.TabIndex = 0;
            // 
            // btnShelter
            // 
            this.btnShelter.BackColor = System.Drawing.Color.SteelBlue;
            this.btnShelter.FlatAppearance.BorderSize = 0;
            this.btnShelter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShelter.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShelter.ForeColor = System.Drawing.Color.White;
            this.btnShelter.Location = new System.Drawing.Point(114, 175);
            this.btnShelter.Name = "btnShelter";
            this.btnShelter.Size = new System.Drawing.Size(221, 133);
            this.btnShelter.TabIndex = 0;
            this.btnShelter.Text = "Albergue Institucional";
            this.btnShelter.UseVisualStyleBackColor = false;
            // 
            // btnIntervention
            // 
            this.btnIntervention.BackColor = System.Drawing.Color.SteelBlue;
            this.btnIntervention.FlatAppearance.BorderSize = 0;
            this.btnIntervention.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntervention.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntervention.ForeColor = System.Drawing.Color.White;
            this.btnIntervention.Location = new System.Drawing.Point(393, 175);
            this.btnIntervention.Name = "btnIntervention";
            this.btnIntervention.Size = new System.Drawing.Size(221, 133);
            this.btnIntervention.TabIndex = 1;
            this.btnIntervention.Text = "Centro de Intervención";
            this.btnIntervention.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(672, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 133);
            this.button2.TabIndex = 2;
            this.button2.Text = "Centro de Atención Integral";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(672, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 133);
            this.button3.TabIndex = 5;
            this.button3.Text = "Unidad Móvil";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SteelBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(393, 357);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(221, 133);
            this.button4.TabIndex = 4;
            this.button4.Text = "Organización no Gubernamental";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnHogar
            // 
            this.btnHogar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHogar.FlatAppearance.BorderSize = 0;
            this.btnHogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHogar.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHogar.ForeColor = System.Drawing.Color.White;
            this.btnHogar.Location = new System.Drawing.Point(114, 357);
            this.btnHogar.Name = "btnHogar";
            this.btnHogar.Size = new System.Drawing.Size(221, 133);
            this.btnHogar.TabIndex = 3;
            this.btnHogar.Text = "Hogar Solidario";
            this.btnHogar.UseVisualStyleBackColor = false;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(348, 77);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(266, 133);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "Administración de usuarios";
            this.btnUser.UseVisualStyleBackColor = false;
            // 
            // btnUnities
            // 
            this.btnUnities.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUnities.FlatAppearance.BorderSize = 0;
            this.btnUnities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnities.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnities.ForeColor = System.Drawing.Color.White;
            this.btnUnities.Location = new System.Drawing.Point(348, 246);
            this.btnUnities.Name = "btnUnities";
            this.btnUnities.Size = new System.Drawing.Size(266, 133);
            this.btnUnities.TabIndex = 2;
            this.btnUnities.Text = "Administración de unidades";
            this.btnUnities.UseVisualStyleBackColor = false;
            // 
            // btnSubModalities
            // 
            this.btnSubModalities.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSubModalities.FlatAppearance.BorderSize = 0;
            this.btnSubModalities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubModalities.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubModalities.ForeColor = System.Drawing.Color.White;
            this.btnSubModalities.Location = new System.Drawing.Point(348, 416);
            this.btnSubModalities.Name = "btnSubModalities";
            this.btnSubModalities.Size = new System.Drawing.Size(266, 133);
            this.btnSubModalities.TabIndex = 3;
            this.btnSubModalities.Text = "Administración de sub-modalidades";
            this.btnSubModalities.UseVisualStyleBackColor = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 729);
            this.Controls.Add(this.panelSecurity);
            this.Controls.Add(this.panelModel);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSidebar);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.panelSidebar.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelModel.ResumeLayout(false);
            this.panelSecurity.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnModel;
        private System.Windows.Forms.Button btnSecurity;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelModel;
        private System.Windows.Forms.Panel panelSecurity;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnHogar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnIntervention;
        private System.Windows.Forms.Button btnShelter;
        private System.Windows.Forms.Button btnSubModalities;
        private System.Windows.Forms.Button btnUnities;
        private System.Windows.Forms.Button btnUser;
    }
}