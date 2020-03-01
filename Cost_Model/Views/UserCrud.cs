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
        public UserCrud()
        {
            InitializeComponent();
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }

        private void UserCrud_Load(object sender, EventArgs e)
        {

        }
    }
}
