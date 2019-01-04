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
using Entity.Models;

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
                ShowMessage(item);

        }

        private void ShowMessage(Entity.Models.Message item)
        {
            Label l_msg = new Label();
            l_msg.Text = item.Content;

            Label l_username = new Label();
            l_username.Text = item.User.UserName;
            l_username.Font = new Font(FontFamily.GenericMonospace, 12, FontStyle.Bold);

            Label l_time = new Label();
            l_time.Text = item.SendDate.ToShortTimeString();

            flowLayoutPanel1.Controls.Add(l_username);
            flowLayoutPanel1.Controls.Add(l_time);
            flowLayoutPanel1.SetFlowBreak(l_time, true);
            flowLayoutPanel1.Controls.Add(l_msg);
            flowLayoutPanel1.SetFlowBreak(l_msg, true);
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
            if (lst_KisiListesi.SelectedItem != null) {
                PrivateMessaging pform = new PrivateMessaging();
                var kisi = ((User)lst_KisiListesi.SelectedItem);
                pform.Text = kisi.Name + " " + kisi.Surname + " (" + kisi.UserName + ")";
            }
        }
    }
}
