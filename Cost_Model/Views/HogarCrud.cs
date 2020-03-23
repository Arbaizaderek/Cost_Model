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

namespace Cost_Model.Views
{
    public partial class HogarCrud : Form
    {
        BLL.clsHogar hogar = new BLL.clsHogar();
        public HogarCrud(string user)
        {
            InitializeComponent();
            LoadSubModilty();
            LoadRegions();
            LoadGender();
            comboBoxSubmodality.SelectedIndex = 0;
            comboBoxRegion.SelectedIndex = 0;
            comboBoxgGender.SelectedIndex = 0;
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            EnlistHogar();
            labelTotal.Visible = false;
            labelCost.Visible = false;
            labelUser.Text = user;
        }
        void LoadSubModilty()
        {
            DAL.clsDAL db = new DAL.clsDAL();
            SqlCommand command = new SqlCommand();
            try
            {
                db.OpenConnection();
                command.Connection = DAL.clsDAL.db;
                command.CommandText = "select Sub_Modality.Sub_Modality_Name from Sub_Modality where Sub_Modality.Modality_ID = 4";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxSubmodality.Items.Add(reader["Sub_Modality_Name"].ToString());
                }

            }
            catch
            {
                MessageBox.Show("Error ");
            }
        }
        void LoadRegions()
        {
            DAL.clsDAL db = new DAL.clsDAL();
            SqlCommand command = new SqlCommand();
            try
            {
                db.OpenConnection();
                command.Connection = DAL.clsDAL.db;
                command.CommandText = "Select * from Region;";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxRegion.Items.Add(reader["Region_Name"].ToString());
                }

            }
            catch
            {
                MessageBox.Show("Error ");
            }
        }
        void LoadGender()
        {
            DAL.clsDAL db = new DAL.clsDAL();
            SqlCommand command = new SqlCommand();
            try
            {
                db.OpenConnection();
                command.Connection = DAL.clsDAL.db;
                command.CommandText = "Select Gender from Gender;";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxgGender.Items.Add(reader["Gender"].ToString());
                }

            }
            catch
            {
                MessageBox.Show("Error ");
            }
        }
        void EnlistHogar()
        {
            dataGridViewIntervencion.DataSource = hogar.EnlistHogar();
        }
        bool Validations()
        {
            if (txtInfra.Text.Contains("a") || txtInfra.Text.Contains("b") || txtInfra.Text.Contains("c") || txtInfra.Text.Contains("d") || txtInfra.Text.Contains("e") || txtInfra.Text.Contains("f") || txtInfra.Text.Contains("g") || txtInfra.Text.Contains("h") || txtInfra.Text.Contains("i") || txtInfra.Text.Contains("j") || txtInfra.Text.Contains("k") || txtInfra.Text.Contains("l") || txtInfra.Text.Contains("m") || txtInfra.Text.Contains("n") || txtInfra.Text.Contains("ñ") || txtInfra.Text.Contains("o") || txtInfra.Text.Contains("p") || txtInfra.Text.Contains("q") || txtInfra.Text.Contains("r") || txtInfra.Text.Contains("s") || txtInfra.Text.Contains("t") || txtInfra.Text.Contains("u") || txtInfra.Text.Contains("v") || txtInfra.Text.Contains("w") || txtInfra.Text.Contains("x") || txtInfra.Text.Contains("y") || txtInfra.Text.Contains("z") || txtInfra.Text.Contains("A") || txtInfra.Text.Contains("B") || txtInfra.Text.Contains("C") || txtInfra.Text.Contains("D") || txtInfra.Text.Contains("E") || txtInfra.Text.Contains("F") || txtInfra.Text.Contains("G") || txtInfra.Text.Contains("H") || txtInfra.Text.Contains("I") || txtInfra.Text.Contains("J") || txtInfra.Text.Contains("K") || txtInfra.Text.Contains("L") || txtInfra.Text.Contains("M") || txtInfra.Text.Contains("N") || txtInfra.Text.Contains("Ñ") || txtInfra.Text.Contains("O") || txtInfra.Text.Contains("P") || txtInfra.Text.Contains("Q") || txtInfra.Text.Contains("R") || txtInfra.Text.Contains("S") || txtInfra.Text.Contains("T") || txtInfra.Text.Contains("U") || txtInfra.Text.Contains("V") || txtInfra.Text.Contains("W") || txtInfra.Text.Contains("X") || txtInfra.Text.Contains("Y") || txtInfra.Text.Contains("Z") || txtInfra.Text.Contains("á") || txtInfra.Text.Contains("é") || txtInfra.Text.Contains("í") || txtInfra.Text.Contains("ó") || txtInfra.Text.Contains("ú") || txtInfra.Text.Contains("Á") || txtInfra.Text.Contains("É") || txtInfra.Text.Contains("Í") || txtInfra.Text.Contains("Ó") || txtInfra.Text.Contains("Ú"))
            {
                txtInfra.Focus();
                MessageBox.Show("Ingrese solo números.");
                txtInfra.Clear();
                return false;
            }
            if (txtEdu.Text.Contains("a") || txtEdu.Text.Contains("b") || txtEdu.Text.Contains("c") || txtEdu.Text.Contains("d") || txtEdu.Text.Contains("e") || txtEdu.Text.Contains("f") || txtEdu.Text.Contains("g") || txtEdu.Text.Contains("h") || txtEdu.Text.Contains("i") || txtEdu.Text.Contains("j") || txtEdu.Text.Contains("k") || txtEdu.Text.Contains("l") || txtEdu.Text.Contains("m") || txtEdu.Text.Contains("n") || txtEdu.Text.Contains("ñ") || txtEdu.Text.Contains("o") || txtEdu.Text.Contains("p") || txtEdu.Text.Contains("q") || txtEdu.Text.Contains("r") || txtEdu.Text.Contains("s") || txtEdu.Text.Contains("t") || txtEdu.Text.Contains("u") || txtEdu.Text.Contains("v") || txtEdu.Text.Contains("w") || txtEdu.Text.Contains("x") || txtEdu.Text.Contains("y") || txtEdu.Text.Contains("z") || txtEdu.Text.Contains("A") || txtEdu.Text.Contains("B") || txtEdu.Text.Contains("C") || txtEdu.Text.Contains("D") || txtEdu.Text.Contains("E") || txtEdu.Text.Contains("F") || txtEdu.Text.Contains("G") || txtEdu.Text.Contains("H") || txtEdu.Text.Contains("I") || txtEdu.Text.Contains("J") || txtEdu.Text.Contains("K") || txtEdu.Text.Contains("L") || txtEdu.Text.Contains("M") || txtEdu.Text.Contains("N") || txtEdu.Text.Contains("Ñ") || txtEdu.Text.Contains("O") || txtEdu.Text.Contains("P") || txtEdu.Text.Contains("Q") || txtEdu.Text.Contains("R") || txtEdu.Text.Contains("S") || txtEdu.Text.Contains("T") || txtEdu.Text.Contains("U") || txtEdu.Text.Contains("V") || txtEdu.Text.Contains("W") || txtEdu.Text.Contains("X") || txtEdu.Text.Contains("Y") || txtEdu.Text.Contains("Z") || txtEdu.Text.Contains("á") || txtEdu.Text.Contains("é") || txtEdu.Text.Contains("í") || txtEdu.Text.Contains("ó") || txtEdu.Text.Contains("ú") || txtEdu.Text.Contains("Á") || txtEdu.Text.Contains("É") || txtEdu.Text.Contains("Í") || txtEdu.Text.Contains("Ó") || txtEdu.Text.Contains("Ú"))
            {
                txtEdu.Focus();
                MessageBox.Show("Ingrese solo números.");
                txtEdu.Clear();
                return false;
            }
            if (txtSalu.Text.Contains("a") || txtSalu.Text.Contains("b") || txtSalu.Text.Contains("c") || txtSalu.Text.Contains("d") || txtSalu.Text.Contains("e") || txtSalu.Text.Contains("f") || txtSalu.Text.Contains("g") || txtSalu.Text.Contains("h") || txtSalu.Text.Contains("i") || txtSalu.Text.Contains("j") || txtSalu.Text.Contains("k") || txtSalu.Text.Contains("l") || txtSalu.Text.Contains("m") || txtSalu.Text.Contains("n") || txtSalu.Text.Contains("ñ") || txtSalu.Text.Contains("o") || txtSalu.Text.Contains("p") || txtSalu.Text.Contains("q") || txtSalu.Text.Contains("r") || txtSalu.Text.Contains("s") || txtSalu.Text.Contains("t") || txtSalu.Text.Contains("u") || txtSalu.Text.Contains("v") || txtSalu.Text.Contains("w") || txtSalu.Text.Contains("x") || txtSalu.Text.Contains("y") || txtSalu.Text.Contains("z") || txtSalu.Text.Contains("A") || txtSalu.Text.Contains("B") || txtSalu.Text.Contains("C") || txtSalu.Text.Contains("D") || txtSalu.Text.Contains("E") || txtSalu.Text.Contains("F") || txtSalu.Text.Contains("G") || txtSalu.Text.Contains("H") || txtSalu.Text.Contains("I") || txtSalu.Text.Contains("J") || txtSalu.Text.Contains("K") || txtSalu.Text.Contains("L") || txtSalu.Text.Contains("M") || txtSalu.Text.Contains("N") || txtSalu.Text.Contains("Ñ") || txtSalu.Text.Contains("O") || txtSalu.Text.Contains("P") || txtSalu.Text.Contains("Q") || txtSalu.Text.Contains("R") || txtSalu.Text.Contains("S") || txtSalu.Text.Contains("T") || txtSalu.Text.Contains("U") || txtSalu.Text.Contains("V") || txtSalu.Text.Contains("W") || txtSalu.Text.Contains("X") || txtSalu.Text.Contains("Y") || txtSalu.Text.Contains("Z") || txtSalu.Text.Contains("á") || txtSalu.Text.Contains("é") || txtSalu.Text.Contains("í") || txtSalu.Text.Contains("ó") || txtSalu.Text.Contains("ú") || txtSalu.Text.Contains("Á") || txtSalu.Text.Contains("É") || txtSalu.Text.Contains("Í") || txtSalu.Text.Contains("Ó") || txtSalu.Text.Contains("Ú"))
            {
                txtSalu.Focus();
                MessageBox.Show("Ingrese solo números.");
                txtSalu.Clear();
                return false;
            }
            if (txtRecre.Text.Contains("a") || txtRecre.Text.Contains("b") || txtRecre.Text.Contains("c") || txtRecre.Text.Contains("d") || txtRecre.Text.Contains("e") || txtRecre.Text.Contains("f") || txtRecre.Text.Contains("g") || txtRecre.Text.Contains("h") || txtRecre.Text.Contains("i") || txtRecre.Text.Contains("j") || txtRecre.Text.Contains("k") || txtRecre.Text.Contains("l") || txtRecre.Text.Contains("m") || txtRecre.Text.Contains("n") || txtRecre.Text.Contains("ñ") || txtRecre.Text.Contains("o") || txtRecre.Text.Contains("p") || txtRecre.Text.Contains("q") || txtRecre.Text.Contains("r") || txtRecre.Text.Contains("s") || txtRecre.Text.Contains("t") || txtRecre.Text.Contains("u") || txtRecre.Text.Contains("v") || txtRecre.Text.Contains("w") || txtRecre.Text.Contains("x") || txtRecre.Text.Contains("y") || txtRecre.Text.Contains("z") || txtRecre.Text.Contains("A") || txtRecre.Text.Contains("B") || txtRecre.Text.Contains("C") || txtRecre.Text.Contains("D") || txtRecre.Text.Contains("E") || txtRecre.Text.Contains("F") || txtRecre.Text.Contains("G") || txtRecre.Text.Contains("H") || txtRecre.Text.Contains("I") || txtRecre.Text.Contains("J") || txtRecre.Text.Contains("K") || txtRecre.Text.Contains("L") || txtRecre.Text.Contains("M") || txtRecre.Text.Contains("N") || txtRecre.Text.Contains("Ñ") || txtRecre.Text.Contains("O") || txtRecre.Text.Contains("P") || txtRecre.Text.Contains("Q") || txtRecre.Text.Contains("R") || txtRecre.Text.Contains("S") || txtRecre.Text.Contains("T") || txtRecre.Text.Contains("U") || txtRecre.Text.Contains("V") || txtRecre.Text.Contains("W") || txtRecre.Text.Contains("X") || txtRecre.Text.Contains("Y") || txtRecre.Text.Contains("Z") || txtRecre.Text.Contains("á") || txtRecre.Text.Contains("é") || txtRecre.Text.Contains("í") || txtRecre.Text.Contains("ó") || txtRecre.Text.Contains("ú") || txtRecre.Text.Contains("Á") || txtRecre.Text.Contains("É") || txtRecre.Text.Contains("Í") || txtRecre.Text.Contains("Ó") || txtRecre.Text.Contains("Ú"))
            {
                txtRecre.Focus();
                MessageBox.Show("Ingrese solo números.");
                txtRecre.Clear();
                return false;
            }
            if (txtAlime.Text.Contains("a") || txtAlime.Text.Contains("b") || txtAlime.Text.Contains("c") || txtAlime.Text.Contains("d") || txtAlime.Text.Contains("e") || txtAlime.Text.Contains("f") || txtAlime.Text.Contains("g") || txtAlime.Text.Contains("h") || txtAlime.Text.Contains("i") || txtAlime.Text.Contains("j") || txtAlime.Text.Contains("k") || txtAlime.Text.Contains("l") || txtAlime.Text.Contains("m") || txtAlime.Text.Contains("n") || txtAlime.Text.Contains("ñ") || txtAlime.Text.Contains("o") || txtAlime.Text.Contains("p") || txtAlime.Text.Contains("q") || txtAlime.Text.Contains("r") || txtAlime.Text.Contains("s") || txtAlime.Text.Contains("t") || txtAlime.Text.Contains("u") || txtAlime.Text.Contains("v") || txtAlime.Text.Contains("w") || txtAlime.Text.Contains("x") || txtAlime.Text.Contains("y") || txtAlime.Text.Contains("z") || txtAlime.Text.Contains("A") || txtAlime.Text.Contains("B") || txtAlime.Text.Contains("C") || txtAlime.Text.Contains("D") || txtAlime.Text.Contains("E") || txtAlime.Text.Contains("F") || txtAlime.Text.Contains("G") || txtAlime.Text.Contains("H") || txtAlime.Text.Contains("I") || txtAlime.Text.Contains("J") || txtAlime.Text.Contains("K") || txtAlime.Text.Contains("L") || txtAlime.Text.Contains("M") || txtAlime.Text.Contains("N") || txtAlime.Text.Contains("Ñ") || txtAlime.Text.Contains("O") || txtAlime.Text.Contains("P") || txtAlime.Text.Contains("Q") || txtAlime.Text.Contains("R") || txtAlime.Text.Contains("S") || txtAlime.Text.Contains("T") || txtAlime.Text.Contains("U") || txtAlime.Text.Contains("V") || txtAlime.Text.Contains("W") || txtAlime.Text.Contains("X") || txtAlime.Text.Contains("Y") || txtAlime.Text.Contains("Z") || txtAlime.Text.Contains("á") || txtAlime.Text.Contains("é") || txtAlime.Text.Contains("í") || txtAlime.Text.Contains("ó") || txtAlime.Text.Contains("ú") || txtAlime.Text.Contains("Á") || txtAlime.Text.Contains("É") || txtAlime.Text.Contains("Í") || txtAlime.Text.Contains("Ó") || txtAlime.Text.Contains("Ú"))
            {
                txtAlime.Focus();
                MessageBox.Show("Ingrese solo números.");
                txtAlime.Clear();
                return false;
            }
            if (txtHigiene.Text.Contains("a") || txtHigiene.Text.Contains("b") || txtHigiene.Text.Contains("c") || txtHigiene.Text.Contains("d") || txtHigiene.Text.Contains("e") || txtHigiene.Text.Contains("f") || txtHigiene.Text.Contains("g") || txtHigiene.Text.Contains("h") || txtHigiene.Text.Contains("i") || txtHigiene.Text.Contains("j") || txtHigiene.Text.Contains("k") || txtHigiene.Text.Contains("l") || txtHigiene.Text.Contains("m") || txtHigiene.Text.Contains("n") || txtHigiene.Text.Contains("ñ") || txtHigiene.Text.Contains("o") || txtHigiene.Text.Contains("p") || txtHigiene.Text.Contains("q") || txtHigiene.Text.Contains("r") || txtHigiene.Text.Contains("s") || txtHigiene.Text.Contains("t") || txtHigiene.Text.Contains("u") || txtHigiene.Text.Contains("v") || txtHigiene.Text.Contains("w") || txtHigiene.Text.Contains("x") || txtHigiene.Text.Contains("y") || txtHigiene.Text.Contains("z") || txtHigiene.Text.Contains("A") || txtHigiene.Text.Contains("B") || txtHigiene.Text.Contains("C") || txtHigiene.Text.Contains("D") || txtHigiene.Text.Contains("E") || txtHigiene.Text.Contains("F") || txtHigiene.Text.Contains("G") || txtHigiene.Text.Contains("H") || txtHigiene.Text.Contains("I") || txtHigiene.Text.Contains("J") || txtHigiene.Text.Contains("K") || txtHigiene.Text.Contains("L") || txtHigiene.Text.Contains("M") || txtHigiene.Text.Contains("N") || txtHigiene.Text.Contains("Ñ") || txtHigiene.Text.Contains("O") || txtHigiene.Text.Contains("P") || txtHigiene.Text.Contains("Q") || txtHigiene.Text.Contains("R") || txtHigiene.Text.Contains("S") || txtHigiene.Text.Contains("T") || txtHigiene.Text.Contains("U") || txtHigiene.Text.Contains("V") || txtHigiene.Text.Contains("W") || txtHigiene.Text.Contains("X") || txtHigiene.Text.Contains("Y") || txtHigiene.Text.Contains("Z") || txtHigiene.Text.Contains("á") || txtHigiene.Text.Contains("é") || txtHigiene.Text.Contains("í") || txtHigiene.Text.Contains("ó") || txtHigiene.Text.Contains("ú") || txtHigiene.Text.Contains("Á") || txtHigiene.Text.Contains("É") || txtHigiene.Text.Contains("Í") || txtHigiene.Text.Contains("Ó") || txtHigiene.Text.Contains("Ú"))
            {
                txtHigiene.Focus();
                MessageBox.Show("Ingrese solo números.");
                txtHigiene.Clear();
                return false;
            }
            if (txtVestuario.Text.Contains("a") || txtVestuario.Text.Contains("b") || txtVestuario.Text.Contains("c") || txtVestuario.Text.Contains("d") || txtVestuario.Text.Contains("e") || txtVestuario.Text.Contains("f") || txtVestuario.Text.Contains("g") || txtVestuario.Text.Contains("h") || txtVestuario.Text.Contains("i") || txtVestuario.Text.Contains("j") || txtVestuario.Text.Contains("k") || txtVestuario.Text.Contains("l") || txtVestuario.Text.Contains("m") || txtVestuario.Text.Contains("n") || txtVestuario.Text.Contains("ñ") || txtVestuario.Text.Contains("o") || txtVestuario.Text.Contains("p") || txtVestuario.Text.Contains("q") || txtVestuario.Text.Contains("r") || txtVestuario.Text.Contains("s") || txtVestuario.Text.Contains("t") || txtVestuario.Text.Contains("u") || txtVestuario.Text.Contains("v") || txtVestuario.Text.Contains("w") || txtVestuario.Text.Contains("x") || txtVestuario.Text.Contains("y") || txtVestuario.Text.Contains("z") || txtVestuario.Text.Contains("A") || txtVestuario.Text.Contains("B") || txtVestuario.Text.Contains("C") || txtVestuario.Text.Contains("D") || txtVestuario.Text.Contains("E") || txtVestuario.Text.Contains("F") || txtVestuario.Text.Contains("G") || txtVestuario.Text.Contains("H") || txtVestuario.Text.Contains("I") || txtVestuario.Text.Contains("J") || txtVestuario.Text.Contains("K") || txtVestuario.Text.Contains("L") || txtVestuario.Text.Contains("M") || txtVestuario.Text.Contains("N") || txtVestuario.Text.Contains("Ñ") || txtVestuario.Text.Contains("O") || txtVestuario.Text.Contains("P") || txtVestuario.Text.Contains("Q") || txtVestuario.Text.Contains("R") || txtVestuario.Text.Contains("S") || txtVestuario.Text.Contains("T") || txtVestuario.Text.Contains("U") || txtVestuario.Text.Contains("V") || txtVestuario.Text.Contains("W") || txtVestuario.Text.Contains("X") || txtVestuario.Text.Contains("Y") || txtVestuario.Text.Contains("Z") || txtVestuario.Text.Contains("á") || txtVestuario.Text.Contains("é") || txtVestuario.Text.Contains("í") || txtVestuario.Text.Contains("ó") || txtVestuario.Text.Contains("ú") || txtVestuario.Text.Contains("Á") || txtVestuario.Text.Contains("É") || txtVestuario.Text.Contains("Í") || txtVestuario.Text.Contains("Ó") || txtVestuario.Text.Contains("Ú"))
            {
                txtVestuario.Focus();
                MessageBox.Show("Ingrese solo números.");
                txtVestuario.Clear();
                return false;
            }
            if (txtCuidado.Text.Contains("a") || txtCuidado.Text.Contains("b") || txtCuidado.Text.Contains("c") || txtCuidado.Text.Contains("d") || txtCuidado.Text.Contains("e") || txtCuidado.Text.Contains("f") || txtCuidado.Text.Contains("g") || txtCuidado.Text.Contains("h") || txtCuidado.Text.Contains("i") || txtCuidado.Text.Contains("j") || txtCuidado.Text.Contains("k") || txtCuidado.Text.Contains("l") || txtCuidado.Text.Contains("m") || txtCuidado.Text.Contains("n") || txtCuidado.Text.Contains("ñ") || txtCuidado.Text.Contains("o") || txtCuidado.Text.Contains("p") || txtCuidado.Text.Contains("q") || txtCuidado.Text.Contains("r") || txtCuidado.Text.Contains("s") || txtCuidado.Text.Contains("t") || txtCuidado.Text.Contains("u") || txtCuidado.Text.Contains("v") || txtCuidado.Text.Contains("w") || txtCuidado.Text.Contains("x") || txtCuidado.Text.Contains("y") || txtCuidado.Text.Contains("z") || txtCuidado.Text.Contains("A") || txtCuidado.Text.Contains("B") || txtCuidado.Text.Contains("C") || txtCuidado.Text.Contains("D") || txtCuidado.Text.Contains("E") || txtCuidado.Text.Contains("F") || txtCuidado.Text.Contains("G") || txtCuidado.Text.Contains("H") || txtCuidado.Text.Contains("I") || txtCuidado.Text.Contains("J") || txtCuidado.Text.Contains("K") || txtCuidado.Text.Contains("L") || txtCuidado.Text.Contains("M") || txtCuidado.Text.Contains("N") || txtCuidado.Text.Contains("Ñ") || txtCuidado.Text.Contains("O") || txtCuidado.Text.Contains("P") || txtCuidado.Text.Contains("Q") || txtCuidado.Text.Contains("R") || txtCuidado.Text.Contains("S") || txtCuidado.Text.Contains("T") || txtCuidado.Text.Contains("U") || txtCuidado.Text.Contains("V") || txtCuidado.Text.Contains("W") || txtCuidado.Text.Contains("X") || txtCuidado.Text.Contains("Y") || txtCuidado.Text.Contains("Z") || txtCuidado.Text.Contains("á") || txtCuidado.Text.Contains("é") || txtCuidado.Text.Contains("í") || txtCuidado.Text.Contains("ó") || txtCuidado.Text.Contains("ú") || txtCuidado.Text.Contains("Á") || txtCuidado.Text.Contains("É") || txtCuidado.Text.Contains("Í") || txtCuidado.Text.Contains("Ó") || txtCuidado.Text.Contains("Ú"))
            {
                txtCuidado.Focus();
                MessageBox.Show("Ingrese solo números.");
                txtCuidado.Clear();
                return false;
            }
            if (txtAten.Text.Contains("a") || txtAten.Text.Contains("b") || txtAten.Text.Contains("c") || txtAten.Text.Contains("d") || txtAten.Text.Contains("e") || txtAten.Text.Contains("f") || txtAten.Text.Contains("g") || txtAten.Text.Contains("h") || txtAten.Text.Contains("i") || txtAten.Text.Contains("j") || txtAten.Text.Contains("k") || txtAten.Text.Contains("l") || txtAten.Text.Contains("m") || txtAten.Text.Contains("n") || txtAten.Text.Contains("ñ") || txtAten.Text.Contains("o") || txtAten.Text.Contains("p") || txtAten.Text.Contains("q") || txtAten.Text.Contains("r") || txtAten.Text.Contains("s") || txtAten.Text.Contains("t") || txtAten.Text.Contains("u") || txtAten.Text.Contains("v") || txtAten.Text.Contains("w") || txtAten.Text.Contains("x") || txtAten.Text.Contains("y") || txtAten.Text.Contains("z") || txtAten.Text.Contains("A") || txtAten.Text.Contains("B") || txtAten.Text.Contains("C") || txtAten.Text.Contains("D") || txtAten.Text.Contains("E") || txtAten.Text.Contains("F") || txtAten.Text.Contains("G") || txtAten.Text.Contains("H") || txtAten.Text.Contains("I") || txtAten.Text.Contains("J") || txtAten.Text.Contains("K") || txtAten.Text.Contains("L") || txtAten.Text.Contains("M") || txtAten.Text.Contains("N") || txtAten.Text.Contains("Ñ") || txtAten.Text.Contains("O") || txtAten.Text.Contains("P") || txtAten.Text.Contains("Q") || txtAten.Text.Contains("R") || txtAten.Text.Contains("S") || txtAten.Text.Contains("T") || txtAten.Text.Contains("U") || txtAten.Text.Contains("V") || txtAten.Text.Contains("W") || txtAten.Text.Contains("X") || txtAten.Text.Contains("Y") || txtAten.Text.Contains("Z") || txtAten.Text.Contains("á") || txtAten.Text.Contains("é") || txtAten.Text.Contains("í") || txtAten.Text.Contains("ó") || txtAten.Text.Contains("ú") || txtAten.Text.Contains("Á") || txtAten.Text.Contains("É") || txtAten.Text.Contains("Í") || txtAten.Text.Contains("Ó") || txtAten.Text.Contains("Ú"))
            {
                txtAten.Focus();
                MessageBox.Show("Ingrese solo números.");
                txtAten.Clear();
                return false;
            }
            if (txtCompra.Text.Contains("a") || txtCompra.Text.Contains("b") || txtCompra.Text.Contains("c") || txtCompra.Text.Contains("d") || txtCompra.Text.Contains("e") || txtCompra.Text.Contains("f") || txtCompra.Text.Contains("g") || txtCompra.Text.Contains("h") || txtCompra.Text.Contains("i") || txtCompra.Text.Contains("j") || txtCompra.Text.Contains("k") || txtCompra.Text.Contains("l") || txtCompra.Text.Contains("m") || txtCompra.Text.Contains("n") || txtCompra.Text.Contains("ñ") || txtCompra.Text.Contains("o") || txtCompra.Text.Contains("p") || txtCompra.Text.Contains("q") || txtCompra.Text.Contains("r") || txtCompra.Text.Contains("s") || txtCompra.Text.Contains("t") || txtCompra.Text.Contains("u") || txtCompra.Text.Contains("v") || txtCompra.Text.Contains("w") || txtCompra.Text.Contains("x") || txtCompra.Text.Contains("y") || txtCompra.Text.Contains("z") || txtCompra.Text.Contains("A") || txtCompra.Text.Contains("B") || txtCompra.Text.Contains("C") || txtCompra.Text.Contains("D") || txtCompra.Text.Contains("E") || txtCompra.Text.Contains("F") || txtCompra.Text.Contains("G") || txtCompra.Text.Contains("H") || txtCompra.Text.Contains("I") || txtCompra.Text.Contains("J") || txtCompra.Text.Contains("K") || txtCompra.Text.Contains("L") || txtCompra.Text.Contains("M") || txtCompra.Text.Contains("N") || txtCompra.Text.Contains("Ñ") || txtCompra.Text.Contains("O") || txtCompra.Text.Contains("P") || txtCompra.Text.Contains("Q") || txtCompra.Text.Contains("R") || txtCompra.Text.Contains("S") || txtCompra.Text.Contains("T") || txtCompra.Text.Contains("U") || txtCompra.Text.Contains("V") || txtCompra.Text.Contains("W") || txtCompra.Text.Contains("X") || txtCompra.Text.Contains("Y") || txtCompra.Text.Contains("Z") || txtCompra.Text.Contains("á") || txtCompra.Text.Contains("é") || txtCompra.Text.Contains("í") || txtCompra.Text.Contains("ó") || txtCompra.Text.Contains("ú") || txtCompra.Text.Contains("Á") || txtCompra.Text.Contains("É") || txtCompra.Text.Contains("Í") || txtCompra.Text.Contains("Ó") || txtCompra.Text.Contains("Ú"))
            {
                txtCompra.Focus();
                MessageBox.Show("Ingrese solo números.");
                txtCompra.Clear();
                return false;
            }
            if (textBoxMesad.Text.Contains("a") || textBoxMesad.Text.Contains("b") || textBoxMesad.Text.Contains("c") || textBoxMesad.Text.Contains("d") || textBoxMesad.Text.Contains("e") || textBoxMesad.Text.Contains("f") || textBoxMesad.Text.Contains("g") || textBoxMesad.Text.Contains("h") || textBoxMesad.Text.Contains("i") || textBoxMesad.Text.Contains("j") || textBoxMesad.Text.Contains("k") || textBoxMesad.Text.Contains("l") || textBoxMesad.Text.Contains("m") || textBoxMesad.Text.Contains("n") || textBoxMesad.Text.Contains("ñ") || textBoxMesad.Text.Contains("o") || textBoxMesad.Text.Contains("p") || textBoxMesad.Text.Contains("q") || textBoxMesad.Text.Contains("r") || textBoxMesad.Text.Contains("s") || textBoxMesad.Text.Contains("t") || textBoxMesad.Text.Contains("u") || textBoxMesad.Text.Contains("v") || textBoxMesad.Text.Contains("w") || textBoxMesad.Text.Contains("x") || textBoxMesad.Text.Contains("y") || textBoxMesad.Text.Contains("z") || textBoxMesad.Text.Contains("A") || textBoxMesad.Text.Contains("B") || textBoxMesad.Text.Contains("C") || textBoxMesad.Text.Contains("D") || textBoxMesad.Text.Contains("E") || textBoxMesad.Text.Contains("F") || textBoxMesad.Text.Contains("G") || textBoxMesad.Text.Contains("H") || textBoxMesad.Text.Contains("I") || textBoxMesad.Text.Contains("J") || textBoxMesad.Text.Contains("K") || textBoxMesad.Text.Contains("L") || textBoxMesad.Text.Contains("M") || textBoxMesad.Text.Contains("N") || textBoxMesad.Text.Contains("Ñ") || textBoxMesad.Text.Contains("O") || textBoxMesad.Text.Contains("P") || textBoxMesad.Text.Contains("Q") || textBoxMesad.Text.Contains("R") || textBoxMesad.Text.Contains("S") || textBoxMesad.Text.Contains("T") || textBoxMesad.Text.Contains("U") || textBoxMesad.Text.Contains("V") || textBoxMesad.Text.Contains("W") || textBoxMesad.Text.Contains("X") || textBoxMesad.Text.Contains("Y") || textBoxMesad.Text.Contains("Z") || textBoxMesad.Text.Contains("á") || textBoxMesad.Text.Contains("é") || textBoxMesad.Text.Contains("í") || textBoxMesad.Text.Contains("ó") || textBoxMesad.Text.Contains("ú") || textBoxMesad.Text.Contains("Á") || textBoxMesad.Text.Contains("É") || textBoxMesad.Text.Contains("Í") || textBoxMesad.Text.Contains("Ó") || textBoxMesad.Text.Contains("Ú"))
            {
                textBoxMesad.Focus();
                MessageBox.Show("Ingrese solo números.");
                textBoxMesad.Clear();
                return false;
            }
            if (txtProye.Text.Contains("a") || txtProye.Text.Contains("b") || txtProye.Text.Contains("c") || txtProye.Text.Contains("d") || txtProye.Text.Contains("e") || txtProye.Text.Contains("f") || txtProye.Text.Contains("g") || txtProye.Text.Contains("h") || txtProye.Text.Contains("i") || txtProye.Text.Contains("j") || txtProye.Text.Contains("k") || txtProye.Text.Contains("l") || txtProye.Text.Contains("m") || txtProye.Text.Contains("n") || txtProye.Text.Contains("ñ") || txtProye.Text.Contains("o") || txtProye.Text.Contains("p") || txtProye.Text.Contains("q") || txtProye.Text.Contains("r") || txtProye.Text.Contains("s") || txtProye.Text.Contains("t") || txtProye.Text.Contains("u") || txtProye.Text.Contains("v") || txtProye.Text.Contains("w") || txtProye.Text.Contains("x") || txtProye.Text.Contains("y") || txtProye.Text.Contains("z") || txtProye.Text.Contains("A") || txtProye.Text.Contains("B") || txtProye.Text.Contains("C") || txtProye.Text.Contains("D") || txtProye.Text.Contains("E") || txtProye.Text.Contains("F") || txtProye.Text.Contains("G") || txtProye.Text.Contains("H") || txtProye.Text.Contains("I") || txtProye.Text.Contains("J") || txtProye.Text.Contains("K") || txtProye.Text.Contains("L") || txtProye.Text.Contains("M") || txtProye.Text.Contains("N") || txtProye.Text.Contains("Ñ") || txtProye.Text.Contains("O") || txtProye.Text.Contains("P") || txtProye.Text.Contains("Q") || txtProye.Text.Contains("R") || txtProye.Text.Contains("S") || txtProye.Text.Contains("T") || txtProye.Text.Contains("U") || txtProye.Text.Contains("V") || txtProye.Text.Contains("W") || txtProye.Text.Contains("X") || txtProye.Text.Contains("Y") || txtProye.Text.Contains("Z") || txtProye.Text.Contains("á") || txtProye.Text.Contains("é") || txtProye.Text.Contains("í") || txtProye.Text.Contains("ó") || txtProye.Text.Contains("ú") || txtProye.Text.Contains("Á") || txtProye.Text.Contains("É") || txtProye.Text.Contains("Í") || txtProye.Text.Contains("Ó") || txtProye.Text.Contains("Ú"))
            {
                txtProye.Focus();
                MessageBox.Show("Ingrese solo números.");
                txtProye.Clear();
                return false;
            }
            if (txtAdmin.Text.Contains("a") || txtAdmin.Text.Contains("b") || txtAdmin.Text.Contains("c") || txtAdmin.Text.Contains("d") || txtAdmin.Text.Contains("e") || txtAdmin.Text.Contains("f") || txtAdmin.Text.Contains("g") || txtAdmin.Text.Contains("h") || txtAdmin.Text.Contains("i") || txtAdmin.Text.Contains("j") || txtAdmin.Text.Contains("k") || txtAdmin.Text.Contains("l") || txtAdmin.Text.Contains("m") || txtAdmin.Text.Contains("n") || txtAdmin.Text.Contains("ñ") || txtAdmin.Text.Contains("o") || txtAdmin.Text.Contains("p") || txtAdmin.Text.Contains("q") || txtAdmin.Text.Contains("r") || txtAdmin.Text.Contains("s") || txtAdmin.Text.Contains("t") || txtAdmin.Text.Contains("u") || txtAdmin.Text.Contains("v") || txtAdmin.Text.Contains("w") || txtAdmin.Text.Contains("x") || txtAdmin.Text.Contains("y") || txtAdmin.Text.Contains("z") || txtAdmin.Text.Contains("A") || txtAdmin.Text.Contains("B") || txtAdmin.Text.Contains("C") || txtAdmin.Text.Contains("D") || txtAdmin.Text.Contains("E") || txtAdmin.Text.Contains("F") || txtAdmin.Text.Contains("G") || txtAdmin.Text.Contains("H") || txtAdmin.Text.Contains("I") || txtAdmin.Text.Contains("J") || txtAdmin.Text.Contains("K") || txtAdmin.Text.Contains("L") || txtAdmin.Text.Contains("M") || txtAdmin.Text.Contains("N") || txtAdmin.Text.Contains("Ñ") || txtAdmin.Text.Contains("O") || txtAdmin.Text.Contains("P") || txtAdmin.Text.Contains("Q") || txtAdmin.Text.Contains("R") || txtAdmin.Text.Contains("S") || txtAdmin.Text.Contains("T") || txtAdmin.Text.Contains("U") || txtAdmin.Text.Contains("V") || txtAdmin.Text.Contains("W") || txtAdmin.Text.Contains("X") || txtAdmin.Text.Contains("Y") || txtAdmin.Text.Contains("Z") || txtAdmin.Text.Contains("á") || txtAdmin.Text.Contains("é") || txtAdmin.Text.Contains("í") || txtAdmin.Text.Contains("ó") || txtAdmin.Text.Contains("ú") || txtAdmin.Text.Contains("Á") || txtAdmin.Text.Contains("É") || txtAdmin.Text.Contains("Í") || txtAdmin.Text.Contains("Ó") || txtAdmin.Text.Contains("Ú"))
            {
                txtAdmin.Focus();
                MessageBox.Show("Ingrese solo números.");
                txtAdmin.Clear();
                return false;
            }
            if (txtOtros.Text.Contains("a") || txtOtros.Text.Contains("b") || txtOtros.Text.Contains("c") || txtOtros.Text.Contains("d") || txtOtros.Text.Contains("e") || txtOtros.Text.Contains("f") || txtOtros.Text.Contains("g") || txtOtros.Text.Contains("h") || txtOtros.Text.Contains("i") || txtOtros.Text.Contains("j") || txtOtros.Text.Contains("k") || txtOtros.Text.Contains("l") || txtOtros.Text.Contains("m") || txtOtros.Text.Contains("n") || txtOtros.Text.Contains("ñ") || txtOtros.Text.Contains("o") || txtOtros.Text.Contains("p") || txtOtros.Text.Contains("q") || txtOtros.Text.Contains("r") || txtOtros.Text.Contains("s") || txtOtros.Text.Contains("t") || txtOtros.Text.Contains("u") || txtOtros.Text.Contains("v") || txtOtros.Text.Contains("w") || txtOtros.Text.Contains("x") || txtOtros.Text.Contains("y") || txtOtros.Text.Contains("z") || txtOtros.Text.Contains("A") || txtOtros.Text.Contains("B") || txtOtros.Text.Contains("C") || txtOtros.Text.Contains("D") || txtOtros.Text.Contains("E") || txtOtros.Text.Contains("F") || txtOtros.Text.Contains("G") || txtOtros.Text.Contains("H") || txtOtros.Text.Contains("I") || txtOtros.Text.Contains("J") || txtOtros.Text.Contains("K") || txtOtros.Text.Contains("L") || txtOtros.Text.Contains("M") || txtOtros.Text.Contains("N") || txtOtros.Text.Contains("Ñ") || txtOtros.Text.Contains("O") || txtOtros.Text.Contains("P") || txtOtros.Text.Contains("Q") || txtOtros.Text.Contains("R") || txtOtros.Text.Contains("S") || txtOtros.Text.Contains("T") || txtOtros.Text.Contains("U") || txtOtros.Text.Contains("V") || txtOtros.Text.Contains("W") || txtOtros.Text.Contains("X") || txtOtros.Text.Contains("Y") || txtOtros.Text.Contains("Z") || txtOtros.Text.Contains("á") || txtOtros.Text.Contains("é") || txtOtros.Text.Contains("í") || txtOtros.Text.Contains("ó") || txtOtros.Text.Contains("ú") || txtOtros.Text.Contains("Á") || txtOtros.Text.Contains("É") || txtOtros.Text.Contains("Í") || txtOtros.Text.Contains("Ó") || txtOtros.Text.Contains("Ú"))
            {
                txtOtros.Focus();
                MessageBox.Show("Ingrese solo números.");
                txtOtros.Clear();
                return false;
            }
            if (txtName.Text == "")
            {
                txtName.Focus();
                MessageBox.Show("Ingrese un nombre.");
                txtName.Clear();
                return false;
            }
            return true;
        }
        String GetSubModality()
        {
            return comboBoxSubmodality.SelectedItem.ToString();
        }
        int GetRegion()
        {
            return Convert.ToInt32(comboBoxRegion.SelectedIndex + 1);
        }
        int GetGender()
        {
            return Convert.ToInt32(comboBoxgGender.SelectedIndex + 1);
        }
        void Clean()
        {
            txtName.Clear();
            comboBoxSubmodality.SelectedIndex = 0;
            comboBoxRegion.SelectedIndex = 0;
            numericUpDownF04.Value = 0;
            numericUpDownF56.Value = 0;
            numericUpDownF712.Value = 0;
            numericUpDownF1318.Value = 0;
            comboBoxgGender.SelectedIndex = 0;
            txtInfra.Clear();
            txtEdu.Clear();
            txtSalu.Clear();
            txtRecre.Clear();
            txtAlime.Clear();
            txtHigiene.Clear();
            txtVestuario.Clear();
            txtCuidado.Clear();
            txtAten.Clear();
            txtCompra.Clear();
            textBoxMesad.Clear();
            txtProye.Clear();
            txtAdmin.Clear();
            txtOtros.Clear();
        }
        void InsertHogar()
        {
            string name = txtName.Text;
            int f1 = Convert.ToInt32(numericUpDownF04.Value);
            int f2 = Convert.ToInt32(numericUpDownF56.Value);
            int f3 = Convert.ToInt32(numericUpDownF712.Value);
            int f4 = Convert.ToInt32(numericUpDownF1318.Value);

            decimal infra = 0;
            if (txtInfra.Text != "")
            {
                infra = Convert.ToDecimal(txtInfra.Text);
            }

            decimal edu = 0;
            if (txtEdu.Text != "")
            {
                edu = Convert.ToDecimal(txtEdu.Text);
            }

            decimal hea = 0;
            if (txtSalu.Text != "")
            {
                hea = Convert.ToDecimal(txtSalu.Text);
            }

            decimal rec = 0;
            if (txtRecre.Text != "")
            {
                rec = Convert.ToDecimal(txtRecre.Text);
            }

            decimal fed = 0;
            if (txtAlime.Text != "")
            {
                fed = Convert.ToDecimal(txtAlime.Text);
            }

            decimal ali = 0;
            if (txtAlime.Text != "")
            {
                ali = Convert.ToDecimal(txtAlime.Text);
            }

            decimal hig = 0;
            if (txtHigiene.Text != "")
            {
                hig = Convert.ToDecimal(txtHigiene.Text);
            }

            decimal ves = 0;
            if (txtVestuario.Text != "")
            {
                ves = Convert.ToDecimal(txtVestuario.Text);
            }

            decimal dia = 0;
            if (txtCuidado.Text != "")
            {
                dia = Convert.ToDecimal(txtCuidado.Text);
            }

            decimal dir = 0;
            if (txtAten.Text != "")
            {
                dir = Convert.ToDecimal(txtAten.Text);
            }

            decimal equ = 0;
            if (txtCompra.Text != "")
            {
                equ = Convert.ToDecimal(txtCompra.Text);
            }

            decimal all = 0;
            if (textBoxMesad.Text != "")
            {
                all = Convert.ToDecimal(textBoxMesad.Text);
            }

            decimal vid = 0;
            if (txtProye.Text != "")
            {
                vid = Convert.ToDecimal(txtProye.Text);
            }

            decimal adm = 0;
            if (txtAdmin.Text != "")
            {
                adm = Convert.ToDecimal(txtAdmin.Text);
            }
            decimal oth = 0;
            if (txtOtros.Text != "")
            {
                oth = Convert.ToDecimal(txtOtros.Text);
            }
            hogar.InsertHogar(name, GetSubModality(), GetRegion(), f1, f2, f3, f4, GetGender(), infra, edu, hea, rec, fed, hig, ves, dia, dir, equ, all, vid, adm, oth, labelUser.Text);
            EnlistHogar();
            Clean();
        }
        void UpdateHogar()
        {
            string name = txtName.Text;
            int f1 = Convert.ToInt32(numericUpDownF04.Value);
            int f2 = Convert.ToInt32(numericUpDownF56.Value);
            int f3 = Convert.ToInt32(numericUpDownF712.Value);
            int f4 = Convert.ToInt32(numericUpDownF1318.Value);

            decimal infra = 0;
            if (txtInfra.Text != "")
            {
                infra = Convert.ToDecimal(txtInfra.Text);
            }

            decimal edu = 0;
            if (txtEdu.Text != "")
            {
                edu = Convert.ToDecimal(txtEdu.Text);
            }

            decimal hea = 0;
            if (txtSalu.Text != "")
            {
                hea = Convert.ToDecimal(txtSalu.Text);
            }

            decimal rec = 0;
            if (txtRecre.Text != "")
            {
                rec = Convert.ToDecimal(txtRecre.Text);
            }

            decimal fed = 0;
            if (txtAlime.Text != "")
            {
                fed = Convert.ToDecimal(txtAlime.Text);
            }

            decimal ali = 0;
            if (txtAlime.Text != "")
            {
                ali = Convert.ToDecimal(txtAlime.Text);
            }

            decimal hig = 0;
            if (txtHigiene.Text != "")
            {
                hig = Convert.ToDecimal(txtHigiene.Text);
            }

            decimal ves = 0;
            if (txtVestuario.Text != "")
            {
                ves = Convert.ToDecimal(txtVestuario.Text);
            }

            decimal dia = 0;
            if (txtCuidado.Text != "")
            {
                dia = Convert.ToDecimal(txtCuidado.Text);
            }

            decimal dir = 0;
            if (txtAten.Text != "")
            {
                dir = Convert.ToDecimal(txtAten.Text);
            }

            decimal equ = 0;
            if (txtCompra.Text != "")
            {
                equ = Convert.ToDecimal(txtCompra.Text);
            }

            decimal all = 0;
            if (textBoxMesad.Text != "")
            {
                all = Convert.ToDecimal(textBoxMesad.Text);
            }

            decimal vid = 0;
            if (txtProye.Text != "")
            {
                vid = Convert.ToDecimal(txtProye.Text);
            }

            decimal adm = 0;
            if (txtAdmin.Text != "")
            {
                adm = Convert.ToDecimal(txtAdmin.Text);
            }
            decimal oth = 0;
            if (txtOtros.Text != "")
            {
                oth = Convert.ToDecimal(txtOtros.Text);
            }
            hogar.UpdateHogar(Convert.ToInt32(dataGridViewIntervencion.CurrentRow.Cells[0].Value), name, GetSubModality(), GetRegion(), f1, f2, f3, f4, GetGender(), infra, edu, hea, rec, fed, hig, ves, dia, dir, equ, all, vid, adm, oth, labelUser.Text);
            EnlistHogar();
            Clean();
            labelCost.Visible = false;
            labelTotal.Visible = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validations() == true)
            {
                InsertHogar();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validations() == true)
            {
                UpdateHogar();
            }
        }
        private void dataGridViewIntervencion_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Visible = false;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            txtName.Text = dataGridViewIntervencion.CurrentRow.Cells[1].Value.ToString();
            comboBoxSubmodality.SelectedItem = dataGridViewIntervencion.CurrentRow.Cells[2].Value.ToString();
            comboBoxRegion.SelectedItem = dataGridViewIntervencion.CurrentRow.Cells[3].Value.ToString();
            numericUpDownF04.Value = Convert.ToInt32(dataGridViewIntervencion.CurrentRow.Cells[4].Value);
            numericUpDownF56.Value = Convert.ToInt32(dataGridViewIntervencion.CurrentRow.Cells[5].Value);
            numericUpDownF712.Value = Convert.ToInt32(dataGridViewIntervencion.CurrentRow.Cells[6].Value);
            numericUpDownF1318.Value = Convert.ToInt32(dataGridViewIntervencion.CurrentRow.Cells[7].Value);
            comboBoxgGender.SelectedItem = dataGridViewIntervencion.CurrentRow.Cells[8].Value.ToString();
            if (dataGridViewIntervencion.CurrentRow.Cells[9].Value.ToString() != "Información no disponible")
            {
                txtInfra.Text = dataGridViewIntervencion.CurrentRow.Cells[9].Value.ToString();
            }
            if (dataGridViewIntervencion.CurrentRow.Cells[10].Value.ToString() != "Información no disponible")
            {
                txtEdu.Text = dataGridViewIntervencion.CurrentRow.Cells[10].Value.ToString();
            }
            if (dataGridViewIntervencion.CurrentRow.Cells[11].Value.ToString() != "Información no disponible")
            {
                txtSalu.Text = dataGridViewIntervencion.CurrentRow.Cells[11].Value.ToString();
            }
            if (dataGridViewIntervencion.CurrentRow.Cells[12].Value.ToString() != "Información no disponible")
            {
                txtRecre.Text = dataGridViewIntervencion.CurrentRow.Cells[12].Value.ToString();
            }
            if (dataGridViewIntervencion.CurrentRow.Cells[13].Value.ToString() != "Información no disponible")
            {
                txtAlime.Text = dataGridViewIntervencion.CurrentRow.Cells[13].Value.ToString();
            }
            if (dataGridViewIntervencion.CurrentRow.Cells[14].Value.ToString() != "Información no disponible")
            {
                txtHigiene.Text = dataGridViewIntervencion.CurrentRow.Cells[14].Value.ToString();
            }
            if (dataGridViewIntervencion.CurrentRow.Cells[15].Value.ToString() != "Información no disponible")
            {
                txtVestuario.Text = dataGridViewIntervencion.CurrentRow.Cells[15].Value.ToString();
            }
            if (dataGridViewIntervencion.CurrentRow.Cells[16].Value.ToString() != "Información no disponible")
            {
                txtCuidado.Text = dataGridViewIntervencion.CurrentRow.Cells[16].Value.ToString();
            }
            if (dataGridViewIntervencion.CurrentRow.Cells[17].Value.ToString() != "Información no disponible")
            {
                txtAten.Text = dataGridViewIntervencion.CurrentRow.Cells[17].Value.ToString();
            }
            if (dataGridViewIntervencion.CurrentRow.Cells[18].Value.ToString() != "Información no disponible")
            {
                txtCompra.Text = dataGridViewIntervencion.CurrentRow.Cells[18].Value.ToString();
            }
            if (dataGridViewIntervencion.CurrentRow.Cells[19].Value.ToString() != "Información no disponible")
            {
                textBoxMesad.Text = dataGridViewIntervencion.CurrentRow.Cells[19].Value.ToString();
            }
            if (dataGridViewIntervencion.CurrentRow.Cells[20].Value.ToString() != "Información no disponible")
            {
                txtProye.Text = dataGridViewIntervencion.CurrentRow.Cells[20].Value.ToString();
            }
            if (dataGridViewIntervencion.CurrentRow.Cells[21].Value.ToString() != "Información no disponible")
            {
                txtAdmin.Text = dataGridViewIntervencion.CurrentRow.Cells[21].Value.ToString();
            }
            if (dataGridViewIntervencion.CurrentRow.Cells[22].Value.ToString() != "Información no disponible")
            {
                txtOtros.Text = dataGridViewIntervencion.CurrentRow.Cells[22].Value.ToString();
            }
            labelTotal.Text = dataGridViewIntervencion.CurrentRow.Cells[23].Value.ToString();
            labelCost.Visible = true;
            labelTotal.Visible = true;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            hogar.DeleteHogar(Convert.ToInt32(dataGridViewIntervencion.CurrentRow.Cells[0].Value), labelUser.Text);
            Clean();
            EnlistHogar();
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            labelCost.Visible = false;
            labelTotal.Visible = false;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Ingrese una búsqueda", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridViewIntervencion.DataSource = hogar.SearchHogar(txtSearch.Text);
            }
        }

        private void txtInfra_Leave(object sender, EventArgs e)
        {
            if (txtInfra.Text != "")
            {
                txtInfra.Text = Text = string.Format("{0:#,##0.00}", double.Parse(txtInfra.Text));
            }

        }

        private void txtEdu_Leave(object sender, EventArgs e)
        {
            if (txtEdu.Text != "")
            {
                txtEdu.Text = Text = string.Format("{0:#,##0.00}", double.Parse(txtEdu.Text));
            }
        }

        private void txtSalu_Leave(object sender, EventArgs e)
        {
            if (txtSalu.Text != "")
            {
                txtSalu.Text = Text = string.Format("{0:#,##0.00}", double.Parse(txtSalu.Text));
            }

        }

        private void txtRecre_Leave(object sender, EventArgs e)
        {
            if (txtRecre.Text != "")
            {
                txtRecre.Text = Text = string.Format("{0:#,##0.00}", double.Parse(txtRecre.Text));
            }

        }

        private void txtAlime_Leave(object sender, EventArgs e)
        {
            if (txtAlime.Text != "")
            {
                txtAlime.Text = Text = string.Format("{0:#,##0.00}", double.Parse(txtAlime.Text));
            }

        }

        private void txtHigiene_Leave(object sender, EventArgs e)
        {
            if (txtHigiene.Text != "")
            {
                txtHigiene.Text = Text = string.Format("{0:#,##0.00}", double.Parse(txtHigiene.Text));
            }

        }

        private void txtVestuario_Leave(object sender, EventArgs e)
        {
            if (txtVestuario.Text != "")
            {
                txtVestuario.Text = Text = string.Format("{0:#,##0.00}", double.Parse(txtVestuario.Text));
            }

        }

        private void txtCuidado_Leave(object sender, EventArgs e)
        {
            if (txtCuidado.Text != "")
            {
                txtCuidado.Text = Text = string.Format("{0:#,##0.00}", double.Parse(txtCuidado.Text));
            }

        }

        private void txtAten_Leave(object sender, EventArgs e)
        {
            if (txtAten.Text != "")
            {
                txtAten.Text = Text = string.Format("{0:#,##0.00}", double.Parse(txtAten.Text));
            }

        }

        private void txtCompra_Leave(object sender, EventArgs e)
        {
            if (txtCompra.Text != "")
            {
                txtCompra.Text = Text = string.Format("{0:#,##0.00}", double.Parse(txtCompra.Text));
            }

        }

        private void textBoxMesad_Leave(object sender, EventArgs e)
        {
            if (textBoxMesad.Text != "")
            {
                textBoxMesad.Text = Text = string.Format("{0:#,##0.00}", double.Parse(textBoxMesad.Text));
            }

        }

        private void txtProye_Leave(object sender, EventArgs e)
        {
            if (txtProye.Text != "")
            {
                txtProye.Text = Text = string.Format("{0:#,##0.00}", double.Parse(txtProye.Text));
            }

        }

        private void txtAdmin_Leave(object sender, EventArgs e)
        {
            if (txtAdmin.Text != "")
            {
                txtAdmin.Text = Text = string.Format("{0:#,##0.00}", double.Parse(txtAdmin.Text));
            }

        }

        private void txtOtros_Leave(object sender, EventArgs e)
        {
            if (txtOtros.Text != "")
            {
                txtOtros.Text = Text = string.Format("{0:#,##0.00}", double.Parse(txtOtros.Text));
            }
        }

    }
}
