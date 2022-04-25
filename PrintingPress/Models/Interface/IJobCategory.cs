using System;
using System.Data;

namespace PrintingPress.Models.Job
{
    public interface IJobCategory
    {
        string JobId { get; set; }

        /// <summary>
        /// Expense date
        /// </summary>
        DateTime Date { get; set; }

        /// <summary>
        /// Expense Setup Status
        /// Income = +
        /// Expense = -
        /// </summary>
        string Status { get; set; }

        string TransactionType { get; set; }

        /// <summary>
        /// Expense setup description
        /// </summary>
        string SetupDescription { get; set; }

        /// <summary>
        /// Expense setup ID
        /// </summary>
        string SetID { get; set; }

        /// <summary>
        /// Expense unique code
        /// </summary>
        string Code { get; set; }

        /// <summary>
        /// Expense heading
        /// </summary>
        string ExpenseHeading { get; set; }

        /// <summary>
        /// Expense description
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Cost of Expenses
        /// </summary>
        string Amount { get; set; }

        /// <summary>
        /// add category
        /// </summary>
        void Add();

        void UpdateJob();
        void DeleteJob();

        /// <summary>
        /// Search Job category
        /// </summary>
        /// <param name="searchText"></param>
        /// <returns></returns>
        DataTable SearchJobCategory(string searchText);

        DataTable GetExpenseSetInfor(string searchText);

        /// <summary>
        /// Get expenses code
        /// </summary>
        /// <param name="searchText"></param>
        /// <returns></returns>
        DataTable GetExpenseCode();

        /// <summary>
        /// Save New expense Setup
        /// </summary>
        void RegisterSetup();

        /// <summary>
        /// Update new Expense setup
        /// </summary>
        void UpdateRegisterSetup();

        /// <summary>
        /// Delete new Expense Setuo
        /// </summary>
        void DeleteRegisterSetup();

        /// <summary>
        /// Register new expense code and heading
        /// </summary>
        void RegisterExpensHeading();

        /// <summary>
        /// Update Expense code and heading
        /// </summary>
        void UpdateExpensHeading();

        /// <summary>
        /// Delete expense heading and code
        /// </summary>
        void DeleteExpensHeading();

        /// <summary>
        /// Search expense code and heading
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        DataTable GetExpenseCodeAndHeading(string search);

        DataTable GetHeadingByCode(string code);
        DataTable Display();
        DataTable todaySearch(string text);
        DataTable DisplayAll();
        DataTable seachAll(  string text);
        void getExpense();
        void getIncome();
        DataTable Display( DateTime date);

        /// <summary>
        /// Record new expense
        /// </summary>
        void Insert();

        void Delete();

        /// <summary>
        /// Update Expense record
        /// </summary>
        void Update();

        /// <summary>
        /// Search expense by code and heading
        /// </summary>
        /// <param name="code"></param>
        /// <param name="heading"></param>
        /// <returns></returns>
        DataTable SearchCodeandHeand(string code, string heading);

        /// <summary>
        /// Search Expenses
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        DataTable SearchExpenses(string search);

        DataTable SearchExpensesByDate(DateTime datefrom);
        DataTable SearchExpensesByDate(DateTime datefrom, DateTime dateto);

        /// <summary>
        /// View all expenditure
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        DataTable ViewAllExpensure(string search);

        /// <summary>
        /// Search expenditure by code and heading
        /// </summary>
        /// <param name="code"></param>
        /// <param name="heading"></param>
        /// <returns></returns>
        DataTable SearchExpenditureCodeandHeand(string code, string heading);

        /// <summary>
        /// GEt expenditure by date
        /// </summary>
        /// <param name="datefrom"></param>
        /// <returns></returns>
        DataTable SearchExpenditureByDate(DateTime datefrom);

        /// <summary>
        /// Get expense by code, heading and date
        /// </summary>
        /// <param name="code"></param>
        /// <param name="heading"></param>
        /// <param name="datefrom"></param>
        /// <returns></returns>
        DataTable SearchExpenditureCodeandHeandDate(string code, string heading, DateTime datefrom);

        /// <summary>
        /// Get expenditure between dates
        /// </summary>
        /// <param name="datefrom"></param>
        /// <param name="dateto"></param>
        /// <returns></returns>
        DataTable SearchExpenditureByDate(DateTime datefrom, DateTime dateto);

        /// <summary>
        /// Get the Description (INCOME OR EXPENDITURE)
        /// For report preparation
        /// </summary>
        /// <param name="code"></param>
        /// <param name="heading"></param>
        /// <returns></returns>
        string GetDataSearch(string code, string heading);

        /// <summary>
        /// Get account code by heading search
        /// </summary>
        /// <param name="heading"></param>
        /// <returns></returns>
        string GetCodeByHeading( string heading);

        /// <summary>
        /// Search account Heading by code
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        DataTable GetAccountHeadingByCode(string code);

        DataTable GetAccountHeading();
        DataTable GetAccountCode();
        DataTable GetJobCategory(string code, string heading);
    }
}