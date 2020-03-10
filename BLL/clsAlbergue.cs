using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class clsAlbergue
    {
        DAL.clsDAL db = new DAL.clsDAL();
        SqlCommand command = new SqlCommand();
        public DataTable EnlistAlbergue()
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE ENLISTALBERGUES";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }
        public void InsertAlbergue(string name, int sub, int region, int f1, int f2, int f3, int f4, int gender, decimal infra, decimal educa, decimal health, decimal recreation, decimal feeding, decimal hygiene, decimal dressing, decimal daily, decimal direct, decimal equipment, decimal allow, decimal life, decimal admi)
        {
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE INSERTALBERGUE '" + name + "'," + sub + "," + region + "," + f1 + "," + f2 + "," + f3 + "," + f4 + "," + gender + "," + infra + "," + educa + "," + health + "," + recreation + "," + feeding + "," + hygiene + "," + dressing + "," + daily + "," + direct + "," + equipment + "," + allow + "," + life + "," + admi + ";";
            command.ExecuteNonQuery();
            MessageBox.Show("Albergue institucional agregado.", "Albergue institucional", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.CloseConnection();
        }
        public void UpdateAlbergue(int id, string name, int sub, int region, int f1, int f2, int f3, int f4, int gender, decimal infra, decimal educa, decimal health, decimal recreation, decimal feeding, decimal hygiene, decimal dressing, decimal daily, decimal direct, decimal equipment, decimal allow, decimal life, decimal admi)
        {
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE UPDATEALBERGUE " + id+ ",'"+ name + "'," + sub + "," + region + "," + f1 + "," + f2 + "," + f3 + "," + f4 + "," + gender + "," + infra + "," + educa + "," + health + "," + recreation + "," + feeding + "," + hygiene + "," + dressing + "," + daily + "," + direct + "," + equipment + "," + allow + "," + life + "," + admi + ";";
            command.ExecuteNonQuery();
            MessageBox.Show("Albergue institucional editado.", "Albergue institucional", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.CloseConnection();
        }
        public void DeleteAlbergue(int id)
        {
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE DELETEALBERGUE " + id + ";";
            command.ExecuteNonQuery();
            MessageBox.Show("Albergue institucional eliminado.", "Albergue institucional", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.CloseConnection();
        }
        public DataTable SearchAlbergue(String search)
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE SEARCHALBERGUE '" + search + "';";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }

        public DataTable Report1Albergue(String sub)
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE ReportAlbergue1 '" + sub + "';";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }
        public DataTable Report2Albergue(String reg)
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE ReportAlbergue2 '" + reg + "';";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }
        public DataTable Report3Albergue(int gen)
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE ReportAlbergue3 " + gen + ";";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }

        public DataTable Report4Albergue(int eda)
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE ReportAlbergue4; ";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }
        public DataTable Report5Albergue(int eda)
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE ReportAlbergue5; ";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }
        public DataTable Report6Albergue(int eda)
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE ReportAlbergue6; ";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }
        public DataTable Report7Albergue(int eda)
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE ReportAlbergue7; ";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }
        public DataTable Report8Albergue(int eda)
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE ReportAlbergue8; ";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }
        public DataTable Report9Albergue(String sub, String reg)
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE ReportAlbergue9 '"+sub+"','"+reg+"';";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }
        public DataTable Report10Albergue(String sub, int eda)
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE ReportAlbergue10 '" + sub + "'," + eda + ";";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }
        public DataTable Report11Albergue(String sub, int eda)
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE ReportAlbergue11 '" + sub + "'," + eda + ";";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }
        public DataTable Report12Albergue(String sub, int eda)
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE ReportAlbergue12 '" + sub + "'," + eda + ";";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }
        public DataTable Report13Albergue(String sub, int eda)
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE ReportAlbergue13 '" + sub + "'," + eda + ";";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }
        public DataTable Report14Albergue(String sub, int gen)
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE ReportAlbergue14 '" + sub + "'," + gen + ";";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }
        public DataTable Report15Albergue(String reg)
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE ReportAlbergue15 '" + reg+ "';";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }
        public DataTable Report16Albergue(String reg)
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE ReportAlbergue16 '" + reg + "';";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }
        public DataTable Report17Albergue(String reg)
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE ReportAlbergue17 '" + reg + "';";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }
        public DataTable Report18Albergue(String reg)
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE ReportAlbergue18 '" + reg + "';";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }
        public DataTable Report19Albergue(String reg, int gen)
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE ReportAlbergue19 '" + reg + "',"+gen+";";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }
    }
}
