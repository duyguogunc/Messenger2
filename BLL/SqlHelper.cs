using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Models;
using System.Data;
namespace BLL
{
    public class SqlHelper
    {
        public string connetionString { get; set; }
        public SqlConnection conn { get; set; }

        public SqlHelper()
        {
            connetionString =
                @"Data Source =185.23.75.48,8081\SQLEXPRESS;
                Initial Catalog=MessengerDB;
                User ID=wissen302;
                Password=123456";
            conn = new SqlConnection(connetionString);
        }
        public void ExecuteProc (string proc,params SqlParameter [] p1)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            cmd.Parameters.AddRange(p1);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
         }
        public void ExecuteCommand(string query)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }
        public DataTable GetAllMessage(string proc)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(proc,conn);
            adp.Fill(dt);
            return dt;
        }
      
       
    }
}
