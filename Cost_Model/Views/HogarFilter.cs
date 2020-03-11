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
    public partial class HogarFilter : Form
    {
        BLL.clsIntervencion intervencion = new BLL.clsIntervencion();

        public HogarFilter()
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
                command.CommandText = "select Sub_Modality.Sub_Modality_Name from Sub_Modality where Sub_Modality.Modality_ID = 4;";
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
                    dataGridView1.DataSource = intervencion.Report1General(comboBoxSubModalities.SelectedItem.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (comboBoxSubModalities.SelectedIndex == -1 && comboBoxRegion.SelectedIndex != -1 && comboBoxAgeRange.SelectedIndex == -1 && comboBoxGender.SelectedIndex == -1)
            {
                try
                {
                    dataGridView1.DataSource = intervencion.Report2General(4, comboBoxRegion.SelectedItem.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (comboBoxSubModalities.SelectedIndex == -1 && comboBoxRegion.SelectedIndex == -1 && comboBoxAgeRange.SelectedIndex == -1 && comboBoxGender.SelectedIndex != -1)
            {
                try
                {
                    dataGridView1.DataSource = intervencion.Report3General(4, comboBoxGender.SelectedIndex + 1);
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
                        dataGridView1.DataSource = intervencion.Report4General(4);
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
                        dataGridView1.DataSource = intervencion.Report5General(4);
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
                        dataGridView1.DataSource = intervencion.Report6General(4);
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
                        dataGridView1.DataSource = intervencion.Report7General(4);
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
                        dataGridView1.DataSource = intervencion.Report8General(4);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (comboBoxSubModalities.SelectedIndex != -1 && comboBoxRegion.SelectedIndex != -1 && comboBoxAgeRange.SelectedIndex == -1 && comboBoxGender.SelectedIndex == -1)
            {
                try
                {
                    dataGridView1.DataSource = intervencion.Report9General(4, comboBoxSubModalities.SelectedItem.ToString(), comboBoxRegion.SelectedItem.ToString());
                }
                catch (Exception)
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
                        dataGridView1.DataSource = intervencion.Report10General(4, comboBoxSubModalities.SelectedItem.ToString(), comboBoxAgeRange.SelectedIndex + 1);
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
                        dataGridView1.DataSource = intervencion.Report11General(4, comboBoxSubModalities.SelectedItem.ToString(), comboBoxAgeRange.SelectedIndex + 1);
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
                        dataGridView1.DataSource = intervencion.Report12General(4, comboBoxSubModalities.SelectedItem.ToString(), comboBoxAgeRange.SelectedIndex + 1);
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
                        dataGridView1.DataSource = intervencion.Report13General(4, comboBoxSubModalities.SelectedItem.ToString(), comboBoxAgeRange.SelectedIndex + 1);
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
                        dataGridView1.DataSource = intervencion.Report1General(comboBoxSubModalities.SelectedItem.ToString());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (comboBoxSubModalities.SelectedIndex != -1 && comboBoxRegion.SelectedIndex == -1 && comboBoxAgeRange.SelectedIndex == -1 && comboBoxGender.SelectedIndex != -1)
            {
                try
                {
                    dataGridView1.DataSource = intervencion.Report14General(4, comboBoxSubModalities.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
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
                        dataGridView1.DataSource = intervencion.Report15General(4, comboBoxRegion.SelectedItem.ToString());
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
                        dataGridView1.DataSource = intervencion.Report16General(4, comboBoxRegion.SelectedItem.ToString());
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
                        dataGridView1.DataSource = intervencion.Report17General(4, comboBoxRegion.SelectedItem.ToString());
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
                        dataGridView1.DataSource = intervencion.Report18General(4, comboBoxRegion.SelectedItem.ToString());
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
                        dataGridView1.DataSource = intervencion.Report2General(4, comboBoxRegion.SelectedItem.ToString());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (comboBoxSubModalities.SelectedIndex == -1 && comboBoxRegion.SelectedIndex != -1 && comboBoxAgeRange.SelectedIndex == -1 && comboBoxGender.SelectedIndex != -1)
            {
                try
                {
                    dataGridView1.DataSource = intervencion.Report19General(4, comboBoxRegion.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
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
                        dataGridView1.DataSource = intervencion.Report20General(4, comboBoxGender.SelectedIndex + 1);
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
                        dataGridView1.DataSource = intervencion.Report21General(4, comboBoxGender.SelectedIndex + 1);
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
                        dataGridView1.DataSource = intervencion.Report22General(4, comboBoxGender.SelectedIndex + 1);
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
                        dataGridView1.DataSource = intervencion.Report23General(4, comboBoxGender.SelectedIndex + 1);
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
                        dataGridView1.DataSource = intervencion.Report3General(4, comboBoxGender.SelectedIndex + 1);
                    }
                    catch (Exception)
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
                        dataGridView1.DataSource = intervencion.Report24General(4, comboBoxSubModalities.SelectedItem.ToString(), comboBoxRegion.SelectedItem.ToString());
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
                        dataGridView1.DataSource = intervencion.Report25General(4, comboBoxSubModalities.SelectedItem.ToString(), comboBoxRegion.SelectedItem.ToString());
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
                        dataGridView1.DataSource = intervencion.Report26General(4, comboBoxSubModalities.SelectedItem.ToString(), comboBoxRegion.SelectedItem.ToString());
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
                        dataGridView1.DataSource = intervencion.Report27General(4, comboBoxSubModalities.SelectedItem.ToString(), comboBoxRegion.SelectedItem.ToString());
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
                        dataGridView1.DataSource = intervencion.Report9General(4, comboBoxSubModalities.SelectedItem.ToString(), comboBoxRegion.SelectedItem.ToString());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (comboBoxSubModalities.SelectedIndex != -1 && comboBoxRegion.SelectedIndex != -1 && comboBoxAgeRange.SelectedIndex == -1 && comboBoxGender.SelectedIndex != -1)
            {
                try
                {
                    dataGridView1.DataSource = intervencion.Report28General(4, comboBoxSubModalities.SelectedItem.ToString(), comboBoxRegion.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
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
                        dataGridView1.DataSource = intervencion.Report29General(4, comboBoxSubModalities.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
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
                        dataGridView1.DataSource = intervencion.Report30General(4, comboBoxSubModalities.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
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
                        dataGridView1.DataSource = intervencion.Report31General(4, comboBoxSubModalities.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
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
                        dataGridView1.DataSource = intervencion.Report32General(4, comboBoxSubModalities.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
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
                        dataGridView1.DataSource = intervencion.Report14General(4, comboBoxSubModalities.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
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
                        dataGridView1.DataSource = intervencion.Report33General(4, comboBoxRegion.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
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
                        dataGridView1.DataSource = intervencion.Report34General(4, comboBoxRegion.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
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
                        dataGridView1.DataSource = intervencion.Report35General(4, comboBoxRegion.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
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
                        dataGridView1.DataSource = intervencion.Report36General(4, comboBoxRegion.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
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
                        dataGridView1.DataSource = intervencion.Report19General(4, comboBoxRegion.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
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
                        dataGridView1.DataSource = intervencion.Report37General(4, comboBoxSubModalities.SelectedItem.ToString(), comboBoxRegion.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
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
                        dataGridView1.DataSource = intervencion.Report38General(4, comboBoxSubModalities.SelectedItem.ToString(), comboBoxRegion.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
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
                        dataGridView1.DataSource = intervencion.Report39General(4, comboBoxSubModalities.SelectedItem.ToString(), comboBoxRegion.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
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
                        dataGridView1.DataSource = intervencion.Report40General(4, comboBoxSubModalities.SelectedItem.ToString(), comboBoxRegion.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
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
                        dataGridView1.DataSource = intervencion.Report28General(4, comboBoxSubModalities.SelectedItem.ToString(), comboBoxRegion.SelectedItem.ToString(), comboBoxGender.SelectedIndex + 1);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Información no disponible para generar modelo.", "Información no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Views.ReportPrinter sc = new Views.ReportPrinter(dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                                                    dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                                                    dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                                                    dataGridView1.CurrentRow.Cells[3].Value.ToString(),
                                                    dataGridView1.CurrentRow.Cells[4].Value.ToString(),
                                                    dataGridView1.CurrentRow.Cells[5].Value.ToString(),
                                                    dataGridView1.CurrentRow.Cells[6].Value.ToString(),
                                                    dataGridView1.CurrentRow.Cells[7].Value.ToString(),
                                                    dataGridView1.CurrentRow.Cells[8].Value.ToString(),
                                                    dataGridView1.CurrentRow.Cells[9].Value.ToString(),
                                                    dataGridView1.CurrentRow.Cells[10].Value.ToString(),
                                                    dataGridView1.CurrentRow.Cells[11].Value.ToString(),
                                                    dataGridView1.CurrentRow.Cells[12].Value.ToString(),
                                                    dataGridView1.CurrentRow.Cells[13].Value.ToString(),
                                                    dataGridView1.CurrentRow.Cells[14].Value.ToString(),
                                                    dataGridView1.CurrentRow.Cells[15].Value.ToString(),
                                                    dataGridView1.CurrentRow.Cells[16].Value.ToString(),
                                                    dataGridView1.CurrentRow.Cells[17].Value.ToString(),
                                                    dataGridView1.CurrentRow.Cells[18].Value.ToString(),
                                                    dataGridView1.CurrentRow.Cells[19].Value.ToString(),
                                                    dataGridView1.CurrentRow.Cells[20].Value.ToString(),
                                                    dataGridView1.CurrentRow.Cells[21].Value.ToString(),
                                                    dataGridView1.CurrentRow.Cells[22].Value.ToString(),
                                                    dataGridView1.CurrentRow.Cells[23].Value.ToString(),
                                                    dataGridView1.CurrentRow.Cells[24].Value.ToString(),
                                                    dataGridView1.CurrentRow.Cells[25].Value.ToString(),
                                                    dataGridView1.CurrentRow.Cells[26].Value.ToString());
            sc.Show();

        }
    }
}
