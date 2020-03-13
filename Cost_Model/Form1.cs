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

                        Views.AdminDashboard screen = new Views.AdminDashboard();
                        screen.Show();
                        this.Hide();
            
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
