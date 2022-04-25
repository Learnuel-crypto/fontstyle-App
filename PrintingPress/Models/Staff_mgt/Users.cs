using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Modification.Models.Helper;
using ChucksMedicare.Model;
using EncryptPassword35;

namespace PrintingPress.Models.Staff_mgt
{
   internal class Users : IUsers
   {
        /// <summary>
        /// All user roles
        /// </summary>
        public static List<string> UserRoles { get; private set; }

        /// <summary>
        /// currently logged in user id
        /// </summary>
        public static string LoginUserID { get; set; }
        /// <summary>
        /// Currently pogged in user username
        /// </summary>
        public static string LoggedinUsername { get; private set; }
        /// <summary>
        /// Currently logged in user password
        /// </summary>
        public static string LoggedInPassword { get; private set; }
        /// <summary>
        /// user id
        /// </summary>
        private string userID;

        public string UserID
        {
            get { return userID; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("userid cannot be empty");
                userID = value;
            }
        }

        private string newPassword;

        public string NewPassword
        {
            get { return newPassword; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("New password cannot be empty");
                newPassword = value;
            }
        }

        private string newUsername;

        public string Newusername
        {
            get { return newUsername; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("new username cannot be empty");
                newUsername = value;
            }
        }

        private string firstQuestion;

        public string FirstQuestion
        {
            get { return firstQuestion; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Select first question");
                firstQuestion = value;
            }
        }

        private string firstAnswer;

        public string FirstAnswer
        {
            get { return firstAnswer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Enter Answer for first question");
                firstAnswer = value;
            }
        }
        private string secondQuestion;

        public string SecondQuestion
        {
            get { return secondQuestion; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Select Second question");
                secondQuestion = value;
            }
        }
        private string secondAnswer;

        public string SecondAnswer
        {
            get { return secondAnswer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Enter answer for second question");
                secondAnswer = value;
            }
        }

        /// <summary>
        /// Checks if login was succefull
        /// </summary>
        public bool IsLogin { get; private set; }
        /// <summary>
        /// If user is a active user
        /// </summary>
        public bool isActive { get; private set; }
        /// <summary>
        /// User role for the user
        /// </summary>
        public static string Role { get; private set; }
        /// <summary>
        /// the user Role ID set by the program
        /// </summary>
        public static int RoleID { get; private set; }
        /// <summary>
        /// username for the new user
        /// </summary>
        public string Username { get; set; }

        public static bool IsLoggedIn { get; set; }
        /// <summary>
        /// reset currently logged in user password
        /// </summary>
        /// <param name="user"></param>
        /// <param name="loggedUserID"></param>
        public void ResetPassword(IUsers user, string loggedUserID)
        {
            try
            {
                ISqlHelper myConHelper = Factory.CreateSqlConHelper();
                SqlCommand myconn = myConHelper.GetConnection().CreateCommand();
                var encryptPassword = SecurePassword.Encrypt(user.NewPassword);
                myconn.Parameters.AddWithValue("@userid", loggedUserID);
                myconn.Parameters.AddWithValue("@password", encryptPassword);
                myconn.CommandText = "sp_reset_password";
                myconn.CommandType = CommandType.StoredProcedure;
                myConHelper.Open();
                myconn.ExecuteNonQuery();
                myConHelper.Close();
                UserActivity.RecordActivity(string.Format("Changed password"));
                LoggedInPassword = encryptPassword;
                IsLogin = IsLoggedIn = false;

            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Change currently loged in username
        /// </summary>
        /// <param name="user"></param>
        /// <param name="loggedUserID"></param>
        public void ResetUsername(IUsers user, string loggedUserID)
        {
            try
            {
                ISqlHelper myConHelper = Factory.CreateSqlConHelper();
                SqlCommand myconn = myConHelper.GetConnection().CreateCommand();
                myconn.Parameters.AddWithValue("@username", user.Newusername);
                myconn.Parameters.AddWithValue("@userid", loggedUserID);
                myconn.CommandText = "sp_reset_username";
                myconn.CommandType = CommandType.StoredProcedure;
                myConHelper.Open();
                myconn.ExecuteNonQuery();
                myConHelper.Close();
                UserActivity.RecordActivity(string.Format("{0} Changed username to {1}", Users.LoggedinUsername, user.Newusername));
                LoggedinUsername = user.Newusername;
                IsLogin = IsLoggedIn = false;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ForgottonPassword(IUsers user)
        {
            try
            {
                ISqlHelper myConHelper = Factory.CreateSqlConHelper();
                SqlCommand myconn = myConHelper.GetConnection().CreateCommand();

                var encryptPassword = SecurePassword.Encrypt(user.NewPassword);

                myconn.Parameters.AddWithValue("@username", user.Username);
                myconn.Parameters.AddWithValue("@password", encryptPassword);
                myconn.CommandType = CommandType.StoredProcedure;
                myconn.CommandText = "sp_reset_forgotten_password";
                myconn.CommandType = CommandType.StoredProcedure;

                myConHelper.Open();
                myconn.ExecuteNonQuery();
                myConHelper.Close();
                LoggedInPassword = encryptPassword;
                IsLogin = false;
            }

            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void SetRecoveryQuestion(IUsers user)
        {
            ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();

            using (SqlConnection myconnection = mySqlHelper.GetConnection())
            {
                myconnection.Open();
                SqlCommand salesComand = myconnection.CreateCommand();
                SqlCommand saleItemsComand = myconnection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = myconnection.BeginTransaction(
                    IsolationLevel.ReadCommitted, "SampleTransaction");

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction. 
                salesComand.Connection = myconnection;
                salesComand.Transaction = transaction;
                saleItemsComand.Connection = myconnection;
                saleItemsComand.Transaction = transaction;
                try
                {
                    //insert into sales table
                    salesComand.Parameters.AddWithValue("@question", user.FirstQuestion);
                    salesComand.Parameters.AddWithValue("@answer", user.FirstAnswer);
                    salesComand.Parameters.AddWithValue("@userid", user.UserID);
                    salesComand.CommandText = "sp_set_questions";
                    salesComand.CommandType = CommandType.StoredProcedure;
                    salesComand.ExecuteNonQuery();

                    saleItemsComand.Parameters.Clear();
                    saleItemsComand.Parameters.AddWithValue("@question", user.SecondQuestion);
                    saleItemsComand.Parameters.AddWithValue("@answer", user.SecondAnswer);
                    saleItemsComand.Parameters.AddWithValue("@userid", user.UserID);
                    saleItemsComand.CommandText = "sp_set_questions";
                    saleItemsComand.CommandType = CommandType.StoredProcedure;
                    saleItemsComand.ExecuteNonQuery();
                    UserActivity.RecordActivity("Set security questions");
                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception(ex.Message + "\nOperation failed");
                }
            }
        }
        /// <summary>
        /// Recover user account
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public string RecoverAccount(string search)
        {
            try
            {
                string foundID = null;
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                using (SqlConnection myconn = mySqlHelper.GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_find_user_account", myconn);
                    cmd.Parameters.AddWithValue("@username", search);
                    cmd.Parameters.AddWithValue("@password", SecurePassword.Encrypt(search));
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);

                    if (table.Rows.Count > 0)
                    {
                        DataRow row = table.Rows[0];
                        foundID = row["UserName"].ToString();

                    }

                    return foundID;

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Login user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string username, string password)
        {
            try
            {
                ISqlHelper myConHelper = Factory.CreateSqlConHelper();
                IsLogin = IsLoggedIn = false;
                isActive = false;
                var pass = SecurePassword.Encrypt(password);
                SqlCommand cmd = new SqlCommand("sp_user_login", myConHelper.GetConnection());
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.CommandType = CommandType.StoredProcedure;
                myConHelper.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(sdr);

                if (table.Rows.Count > 0)
                {
                    DataRow row = table.Rows[0];
                    if (!string.IsNullOrEmpty(row["ID"].ToString()))
                    {
                        Users.LoginUserID = (row["UserID"].ToString());
                        LoggedinUsername = row["Username"].ToString();
                        LoggedInPassword = row["Password"].ToString();
                        isActive = bool.Parse(row["Isactive"].ToString());
                        Role = row["Role"].ToString();
                    }
                    else
                    {
                        return IsLogin;
                    }

                    //SET PRIVILEDGE
                    if (SecurePassword.Encrypt(username) != SecurePassword.Encrypt(LoggedinUsername))
                       return IsLogin = IsLoggedIn = false;
                    SetPrivilege(Role);
                    IsLogin = IsLoggedIn = true;

                }

                return IsLogin;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public void ResetPassword(IUsers user)
        {

        }
        /// <summary>
        /// Set the logged in user privilege level
        /// </summary>
        /// <param name="role"></param>
        private static void SetPrivilege(string role)
        {
            role = role.ToLower().Trim();
            if (role == "administrator")
            {
                Users.RoleID = 7;
            }
            else if (role == "manager")
            {
                Users.RoleID = 6;
            }
            else if (role == "secretary")
            {
                Users.RoleID = 5;
            }
            else if (role == "designer" || role == "operator")
            {
                Users.RoleID = 4;
            } 
            else
            {
                Users.RoleID = 0;
            }


        }
        /// <summary>
        /// Check at first run if there is a user in the database
        /// </summary>
        public static void CheckUserExistOnFirstRun()
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand cmd = new SqlCommand("sp_users_exist", mySqlHelper.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                mySqlHelper.Open();
                cmd.ExecuteNonQuery();
                mySqlHelper.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public IUsers getUserQuestions(IUsers user)
        {
            try
            {
                IUsers questions = Factory.CreateNewUser();

                ISqlHelper myConHelper = Factory.CreateSqlConHelper();
                IsLogin = false;
                isActive = false;
                SqlCommand cmd = new SqlCommand("sp_get_question_for_recovery", myConHelper.GetConnection());
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.CommandType = CommandType.StoredProcedure;
                myConHelper.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(sdr);

                if (table.Rows.Count > 0)
                {
                    DataRow row = table.Rows[0];
                    DataRow row2 = table.Rows[1];
                    if (!string.IsNullOrEmpty(row["Question"].ToString()))
                    {
                        questions.FirstQuestion = row["Question"].ToString();
                        questions.FirstAnswer = row["Answer"].ToString();

                        questions.SecondQuestion = row2["Question"].ToString();
                        questions.SecondAnswer = row2["Answer"].ToString();
                    }
                }

                return questions;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
