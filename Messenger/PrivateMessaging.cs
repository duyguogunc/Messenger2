using Messenger.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messenger
{
    public partial class PrivateMessaging : Form
    {
        public PrivateMessaging()
        {
            InitializeComponent();
        }

        private void PrivateMessaging_Load(object sender, EventArgs e)
        {
            flp_Emoji.Visible = false;
        }
        private void btn_Emoji_Click(object sender, EventArgs e)
        {
            flp_Emoji.Visible = true;
           string[] emoji= Directory.GetFiles("Resources\\Emojis");
            foreach (var item in emoji)
            {
                PictureBox p = new PictureBox();
                p.ImageLocation = item;
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.Size = new Size(20, 20);
                flp_Emoji.Controls.Add(p);
            }
          
        }
    }
}
