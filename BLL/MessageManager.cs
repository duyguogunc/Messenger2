using Entity.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace BLL
{
    public class MessageManager
    {
        SqlHelper sql = new SqlHelper();

        public List<Message> GetMessage()
        {
            List<Message> messageList = new List<Message>();
            DataTable dt = sql.GetAllMessage("Select * From Messages");

            foreach (DataRow item in dt.Rows)
            {
                Message message = new Message();
                message.User = new User();
                if (message.User.IsBlocked == false)
                {
                    message.Content = item["Message"].ToString();
                    message.User.UserName = item["SenderUser"].ToString();
                    message.SendDate = (DateTime)item["Date"];
                    message.MessageId = (int)item["MessageID"];

                    messageList.Add(message);
                }
            }
            return messageList;
        }

        public void InsertMessage(Message msg)
        {
            SqlParameter p1 = new SqlParameter("Message", msg.Content);
            SqlParameter p2 = new SqlParameter("Date", msg.SendDate);
            SqlParameter p3 = new SqlParameter("SenderUser", msg.User.UserName);
            SqlParameter p4 = new SqlParameter("ReceiverUser", msg.ReciverUsers);

            sql.ExecuteProc("SendingMessage", p1, p2, p3, p4);
        }
        public void GetMessageJson()
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            string json = jss.Serialize(GetMessage());
            File.WriteAllText("messages.json", json);
        }

        public List<User> GetUsers()
        {
            List<User> userList = new List<User>();
            DataTable dt = sql.GetAllMessage("Select * From Users");
            foreach (DataRow item in dt.Rows)
            {
                User user = new User();
                user.Name = item["Name"].ToString();
                user.Surname = item["SurName"].ToString();
                user.Password = item["Password"].ToString();
                user.ImageAddress = item["ImageAdress"].ToString();
                user.IsBlocked = (bool)item["IsBlock"];
                user.Activity = (bool)item["IsActive"];

                userList.Add(user);
            }
            return userList;
        }
    }
}
