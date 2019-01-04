using BLL;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messenger
{
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        private void btn_kaydol_Click(object sender, EventArgs e)
        {
            User u = new User();
            UserManage us = new UserManage();
            u.Name = txt_Ad.Text;
            u.Surname = txt_soyad.Text;
            u.Password = txt_sifre.Text; 
            us.SignUp(u);
            
        }
    }
}
