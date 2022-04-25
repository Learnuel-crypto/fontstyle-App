using EncryptString;
using PrintingPress;
using PrintingPress.Models.Helper;
using System;
using System.Data.SqlClient;
using WindowsFormsApplication1.Modification.Models.Helper;

namespace WindowsFormsApplication1.Modification.Models.ProcedureUpdate
{
    /// <summary>
    /// Create new Procedures
    /// </summary>
    internal  class CreateProcedure
    {
        StringEncryptor StrCrypt = new StringEncryptor();
        /// <summary>
        /// Create Procedure
        /// </summary>
        /// <param name="proceduresText"></param>
        internal void Create(string proceduresText)
      {
        try
        {
          ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
          SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
          myComand.CommandText = StrCrypt.Decrypt(proceduresText); 
          
          mySqlHelper.Open();
          myComand.ExecuteNonQuery();
          mySqlHelper.Close(); 
        }

        catch (Exception ex)
        {
            if (ex.Message.StartsWith("There is already an object named"))
            {
               return;
            }
            else
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
                }
            
           
        }
    }
 
    }
}
