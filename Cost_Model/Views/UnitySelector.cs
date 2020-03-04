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
        public UnitySelector()
        {
            InitializeComponent();
        }

        private void btnShelter_Click(object sender, EventArgs e)
        {
            Views.ShelterCrud screen = new Views.ShelterCrud();
            screen.Show();
            this.Hide();
        }

        private void btnIntervention_Click(object sender, EventArgs e)
        {
            Views.IntervencionCrud screen = new Views.IntervencionCrud();
            screen.Show();
            this.Hide();
        }
    }
}
