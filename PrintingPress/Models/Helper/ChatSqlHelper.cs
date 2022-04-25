using System.Configuration;
using System.Data.SqlClient;
using WindowsFormsApplication1.Modification.Models.Helper;

namespace PrintingPress.Models.Helper
{
    class ChatSqlHelper:SqlHelper,ISqlHelper
    {
         
        public override SqlConnection GetChatConnection()
        {

            return cn = new SqlConnection(
                StrCrypt.Decrypt(ConfigurationManager.ConnectionStrings["chatserver"].ConnectionString));
        }
    }
}
