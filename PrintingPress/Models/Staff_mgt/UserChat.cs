using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApplication1.Modification.Models.Helper;

namespace PrintingPress.Models.Staff_mgt
{
    public class UserChat : IUserChat
    {
        public string ChatID { get; set; }
        /// <summary>
        /// the message of the chat of length not more than 150 characters
        /// </summary>
        public string Chat { get; set; }
        public DateTime ChatDate { get; set; }
        /// <summary>
        /// the hash of the datetime of the chat for the purpose of chart deletion
        /// </summary>
        public string Chathash { get; set; }
        /// <summary>
        /// the user staffid of the user
        /// </summary>
        public string Userid { get; set; }
        /// <summary>
        /// indicate the total number of message
        /// </summary>
        public static int newMessageCount = 0;
        public static int LastChatid = 0;
        /// <summary>
        /// username of chats
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// save the chat and the the chat id which is th last 
        /// chat id
        /// </summary>
        /// <param name="userchat"></param>

        public void Save(IUserChat userchat)
        {
            //ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
            using (SqlConnection myconnection = Factory.CreateSqlConHelper().GetConnection())
            {
                myconnection.Open();

                SqlCommand InvoiceComand = myconnection.CreateCommand();
                SqlCommand JobItemsComand = myconnection.CreateCommand();
                SqlCommand customerComand = myconnection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = myconnection.BeginTransaction(
                    IsolationLevel.ReadCommitted, "SampleTransaction");

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction. 
                InvoiceComand.Connection = myconnection;
                InvoiceComand.Transaction = transaction;

                JobItemsComand.Connection = myconnection;
                JobItemsComand.Transaction = transaction;

                customerComand.Connection = myconnection;
                customerComand.Transaction = transaction;

                try
                {
                    //add customer 


                    //insert into sales table
                    InvoiceComand.Parameters.AddWithValue("@chat", userchat.Chat);
                    InvoiceComand.Parameters.AddWithValue("@chatdate", userchat.ChatDate);
                    InvoiceComand.Parameters.AddWithValue("@chathash", userchat.Chathash);
                    InvoiceComand.Parameters.AddWithValue("@userid", userchat.Userid);
                    InvoiceComand.CommandText = "sp_save_chat";
                    InvoiceComand.CommandType = CommandType.StoredProcedure;
                    InvoiceComand.ExecuteNonQuery();
                    InvoiceComand.CommandType = CommandType.StoredProcedure;
                    InvoiceComand.ExecuteNonQuery();

                    JobItemsComand.CommandText = "sp_get_last_chat_id";
                    JobItemsComand.Parameters.AddWithValue("@username", userchat.Username);
                    JobItemsComand.CommandType = CommandType.StoredProcedure;
                   // transaction.Commit(); // save the operation to database if no error occurs
                    //else everything is returned to how it was before the operation started
                    SqlDataReader sdr = JobItemsComand.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);

                    if (table.Rows.Count > 0)
                    {
                        DataRow row = table.Rows[0];
                        LastChatid = Convert.ToInt32(row["ChatID"].ToString());

                    } 
                    transaction.Commit();
                    
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception(ex.Message + "\nTransaction failed");
                }
            }
        }
         
        public static int GetLastChatid()
        {
            int newChatid = 0;

            using (SqlConnection myconnection = Factory.CreateSqlConHelper().GetConnection())
            {
                myconnection.Open();

                SqlCommand InvoiceComand = myconnection.CreateCommand();
                SqlCommand JobItemsComand = myconnection.CreateCommand();
                SqlCommand customerComand = myconnection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = myconnection.BeginTransaction(
                    IsolationLevel.ReadCommitted, "SampleTransaction");

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction. 
                InvoiceComand.Connection = myconnection;
                InvoiceComand.Transaction = transaction;

                JobItemsComand.Connection = myconnection;
                JobItemsComand.Transaction = transaction;

                customerComand.Connection = myconnection;
                customerComand.Transaction = transaction;

                try
                {
                    //add customer 

                    InvoiceComand.CommandText = "sp_get_last_chat_id";
                    InvoiceComand.Parameters.AddWithValue("@username", Users.LoggedinUsername);
                    InvoiceComand.CommandType = CommandType.StoredProcedure; 
                    SqlDataReader sdr = InvoiceComand.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);

                    if (table.Rows.Count > 0)
                    {
                        DataRow row = table.Rows[0];
                        if (!string.IsNullOrEmpty(row["ChatID"].ToString()))
                            newChatid = Convert.ToInt32(row["ChatID"].ToString());

                    } 

                transaction.Commit();
                    return newChatid;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception(ex.Message + "\nTransaction failed");
                }
            }
             
 
        }
        public List<IUserChat> GetAllChat()
        {
            try
            {
                List<IUserChat> Chats = new List<IUserChat>();
                ISqlHelper connection = Factory.CreateSqlConHelper();
                using (SqlConnection con = connection.GetConnection())
                {
                    SqlCommand myComand = con.CreateCommand();
                    myComand.Connection = con;
                    myComand.Parameters.Clear();
                    myComand.CommandText = "sp_get_all_chats";
                    myComand.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = myComand.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);
                    con.Close();
                    newMessageCount = table.Rows.Count;
                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            IUserChat newChat = Factory.CreateChat();

                            newChat.Chat = row["Chat"].ToString();
                           newChat.ChatDate =Convert.ToDateTime( row["Date"]) ;
                            newChat.Chathash = row["Chathash"].ToString();
                            newChat.Username = row["Username"].ToString();
                            newChat.ChatID = row["Chatid"].ToString();
                            Chats.Add(newChat);
                        }
                    }
                    return Chats;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// loads chats that are 7 days from present day (a week chat)
        /// </summary>
        /// <returns></returns>
        public List<IUserChat> LoadChat()
        {
            try
            {
                List<IUserChat> Chats = new List<IUserChat>();
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                using (SqlConnection con = mySqlHelper.GetConnection())
                {
                    SqlCommand myComand = con.CreateCommand();
                    myComand.Connection = con;
                    myComand.Parameters.Clear();
                    myComand.CommandText = "sp_get_a_week_chats";
                    myComand.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = myComand.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);
                    con.Close();  
                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            IUserChat newChat = Factory.CreateChat();

                            newChat.Chat = row["Chat"].ToString();
                            newChat.ChatDate = Convert.ToDateTime(row["Date"]);
                            newChat.Chathash = row["Chathash"].ToString();
                            newChat.Username = row["Username"].ToString();
                            newChat.ChatID = row["ChatID"].ToString(); 
                            newChat.Userid = row["UserID"].ToString(); 
                            LastChatid = Convert.ToInt32(newChat.ChatID);

                            Chats.Add(newChat);
                        }
                    }

                    return Chats;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<IUserChat> LoadNewChat(string lastChatID)
        {
            try
            {
                List<IUserChat> Chats = new List<IUserChat>();
                ISqlHelper connection = Factory.CreateSqlConHelper();
                using (SqlConnection con = connection.GetConnection())
                {
                    SqlCommand myComand = con.CreateCommand();
                    myComand.Connection = con;
                    myComand.Parameters.Clear();
                    myComand.Parameters.AddWithValue("@chatid", lastChatID);
                    myComand.CommandText = "sp_get_new_chats";
                    myComand.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader sdr = myComand.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);
                    con.Close();
                    newMessageCount = table.Rows.Count;
                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            IUserChat newChat = Factory.CreateChat();

                            newChat.Chat = row["Chat"].ToString();
                           newChat.ChatDate =Convert.ToDateTime( row["date"]);
                            newChat.Chathash = row["Chathash"].ToString();
                            newChat.Username = row["Username"].ToString();
                            LastChatid = Convert.ToInt32(row["ChatID"].ToString());
                            newChat.Userid = row["UserID"].ToString();
                            Chats.Add(newChat);
                        }
                    }
                    return Chats;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
