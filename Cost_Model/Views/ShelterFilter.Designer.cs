namespace Cost_Model.Views
{
    partial class ShelterFilter
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
            this.labelLocation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSubModalities = new System.Windows.Forms.ComboBox();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.comboBoxAgeRange = new System.Windows.Forms.ComboBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.btnModel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.ForeColor = System.Drawing.Color.White;
            this.labelLocation.Location = new System.Drawing.Point(27, 23);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(264, 35);
            this.labelLocation.TabIndex = 1;
            this.labelLocation.Text = "Albergue Institucional";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(161, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione los parámetros para su consulta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(104, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Submodalidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(181, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Género:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(189, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "Región:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(121, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 35);
            this.label5.TabIndex = 6;
            this.label5.Text = "Grupo etario:";
            // 
            // comboBoxSubModalities
            // 
            this.comboBoxSubModalities.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubModalities.FormattingEnabled = true;
            this.comboBoxSubModalities.Location = new System.Drawing.Point(298, 190);
            this.comboBoxSubModalities.Name = "comboBoxSubModalities";
            this.comboBoxSubModalities.Size = new System.Drawing.Size(398, 32);
            this.comboBoxSubModalities.TabIndex = 7;
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.Font = new System.Drawing.Font("Calibri", 12F);
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Location = new System.Drawing.Point(298, 264);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(398, 32);
            this.comboBoxRegion.TabIndex = 8;
            // 
            // comboBoxAgeRange
            // 
            this.comboBoxAgeRange.Font = new System.Drawing.Font("Calibri", 12F);
            this.comboBoxAgeRange.FormattingEnabled = true;
            this.comboBoxAgeRange.Items.AddRange(new object[] {
            "De 0 a 4 años",
            "De 5 a 6 años",
            "De 7 a 12 años",
            "De 13 a 18 años"});
            this.comboBoxAgeRange.Location = new System.Drawing.Point(298, 332);
            this.comboBoxAgeRange.Name = "comboBoxAgeRange";
            this.comboBoxAgeRange.Size = new System.Drawing.Size(398, 32);
            this.comboBoxAgeRange.TabIndex = 9;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Calibri", 12F);
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Hombres",
            "Mujeres",
            "Mixto"});
            this.comboBoxGender.Location = new System.Drawing.Point(298, 409);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(403, 32);
            this.comboBoxGender.TabIndex = 10;
            // 
            // btnModel
            // 
            this.btnModel.BackColor = System.Drawing.Color.White;
            this.btnModel.FlatAppearance.BorderSize = 0;
            this.btnModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModel.Location = new System.Drawing.Point(341, 502);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(188, 64);
            this.btnModel.TabIndex = 11;
            this.btnModel.Text = "Modelar";
            this.btnModel.UseVisualStyleBackColor = false;
            // 
            // ShelterFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 627);
            this.Controls.Add(this.btnModel);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.comboBoxAgeRange);
            this.Controls.Add(this.comboBoxRegion);
            this.Controls.Add(this.comboBoxSubModalities);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLocation);
            this.Name = "ShelterFilter";
            this.Text = "ShelterFilter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSubModalities;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.ComboBox comboBoxAgeRange;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Button btnModel;
    }
}