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
    public partial class NonAdminDashboard : Form
    {
        public NonAdminDashboard(string user)
        {
            InitializeComponent();
            panelHome.BringToFront();
            labelLocation.Text = "Inicio";
            labelUser.Text = user;
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

        private void btnShelter_Click(object sender, EventArgs e)
        {
            Views.ShelterFilter screen = new Views.ShelterFilter();
            screen.Show();
        }

        private void btnIntervention_Click(object sender, EventArgs e)
        {
            Views.IntervencionFilter screen = new Views.IntervencionFilter();
            screen.Show();
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            Views.CentroFilter screen = new Views.CentroFilter();
            screen.Show();
        }

        private void btnHogar_Click(object sender, EventArgs e)
        {
            Views.HogarFilter screen = new Views.HogarFilter();
            screen.Show();
        }

        private void btnONG_Click(object sender, EventArgs e)
        {
            Views.ONGFilter screen = new Views.ONGFilter();
            screen.Show();
        }

        private void btnProyecto_Click(object sender, EventArgs e)
        {
            Views.ProyectoFilter screen = new Views.ProyectoFilter();
            screen.Show();
        }

        private void btnUnity_Click(object sender, EventArgs e)
        {
            Views.UnidadesFilter screen = new Views.UnidadesFilter();
            screen.Show();
        }
    }
}
