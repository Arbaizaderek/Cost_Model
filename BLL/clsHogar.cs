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
    public class clsHogar
    {
        DAL.clsDAL db = new DAL.clsDAL();
        SqlCommand command = new SqlCommand();

        public DataTable EnlistHogar()
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE ENLISTHOGAR";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }
        public void InsertHogar(string name, string sub, int region, int f1, int f2, int f3, int f4, int gender, decimal infra, decimal educa, decimal health, decimal recreation, decimal feeding, decimal hygiene, decimal dressing, decimal daily, decimal direct, decimal equipment, decimal allow, decimal life, decimal admi, decimal othe, string user)
        {
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE INSERTHOGAR '" + name + "','" + sub + "'," + region + "," + f1 + "," + f2 + "," + f3 + "," + f4 + "," + gender + "," + infra + "," + educa + "," + health + "," + recreation + "," + feeding + "," + hygiene + "," + dressing + "," + daily + "," + direct + "," + equipment + "," + allow + "," + life + "," + admi + "," + othe + ",'" + user + "';";            command.ExecuteNonQuery();
            MessageBox.Show("Hogar solidario agregado.", "Hogar solidario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.CloseConnection();
        }
        public void UpdateHogar(int id, string name, string sub, int region, int f1, int f2, int f3, int f4, int gender, decimal infra, decimal educa, decimal health, decimal recreation, decimal feeding, decimal hygiene, decimal dressing, decimal daily, decimal direct, decimal equipment, decimal allow, decimal life, decimal admi, decimal othe, string user)
        {
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE UPDATEHOGAR " + id + ",'" + name + "','" + sub + "'," + region + "," + f1 + "," + f2 + "," + f3 + "," + f4 + "," + gender + "," + infra + "," + educa + "," + health + "," + recreation + "," + feeding + "," + hygiene + "," + dressing + "," + daily + "," + direct + "," + equipment + "," + allow + "," + life + "," + admi + "," + othe + ",'" + user + "';";
            command.ExecuteNonQuery();
            MessageBox.Show("Hogar solidario editado.", "Hogar solidario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.CloseConnection();
        }
        public void DeleteHogar(int id, string user)
        {
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE DELETEHOGAR " + id + ",'" + user + "';";
            command.ExecuteNonQuery();
            MessageBox.Show("Hogar solidario eliminado.", "Hogar solidario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.CloseConnection();
        }
        public DataTable SearchHogar(String search)
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE SearchHogar '" + search + "';";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }
    }
}
