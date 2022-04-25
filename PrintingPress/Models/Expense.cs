using PrintingPress.Models.Helper;
using System;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApplication1;
using WindowsFormsApplication1.Modification.Models.Helper;
using ChucksMedicare.Model;
using WindowsFormsApplication1.Modification.Models.ProcedureUpdate;
using WindowsFormsApplication1.Modification.Models;

namespace PrintingPress.Models
{
    public class Expenses : IExpenses
    {
        public static long Total = 0;
        public static long Income = 0;
        public static long Expense = 0;
        public static long Bal = 0;

        public SqlDataAdapter da;
        public DataTable _table;
        public Expenses()
        {

        }
        #region SETUP SECTION
        /// <summary>
        /// Expense date
        /// </summary>
        public DateTime Date { get; set; }
        private string status;
        /// <summary>
        /// Expense Setup Status
        /// Income = +
        /// Expense = -
        /// </summary>
        public string Status
        {
            get { return status; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Status cannot be empty");
                if (value.ToLower().Trim() != "income" && value.ToLower().Trim() != "expense")
                    throw new Exception("Invalid Status");
                if (value.ToLower().Trim() == "income")
                    value = "+";
                if (value.ToLower().Trim() == "expense")
                    value = "-";
                status = value;
            }
        }
        private string transactiontype;

        public string TransactionType
        {
            get { return transactiontype; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Transaction Type is empty"); 
                transactiontype = value;
            }
        }

        private string setupDescription;
        /// <summary>
        /// Expense setup description
        /// </summary>
        public string SetupDescription
        {
            get { return setupDescription; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Description cannot be empty");
                setupDescription = value;
            }
        }

        private string setID;
        /// <summary>
        /// Expense setup ID
        /// </summary>
        public string SetID
        {
            get { return setID; }
            set { setID = value; }
        }
        private string code;
        /// <summary>
        /// Expense unique code
        /// </summary>
        public string Code
        {
            get { return code; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Cashflow code cannot be empty");
                Validation.ExpenseCode(value);
                code = value;
            }
        }
        private string expenseHeading;
        /// <summary>
        /// Expense heading
        /// </summary>
        public string ExpenseHeading
        {
            get { return expenseHeading; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Cashflow heading cannot be empty");

                expenseHeading = value;
            }
        }

        private string description;
        /// <summary>
        /// Expense description
        /// </summary>
        public string Description
        {
            get { return description; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Cashflow description can't be empty");
                description = value.Trim();
            }
        }
        private string amount;
        /// <summary>
        /// Cost of Expenses
        /// </summary>
        public string Amount
        {
            get { return amount; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Enter expense cost");
                Validation.Amount(value);
                amount = value.Trim();
            }
        }

        private Decimal netDebt;

        public Decimal NetDebt
        {
            get { return netDebt; }
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                    throw new Exception("Enter expense cost");
                if (value < 0)
                    throw new Exception("Invalide Debt balance");
                Validation.Amount(value.ToString());
                netDebt = value;
            }
        }

        public DataTable GetExpenseSetInfor(string searchText)
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", searchText);
                myComand.CommandText = "sp_get_expense_setup_infor";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }
        /// <summary>
        /// Get expenses code
        /// </summary>
        /// <param name="searchText"></param>
        /// <returns></returns>
        public DataTable GetExpenseCode()
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.CommandText = "sp_get_expense_Code";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }
        /// <summary>
        /// Save New expense Setup
        /// </summary>
        public void RegisterSetup()
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                using (SqlConnection con = mySqlHelper.GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();

                    cmd.Parameters.AddWithValue("@statement", setupDescription);
                    cmd.Parameters.AddWithValue("@status", this.status);
                    cmd.CommandText = "sp_new_expense_setup";
                    cmd.CommandType = CommandType.StoredProcedure;
                    mySqlHelper.Open();
                    cmd.ExecuteNonQuery();
                    var x = Status == "+" ? "Income" : "Expense";
                    UserActivity.RecordActivity(string.Format("Added new {0} category", x));
                     
                }
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }
        /// <summary>
        /// Update new Expense setup
        /// </summary>
        public void UpdateRegisterSetup()
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                using (SqlConnection con = mySqlHelper.GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();

                    cmd.Parameters.AddWithValue("@setid", SetID);
                    cmd.Parameters.AddWithValue("@statement", setupDescription);
                    cmd.Parameters.AddWithValue("@status", this.status);
                    cmd.CommandText = "sp_update_expense_setup";
                    cmd.CommandType = CommandType.StoredProcedure;
                    mySqlHelper.Open();
                    cmd.ExecuteNonQuery();
                    var x = Status == "+" ? "Income" : "Expense";
                    UserActivity.RecordActivity( string.Format("Updated one {0} category", x));
                    
                }
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }
        /// <summary>
        /// Delete new Expense Setuo
        /// </summary>
        public void DeleteRegisterSetup()
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                using (SqlConnection con = mySqlHelper.GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();

                    cmd.Parameters.AddWithValue("@setid", SetID);
                    cmd.CommandText = "sp_delete_expense_setup";
                    cmd.CommandType = CommandType.StoredProcedure;
                    mySqlHelper.Open();
                    cmd.ExecuteNonQuery();
                    var x = Status == "+" ? "Income" : "Expense";
                    UserActivity.RecordActivity(string.Format("Deleted an {0} category", x));
        

                }
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }
        //EXPENSE HEADING SECTION
        /// <summary>
        /// Register new expense code and heading
        /// </summary>
        public void RegisterExpensHeading()
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                using (SqlConnection con = mySqlHelper.GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();

                    cmd.Parameters.AddWithValue("@setid", setupDescription);
                    cmd.Parameters.AddWithValue("@code", this.Code);
                    cmd.Parameters.AddWithValue("@heading", this.ExpenseHeading);
                    cmd.CommandText = "sp_new_expense_code";
                    cmd.CommandType = CommandType.StoredProcedure;
                    mySqlHelper.Open();
                    cmd.ExecuteNonQuery();
                    UserActivity.RecordActivity(string.Format("Added new heading to code {0}", code));
 
                }
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }
        /// <summary>
        /// Update Expense code and heading
        /// </summary>
        public void UpdateExpensHeading()
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                using (SqlConnection con = mySqlHelper.GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();

                    cmd.Parameters.AddWithValue("@setid", setupDescription);
                    cmd.Parameters.AddWithValue("@codeid", this.SetID);
                    cmd.Parameters.AddWithValue("@code", this.Code);
                    cmd.Parameters.AddWithValue("@heading", this.ExpenseHeading);
                    cmd.CommandText = "sp_update_expense_code";
                    cmd.CommandType = CommandType.StoredProcedure;
                    mySqlHelper.Open();
                    cmd.ExecuteNonQuery();
                    UserActivity.RecordActivity(string.Format("Updated heading: {0} ", code));
                     
                }
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }
        /// <summary>
        /// Delete expense heading and code
        /// </summary>
        public void DeleteExpensHeading()
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                using (SqlConnection con = mySqlHelper.GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.Parameters.AddWithValue("@codeid", this.SetID);
                    cmd.CommandText = "sp_delete_expense_code";
                    cmd.CommandType = CommandType.StoredProcedure;
                    mySqlHelper.Open();
                    cmd.ExecuteNonQuery();
                    UserActivity.RecordActivity(string.Format("Deleted heading {0} ", code));
                    
                }
            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message);
            }
        }
        /// <summary>
        /// Search expense code and heading
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public DataTable GetExpenseCodeAndHeading(string search)
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", search);
                myComand.CommandText = "sp_get_expense_code_heading";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }



        public DataTable GetHeadingByCode(string code)
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", code);
                myComand.CommandText = "sp_get_heading_by_code";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }
        #endregion


        public DataTable Display()
        {
            Total = 0;
            SqlConnection con = Factory.CreateSqlConHelper().GetConnection();
            con.Open();
            DataTable dts = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT  *FROM Expense WHERE Date = @sdate", con);
          
            da.Fill(dts);
            return dts;

        }
        public DataTable todaySearch(string text)
        {
            Total = 0;
            SqlConnection con = Factory.CreateSqlConHelper().GetConnection();
            con.Open();
            DataTable dts = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT  *FROM Expense WHERE Description LIKE'%' +@search + '%' OR Amount LIKE'%' + @search + '%'" +
                                                   "AND  Date = @sdate", con);
            da.SelectCommand.Parameters.AddWithValue("@search", SqlDbType.VarChar).Value =text;
          
            da.Fill(dts);
            return dts;
        }
        public DataTable DisplayAll()
        {
            Total = 0;
            SqlConnection con = Factory.CreateSqlConHelper().GetConnection();
            con.Open();
            DataTable dts = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT  *FROM Expense ORDER BY ID desc", con);
            da.Fill(dts);
            
            con.Close();
            return dts;
        }
        public DataTable seachAll(  string text)
        {
            try
            {
                Total = 0;
                using (SqlConnection con = Factory.CreateSqlConHelper().GetConnection())
                {
                    con.Open();
                    DataTable dts = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT  *FROM Expense WHERE Description LIKE'%' + @search + '%' OR Amount LIKE'%' + @search + '%'" +
                        "OR Date like'%' + @search + '%' ", con);
                    da.SelectCommand.Parameters.AddWithValue("@search", SqlDbType.VarChar).Value = text;
                    da.Fill(dts);
                    return dts;
                }

                //con.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public void getExpense()
        {
            try
            {
                Expense = 0;

                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@sdate", DateTime.Today.Date);
                myComand.Parameters.AddWithValue("@status", "-");
                myComand.CommandText = "sp_get_today_expense";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                if (_table.Rows.Count > 0)
                {
                    foreach (DataRow drRec in _table.Rows)
                    {
                        // GET THE TOTAL INCOME
                        if (!string.IsNullOrEmpty((drRec["Amount"].ToString())))
                        {
                            long amount = Convert.ToInt64(drRec["Amount"]);
                            Expense = Expense + amount;
                        }


                    }
                }

                getIncome();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void getIncome()
        {
            try
            {
                Income = 0;
                Bal = 0;
                using (SqlConnection con = Factory.CreateSqlConHelper().GetConnection())
                {
                    con.Open();
                    DataTable dts = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT  Amount FROM Cash WHERE Pay_Date =@sdate", con);
                   // da.SelectCommand.Parameters.AddWithValue("@sdate", SqlDbType.VarChar).Value = dataAccess.Sdate;
                    da.Fill(dts);
                    if (dts.Rows.Count > 0)
                    {
                        foreach (DataRow drRec in dts.Rows)
                        {
                            // GET THE TOTAL EXPENSES
                            if (!string.IsNullOrEmpty((drRec["Amount"].ToString())))
                            {
                                long amount = Convert.ToInt64(drRec["Amount"]);
                                Income = Income + amount;
                            }
                        }
                    }
                }

                //con.Close();
                Bal = Income - Expense;
            }
            catch (Exception ex)
            {
                // con.Close();
                throw new Exception(ex.Message);
            }
        }
        public DataTable Display( DateTime date)
        {
            try
            {
                using (SqlConnection con = Factory.CreateSqlConHelper().GetConnection())
                {
                    con.Open();
                    DataTable dts = new DataTable();
                    SqlDataAdapter da =
                        new SqlDataAdapter("SELECT  *FROM Expense WHERE Date =@sdate", con);
                    da.SelectCommand.Parameters.AddWithValue("@sdate", SqlDbType.VarChar).Value = date.Date;
                    da.Fill(dts);
                    return dts;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Record new expense
        /// </summary>
        public void Insert()
        {
            try
            {
                //INSERT EXPENSE VALUES   

                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                using (SqlConnection con = mySqlHelper.GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.Parameters.AddWithValue("@Code", this.Code);
                    cmd.Parameters.AddWithValue("@Description", this.Description);
                    cmd.Parameters.AddWithValue("@Heading", this.ExpenseHeading);
                    cmd.Parameters.AddWithValue("@Amount", this.amount);
                    cmd.Parameters.AddWithValue("@Date", this.Date);
                    cmd.Parameters.AddWithValue("@Method", this.TransactionType);
                    cmd.CommandText = "sp_add_expense";
                    cmd.CommandType = CommandType.StoredProcedure;
                    mySqlHelper.Open();
                    cmd.ExecuteNonQuery();
                    UserActivity.RecordActivity( string.Format("Made code: {0} activity", this.Code));
                    
                }
            }
            catch (Exception ex)
            {
                throw new ExceptionHandling("Code and Heading do not match", ex);
                //throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Pay debt from invoice balance
        /// </summary>
        public void PayDebt()
        {
            try
            { 
                using (SqlConnection con = Factory.CreateSqlConHelper().GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.Parameters.AddWithValue("@Code", this.Code);
                    cmd.Parameters.AddWithValue("@Description", this.Description);
                    cmd.Parameters.AddWithValue("@Heading", this.ExpenseHeading);
                    cmd.Parameters.AddWithValue("@Amount", this.amount);
                    cmd.Parameters.AddWithValue("@Date", this.Date);
                    cmd.Parameters.AddWithValue("@Method", this.TransactionType);
                    cmd.Parameters.AddWithValue("@Invoiceid", this.SetID);//setid serve as invoiceid
                    cmd.Parameters.AddWithValue("@Netdebt", this.NetDebt);
                    cmd.CommandText = "sp_pay_debt";
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    UserActivity.RecordActivity(string.Format("{0} : {1} activity",this.Description, this.Code));

                }
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().StartsWith("could not find stored procedure"))
                {
                    CreateProcedure proc = Factory.CreateProc();
                    proc.Create(Procedures.create_debt_payment_receipt_table());
                    proc.Create(Procedures.sp_pay_debt());
                    PayDebt();

                }
                else
                {
                    throw new ExceptionHandling("Code and Heading do not match", ex);
                    //throw new Exception(ex.Message);
                }
            }
        }
        public void Delete()
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                using (SqlConnection con = mySqlHelper.GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.Parameters.AddWithValue("@Id", this.SetID);
                    cmd.CommandText = "sp_delete_expense";
                    cmd.CommandType = CommandType.StoredProcedure;
                    mySqlHelper.Open();
                    cmd.ExecuteNonQuery();
                    UserActivity.RecordActivity( string.Format("Deleted code: {0} activity", this.Code));
 
                }
            }
            catch (Exception ex)
            {
                throw new ExceptionHandling("Record could not be deleted", ex);
                //throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Update Expense record
        /// </summary>
        public void Update()
        {
            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                using (SqlConnection con = mySqlHelper.GetConnection())
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.Parameters.AddWithValue("@Code", this.Code);
                    cmd.Parameters.AddWithValue("@Description", this.Description);
                    cmd.Parameters.AddWithValue("@Heading", this.ExpenseHeading);
                    cmd.Parameters.AddWithValue("@Amount", this.amount);
                    cmd.Parameters.AddWithValue("@Date", this.Date);
                    cmd.Parameters.AddWithValue("@Id", this.SetID);
                    cmd.CommandText = "sp_update_expense";
                    cmd.CommandType = CommandType.StoredProcedure;
                    mySqlHelper.Open();
                    cmd.ExecuteNonQuery();
                    UserActivity.RecordActivity(string.Format("Updated code: {0} activity", this.Code));
                   
                }
            }
            catch (Exception ex)
            {
                throw new ExceptionHandling("Record could not be updated", ex);
                // throw new Exception(Ex.Message);
            }
        }
        /// <summary>
        /// Search expense by code and heading
        /// </summary>
        /// <param name="code"></param>
        /// <param name="heading"></param>
        /// <returns></returns>
        public DataTable SearchCodeandHeand(string code, string heading)
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@code", code.Trim());
                myComand.Parameters.AddWithValue("@heading", heading.Trim());
                myComand.CommandText = "sp_view_expense_by_codeand_heading";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }
        /// <summary>
        /// Search Expenses
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public DataTable SearchExpenses(string search)
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", search);
                myComand.CommandText = "sp_view_expense";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }
        public DataTable SearchExpensesByDate(DateTime datefrom)
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@date", datefrom);
                myComand.CommandText = "sp_view_expense_by_date";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }
        public DataTable SearchExpensesByDate(DateTime datefrom, DateTime dateto)
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@datefrom", datefrom);
                myComand.Parameters.AddWithValue("@dateto", dateto);
                myComand.CommandText = "sp_view_expense_by_between_date";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }
        #region EXPENDITURE
        /// <summary>
        /// View all expenditure
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public DataTable ViewAllExpensure(string search)
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@search", search);
                myComand.CommandText = "sp_view_expenditure";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }
        /// <summary>
        /// Search expenditure by code and heading
        /// </summary>
        /// <param name="code"></param>
        /// <param name="heading"></param>
        /// <returns></returns>
        public DataTable SearchExpenditureCodeandHeand(string code, string heading)
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@code", code.Trim());
                myComand.Parameters.AddWithValue("@heading", heading.Trim());
                myComand.CommandText = "sp_view_expenditure_by_codeand_heading";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }
        /// <summary>
        /// GEt expenditure by date
        /// </summary>
        /// <param name="datefrom"></param>
        /// <returns></returns>
        public DataTable SearchExpenditureByDate(DateTime datefrom)
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@datefrom", datefrom);
                myComand.CommandText = "sp_get_expenditure_by";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }

        /// <summary>
        /// Get expense by code, heading and date
        /// </summary>
        /// <param name="code"></param>
        /// <param name="heading"></param>
        /// <param name="datefrom"></param>
        /// <returns></returns>
        public DataTable SearchExpenditureCodeandHeandDate(string code, string heading, DateTime datefrom)
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@code", code.Trim());
                myComand.Parameters.AddWithValue("@heading", heading.Trim());
                myComand.Parameters.AddWithValue("@datefrom", datefrom.Date);
                myComand.CommandText = "sp_view_expense_by_codeand_heading_date";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }
        /// <summary>
        /// Get expenditure between dates
        /// </summary>
        /// <param name="datefrom"></param>
        /// <param name="dateto"></param>
        /// <returns></returns>
        public DataTable SearchExpenditureByDate(DateTime datefrom, DateTime dateto)
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@datefrom", datefrom);
                myComand.Parameters.AddWithValue("@dateto", dateto);
                myComand.CommandText = "sp_get_expenditure_between_date";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }

        /// <summary>
        /// Get the Description (INCOME OR EXPENDITURE)
        /// For report preparation
        /// </summary>
        /// <param name="code"></param>
        /// <param name="heading"></param>
        /// <returns></returns>
        public string GetDataSearch(string code, string heading)
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                using (SqlConnection myconn = mySqlHelper.GetConnection())
                {
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_prepare_expendiure_by_codeand_heading", myconn);
                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.Parameters.AddWithValue("@heading", heading.Trim());
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);

                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            return dr[0].ToString();
                        }

                    }

                    return null;

                }

            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }
        /// <summary>
        /// Get account code by heading search
        /// </summary>
        /// <param name="heading"></param>
        /// <returns></returns>
        public string GetCodeByHeading( string heading)
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                using (SqlConnection myconn = mySqlHelper.GetConnection())
                {
                    string code ="";
                    myconn.Open();
                    SqlCommand cmd = new SqlCommand("sp_get_code_by_heading", myconn); 
                    cmd.Parameters.AddWithValue("@heading", heading.Trim());
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(sdr);

                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                             code= dr["Code"].ToString();
                             break;
                        }

                    }

                    return code;
                }

            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }
        /// <summary>
        /// Search account Heading by code
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public DataTable GetAccountHeadingByCode(string code)
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.Parameters.AddWithValue("@code", code); 
                myComand.CommandText = "sp_get_heading_by_code";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }

        public DataTable GetAccountHeading()
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand(); 
                myComand.CommandText = "sp_list_heading";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }
        public DataTable GetAccountCode()
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand(); 
                myComand.CommandText = "sp_list_code";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }
        public DataTable GetIncomeHeading()
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.CommandText = "sp_get_income_heading";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }
        public DataTable GetExpenseHeading()
        {

            try
            {
                ISqlHelper mySqlHelper = Factory.CreateSqlConHelper();
                SqlCommand myComand = mySqlHelper.GetConnection().CreateCommand();
                myComand.CommandText = "sp_get_expense_heading";
                myComand.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(myComand);
                _table = new DataTable();
                da.Fill(_table);
                mySqlHelper.Open();
                myComand.ExecuteNonQuery();
                mySqlHelper.Close();
                return _table;

            }

            catch (Exception ex)
            {
                throw new ExceptionHandling("There was error in the process, try again", ex);
            }
        }
        #endregion
 
     
    }
}
