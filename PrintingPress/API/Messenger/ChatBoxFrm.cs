using PrintingPress.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;
using ChucksMedicare.Model;
using EncryptPassword35;
using PrintingPress.Models.Staff_mgt;
using System.Collections.Generic;
using WindowsFormsApplication1.Modification.Models.Helper;

namespace PrintingPress.API.Messenger
{
    public partial class ChatBoxFrm : Form
    {
        private ChatNotifyFrm notify;
        public static string selectChat;
        private int increasePostion = 0;
        private ISqlHelper chatSqlHelper = Factory.CreateChatSqlCoHelpter();
        private IUserChat userChat = Factory.CreateChat();
        private Queue<List<IUserChat>> chatQueue = new Queue<List<IUserChat>>();
        public ChatBoxFrm()
        {
            InitializeComponent(); 
            copyTimer.Start();
        }
        
       
        void ScrolChat()
        {
            int change = flpChats.VerticalScroll.Value + flpChats.VerticalScroll.SmallChange * 30;
            flpChats.AutoScrollPosition = new Point(0, change);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtMessage.Text))
            {
                userChat.Chat = txtMessage.Text.Trim();
                userChat.ChatDate = DateTime.Now;
                userChat.Userid = Users.LoginUserID;
                userChat.Username = Users.LoggedinUsername;
                userChat.Chathash = SecurePassword.Encrypt(userChat.ChatDate.ToString() );
                userChat.Save(userChat);
                flpChats.Controls.Add(new ucDateTime(userChat.ChatDate.ToString()));
                flpChats.Controls.Add(new MessageContainer(Users.LoggedinUsername , userChat.Chat, Color.Gold));
                  
                if (flpChats.VerticalScroll.Visible)
                    ScrolChat();
            }
                  
                if (ChatNotifyFrm.NotifyCount <= 4)
                {
                    notify = new ChatNotifyFrm(txtMessage.Text, "Notification", 300, increasePostion);
                    notify.Show();
                    increasePostion += 115;
                }
                else { 

                increasePostion = 0;
                } 
            txtMessage.Clear();
            txtMessage.Focus();

            
        }

        private void copyTimer_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectChat))
            {
                txtMessage.Text =string.Format("{0} {1}", txtMessage.Text, selectChat);
                 selectChat="" ;
            }
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char) Keys.Enter)
            {
                btnSend.PerformClick();
            }
        }

        private void ChatBoxFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //log user as shutdown
            if (Users.RoleID == 7 || Users.RoleID == 6 || Users.RoleID == 5)
            {
               
            }
            else
            {
                UserActivity.RecordActivity("Shutdown Application");
                Application.Exit();
            }
             
           

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Logged out user
            UserActivity.RecordActivity("Logged out");
            var login = new LoginFrm();
            login.Show();
            this.Hide();
        }

        private void ChatBoxFrm_Load(object sender, EventArgs e)
        {
            try { 
            if (Users.RoleID == 7 || Users.RoleID == 6 || Users.RoleID == 5)
            {
                btnLogout.Visible = false;
            }

           
            //load chats
            var weekChat = userChat.LoadChat();
            foreach (var chat in weekChat)
            {
                if (chat.Userid == Users.LoginUserID)
                {
                    flpChats.Controls.Add(new ucDateTime(chat.ChatDate.ToString()));
                    flpChats.Controls.Add(new MessageContainer(Users.LoggedinUsername, chat.Chat, Color.Gold));
                }
                else
                {
                    flpChats.Controls.Add(new ucDateTime(chat.ChatDate.ToString()));
                    flpChats.Controls.Add(new MessageContainer(chat.Username, chat.Chat, Color.Cornsilk));

                        //notification
                       
                            

                        
                }
                if (flpChats.VerticalScroll.Visible)
                    ScrolChat();
                UserChat.LastChatid =Int32.Parse( chat.ChatID);
            }
            ChatUpdater.Start();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void LoadNew(List<IUserChat> newchat)
        {
            var x = 0;
            foreach (var chat in newchat)
            {
                if (chat.Userid == Users.LoginUserID)
                {
                    flpChats.Controls.Add(new ucDateTime(chat.ChatDate.ToString()));
                    flpChats.Controls.Add(new MessageContainer(Users.LoggedinUsername, chat.Chat, Color.Gold));
                }
                else
                {
                    flpChats.Controls.Add(new ucDateTime(chat.ChatDate.ToString()));
                    flpChats.Controls.Add(new MessageContainer(chat.Username, chat.Chat, Color.Cornsilk));

                    var notify = new ChatNotifyFrm(chat.Chat, chat.Username, 10000, 0);
                    this.notify.Show();
                    x++;
                    increasePostion += 115;
                    if (x <= 4)
                    {
                        increasePostion = 0;
                    }
                }
                if (flpChats.VerticalScroll.Visible)
                    ScrolChat();
                UserChat.LastChatid = Int32.Parse(chat.ChatID);
            }
        }
        private void ChatUpdater_Tick(object sender, EventArgs e)
        {
            try
            {
                int x = UserChat.GetLastChatid();
                if (UserChat.LastChatid < x)
                { 
                    LoadNew(userChat.LoadNewChat(x.ToString()));
                }
            }
        
        catch (Exception ex)
        {
                ChatUpdater.Stop();
            MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
}

        private void waitTimer_Tick(object sender, EventArgs e)
        {
            ChatUpdater.Start();
        }
    }
}
