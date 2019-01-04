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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.UserName = txt_KullaniciAdi.Text;
            u.Password = txt_sifre.Text;
            UserManage us = new UserManage();
            us.SignIn(u);
            new Form1().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new KayitOl().Show();
        }

        private void iNGİLİZCEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
