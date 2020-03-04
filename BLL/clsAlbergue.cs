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
    }
}
