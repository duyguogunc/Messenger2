using BLL;
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
            rch_GidenYazi.Clear();

        }

        public void GetMessage()
        {
            flowLayoutPanel1.Controls.Clear();
            var gelen = mm.GetMessage();

            foreach (var item in gelen)
            {
                Label l = new Label();
                l.Text = item.Content;
                Label l1 = new Label();
                l1.Text = item.User.UserName;
                Label l2 = new Label();
                l2.Text = item.SendDate.ToShortTimeString();
                flowLayoutPanel1.Controls.Add(l1);
                flowLayoutPanel1.SetFlowBreak(l1,true);
                flowLayoutPanel1.Controls.Add(l);
                flowLayoutPanel1.SetFlowBreak(l, true);
                flowLayoutPanel1.Controls.Add(l2);

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

        private void lst_KisiListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            new PrivateMessaging().Show();
        }
    }
}
