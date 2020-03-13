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
    public partial class ReportPrinter : Form
    {
        public ReportPrinter(String inf, String porInf, String edu, String porEdu, String sal, String porSal, String rec, String porRec, String ali, String porAli, String hig, String porHig, String ves, String porVes, String cui, String porCui, String ate, String porAte, String com, String porCom, String mes, String porMes, String pro, String porPro, String gas, String porGas, String tot)
        {
            InitializeComponent();
            if (inf == "")
            {
                label1.Visible = false;
                label24.Visible = false;
                label52.Visible = false;
                label36.Visible = false;
                label63.Visible = false;
            }
            else
            {
                label24.Text = inf;
                label36.Text = porInf;
            }
            if (edu == "")
            {
                label2.Visible = false;
                label23.Visible = false;
                label51.Visible = false;
                label35.Visible = false;
                label62.Visible = false;
            }
            else
            {
                label23.Text = edu;
                label35.Text = porEdu;
            }
            if (sal == "")
            {
                label3.Visible = false;
                label22.Visible = false;
                label50.Visible = false;
                label34.Visible = false;
                label61.Visible = false;
            }
            else
            {
                label22.Text = sal;
                label34.Text = porSal;
            }
            if (rec == "")
            {
                label4.Visible = false;
                label21.Visible = false;
                label49.Visible = false;
                label33.Visible = false;
                label60.Visible = false;
            }
            else
            {
                label21.Text = rec;
                label33.Text = porRec;
            }
            if (ali == "")
            {
                label5.Visible = false;
                label20.Visible = false;
                label48.Visible = false;
                label32.Visible = false;
                label59.Visible = false;
            }
            else
            {
                label20.Text =ali;
                label32.Text = porAli;
            }
            if (hig == "")
            {
                label6.Visible = false;
                label19.Visible = false;
                label47.Visible = false;
                label31.Visible = false;
                label58.Visible = false;
            }
            else
            {
                label19.Text = hig;
                label31.Text = porHig;
            }
            if (ves == "")
            {
                label7.Visible = false;
                label18.Visible = false;
                label46.Visible = false;
                label30.Visible = false;
                label57.Visible = false;
            }
            else
            {
                label18.Text = ves;
                label30.Text = porVes;
            }
            if (cui == "")
            {
                label8.Visible = false;
                label17.Visible = false;
                label45.Visible = false;
                label29.Visible = false;
                label56.Visible = false;
            }
            else
            {
                label17.Text = cui;
                label29.Text = porCui;
            }
            if (ate == "")
            {

                label9.Visible = false;
                label16.Visible = false;
                label44.Visible = false;
                label28.Visible = false;
                label55.Visible = false;
            }
            else
            {
                label16.Text = ate;
                label28.Text = porAte;
            }

            if (com == "")
            {
                label10.Visible = false;
                label15.Visible = false;
                label43.Visible = false;
                label27.Visible = false;
                label54.Visible = false;
            }
            else
            {
                label15.Text = com;
                label27.Text = porCom;
            }

            if (mes == "")
            {
                label11.Visible = false;
                label14.Visible = false;
                label42.Visible = false;
                label26.Visible = false;
                label53.Visible = false;
            }
            else
            {
                label14.Text = mes;
                label26.Text = porMes;
            }

            if (pro == "")
            {
                label12.Visible = false;
                label13.Visible = false;
                label41.Visible = false;
                label25.Visible = false;
                label40.Visible = false;
            }
            else
            {
                label13.Text = pro;
                label25.Text = porPro;
            }

            if (gas == "")
            {
                label68.Visible = false;
                label67.Visible = false;
                label65.Visible = false;
                label66.Visible = false;
                label64.Visible = false;
            }
            else
            {
                label67.Text = gas;
                label66.Text = porGas;
            }
            label38.Text = tot;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        Bitmap bmp;
        
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(840, 1188, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
    }
}
