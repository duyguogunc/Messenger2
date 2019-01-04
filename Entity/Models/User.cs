using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ImageAddress { get; set; }
        public bool Activity { get; set; }
        public bool IsBlocked { get; set; }
        public DateTime LastMessage { get; set; }
    }
}
