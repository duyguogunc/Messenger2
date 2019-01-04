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

namespace BLL
{
    public partial class Blockcs : Form
    {
        MessageManager msgmanager = new MessageManager();
        public Blockcs()
        {
            InitializeComponent();
        }
        
        private void Blockcs_Load(object sender, EventArgs e)
        {
            listBoxBlock.DataSource = msgmanager.GetUsers();
        }
    }
}
