using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace oneStore
{
    class databaseclass
    {

        SqlConnection sql_con;
        SqlCommand sql_comm;
        SqlDataAdapter sql_ada;
        

        public databaseclass()
        {
            sql_con = new SqlConnection(Properties.Settings.Default.connectionString);
        }
        public void connectionOpen()
        {
            sql_con.Open();
        }
        public void connectionClose()
        {
            sql_con.Close();
        }
        public void login_logout_record(string a)
        {
            connectionOpen();
            sql_comm = new SqlCommand(a, sql_con);
            sql_comm.ExecuteNonQuery();
            connectionClose();

        }
        public DataTable database_record(string a)
        {
            connectionOpen();
            sql_ada = new SqlDataAdapter(a, sql_con);
            DataTable dt = new DataTable();
            sql_ada.Fill(dt);
            connectionClose();

            return dt;
        }
        public void  Insert_datadatabase_record(string a)
        {
            connectionOpen();
            sql_comm = new SqlCommand(a, sql_con);
            sql_comm.ExecuteNonQuery();
            connectionClose();
        }
        public void sells_record(string a)
        {
            connectionOpen();
            sql_comm = new SqlCommand(a, sql_con);
            sql_comm.ExecuteNonQuery();
            connectionClose();
        }
        public DataTable getprofiledata(string a)
        {
            connectionOpen();
            sql_ada = new SqlDataAdapter(a, sql_con);
            DataTable dt = new DataTable();
            sql_ada.Fill(dt);
            connectionClose();

            return dt;
        }
    }
}
