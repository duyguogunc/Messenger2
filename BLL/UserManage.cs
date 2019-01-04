using Entity.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserManage
    {
        SqlHelper sqlHelper = new SqlHelper();
        public bool SignUp(User newUser)
        {
            SqlParameter p1 = new SqlParameter("UserName", newUser.UserName);
            SqlParameter p2 = new SqlParameter("Name", newUser.Name);
            SqlParameter p3 = new SqlParameter("SurName", newUser.Surname);
            SqlParameter p4 = new SqlParameter("Password", newUser.Password);
            return sqlHelper.StateProc("UserSignUp", p1, p2, p3, p4);
        }

        public bool SignIn(User user)
        {
            SqlParameter p1 = new SqlParameter("UserName", user.UserName);
            SqlParameter p2 = new SqlParameter("Password", user.Password);
            return sqlHelper.StateProc("SignIn", p1, p2);

        }
        public void SignOut(User user)
        {
            SqlParameter p1 = new SqlParameter("UserName", user.UserName);
            SqlParameter p2 = new SqlParameter("Password", user.Password);
            sqlHelper.ExecuteProc("SignOut", p1, p2);
        }

        public List<User> ActiveUsers()
        {
            List<User> list = new List<User>();
            DataTable dt = sqlHelper.GetAllMessage("SELECT * FROM Users WHERE IsActive = 1");
            foreach (DataRow item in dt.Rows)
            {
                User user = new User();
                user.UserName = item["UserName"].ToString();
                user.Name = item["Name"].ToString();
                user.Activity = (bool)item["IsActive"];
                list.Add(user);
            }
            return list;
        }
    }
}
