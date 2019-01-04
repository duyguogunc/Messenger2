using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public DateTime SendDate { get; set; }
        public string Content { get; set; }
        public User User { get; set; }
        public List<User> ReciverUsers { get; set; }
        public Message()
        {
            SendDate = DateTime.Today;
        }

    }
}
