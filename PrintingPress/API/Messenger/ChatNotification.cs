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
    public partial class ChatNotification : Form
    {

        private int objectCount;
        public enum enmAction
        {
         wait,
            start,
            close
        }
        public ChatNotification()
        {
            InitializeComponent();
            if(this!=null)
                objectCount += 1;
        }
        private int x, y;
        private ChatNotification.enmAction action;

    public void showAlert(string msg)
    {
        this.Opacity = 0.0;
        this.StartPosition = FormStartPosition.Manual;

        string fname;
        for (int i = 1; i < 10; i++)
        {
            fname = "alert" + i.ToString();
            ChatNotification frm = (ChatNotification)Application.OpenForms[fname];
            if (frm == null)
            {
                this.Name = fname;
                this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * 1;
                this.Location = new Point(this.x, this.y);
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            lblMsg.Text = msg;
            this.Show();
            this.action = enmAction.start;
            timerWait.Interval = 1;
            timerWait.Start();
        }

    }

    private void btnClose_Click(object sender, EventArgs e)
    {
       
    }

        private void picIcon_Click(object sender, EventArgs e)
        {

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            timerWait.Interval = 1;
            action = enmAction.close;
        }

        private void timerWait_Tick(object sender, EventArgs e)
    {
        switch (this.action)
        {
            case enmAction.wait:
                timerWait.Interval = 5000;
                action = enmAction.close;
                break;
            case enmAction.start:
                timerWait.Interval = 1;
                this.Opacity += 0.1;
                if (this.x < this.Location.X)
                {
                    this.Left--;
                }
                else
                {
                    if (this.Opacity ==1.0)
                    {
                        action = enmAction.wait;
                    }
                }
                break;

            case enmAction.close:
                timerWait.Interval = 1;
                this.Opacity -= 0.1;
                this.Left -= 3;
                if (base.Opacity == 0.0)
                {
                    base.Close();
                }
                break;
        }
    }

}
    }
