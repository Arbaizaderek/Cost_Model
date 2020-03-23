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
    public partial class SubModalityCrud : Form
    {
        BLL.clsSubmodality submodality = new BLL.clsSubmodality();
        
        public SubModalityCrud()
        {
            InitializeComponent();
            LoadModalities();
            EnlistSubmodalities();
            comboBoxModality.SelectedIndex = 0;
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }
        void LoadModalities()
        {
            DAL.clsDAL db = new DAL.clsDAL();
            SqlCommand command = new SqlCommand();
            try
            {
                db.OpenConnection();
                command.Connection = DAL.clsDAL.db;
                command.CommandText = "select Modality.Modality_Name from Modality order by Modality.Modality_ID asc;";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxModality.Items.Add(reader["Modality_Name"].ToString());
                }

            }
            catch
            {
                MessageBox.Show("Error ");
            }
        }
        void EnlistSubmodalities()
        {
            dataGridViewModalities.DataSource = submodality.EnlistSubModalities();
        }
        bool Validations()
        {
            if(txtSubmodality.Text == "")
            {
                MessageBox.Show("Entre una submodalidad", "Submodalidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSubmodality.Focus();
                return false;
            }
            return true;
        }
        void InsertSubmodality()
        {
            submodality.InsertSubmodality(txtSubmodality.Text, (comboBoxModality.SelectedIndex + 1));
            EnlistSubmodalities();
        }
        void Clear()
        {
            comboBoxModality.SelectedIndex = 0;
            txtSubmodality.Clear();
            txtSearch.Clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validations() == true)
            {
                InsertSubmodality();
                EnlistSubmodalities();
                Clear();
            }
        }
        private void dataGridViewModalities_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxModality.SelectedItem = dataGridViewModalities.CurrentRow.Cells[2].Value;
            txtSubmodality.Text = dataGridViewModalities.CurrentRow.Cells[1].Value.ToString();
            btnSave.Visible = false;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validations() == true)
            {
                submodality.UpdateSubmodality(Convert.ToInt32(dataGridViewModalities.CurrentRow.Cells[0].Value.ToString()), txtSubmodality.Text, comboBoxModality.SelectedIndex + 1);
                Clear();
                EnlistSubmodalities();
                btnSave.Visible = true;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            submodality.DeleteSubmodality(Convert.ToInt32(dataGridViewModalities.CurrentRow.Cells[0].Value.ToString()));
            Clear();
            EnlistSubmodalities();
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridViewModalities.DataSource = submodality.SearchSubModalities(txtSearch.Text);
            Clear();
        }
    }
}
