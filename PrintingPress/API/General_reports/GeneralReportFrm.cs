using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
using PrintingPress.API.Income_expense;
using PrintingPress.API.Reports;
using PrintingPress.Models;
using PrintingPress.Models.Job;
using Exception = System.Exception;

namespace PrintingPress.API.General_reports
{
    public partial class GeneralReportFrm : Form
    {
        private DataTable Data;
        private DataSet ds;
        internal static bool CasflowPrint;
        internal static bool invoicePrint;
        public static bool ItemsProcessing { get; private set; }
        private Decimal CashflowTotalIncome = 0.00m;
        private Decimal CashflowTotalExpense = 0.00m;
        private Decimal TotalCapitalExpdenditure = 0.00m;
        private Decimal TotalItemEstematedCost = 0.00m;
        Dictionary<string, string> CodeHeadings = new Dictionary<string, string>();
        Dictionary<string, Decimal> CodeHeadingAmount = new Dictionary<string, Decimal>();
        public GeneralReportFrm()
        {
            InitializeComponent();
        }

        private async Task LoadActivityDataAsync(DataGridView userData)
        {
            Data = new DataTable();
            ds = new DataSet();
             
                //add more columns
                Data.Columns.AddRange(new DataColumn[3]
                {
                    new DataColumn("Username", typeof(string)),
                    new DataColumn("Activity", typeof(string)),
                    new DataColumn("Date_time", typeof(string)),
                });
                foreach (DataGridViewRow item in userData.Rows)
                {
                    DateTime date =Convert.ToDateTime( item.Cells["Date"].Value.ToString().Trim());
                    Data.Rows.Add(item.Cells["Username"].Value, item.Cells["Activity"].Value,
                        string.Format("{0} {1}", date.ToString("dd/MM/yyyy"), item.Cells["Time"].Value)
                    );
                }
            
        }

        private void LoadCashflowDataAsync(DataGridView cashData)
        {
            Data = new DataTable();
            ds = new DataSet();
            ICashFlow cashFlow = Factory.createCashFlow();
            IInvoice invoice = Factory.CreateInvoice();
            //add more columns
            Data.Columns.AddRange(new DataColumn[6]
            {
                new DataColumn("Code", typeof(string)),
                new DataColumn("Heading", typeof(string)),
                new DataColumn("Description", typeof(string)),
                new DataColumn("Method", typeof(string)),
                new DataColumn("Amount", typeof(Decimal)),
                new DataColumn("Date", typeof(string)),
            });
            foreach (DataGridViewRow item in cashData.Rows)
            {
                 
                var datarow = cashFlow.GetCodeStatus(item.Cells["Code"].Value.ToString()).Rows[0];
                    
                DateTime date = Convert.ToDateTime(item.Cells["Date"].Value.ToString().Trim());
                Data.Rows.Add(item.Cells["Code"].Value, item.Cells["Heading"].Value, item.Cells["Description"].Value, item.Cells["Method"].Value, item.Cells["Amount"].Value,
                    string.Format("{0}", date.ToString("dd/MM/yyyy")) 
                );
              
                if (datarow["Status"].ToString() == "-")
                {
                    CashflowTotalExpense += Convert.ToDecimal(item.Cells["Amount"].Value);
                }else if (datarow["Status"].ToString() == "+")
                {
                    CashflowTotalIncome += Convert.ToDecimal(item.Cells["Amount"].Value);
                }
            }
            //get invoice data
            DataTable invoiceData=null;
            if (string.IsNullOrEmpty(ViewCashFlowFrm.InvoiceDateFrom) &&
                string.IsNullOrEmpty(ViewCashFlowFrm.InvoiceDateTo))
            {
                invoiceData = invoice.Display("");
                
            }else if (!string.IsNullOrEmpty(ViewCashFlowFrm.InvoiceDateFrom) &&
                      string.IsNullOrEmpty(ViewCashFlowFrm.InvoiceDateTo))
            {
                var from = Convert.ToDateTime(ViewCashFlowFrm.InvoiceDateFrom);
                invoiceData = invoice.Display(from);
            }
            else if(!string.IsNullOrEmpty(ViewCashFlowFrm.InvoiceDateFrom) &&
                    !string.IsNullOrEmpty(ViewCashFlowFrm.InvoiceDateTo))
            {
                var from = Convert.ToDateTime(ViewCashFlowFrm.InvoiceDateFrom);
                var to = Convert.ToDateTime(ViewCashFlowFrm.InvoiceDateTo);
                invoiceData = invoice.Display(from, to);
            }

            if (invoiceData.Rows.Count > 0)
            {
                foreach (DataRow row in invoiceData.Rows)
                {
                    var headInfor = invoice.GetHeadingInfor(row["InvoiceID"].ToString());
                    var Firstcode = "";
                    var Othercode = "";
                    var heading = "";
                    var Otherheading = "";
                    var desc = "";
                    if (headInfor.Rows.Count > 1)
                    {
                        int x = 0;
                        foreach (DataRow head in headInfor.Rows)
                        {
                            if (x > 0)
                            { 
                                Othercode += string.Format("{0} ", head["Code"].ToString());
                                Otherheading +=string.Format("& {0} ", head["Heading"].ToString());
                                desc +=string.Format("{0} ", head["Category"].ToString());
                            }
                            else
                            {
                                Firstcode = head["Code"].ToString();
                                heading = head["Heading"].ToString();
                                desc = head["Category"].ToString();
                            }

                            x++;
                        }
                    }
                    else { 
                       foreach (DataRow head in headInfor.Rows)
                        {
                            Firstcode = head["Code"].ToString();
                            heading = head["Heading"].ToString(); 
                            desc = head["Category"].ToString();
                            break;
                            
                        }
                      }

                   DateTime date = Convert.ToDateTime(row["Date"].ToString());
                   var invoiceTotal = Convert.ToDecimal(row["Cash"].ToString()) +
                                      Convert.ToDecimal(row["To_bank"].ToString());
                    //add data to the table
                    var insertedother = string.IsNullOrEmpty(Otherheading) ? desc : Otherheading.ToLower();

                Data.Rows.Add(Firstcode, string.Concat(Othercode,heading," #",row["InvoiceID"]), insertedother, row["Method"].ToString(), invoiceTotal,
                        string.Format("{0}", date.ToString("dd/MM/yyyy"))
                    );
                CashflowTotalIncome += invoiceTotal;
                }
            }
        }

        public async void PrintReceipt(DataGridView activityData)
        {
            try
            { 
                MyPrinter.GetReceiptHeading(); 
                await LoadActivityDataAsync(activityData);
                CRPUserActivity crp = new CRPUserActivity();
                crp.Database.Tables["User_activity"].SetDataSource(Data);
                crpReportViewer.ReportSource = null;
                crp.SetParameterValue("Bizcontact", string.IsNullOrEmpty(MyPrinter.Contact) ? "08135258516" : MyPrinter.Contact); ///get contact and address 
                crp.SetParameterValue("Title", MyPrinter.PrintTitle);
                crpReportViewer.ReportSource = crp; 
                this.ShowDialog();
                MyPrinter.PrintTitle = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public async void PrintCashFlow(DataGridView cashData)
        {
            try
            {
               
              Task task= new Task(()=> LoadCashflowDataAsync(cashData));
              task.Start();
              await task;
              MyPrinter.GetReceiptHeading();
                CRPCashflow crp = new CRPCashflow();
                crp.Database.Tables["Cashflow"].SetDataSource(Data);
                crpReportViewer.ReportSource = null;
                crp.SetParameterValue("Bizcontact", string.IsNullOrEmpty(MyPrinter.Contact) ? "08135258516" : MyPrinter.Contact); ///get contact and address 
                crp.SetParameterValue("Title", MyPrinter.PrintTitle);
                crp.SetParameterValue("TotalExpense", CashflowTotalExpense);
                crp.SetParameterValue("TotalIncome", CashflowTotalIncome);
                crpReportViewer.ReportSource = crp;
                CasflowPrint = false;
              this.ShowDialog();
                MyPrinter.PrintTitle = null;
            }
            catch (Exception ex)
            {
                CasflowPrint = false;
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LoadInvoiceDataAsync(DataGridView invoiceData)
        {
            Data = new DataTable();
            ds = new DataSet();

            //add more columns
            Data.Columns.AddRange(new DataColumn[8]
            {
                new DataColumn("ID", typeof(string)),
                new DataColumn("Tqty", typeof(int)),
                new DataColumn("Total", typeof(Decimal)),
                new DataColumn("Cash", typeof(Decimal)),
                new DataColumn("To_bank", typeof(Decimal)),
                new DataColumn("Bal", typeof(Decimal)),
                new DataColumn("Method", typeof(string)),
                new DataColumn("Date", typeof(string)),
            });
            foreach (DataGridViewRow item in invoiceData.Rows)
            {
                DateTime date = Convert.ToDateTime(item.Cells["Date"].Value.ToString().Trim());
                Data.Rows.Add(item.Cells["InvoiceID"].Value, item.Cells["Totalqty"].Value, item.Cells["Total"].Value, item.Cells["Cash"].Value, item.Cells["To_bank"].Value, item.Cells["Balance"].Value, item.Cells["Method"].Value,
                    string.Format("{0}", date.ToString("dd/MM/yyyy"))
                );
            }

        }

        private void LoadCustomerInvoiceDataAsync(DataGridView invoiceData)
        {
            Data = new DataTable();
            ds = new DataSet();

            //add more columns
            Data.Columns.AddRange(new DataColumn[8]
            {
                new DataColumn("ID", typeof(string)),
                new DataColumn("Tqty", typeof(int)),
                new DataColumn("Total", typeof(Decimal)),
                new DataColumn("Cash", typeof(Decimal)),
                new DataColumn("To_bank", typeof(Decimal)),
                new DataColumn("Bal", typeof(Decimal)),
                new DataColumn("Method", typeof(string)),
                new DataColumn("Date", typeof(string)),
            });
            foreach (DataGridViewRow item in invoiceData.Rows)
            {
                DateTime date = Convert.ToDateTime(item.Cells["Date"].Value.ToString().Trim());
                Data.Rows.Add(item.Cells["InvoiceID"].Value, item.Cells["Qty"].Value, item.Cells["Total"].Value, item.Cells["Cash"].Value, item.Cells["To_bank"].Value, item.Cells["Bal"].Value, item.Cells["Method"].Value,
                    string.Format("{0}", date.ToString("dd/MM/yyyy"))
                );
            }

        }
        public async void PrintInvoice(DataGridView invoiceData,bool isCustomer=false)
        {
            try
            {
                if (isCustomer)
                {
                    Task task = new Task(() => LoadCustomerInvoiceDataAsync(invoiceData));
                    task.Start();
                    await task;
                }
                else
                {
                    Task task = new Task(() => LoadInvoiceDataAsync(invoiceData));
                    task.Start();
                    await task;
                }
              
                MyPrinter.GetReceiptHeading();
                CRPInvoice crp = new CRPInvoice();
                crp.Database.Tables["Invoice"].SetDataSource(Data);
                crpReportViewer.ReportSource = null;
                crp.SetParameterValue("Bizcontact", string.IsNullOrEmpty(MyPrinter.Contact) ? "08135258516" : MyPrinter.Contact); ///get contact and address 
                crp.SetParameterValue("Title", MyPrinter.PrintTitle);
                crpReportViewer.ReportSource = crp;
                invoicePrint = false;
                this.ShowDialog();
                MyPrinter.PrintTitle = null;
            }
            catch (Exception ex)
            {
                invoicePrint = false;
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public async void PrintAccountStatement(DataGridView cashData,List<string>headList,bool sumHeadings=false)
        {
            try
            {

                Task task = new Task(() => LoadAccountDataAsync(cashData,headList,sumHeadings));
                task.Start();
                await task;
                MyPrinter.GetReceiptHeading();
                CRPAccountStatement crp = new CRPAccountStatement();
                crp.Database.Tables["Account_statement"].SetDataSource(Data);
                crpReportViewer.ReportSource = null;
                crp.SetParameterValue("Bizcontact", string.IsNullOrEmpty(MyPrinter.Contact) ? "08135258516" : MyPrinter.Contact); ///get contact and address 
                crp.SetParameterValue("Title", MyPrinter.PrintTitle);
                crp.SetParameterValue("TotalExpense", CashflowTotalExpense);
                crp.SetParameterValue("TotalIncome", CashflowTotalIncome);
                crp.SetParameterValue("TotalProject", TotalCapitalExpdenditure);
                crpReportViewer.ReportSource = crp;
                CasflowPrint = false;
                this.ShowDialog();
                MyPrinter.PrintTitle = null;
            }
            catch (Exception ex)
            {
                CasflowPrint = false;
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public async void PrintCustomerReport(DataGridView cashData)
        {
            try
            { 
                await Task.Run(() => LoadReportDataAsync(cashData));
                
                MyPrinter.GetReceiptHeading();
                CRPCustomerInflow crp = new CRPCustomerInflow();
                crp.Database.Tables["Customer_report"].SetDataSource(Data);
                crpReportViewer.ReportSource = null;
                crp.SetParameterValue("Bizcontact", string.IsNullOrEmpty(MyPrinter.Contact) ? "08135258516" : MyPrinter.Contact); ///get contact and address 
                crp.SetParameterValue("Title", MyPrinter.PrintTitle);
                //crp.SetParameterValue("TotalExpense", CashflowTotalExpense);
                //crp.SetParameterValue("TotalIncome", CashflowTotalIncome);
                //crp.SetParameterValue("TotalProject", TotalCapitalExpdenditure);
                crpReportViewer.ReportSource = crp;
               // CasflowPrint = false;
                this.ShowDialog();
                MyPrinter.PrintTitle = null;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LoadReportDataAsync(DataGridView invoiceData)
        {
            Data = new DataTable();
            ds = new DataSet();

            //add more columns
            Data.Columns.AddRange(new DataColumn[6]
            {
                new DataColumn("SN", typeof(int)),
                new DataColumn("Name", typeof(string)),
                new DataColumn("Contact", typeof(string)),
                new DataColumn("Tqty", typeof(int)),
                new DataColumn("Inflow", typeof(Decimal)),
                new DataColumn("Balance", typeof(Decimal)), 
            });
            int x = 1;
            foreach (DataGridViewRow item in invoiceData.Rows)
            { 
                Data.Rows.Add(x,item.Cells["Name"].Value, item.Cells["Contact"].Value, item.Cells["Tqty"].Value, item.Cells["Inflow"].Value, item.Cells["Bal"].Value
                );
                x++;
            }

        }
        private void LoadAccountDataAsync(DataGridView cashData,List<string> headingList,bool sumheading=false)
        {
            try
            {
                Data = new DataTable();
                ds = new DataSet();
                int x = 0;
                ICashFlow cashFlow = Factory.createCashFlow();
                IInvoice invoice = Factory.CreateInvoice();
                IExpenses expense = Factory.CreateExpenses();
               
                //add more columns
                Data.Columns.AddRange(new DataColumn[3]
                {
                    new DataColumn("Category", typeof(string)),
                    new DataColumn("Description", typeof(string)),
                    new DataColumn("Expenditure", typeof(string)),
                });
                foreach (var head in headingList)
                {
                    Data.Rows.Add(ChangeLetter(x), head.ToUpper(), "");
                    foreach (DataGridViewRow item in cashData.Rows)
                    {

                        var y = expense.GetDataSearch(item.Cells["Code"].Value.ToString(),
                            item.Cells["Heading"].Value.ToString());

                        var code = "";
                        var heading = item.Cells["Heading"].Value.ToString();


                        if (sumheading)
                        {
                            if (head == y)
                            {
                                
                                    if (CodeHeadings.ContainsKey(heading))
                                    {
                                        code = CodeHeadings[heading];
                                        if (code != item.Cells["Code"].Value.ToString())
                                        {
                                            CodeHeadings.Add(heading, item.Cells["Code"].Value.ToString());
                                        }
                                    }
                                    else
                                    {
                                        CodeHeadings.Add(heading, item.Cells["Code"].Value.ToString());
                                    }


                                if (!CodeHeadingAmount.ContainsKey(heading))
                                {
                                    CodeHeadingAmount.Add(heading,Convert.ToDecimal( item.Cells["Amount"].Value));
                                }
                                else
                                {
                                    var amount =Convert.ToDecimal( CodeHeadingAmount[heading].ToString());
                                    amount+= Convert.ToDecimal(item.Cells["Amount"].Value);
                                    CodeHeadingAmount[heading] = amount;
                                }
                                
                                 
                                if (head.ToLower() == "income")
                                {
                                    CashflowTotalIncome += Convert.ToDecimal(item.Cells["Amount"].Value);
                                }
                                else if (head.ToLower() == "expenditure")
                                {
                                    CashflowTotalExpense += Convert.ToDecimal(item.Cells["Amount"].Value);
                                }
                                else
                                {
                                    TotalCapitalExpdenditure += Convert.ToDecimal(item.Cells["Amount"].Value);
                                }

                            }
                        }
                        else
                        {
                            if (head == y)
                            {
                                Data.Rows.Add(item.Cells["Code"].Value, item.Cells["Heading"].Value,
                                    item.Cells["Amount"].Value 
                                );

                                if (head.ToLower() == "income")
                                {
                                    CashflowTotalIncome += Convert.ToDecimal(item.Cells["Amount"].Value);
                                }
                                else if (head.ToLower() == "expenditure")
                                {
                                    CashflowTotalExpense += Convert.ToDecimal(item.Cells["Amount"].Value);
                                }
                                else
                                {
                                    TotalCapitalExpdenditure += Convert.ToDecimal(item.Cells["Amount"].Value);
                                }

                            }

                        }
                    }

                     

                    if (head.ToLower() == "income")
                    {
                        //add invoice data here to the table
                        //get invoice data
                        DataTable invoiceData = null;
                        if (string.IsNullOrEmpty(ViewCashFlowFrm.InvoiceDateFrom) &&
                            string.IsNullOrEmpty(ViewCashFlowFrm.InvoiceDateTo))
                        {
                            invoiceData = invoice.Display("");

                        }
                        else if (!string.IsNullOrEmpty(ViewCashFlowFrm.InvoiceDateFrom) &&
                                 string.IsNullOrEmpty(ViewCashFlowFrm.InvoiceDateTo))
                        {
                            var from = Convert.ToDateTime(ViewCashFlowFrm.InvoiceDateFrom);
                            invoiceData = invoice.Display(from);
                        }
                        else if (!string.IsNullOrEmpty(ViewCashFlowFrm.InvoiceDateFrom) &&
                                 !string.IsNullOrEmpty(ViewCashFlowFrm.InvoiceDateTo))
                        {
                            var from = Convert.ToDateTime(ViewCashFlowFrm.InvoiceDateFrom);
                            var to = Convert.ToDateTime(ViewCashFlowFrm.InvoiceDateTo);
                            invoiceData = invoice.Display(from, to);
                        }

                        addinvoiceData(invoiceData, Data,sumheading);
                         
                    }
                    else if (head.ToLower() == "expenditure")
                    {
                        Data.Rows.Add(" ", " ", CashflowTotalExpense.ToString("N"));
                    }
                    else if (head.ToLower() == "capital project")
                    {
                        Data.Rows.Add(" ", " ", TotalCapitalExpdenditure.ToString("N"));
                    }

                    //insert record into datatable
                    if (sumheading)
                    {
                        if (CodeHeadingAmount.Count > 0)
                        {
                            foreach (var record in CodeHeadings)
                            {
                                Data.Rows.Add(record.Value, record.Key, CodeHeadingAmount[record.Key].ToString("N"));
                            }
                            Data.Rows.Add(" ", " ", CashflowTotalIncome.ToString("N"));
                            CodeHeadings.Clear();
                            CodeHeadingAmount.Clear();
                        }
                    }
                    x++;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        void addinvoiceData(DataTable invoiceData, DataTable table,bool sumtotal)
        {
            if (invoiceData.Rows.Count > 0)
            {
                IInvoice invoice = Factory.CreateInvoice();
                foreach (DataRow row in invoiceData.Rows)
                {
                    var headInfor = invoice.GetHeadingInfor(row["InvoiceID"].ToString());
                    var Firstcode = "";
                    var Othercode = "";
                    var heading = "";
                    var Otherheading = "";
                    var desc = "";
                    if (headInfor.Rows.Count > 1)
                    {
                        int x = 0;
                        foreach (DataRow head in headInfor.Rows)
                        {
                            if (x > 0)
                            {
                                Othercode += string.Format("{0} ", head["Code"].ToString());
                                Otherheading += string.Format("& {0} ", head["Heading"].ToString());
                                desc += string.Format("{0} ", head["Category"].ToString());
                            }
                            else
                            {
                                Firstcode = head["Code"].ToString();
                                heading = head["Heading"].ToString();
                                desc = head["Category"].ToString();
                            }

                            x++;
                        }
                    }
                    else
                    {
                        foreach (DataRow head in headInfor.Rows)
                        {
                            Firstcode = head["Code"].ToString();
                            heading = head["Heading"].ToString();
                            desc = head["Category"].ToString();
                            break;

                        }
                    }
                     
                    var invoiceTotal = Convert.ToDecimal(row["Cash"].ToString()) +
                                       Convert.ToDecimal(row["To_bank"].ToString());
                   
                    //add data to the table
                    var insertedother = string.IsNullOrEmpty(Otherheading) ? desc : Otherheading.ToLower();
                    var currentHeading = string.Concat(heading, " ", Otherheading);
                    var currentCode = string.Concat(Firstcode, " ", Othercode);
                    if (sumtotal)
                    {
                        if (CodeHeadings.ContainsKey(currentHeading))
                        {
                            var code = CodeHeadings[currentHeading];
                            if (code != currentCode)
                            {
                                CodeHeadings.Add(currentHeading, currentCode);
                            }
                        }
                        else
                        {
                            CodeHeadings.Add(currentHeading, currentCode);
                        }

                        if (!CodeHeadingAmount.ContainsKey(currentHeading))
                        {
                            CodeHeadingAmount.Add(currentHeading, invoiceTotal);
                        }
                        else
                        {
                            var amount = Convert.ToDecimal(CodeHeadingAmount[currentHeading].ToString());
                            amount += invoiceTotal;
                            CodeHeadingAmount[currentHeading] = amount;
                        }
                    }
                    else
                    {
                        table.Rows.Add(string.Concat(Firstcode, " ", Othercode), string.Concat(heading, " ", Otherheading), invoiceTotal.ToString("N")
                        );
                    }
                      
                    CashflowTotalIncome += invoiceTotal;
                }
            }
        }

        private string ChangeLetter(int x)
        {
            if (x == 0)
                return "A";
            if (x == 1)
                return "B";
            if (x == 2)
                return "C";
            if (x == 3)
                return "D";
            if (x == 4)
                return "E";
            if (x == 5)
                return "F";
            if (x == 6)
                return "G";
            if (x == 7)
                return "H";
            return "I";
        }

        public async void PrintItemsReport(DataGridView itemData)
        {
            try
            {
                ItemsProcessing = true;
                await Task.Run(() => LoadItemDataAsync(itemData));

                MyPrinter.GetReceiptHeading();
                CRPInvoiceItems crp = new CRPInvoiceItems();
                crp.Database.Tables["Invoice_items"].SetDataSource(Data);
                crpReportViewer.ReportSource = null;
                crp.SetParameterValue("Bizcontact", string.IsNullOrEmpty(MyPrinter.Contact) ? "08135258516" : MyPrinter.Contact); ///get contact and address 
                crp.SetParameterValue("Title", MyPrinter.PrintTitle);
                crp.SetParameterValue("EstimatedCost", TotalItemEstematedCost);
                //crp.SetParameterValue("TotalIncome", CashflowTotalIncome);
                //crp.SetParameterValue("TotalProject", TotalCapitalExpdenditure);
                crpReportViewer.ReportSource = crp;
                
                ItemsProcessing = false;
                this.ShowDialog();
                MyPrinter.PrintTitle = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadItemDataAsync(DataGridView itemData)
        {
            List<string> invoiceIdList = new List<string>();
                 Data = new DataTable();
                ds = new DataSet();

                //add more columns
                Data.Columns.AddRange(new DataColumn[5]
                {
                    new DataColumn("ID", typeof(string)),
                    new DataColumn("Description", typeof(string)),
                    new DataColumn("Qty", typeof(int)), 
                    new DataColumn("Cost", typeof(Decimal)),
                    new DataColumn("Date", typeof(string)),
                });
                int x = 1;
                foreach (DataGridViewRow item in itemData.Rows)
                {
                    var id = item.Cells["InvoiceID"].Value.ToString();
                    DateTime date =Convert.ToDateTime( item.Cells["Date"].Value);
                    Data.Rows.Add(id, item.Cells["Description"].Value, item.Cells["Qty"].Value, item.Cells["Cost"].Value, date.Date.ToShortDateString()
                    );
                    if(!invoiceIdList.Contains(id))
                        invoiceIdList.Add(id);
                    
                }

                foreach (var id in invoiceIdList)
                {
                //get the total amount paid
                TotalItemEstematedCost += Job.InvoiceTotal(id);
                //add value to TotalItemExtematedCost
                var desc = string.Format("{0} #{1}", "Received debt payment for invoice", id);
                //get the debt paid as well
                //add value to TotalItemExtematedCost
                TotalItemEstematedCost += Job.TotalDebtPaid(desc.ToLower().Trim());
                }
        }
    }
}
