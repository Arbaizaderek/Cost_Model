﻿using System;
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
    public partial class Bitacoracs : Form
    {
        BLL.clsProyecto cla = new BLL.clsProyecto();
        public Bitacoracs()
        {
            InitializeComponent();
            dataGridView1.DataSource = cla.EnlistBitacora();
        }
    }
}
