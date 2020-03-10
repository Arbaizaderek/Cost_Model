using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cost_Model.Views
{
    public partial class ShelterFilter : Form
    {
        BLL.clsAlbergue albergue = new BLL.clsAlbergue();
        public ShelterFilter()
        {
            InitializeComponent();
            LoadSubModalities();
            LoadRegions();
        }
        void LoadSubModalities()
        {
            DAL.clsDAL db = new DAL.clsDAL();
            SqlCommand command = new SqlCommand();
            try
            {
                db.OpenConnection();
                command.Connection = DAL.clsDAL.db;
                command.CommandText = "select Sub_Modality.Sub_Modality_Name from Sub_Modality where Sub_Modality.Modality_ID = 1;";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxSubModalities.Items.Add(reader["Sub_Modality_Name"].ToString());
                }

            }
            catch
            {
                MessageBox.Show("Error ");
            }
        }
        void LoadRegions()
        {
            DAL.clsDAL db = new DAL.clsDAL();
            SqlCommand command = new SqlCommand();
            try
            {
                db.OpenConnection();
                command.Connection = DAL.clsDAL.db;
                command.CommandText = "Select * from Region";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxRegion.Items.Add(reader["Region_Name"].ToString());
                }

            }
            catch
            {
                MessageBox.Show("Error ");
            }
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
            if (comboBoxSubModalities.SelectedIndex != -1 && comboBoxRegion.SelectedIndex == -1 && comboBoxAgeRange.SelectedIndex == -1 && comboBoxGender.SelectedIndex == -1)
            {
                try
                {
                    dataGridView1.DataSource = albergue.Report1Albergue(comboBoxSubModalities.SelectedItem.ToString());
                }
                catch (Exception error)
                {
                    MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (comboBoxSubModalities.SelectedIndex == -1 && comboBoxRegion.SelectedIndex != -1 && comboBoxAgeRange.SelectedIndex == -1 && comboBoxGender.SelectedIndex == -1)
            {
                try
                {
                    dataGridView1.DataSource = albergue.Report2Albergue(comboBoxRegion.SelectedItem.ToString());
                }
                catch (Exception error)
                {
                    MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (comboBoxSubModalities.SelectedIndex == -1 && comboBoxRegion.SelectedIndex == -1 && comboBoxAgeRange.SelectedIndex == -1 && comboBoxGender.SelectedIndex != -1)
            {
                try
                {
                    dataGridView1.DataSource = albergue.Report3Albergue(comboBoxGender.SelectedIndex + 1);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            if (comboBoxSubModalities.SelectedIndex == -1 && comboBoxRegion.SelectedIndex == -1 && comboBoxAgeRange.SelectedIndex != -1 && comboBoxGender.SelectedIndex == -1)
            {
                if (comboBoxAgeRange.SelectedIndex == 0)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report4Albergue(comboBoxAgeRange.SelectedIndex + 1);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (comboBoxAgeRange.SelectedIndex == 1)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report5Albergue(comboBoxAgeRange.SelectedIndex + 1);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (comboBoxAgeRange.SelectedIndex == 2)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report6Albergue(comboBoxAgeRange.SelectedIndex + 1);
                    }
                    catch(Exception error)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (comboBoxAgeRange.SelectedIndex == 3)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report7Albergue(comboBoxAgeRange.SelectedIndex + 1);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (comboBoxAgeRange.SelectedIndex == 4)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report8Albergue(comboBoxAgeRange.SelectedIndex + 1);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (comboBoxSubModalities.SelectedIndex != -1 && comboBoxRegion.SelectedIndex != -1 && comboBoxAgeRange.SelectedIndex == -1 && comboBoxGender.SelectedIndex == -1)
            {
                try
                {
                    dataGridView1.DataSource = albergue.Report9Albergue(comboBoxSubModalities.SelectedItem.ToString(), comboBoxRegion.SelectedItem.ToString());
                }
                catch (Exception error)
                {
                    MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (comboBoxSubModalities.SelectedIndex != -1 && comboBoxRegion.SelectedIndex == -1 && comboBoxAgeRange.SelectedIndex != -1 && comboBoxGender.SelectedIndex == -1)
            {
                if (comboBoxAgeRange.SelectedIndex == 0)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report10Albergue(comboBoxSubModalities.SelectedItem.ToString(), comboBoxAgeRange.SelectedIndex + 1);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (comboBoxAgeRange.SelectedIndex == 1)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report11Albergue(comboBoxSubModalities.SelectedItem.ToString(), comboBoxAgeRange.SelectedIndex + 1);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (comboBoxAgeRange.SelectedIndex == 2)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report12Albergue(comboBoxSubModalities.SelectedItem.ToString(), comboBoxAgeRange.SelectedIndex + 1);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (comboBoxAgeRange.SelectedIndex == 3)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report13Albergue(comboBoxSubModalities.SelectedItem.ToString(), comboBoxAgeRange.SelectedIndex + 1);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (comboBoxAgeRange.SelectedIndex == 4)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report1Albergue(comboBoxSubModalities.SelectedItem.ToString()); 
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (comboBoxSubModalities.SelectedIndex != -1 && comboBoxRegion.SelectedIndex == -1 && comboBoxAgeRange.SelectedIndex == -1 && comboBoxGender.SelectedIndex != -1)
            {
                try
                {
                    dataGridView1.DataSource = albergue.Report14Albergue(comboBoxSubModalities.SelectedItem.ToString(), comboBoxGender.SelectedIndex+1);
                }
                catch (Exception)
                {
                    MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (comboBoxSubModalities.SelectedIndex == -1 && comboBoxRegion.SelectedIndex != -1 && comboBoxAgeRange.SelectedIndex != -1 && comboBoxGender.SelectedIndex == -1)
            {
                if (comboBoxAgeRange.SelectedIndex == 0)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report15Albergue(comboBoxRegion.SelectedItem.ToString());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (comboBoxAgeRange.SelectedIndex == 1)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report16Albergue(comboBoxRegion.SelectedItem.ToString());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (comboBoxAgeRange.SelectedIndex == 2)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report17Albergue(comboBoxRegion.SelectedItem.ToString());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (comboBoxAgeRange.SelectedIndex == 3)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report18Albergue(comboBoxRegion.SelectedItem.ToString());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if(comboBoxAgeRange.SelectedIndex == 4)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report2Albergue(comboBoxRegion.SelectedItem.ToString());
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (comboBoxSubModalities.SelectedIndex == -1 && comboBoxRegion.SelectedIndex != -1 && comboBoxAgeRange.SelectedIndex == -1 && comboBoxGender.SelectedIndex != -1)
            {
                try
                {
                    dataGridView1.DataSource = albergue.Report19Albergue(comboBoxRegion.SelectedItem.ToString(),comboBoxGender.SelectedIndex + 1);
                }
                catch (Exception)
                {
                    MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (comboBoxSubModalities.SelectedIndex == -1 && comboBoxRegion.SelectedIndex == -1 && comboBoxAgeRange.SelectedIndex != -1 && comboBoxGender.SelectedIndex != -1)
            {
                if (comboBoxAgeRange.SelectedIndex == 0)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report20Albergue(comboBoxGender.SelectedIndex + 1);
                    }
                    catch
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                if (comboBoxAgeRange.SelectedIndex == 1)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report21Albergue(comboBoxGender.SelectedIndex + 1);
                    }
                    catch
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (comboBoxAgeRange.SelectedIndex == 2)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report22Albergue(comboBoxGender.SelectedIndex + 1);
                    }
                    catch
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (comboBoxAgeRange.SelectedIndex == 3)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report23Albergue(comboBoxGender.SelectedIndex + 1);
                    }
                    catch
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (comboBoxAgeRange.SelectedIndex == 4)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report3Albergue(comboBoxGender.SelectedIndex + 1);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (comboBoxSubModalities.SelectedIndex != -1 && comboBoxRegion.SelectedIndex != -1 && comboBoxAgeRange.SelectedIndex != -1 && comboBoxGender.SelectedIndex == -1)
            {
               if (comboBoxAgeRange.SelectedIndex == 0)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report24Albergue(comboBoxSubModalities.SelectedItem.ToString(), comboBoxRegion.SelectedItem.ToString());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               if (comboBoxAgeRange.SelectedIndex == 1)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report25Albergue(comboBoxSubModalities.SelectedItem.ToString(), comboBoxRegion.SelectedItem.ToString());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               if (comboBoxAgeRange.SelectedIndex == 2)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report26Albergue(comboBoxSubModalities.SelectedItem.ToString(), comboBoxRegion.SelectedItem.ToString());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               if (comboBoxAgeRange.SelectedIndex == 3)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report27Albergue(comboBoxSubModalities.SelectedItem.ToString(), comboBoxRegion.SelectedItem.ToString());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               if (comboBoxAgeRange.SelectedIndex == 4)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report9Albergue(comboBoxSubModalities.SelectedItem.ToString(), comboBoxRegion.SelectedItem.ToString());
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (comboBoxSubModalities.SelectedIndex != -1 && comboBoxRegion.SelectedIndex != -1 && comboBoxAgeRange.SelectedIndex == -1 && comboBoxGender.SelectedIndex != -1)
            {
                try
                {
                    dataGridView1.DataSource = albergue.Report28Albergue(comboBoxSubModalities.SelectedItem.ToString(), comboBoxRegion.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
                }
                catch (Exception)
                {
                    MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (comboBoxSubModalities.SelectedIndex != -1 && comboBoxRegion.SelectedIndex == -1 && comboBoxAgeRange.SelectedIndex != -1 && comboBoxGender.SelectedIndex != -1)
            {
                if (comboBoxAgeRange.SelectedIndex == 0)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report29Albergue(comboBoxSubModalities.SelectedItem.ToString(), comboBoxGender.SelectedIndex+1);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (comboBoxAgeRange.SelectedIndex == 1)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report30Albergue(comboBoxSubModalities.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (comboBoxAgeRange.SelectedIndex == 2)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report31Albergue(comboBoxSubModalities.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (comboBoxAgeRange.SelectedIndex == 3)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report32Albergue(comboBoxSubModalities.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (comboBoxAgeRange.SelectedIndex == 4)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report14Albergue(comboBoxSubModalities.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (comboBoxSubModalities.SelectedIndex == -1 && comboBoxRegion.SelectedIndex != -1 && comboBoxAgeRange.SelectedIndex != -1 && comboBoxGender.SelectedIndex != -1)
            {
                if (comboBoxAgeRange.SelectedIndex == 0)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report33Albergue(comboBoxRegion.SelectedItem.ToString(), comboBoxGender.SelectedIndex+1);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (comboBoxAgeRange.SelectedIndex == 1)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report34Albergue(comboBoxRegion.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (comboBoxAgeRange.SelectedIndex == 2)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report35Albergue(comboBoxRegion.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (comboBoxAgeRange.SelectedIndex == 3)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report36Albergue(comboBoxRegion.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (comboBoxAgeRange.SelectedIndex == 4)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report19Albergue(comboBoxRegion.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (comboBoxSubModalities.SelectedIndex != -1 && comboBoxRegion.SelectedIndex != -1 && comboBoxAgeRange.SelectedIndex != -1 && comboBoxGender.SelectedIndex != -1)
            {
                if (comboBoxAgeRange.SelectedIndex == 0)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report37Albergue(comboBoxSubModalities.SelectedItem.ToString(), comboBoxRegion.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (comboBoxAgeRange.SelectedIndex == 1)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report38Albergue(comboBoxSubModalities.SelectedItem.ToString(), comboBoxRegion.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (comboBoxAgeRange.SelectedIndex == 2)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report39Albergue(comboBoxSubModalities.SelectedItem.ToString(), comboBoxRegion.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (comboBoxAgeRange.SelectedIndex == 3)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report40Albergue(comboBoxSubModalities.SelectedItem.ToString(), comboBoxRegion.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (comboBoxAgeRange.SelectedIndex == 4)
                {
                    try
                    {
                        dataGridView1.DataSource = albergue.Report28Albergue(comboBoxSubModalities.SelectedItem.ToString(), comboBoxRegion.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
