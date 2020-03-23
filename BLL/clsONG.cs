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
    public class clsONG
    {
        DAL.clsDAL db = new DAL.clsDAL();
        SqlCommand command = new SqlCommand();

        public DataTable EnlistONG()
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE ENLISTONG";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }
        public void InsertONG(string name, string sub, int region, int f1, int f2, int f3, int f4, int gender, decimal infra, decimal educa, decimal health, decimal recreation, decimal feeding, decimal hygiene, decimal dressing, decimal daily, decimal direct, decimal equipment, decimal allow, decimal life, decimal admi, decimal othe, string user)
        {
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE INSERTONG  '" + name + "','" + sub + "'," + region + "," + f1 + "," + f2 + "," + f3 + "," + f4 + "," + gender + "," + infra + "," + educa + "," + health + "," + recreation + "," + feeding + "," + hygiene + "," + dressing + "," + daily + "," + direct + "," + equipment + "," + allow + "," + life + "," + admi + "," + othe + ",'" + user + "';";
            command.ExecuteNonQuery();
            MessageBox.Show("ONG agregada.", "ONG", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.CloseConnection();
        }
        public void UpdateONG(int id, string name, string sub, int region, int f1, int f2, int f3, int f4, int gender, decimal infra, decimal educa, decimal health, decimal recreation, decimal feeding, decimal hygiene, decimal dressing, decimal daily, decimal direct, decimal equipment, decimal allow, decimal life, decimal admi, decimal oth, string user)
        {
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE UPDATEONG " + id + ",'" + name + "','" + sub + "'," + region + "," + f1 + "," + f2 + "," + f3 + "," + f4 + "," + gender + "," + infra + "," + educa + "," + health + "," + recreation + "," + feeding + "," + hygiene + "," + dressing + "," + daily + "," + direct + "," + equipment + "," + allow + "," + life + "," + admi + "," + oth + ",'" + user + "';";
            command.ExecuteNonQuery();
            MessageBox.Show("ONG editado.", "ONG", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.CloseConnection();
        }
        public void DeleteONG(int id, string user)
        {
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE DELETEONG " + id + ",'" + user + "';";
            command.ExecuteNonQuery();
            MessageBox.Show("ONG eliminada.", "ONG", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.CloseConnection();
        }
        public DataTable SearchONG(String search)
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE SEARCHONG '" + search + "';";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }
    }
}
