namespace PrintingPress.Models.Staff_mgt
{
    internal interface IUsers
    {
        string UserID { get; set; }
        string NewPassword { get; set; }
        string Newusername { get; set; }
        string FirstQuestion { get; set; }
        string FirstAnswer { get; set; }
        string SecondQuestion { get; set; }
        string SecondAnswer { get; set; }

        /// <summary>
        /// Checks if login was succefull
        /// </summary>
        bool IsLogin { get; }

        /// <summary>
        /// If user is a active user
        /// </summary>
        bool isActive { get; }

        /// <summary>
        /// username for the new user
        /// </summary>
        string Username { get; set; }

        /// <summary>
        /// reset currently logged in user password
        /// </summary>
        /// <param name="user"></param>
        /// <param name="loggedUserID"></param>
        void ResetPassword(IUsers user, string loggedUserID);

        /// <summary>
        /// Change currently loged in username
        /// </summary>
        /// <param name="user"></param>
        /// <param name="loggedUserID"></param>
        void ResetUsername(IUsers user, string loggedUserID);

        void ForgottonPassword(IUsers user);
        void SetRecoveryQuestion(IUsers user);

        /// <summary>
        /// Recover user account
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        string RecoverAccount(string search);

        /// <summary>
        /// Login user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool Login(string username, string password);

        void ResetPassword(IUsers user);
        IUsers getUserQuestions(IUsers user);
    }
}