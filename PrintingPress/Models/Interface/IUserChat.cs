using System;
using System.Collections.Generic;

namespace PrintingPress.Models.Staff_mgt
{
    public interface IUserChat
    {
        string ChatID { get; set; }

        /// <summary>
        /// the message of the chat of length not more than 150 characters
        /// </summary>
        string Chat { get; set; }

        DateTime ChatDate { get; set; }

        /// <summary>
        /// the hash of the datetime of the chat for the purpose of chart deletion
        /// </summary>
        string Chathash { get; set; }

        /// <summary>
        /// the user staffid of the user
        /// </summary>
        string Userid { get; set; }

        /// <summary>
        /// username of chats
        /// </summary>
        string Username { get; set; }

        /// <summary>
        /// save the chat and the the chat id which is th last 
        /// chat id
        /// </summary>
        /// <param name="userchat"></param>
        void Save(IUserChat userchat);

        List<IUserChat> GetAllChat();

        /// <summary>
        /// loads chats that are 7 days from present day (a week chat)
        /// </summary>
        /// <returns></returns>
        List<IUserChat> LoadChat();

        List<IUserChat> LoadNewChat(string lastChatID); 
    }
}