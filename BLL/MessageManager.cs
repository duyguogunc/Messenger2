using Entity.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MessageManager
    {
        SqlHelper sql = new SqlHelper();

        public List<Message> GetMessage()
        {
            List<Message> messageList = new List<Message>();
            DataTable dt = sql.GetAllMessage();
            foreach (DataRow item in dt.Rows)
            {
                Message message = new Message();
                message.Content = item["Message"].ToString();
                message.User.UserName = item["SenderUser"].ToString();
                message.SendDate = (DateTime)item["Date"];
                message.MessageId = (int)item["MessageID"];

                messageList.Add(message);
            }
            return messageList;
        }

        public void InsertMessage(Message msg)
        {

        }
    }
}
