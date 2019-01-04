﻿using BLL;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Entity.Models.Message m = new Entity.Models.Message();
        MessageManager mm = new MessageManager();

        private void btn_Gonder_Click(object sender, EventArgs e)
        {

            m.Content = rch_GidenYazi.Text;
            m.User = Program.User;
            mm.InsertMessage(m);



        }
        public void GetMessage()
        {
            flowLayoutPanel1.Controls.Clear();
            var gelen = mm.GetMessage();

            foreach (var item in gelen)
            {
                Label l = new Label();
                l.Text = item.Content;
                flowLayoutPanel1.Controls.Add(l);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetMessage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BLL.UserManage BLL = new BLL.UserManage();
            lst_KisiListesi.DisplayMember = "Name";
            lst_KisiListesi.ValueMember = "UserName";
            lst_KisiListesi.DataSource = BLL.ActiveUsers();
        }
    }
}
