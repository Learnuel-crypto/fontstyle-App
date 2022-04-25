using EncryptPassword35;
using System;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApplication1.Modification.Models.Helper;
using PrintingPress;

namespace ChucksMedicare.Model.Staff_mgt
{
    class Staffs : IStaffs
     {
       
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int IsActive { get; set; }
        private string name;
        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }


        public string Name
        {
            get { return name; }
            set
            {
                
                name = value;
            }
        }

        private string contact;
        private SqlDataAdapter da;
        private DataTable _table;

        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        //public   void DeleteDocument()
        //{
        //    try
        //    {
        //        ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
        //        SqlCommand myCommand = mySqlHelper.GetConnection().CreateCommand();
        //        myCommand.Parameters.Clear();
        //        myCommand.Parameters.AddWithValue("@documentid", DocumentID); 
        //        myCommand.CommandText = "sp_delete_document";
        //        myCommand.CommandType = CommandType.StoredProcedure;
        //        mySqlHelper.Open();
        //        myCommand.ExecuteNonQuery();
        //        mySqlHelper.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        /// <summary>
        /// sava document for staff
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="filename"></param>
        /// <param name="ID"></param>
        //public   void SaveDocument(string filepath, string filename, string ID)
        //{
        //    try
        //    {
        //        using (FileStream stream = File.OpenRead(filepath))
        //        {
        //            byte[] buffer = new byte[stream.Length];
        //            stream.Read(buffer, 0, buffer.Length);
        //            string extn = new FileInfo(filepath).Extension;
        //            string name = filename;
        //            ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
        //            SqlCommand myCommand = mySqlHelper.GetConnection().CreateCommand();
        //            myCommand.Parameters.Clear();
        //            myCommand.Parameters.AddWithValue("@document", SqlDbType.VarBinary).Value = buffer;
        //            myCommand.Parameters.AddWithValue("@extension", SqlDbType.Char).Value = extn;
        //            myCommand.Parameters.AddWithValue("@filename", SqlDbType.VarChar).Value = name;
        //            myCommand.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = ID;
        //            myCommand.CommandText = "sp_save_file";
        //            myCommand.CommandType = CommandType.StoredProcedure;
        //            mySqlHelper.Open();
        //            myCommand.ExecuteNonQuery();
        //            mySqlHelper.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //} 
        //public   void UpdateDocument()
        //{
        //    try
        //    {
        //        ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
        //        SqlCommand myCommand = mySqlHelper.GetConnection().CreateCommand();
        //        myCommand.Parameters.Clear();
        //        myCommand.Parameters.AddWithValue("@documentid", DocumentID);
        //        myCommand.Parameters.AddWithValue("@name", Title);
        //        myCommand.CommandText = "sp_update_staff_document";
        //        myCommand.CommandType = CommandType.StoredProcedure;
        //        mySqlHelper.Open();
        //        myCommand.ExecuteNonQuery();
        //        mySqlHelper.Close();
        //        UserActivity.RecordActivity(string.Format("Updated a document for Staff {0}", ID));
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        /// <summary>
        /// Create new staff
        /// </summary>
        protected  internal void Add()
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myCommand = mySqlHelper.GetConnection().CreateCommand();
                myCommand.Parameters.Clear();
                myCommand.Parameters.AddWithValue("@names", Name);
                myCommand.Parameters.AddWithValue("@contact", Contact);
                //myCommand.Parameters.AddWithValue("@email", Email);
                //myCommand.Parameters.AddWithValue("@address", Address);
                //myCommand.Parameters.AddWithValue("@dob", DateOfBirth);
                //myCommand.Parameters.AddWithValue("@empdate", EmpDate);
                //myCommand.Parameters.AddWithValue("@department", Department);
                //myCommand.Parameters.AddWithValue("@passport", Passport);
                //myCommand.Parameters.AddWithValue("@gender", Gender);
                //myCommand.Parameters.AddWithValue("@salary", Salary);
               
                myCommand.CommandText = "sp_add_staff";
                myCommand.CommandType = CommandType.StoredProcedure;
                 mySqlHelper.Open();
                myCommand.ExecuteNonQuery();
                mySqlHelper.Close();
                UserActivity.RecordActivity("Registered a staff with Account");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Create new staff and user account
        /// </summary>

         public void AddWithAccount(bool firstRun)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myCommand = mySqlHelper.GetConnection().CreateCommand();
                myCommand.Parameters.Clear();
                myCommand.Parameters.AddWithValue("@names", Name);
                myCommand.Parameters.AddWithValue("@contact", Contact); 
                myCommand.Parameters.AddWithValue("@username", Username);
                myCommand.Parameters.AddWithValue("@password", SecurePassword.Encrypt(Password));
                myCommand.Parameters.AddWithValue("@role", Role); 
                myCommand.Parameters.AddWithValue("@isactive", IsActive);

                myCommand.CommandText = "sp_add_staff_with_account";
                myCommand.CommandType = CommandType.StoredProcedure;
                mySqlHelper.Open();
                myCommand.ExecuteNonQuery();
                mySqlHelper.Close();
                if (!firstRun)
                    UserActivity.RecordActivity("Registered a staff with Account");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Update the staff details
        /// </summary>
        //public void UpdateDetails()
        //{
        //    try
        //    {
        //        ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
        //        SqlCommand myCommand = mySqlHelper.GetConnection().CreateCommand();
        //        myCommand.Parameters.Clear();
        //        myCommand.Parameters.AddWithValue("@staffid", ID);
        //        myCommand.Parameters.AddWithValue("@names", Name);
        //        myCommand.Parameters.AddWithValue("@contact", Contact);
        //        myCommand.Parameters.AddWithValue("@email", Email);
        //        myCommand.Parameters.AddWithValue("@address", Address);
        //        myCommand.Parameters.AddWithValue("@dob", DateOfBirth);
        //        myCommand.Parameters.AddWithValue("@empdate", EmpDate);
        //        myCommand.Parameters.AddWithValue("@department", Department);
        //        myCommand.Parameters.AddWithValue("@passport", Passport);
        //        myCommand.Parameters.AddWithValue("@gender", Gender); 
        //        myCommand.Parameters.AddWithValue("@salary", Salary);  
        //        myCommand.CommandText = "sp_update_staff";
        //        myCommand.CommandType = CommandType.StoredProcedure;
        //        mySqlHelper.Open();
        //        myCommand.ExecuteNonQuery();
        //        mySqlHelper.Close();
        //        UserActivity.RecordActivity(string.Format("Updated staff: {0} details",ID));

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        /// <summary>
        /// Update the user account details
        /// </summary>
        public void UpdateAccount()
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myCommand = mySqlHelper.GetConnection().CreateCommand();
                myCommand.Parameters.Clear();
              //  myCommand.Parameters.AddWithValue("@staffid", ID); 
                myCommand.Parameters.AddWithValue("@username", Username);
                myCommand.Parameters.AddWithValue("@password", SecurePassword.Encrypt(Password));
                myCommand.Parameters.AddWithValue("@role", Role); 
                myCommand.Parameters.AddWithValue("@isactive", IsActive);
                myCommand.CommandText = "sp_add_staff_with_account";
                myCommand.CommandType = CommandType.StoredProcedure;
                mySqlHelper.Open();
                myCommand.ExecuteNonQuery();
                mySqlHelper.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Get staff and search through it
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public virtual DataTable GetStaff(string search)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", search);
                myComand.CommandText = "sp_searach_staff";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Delete staff from database
        /// </summary>
        /// <param name="userid"></param>
        public virtual void Delete(string userid)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myCommand = mySqlHelper.GetConnection().CreateCommand();
                myCommand.Parameters.Clear();
               // myCommand.Parameters.AddWithValue("@deleteID", ID);
                myCommand.Parameters.AddWithValue("@userid", userid);
                myCommand.CommandText = "sp_delete_staff";
                myCommand.CommandType = CommandType.StoredProcedure;
                mySqlHelper.Open();
                myCommand.ExecuteNonQuery();
                mySqlHelper.Close();
                UserActivity.RecordActivity("Deleted a staff");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Get user account details
        /// </summary>
        /// <param name="userID">staff id of the user</param>
        /// <returns></returns>
        public virtual DataTable GetUserDetails(string userID)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@staffid", userID);
                myComand.CommandText = "sp_user_details";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Create user account for staff
        /// </summary>
        /// <param name="userid"></param>
        public void CreateAccount(string userid)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myCommand = mySqlHelper.GetConnection().CreateCommand();
                myCommand.Parameters.Clear();
                myCommand.Parameters.AddWithValue("@userid", userid);
              //  myCommand.Parameters.AddWithValue("@staffid", ID);
                myCommand.Parameters.AddWithValue("@username", Username);
                myCommand.Parameters.AddWithValue("@role", Role);
                myCommand.Parameters.AddWithValue("@password", SecurePassword.Encrypt(Password)); 
                myCommand.Parameters.AddWithValue("@isactive",  IsActive); 
                myCommand.CommandText = "sp_user_account";
                myCommand.CommandType = CommandType.StoredProcedure;
                mySqlHelper.Open();
                myCommand.ExecuteNonQuery();
                mySqlHelper.Close();
                UserActivity.RecordActivity("Created a staff Account");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Update user account role and status
        /// </summary>
        /// <param name="userid"></param>
        public void UpdateUserAccount(string userid)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myCommand = mySqlHelper.GetConnection().CreateCommand();
                myCommand.Parameters.Clear();
                myCommand.Parameters.AddWithValue("@userid", userid);
               // myCommand.Parameters.AddWithValue("@staffid", ID); 
                myCommand.Parameters.AddWithValue("@role", Role);
                myCommand.Parameters.AddWithValue("@isactive", IsActive);
                myCommand.CommandText = "sp_update_user_acount";
                myCommand.CommandType = CommandType.StoredProcedure;
                mySqlHelper.Open();
                myCommand.ExecuteNonQuery();
                mySqlHelper.Close();
                UserActivity.RecordActivity("Updated a staff Account settings");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Delete user account
        /// </summary>
        /// <param name="userid"></param>
        public void DeleteUserAccount(string userid)
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myCommand = mySqlHelper.GetConnection().CreateCommand();
                myCommand.Parameters.Clear();
                myCommand.Parameters.AddWithValue("@userid", userid);
               // myCommand.Parameters.AddWithValue("@staffid", ID);
                myCommand.CommandText = "sp_delete_user_acount";
                myCommand.CommandType = CommandType.StoredProcedure;
                mySqlHelper.Open();
                myCommand.ExecuteNonQuery();
                mySqlHelper.Close();
                UserActivity.RecordActivity("Deleted a staff Account");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        } 
    }
}
    
