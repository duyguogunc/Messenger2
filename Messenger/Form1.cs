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

        private void btn_Gonder_Click(object sender, EventArgs e)
        {
            Entity.Models.Message m = new Entity.Models.Message();
            MessageManager mm = new MessageManager();
            m.Content = rch_GidenYazi.Text;
            m.User = Program.User;
            mm.InsertMessage(m);

            
            
        }

        private void rch_GelenYazi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
