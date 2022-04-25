using PrintingPress.Models;
using PrintingPress.Models.Staff_mgt;
using WindowsFormsApplication1.Modification.Models.Helper;
using ChucksMedicare.Model.Staff_mgt;
using PrintingPress.Models.Job;
using WindowsFormsApplication1.Modification.Models.ProcedureUpdate;
using ChucksMedicare.Model;
using PrintingPress.Models.Helper;
using WindowsFormsApplication1;

namespace PrintingPress
{
    public static class Factory
    {
        internal static ISqlHelper CreateSqlConHelper()
        {
            return  new SqlHelper();
        }
        /// <summary>
        /// Connect to mysql database
        /// </summary>
        /// <returns></returns>
        internal static ISqlHelper CreateChatSqlCoHelpter()
        {
            return new ChatSqlHelper();
        }
        internal static ISqlHelper CreateSqlConHelper(bool connect)
        {
            return new SqlHelper(connect);
        }
        internal static ISqlHelper CreateSqlConHelper(string connectstring)
        {
            return new SqlHelper(connectstring);
        }
        internal static IAppSettings CreateAppSettings()
        {
           return new AppSettings();
        }

        internal static IJobCategory CreateJobCategory()
        {
            return  new JobCategory();
        }

        internal static IExpenses CreateExpenses()
        {
            return  new Expenses();
        }

        internal static IUsers CreateNewUser()
        {
            return  new Users();
        }
        /// <summary>
        /// Create new staff
        /// </summary>
        /// <returns></returns>
        internal static IStaffs CreateStaff()
        {
            return  new Staffs();
        }
        /// <summary>
        /// Create Job category
        /// </summary>
        /// <returns></returns>
        internal static IJobCategory CreateCategory()
        {
            return new JobCategory();
        }
        /// <summary>
        /// Creat Job items
        /// </summary>
        /// <returns></returns>
        internal static IJob CreateJob()
        {
            return  new Job();
        }

        internal static ICustomer CreateCustomer()
        {
           return  new Customer();
        }

        internal static IInvoice CreateInvoice()
        {
            return  new Invoice();
        }

        internal static ICashFlow createCashFlow()
        {
            return  new CashFlow();
        }

        internal static IUserChat CreateChat()
        {
            return  new UserChat();
        }
        /// <summary>
        /// Create instance of create proceduress
        /// </summary>
        /// <returns></returns>
        internal static CreateProcedure CreateProc()
        {
            return  new CreateProcedure();
        }

        internal static IUserActivity UserActivity()
        {
           return  new UserActivity();
        }
        /// <summary>
        /// Create database for import of backup file
        /// </summary>
        /// <returns></returns>
        internal static MyDB CreateDb()
        {
            return new MyDB();
        }

        internal static IArithmetic CreateArithmetic()
        {
            return  new Arithmetic();
        }
    }
}
