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

namespace Cost_Model
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DAL.clsDAL db = new DAL.clsDAL();

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        void Login()
        {

            var user = GetUser();
            if (user != "1")
            {
                MessageBox.Show("Error con el usuario.");
            }
            else
            {
                var password = GetPassword();
                if (password != "1")
                {
                    MessageBox.Show("Error con la clave.");
                }
                else
                {
                    var role = GetRole();
                    if (role == "True")
                    {
                        Views.AdminDashboard screen = new Views.AdminDashboard(txtUsername.Text);
                        screen.Show();
                        this.Hide();
                    }
                    else
                    {
                        Views.NonAdminDashboard screen = new Views.NonAdminDashboard(txtUsername.Text);
                        screen.Show();
                        this.Hide();
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoginValidations() == true)
            {
                Login();
            }
        }

        bool LoginValidations()
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Ingrese un usuario", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                txtUsername.Focus();
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Ingrese una contraseña", "Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                txtPassword.Focus();
            }
            return true;
        }

        string GetUser()
        {
            db.OpenConnection();
            String sqlSelectQuery = "select COUNT(PaniUser.Username) as 'Username' from PaniUser where PaniUser.Username = '" + txtUsername.Text + "';";
            SqlCommand cmd = new SqlCommand(sqlSelectQuery, DAL.clsDAL.db);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return (dr["Username"].ToString());
            }
            return "0";
        }
        string GetPassword()
        {
            db.OpenConnection();
            String sqlSelectQuery = "select COUNT(PaniUser.Username) as 'Username' from PaniUser where PaniUser.Username = '"+txtUsername.Text+"' and PaniUser.Password = '"+txtPassword.Text+"';";
            SqlCommand cmd = new SqlCommand(sqlSelectQuery, DAL.clsDAL.db);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return (dr["Username"].ToString());
            }
            return "0";
        }
        string GetRole()
        {
            db.OpenConnection();
            String sqlSelectQuery = "select PaniUser.Administrator as 'Username' from PaniUser where PaniUser.Username = '" + txtUsername.Text + "' and PaniUser.Password = '" + txtPassword.Text + "';";
            SqlCommand cmd = new SqlCommand(sqlSelectQuery, DAL.clsDAL.db);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return (dr["Username"].ToString());
            }
            return "0";
        }
    }
}
