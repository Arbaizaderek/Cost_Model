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
    public class clsCentro
    {
        DAL.clsDAL db = new DAL.clsDAL();
        SqlCommand command = new SqlCommand();

        public DataTable EnlistCentro()
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE ENLISTCENTRO";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }
        public void InsertCentro(string name, string sub, int region, int f1, int f2, int f3, int f4, int gender, decimal infra, decimal educa, decimal health, decimal recreation, decimal feeding, decimal hygiene, decimal dressing, decimal daily, decimal direct, decimal equipment, decimal allow, decimal life, decimal admi, decimal othe, string user)
        {
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE INSERTCENTRO '" + name + "','" + sub + "'," + region + "," + f1 + "," + f2 + "," + f3 + "," + f4 + "," + gender + "," + infra + "," + educa + "," + health + "," + recreation + "," + feeding + "," + hygiene + "," + dressing + "," + daily + "," + direct + "," + equipment + "," + allow + "," + life + "," + admi + "," + othe + ",'" + user + "';";
            command.ExecuteNonQuery();
            MessageBox.Show("Centro de atención intregal agregado.", "Centro de atención intregal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.CloseConnection();
        }
        public void UpdateCentro(int id, string name, string sub, int region, int f1, int f2, int f3, int f4, int gender, decimal infra, decimal educa, decimal health, decimal recreation, decimal feeding, decimal hygiene, decimal dressing, decimal daily, decimal direct, decimal equipment, decimal allow, decimal life, decimal admi, decimal oth, string user)
        {
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE UPDATECENTRO " + id + ",'" + name + "','" + sub + "'," + region + "," + f1 + "," + f2 + "," + f3 + "," + f4 + "," + gender + "," + infra + "," + educa + "," + health + "," + recreation + "," + feeding + "," + hygiene + "," + dressing + "," + daily + "," + direct + "," + equipment + "," + allow + "," + life + "," + admi + "," + oth + ",'" + user + "';";
            command.ExecuteNonQuery();
            MessageBox.Show("Centro de atención intregal editado.", "Centro de atención intregal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.CloseConnection();
        }
        public void DeleteCentro(int id, string user)
        {
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE DELETECENTRO " + id + ",'" + user + "';";
            command.ExecuteNonQuery();
            MessageBox.Show("Centro de atención intregal eliminado.", "Centro de atención intregal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.CloseConnection();
        }
        public DataTable SearchCentro(String search)
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE SEARCHCENTRO '"+search+"';";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }
    }
}
