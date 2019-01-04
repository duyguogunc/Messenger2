using Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserManage
    {
        public void SıgnUp(User newUser)
        {
            SqlParameter p1 = new SqlParameter("UserName", newUser.UserName);
            SqlParameter p2 = new SqlParameter("Name", newUser.Name);
            SqlParameter p3 = new SqlParameter("SurName", newUser.Surname);
            SqlParameter p4 = new SqlParameter("Password", newUser.Password);

        }
    }
}
