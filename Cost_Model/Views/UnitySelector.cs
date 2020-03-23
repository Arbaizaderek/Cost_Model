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
    public partial class UnitySelector : Form
    {
        public UnitySelector(string user)
        {
            InitializeComponent();
            label1.Text = user;
        }

        private void btnShelter_Click(object sender, EventArgs e)
        {
            Views.ShelterCrud screen = new Views.ShelterCrud(label1.Text);
            screen.Show();
            this.Hide();
        }

        private void btnIntervention_Click(object sender, EventArgs e)
        {
            Views.IntervencionCrud screen = new Views.IntervencionCrud(label1.Text);
            screen.Show();
            this.Hide();
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            Views.AtencionCrud screen = new Views.AtencionCrud(label1.Text);
            screen.Show();
            this.Hide();
        }

        private void btnHogar_Click(object sender, EventArgs e)
        {
            Views.HogarCrud screen = new Views.HogarCrud(label1.Text);
            screen.Show();
            this.Hide();
        }

        private void btnONG_Click(object sender, EventArgs e)
        {
            Views.ONGCrud screen = new Views.ONGCrud(label1.Text);
            screen.Show();
            this.Hide();
        }

        private void btnUnity_Click(object sender, EventArgs e)
        {
            Views.UnidadCrud screen = new Views.UnidadCrud(label1.Text);
            screen.Show();
            this.Hide();
        }

        private void btnProyectoEspecial_Click(object sender, EventArgs e)
        {
            Views.ProyectoCrud screen = new Views.ProyectoCrud(label1.Text);
            screen.Show();
            this.Hide();
        }
    }
}
