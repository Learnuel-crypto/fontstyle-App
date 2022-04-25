using System.Data.SqlClient;

namespace WindowsFormsApplication1.Modification.Models.Helper
{
    public interface ISqlHelper
    {
        bool IsConnection { get; }

        void Close();
        SqlConnection GetConnection();
        SqlConnection GetChatConnection();
        void Open();
    }
}