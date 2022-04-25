using System;
using System.Collections.Generic;
using System.Data;

namespace PrintingPress.Models.Staff_mgt
{
    public interface IUserChats
    {
        string ID { get; set; }
        string Chat { get; set; }
        string ChatDate { get; set; }
        string Hash { get; set; }
        string Username { get; set; }
        string Receiver { get; set; }
        string staffID { get; set; }
        int Seen { get; set; }
        void Save(IUserChats userchat);

        /// <summary>
        /// loads chats that are 7 days from present day (a week chat)
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        List<IUserChats> LoadChat(string username);

        /// <summary>
        /// Get all the chat
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        List<IUserChats> LoadAllChat(string username);

        /// <summary>
        /// Load the new chat
        /// NOT IN USER
        /// </summary>
        /// <param name="lastChatID"></param>
        /// <returns></returns>
        List<IUserChats> LoadNewChat(string lastChatID);

        /// <summary>
        /// All the last chat for a user from other users
        /// </summary>
        /// <returns></returns>
        List<IUserChats> GetLastChats(string username);

        /// <summary>
        /// Get the last chat by this user
        /// </summary>
        /// <param name="username">the sender user name</param>
        /// <returns></returns>
        DataTable GetSenderLastChats(string username);

        /// <summary>
        /// Format the date to MM/dd/yyyy with timestamp
        /// </summary>
        /// <param name="chatDateTime">current datetime</param>
        /// <returns></returns>
        string ToDateTime(DateTime chatDateTime);

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>

        /// <summary>
        /// Read the chat sent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="receiver"></param>
        void ReadChat(string sender, string receiver);

        /// <summary>
        /// Get all users that are active with the passport
        /// </summary>
        /// <returns></returns>
        List<IUserChats> GetAllUsers();

        /// <summary>
        /// Get new chat sent to the user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="receiver"></param>
        /// <returns></returns>
        List<IUserChats> GetNewChat(string username, string receiver);

        /// <summary>
        /// Get the number of new chat for this user
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        int GetTotalNewChat(string username);
    }
}