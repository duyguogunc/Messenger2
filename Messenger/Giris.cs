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
            if (us.SignIn(u)==true)
            {
                Program.User = u;
                new Form1().Show();
            }
            else
            {
                MessageBox.Show("Bilgilerinizi kontrol ediniz.");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new KayitOl().Show();
        }

        private void INGILIZCEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LanguageChoose.ChangedLanguage(Language.en);
            this.Controls.Clear();
            InitializeComponent();
        }

        private void tÜRKÇEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LanguageChoose.ChangedLanguage(Language.tr);
            this.Controls.Clear();
            InitializeComponent();
        }

        private void aLMANCAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LanguageChoose.ChangedLanguage(Language.de);
            this.Controls.Clear();
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Blockcs().Show();
        }
    }
}
