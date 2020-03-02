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
    public class clsSubmodality
    {
        DAL.clsDAL db = new DAL.clsDAL();
        SqlCommand command = new SqlCommand();

        public DataTable EnlistSubModalities()
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE ENLISTSUBMODALITIES";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }
        public void InsertSubmodality(String submodality, int modality)
        {
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE INSERTSUBMODALITY '" + submodality + "'," +modality+ ";";
            command.ExecuteNonQuery();
            MessageBox.Show("Submodalidad agregada.", "Submodalidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.CloseConnection();
        }
        public void UpdateSubmodality(int id, String submodality, int modality)
        {
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE UPDATESUBMODALITY " + id + ", '" + submodality + "'," + modality + ";";
            command.ExecuteNonQuery();
            MessageBox.Show("Submodalidad editada.", "Submodalidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.CloseConnection();
        }
        public void DeleteSubmodality(int id)
        {
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE DELETESUBMODALITY " + id + ";";
            command.ExecuteNonQuery();
            MessageBox.Show("Submodalidad eliminada.", "Submodalidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.CloseConnection();
        }
        public DataTable SearchSubModalities(String search)
        {
            DataTable dataTable = new DataTable();
            db.OpenConnection();
            command.Connection = DAL.clsDAL.db;
            command.CommandText = "EXECUTE SEARCHSUBMODALITY '"+search+"';";
            SqlDataReader reader = command.ExecuteReader();
            dataTable.Load(reader);
            return dataTable;
            db.CloseConnection();
        }
    }
}
