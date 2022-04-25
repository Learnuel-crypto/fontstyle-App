using System;
using System.Data;
using System.Windows.Forms;

namespace PrintingPress.Models
{
    public interface IExpenses
    {
        string Amount { get; set; }
        string Code { get; set; }
        DateTime Date { get; set; }
        string Description { get; set; }
        string ExpenseHeading { get; set; }
        string SetID { get; set; }
        string SetupDescription { get; set; }
        string Status { get; set; }
        string TransactionType { get; set; }
        Decimal NetDebt { get; set; }
        void Delete();
        void DeleteExpensHeading();
        void DeleteRegisterSetup();
        DataTable Display( );
        DataTable Display(  DateTime date);
        DataTable DisplayAll( );
        string GetDataSearch(string code, string heading);
        void getExpense();
        DataTable GetExpenseCode();
        DataTable GetExpenseCodeAndHeading(string search);
        DataTable GetExpenseSetInfor(string searchText);
        DataTable GetHeadingByCode(string code);
        void getIncome();
        void Insert();
        void RegisterExpensHeading();
        void RegisterSetup();
          DataTable seachAll( string text);
        DataTable SearchCodeandHeand(string code, string heading);
        DataTable SearchExpenditureByDate(DateTime datefrom);
        DataTable SearchExpenditureByDate(DateTime datefrom, DateTime dateto);
        DataTable SearchExpenditureCodeandHeand(string code, string heading);
        DataTable SearchExpenditureCodeandHeandDate(string code, string heading, DateTime datefrom);
        DataTable SearchExpenses(string search);
        DataTable SearchExpensesByDate(DateTime datefrom);
        DataTable SearchExpensesByDate(DateTime datefrom, DateTime dateto);
          DataTable todaySearch(string text);
        void Update();
        void UpdateExpensHeading();
        void UpdateRegisterSetup();
        DataTable ViewAllExpensure(string search);
        string GetCodeByHeading(string heading);
        DataTable GetAccountHeadingByCode(string code);
        DataTable GetAccountHeading();
        DataTable GetAccountCode();
        DataTable GetExpenseHeading();
        DataTable GetIncomeHeading();
        void PayDebt();
    }
}