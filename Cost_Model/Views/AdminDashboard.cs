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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            panelHome.BringToFront();
            labelLocation.Text = "Inicio";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelHome.BringToFront();
            labelLocation.Text = "Inicio";
        }
        private void btnModel_Click(object sender, EventArgs e)
        {
            panelModel.BringToFront();
            labelLocation.Text = "Modelo de costo";
        }
        private void btnSecurity_Click(object sender, EventArgs e)
        {
            panelSecurity.BringToFront();
            labelLocation.Text = "Controles";
        }
        private void btnShelter_Click(object sender, EventArgs e)
        {
            Views.ShelterFilter screen = new Views.ShelterFilter();
            screen.Show();
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            Views.UserCrud screen = new Views.UserCrud();
            screen.Show();
        }

        private void btnSubModalities_Click(object sender, EventArgs e)
        {
            Views.SubModalityCrud screen = new Views.SubModalityCrud();
            screen.Show();
        }
    }
}
