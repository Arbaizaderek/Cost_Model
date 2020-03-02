using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cost_Model.Views
{
    public partial class UserCrud : Form
    {
        DAL.DataBaseModelDataContext db = new DAL.DataBaseModelDataContext();
        BLL.clsPaniUser user = new BLL.clsPaniUser();
        public UserCrud()
        {
            InitializeComponent();
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            EnlistUser();
        }
        private void UserCrud_Load(object sender, EventArgs e)
        {

        }
        void EnlistUser()
        {
            dataGridViewUser.DataSource = db.EnlistUser();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validations() == true)
            {
                user.InsertUser(txtUser.Text, txtPassword.Text, getAdmin());
                Clean();
                EnlistUser();
            }
        }
        bool getAdmin()
        {
            if(checkBoxAdministrator.Checked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        void Clean()
        {
            txtUser.Clear();
            txtPassword.Clear();
            checkBoxAdministrator.Checked = false;
            txtSearch.Clear();
        }
        bool Validations()
        {
            if (txtUser.Text == "")
            {
                txtUser.Focus();
                MessageBox.Show("Ingrese un usuario.", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPassword.Text == "")
            {
                txtPassword.Focus();
                MessageBox.Show("Ingrese una clave.", "Clave", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void dataGridViewUser_DoubleClick(object sender, EventArgs e)
        {
            btnSave.Visible = false ;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            txtUser.Text = dataGridViewUser.CurrentRow.Cells[1].Value.ToString();
            txtPassword.Text = dataGridViewUser.CurrentRow.Cells[2].Value.ToString();
            if(dataGridViewUser.CurrentRow.Cells[3].Value.ToString() == "True")
            {
                checkBoxAdministrator.Checked = true;
            }
            else
            {
                checkBoxAdministrator.Checked = false;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validations() == true)
            {
                user.UpdateUser(Convert.ToInt32(dataGridViewUser.CurrentRow.Cells[0].Value.ToString()), txtUser.Text, txtPassword.Text, getAdmin());
                Clean();
                EnlistUser();
                btnSave.Visible = true;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            user.DeleteUser(Convert.ToInt32(dataGridViewUser.CurrentRow.Cells[0].Value.ToString()));
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            EnlistUser();
            Clean();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                MessageBox.Show("Ingrese un usuario", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridViewUser.DataSource = user.SearchUser(txtSearch.Text);
                Clean();
            }
            
        }
    }
}
