using System.Data;

namespace ChucksMedicare.Model.Staff_mgt
{
    internal interface IStaffs
    {
        string Username { get; set; }
        string Password { get; set; }
        string Role { get; set; }
        int IsActive { get; set; }
        string ID { get; set; }
        string Name { get; set; }
        string Contact { get; set; }

        /// <summary>
        /// Update the user account details
        /// </summary>
        void UpdateAccount();

        /// <summary>
        /// Get staff and search through it
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        DataTable GetStaff(string search);

        /// <summary>
        /// Delete staff from database
        /// </summary>
        /// <param name="userid"></param>
        void Delete(string userid);

        /// <summary>
        /// Get user account details
        /// </summary>
        /// <param name="userID">staff id of the user</param>
        /// <returns></returns>
        DataTable GetUserDetails(string userID);

        /// <summary>
        /// Create user account for staff
        /// </summary>
        /// <param name="userid"></param>
        void CreateAccount(string userid);

        /// <summary>
        /// Update user account role and status
        /// </summary>
        /// <param name="userid"></param>
        void UpdateUserAccount(string userid);

        /// <summary>
        /// Delete user account
        /// </summary>
        /// <param name="userid"></param>
        void DeleteUserAccount(string userid);

        void AddWithAccount(bool firstRun);
    }
}