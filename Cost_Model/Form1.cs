using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        DAL.DataBaseModelDataContext db = new DAL.DataBaseModelDataContext();

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        void Login()
        {
            try
            {
                var user = db.Users.Where(i => i.Username == txtUsername.Text && i.Password == txtPassword.Text).Single();
                if (user != null)
                {
                    if (user.Administrator == true)
                    {
                        Views.AdminDashboard screen = new Views.AdminDashboard();
                        screen.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("NonAdmin");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error al iniciar sesión");
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
    }
}
