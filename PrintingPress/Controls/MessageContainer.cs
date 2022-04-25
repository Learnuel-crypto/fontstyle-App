using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrintingPress.API.Messenger;

namespace PrintingPress.Controls
{
    public partial class MessageContainer : UserControl
    {
        public MessageContainer()
        {
            InitializeComponent();
        }
        public MessageContainer(string username,string message,Color backColor)
        {
            InitializeComponent();
            this.lblUsername.Text = username; 
            this.lblMessage.Text = message;
            this.BackColor =(Color)backColor;
            
        }
        private void MessageContainer_Load(object sender, EventArgs e)
        {

        }

        private void lblMessage_DoubleClick(object sender, EventArgs e)
        {
           ChatBoxFrm.selectChat= lblMessage.Text;
        }
    }
}
