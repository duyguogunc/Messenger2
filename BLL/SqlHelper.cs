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
        public string ConnetionString { get; set; }
        public SqlConnection Conn { get; set; }

        public SqlHelper()
        {
            ConnetionString =
                @"Data Source =185.23.75.48,8081\SQLEXPRESS;
                Initial Catalog=MessengerDB;
                User ID=wissen302;
                Password=123456";
            Conn = new SqlConnection(ConnetionString);
        }
        public void ExecuteProc (string proc,params SqlParameter [] p1)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = proc;
            cmd.Connection = Conn;
            cmd.Parameters.AddRange(p1);
            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();
         }
        public void ExecuteCommand(string query)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = Conn;
            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();
            Conn.Dispose();
        }
        public DataTable GetAllMessage(string proc)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(proc,Conn);
            adp.Fill(dt);
            return dt;
        }
      
       
    }
}
