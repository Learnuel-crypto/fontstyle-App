using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintingPress.API.Messenger
{
    public partial class ChatNotifyFrm : Form
    {
        private int timeCount = 0;
        private int increaseValue = 0;
        public static int NotifyCount = 0;
        public ChatNotifyFrm()
        {
            InitializeComponent();
            NotifyCount++;

        }
        public ChatNotifyFrm(string message, string caption, int seconds, int positionIncreaseValue = 0)
        {
            
            InitializeComponent();
            lblMessage.Text = message;
            if (!string.IsNullOrEmpty(caption))
                caption = caption.Length > 30 ? caption = caption.Substring(0, 28) + ".." : caption;
            lblCaption.Text = string.IsNullOrEmpty(caption) ? "" : caption;
            timeCount = seconds;
            NotifyTimer.Start();
            increaseValue = increaseValue + positionIncreaseValue;
            NotifyCount++;
        }
        
        protected override void OnLoad(EventArgs e)
        {
            var screen = Screen.FromPoint(this.Location);
            this.Location = new Point(screen.WorkingArea.Right - this.Width, screen.WorkingArea.Bottom - increaseValue - this.Height);
            base.OnLoad(e);
             
        }

        private void NotifyTimer_Tick(object sender, EventArgs e)
        {
            timeCount--;
            if (timeCount == 0)
            {
                this.Close();
                this.Dispose();
                NotifyTimer.Stop();
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void ChatNotifyFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            NotifyCount--;
        }
    }
}
