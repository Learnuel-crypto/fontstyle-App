using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using PrintingPress.Models.Job;
using WindowsFormsApplication1;
using PrintingPress.Models.Staff_mgt;
using System.Threading.Tasks;

namespace PrintingPress.API.Reports.Invoice_receipt
{
    public partial class CRInvoiceFrm : Form
    {
        private DataTable invoiceData;
        private DataSet ds;
        /// <summary>
        /// Invoice receitp printing
        /// </summary>
        internal static  bool loadingInvoiceReceipt;
        /// <summary>
        /// printing of debtpayment receipt
        /// </summary>
        internal static  bool loadingDebtReceipt;
        /// <summary>
        /// Reprinting of debtpayment receipt
        /// </summary>
        internal static  bool loadingReprintDebtReceipt;
        public CRInvoiceFrm()
        {
            InitializeComponent();
            loadingInvoiceReceipt = true;
        }

        private void LoadReprintReceipt(IInvoice invoice)
        {
            invoiceData = new DataTable();
            ds = new DataSet();
            IInvoice Invoice = Factory.CreateInvoice();
            //add more columns
            invoiceData.Columns.AddRange(new DataColumn[3]
            {
                new DataColumn("Qty", typeof(Int16)),
                new DataColumn("Description", typeof(string)),
                new DataColumn("Amount", typeof(Decimal)),
            });
            DataTable data = Invoice.DisplayInvoiceItem(invoice.InvoicID);
            foreach (DataRow item in data.Rows)
            {
                invoiceData.Rows.Add(item["Pieces"], item["Description"], item["Cost"]);
            }
        }
        /// <summary>
        /// Reprint existing invoice receipt
        /// </summary>
        /// <param name="invoice"></param>
        public async void ReprintReceipt(IInvoice invoice)
        { 
            await Task.Run(()=>LoadReprintReceipt(invoice));
            IInvoice Invoice = Factory.CreateInvoice();
            var customerDetails = Invoice.DisplayInvoiceCustomer(invoice.InvoicID).Rows[0];
            MyPrinter.GetReceiptHeading();
            var barcodePath = BarCodeGen.QRcode(string.Format("FONTSTYLE INTERATED SOLUTION BN2700619 #{0} |Pr!nt press", invoice.InvoicID));
            CRInvoice crp = new CRInvoice();
            crp.Database.Tables["Invoice_receipt"].SetDataSource(invoiceData);
            CRPInvoiceViewer.ReportSource = null;
            crp.SetParameterValue("InvoiceID", invoice.InvoicID);
            crp.SetParameterValue("Name", customerDetails["Name"]);
            crp.SetParameterValue("Contact", customerDetails["Contact"]);
            crp.SetParameterValue("Type", invoice.Method);
            crp.SetParameterValue("Paid", invoice.Paid);
            crp.SetParameterValue("BarcodePath", barcodePath);
            crp.SetParameterValue("Bizcontact", string.IsNullOrEmpty(MyPrinter.Contact) ? "08135258516" : MyPrinter.Contact);///get contact and address
            invoice.OtherPayment ="";
            if (invoice.Method.ToLower() != "cash")
                invoice.OtherPayment = invoice.Method;
            if (invoice.Method.Contains("&"))
                invoice.OtherPayment = invoice.Method.Substring(invoice.Method.IndexOf("&") + 1);

            crp.SetParameterValue("Other", string.IsNullOrEmpty(invoice.OtherPayment) ? " " : invoice.OtherPayment + "(N):");
            crp.SetParameterValue("OtherAmount", invoice.OtherPaymentAmount);
            crp.SetParameterValue("Cashier", Users.LoggedinUsername);
            var date = invoice.Date.ToString("dd/MM/yyyy");
            crp.SetParameterValue("TranDate", date);
            crp.SetParameterValue("Address", string.IsNullOrEmpty(MyPrinter.Address) ? "Fontstyle integrated solution" : MyPrinter.Address);
            CRPInvoiceViewer.ReportSource = crp;
            loadingInvoiceReceipt = false;
            this.ShowDialog();
        }
        /// <summary>
        /// Print Receipt
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="items"></param>
        /// <param name="invoice"></param>
        public void PrintReceipt(ICustomer customer,List<IJob> items,IInvoice invoice)
        {
            invoiceData = new DataTable();
            ds = new DataSet();
         
            //add more columns
            invoiceData.Columns.AddRange(new DataColumn[3]
                {
                    new DataColumn("Qty", typeof(Int16)),
                    new DataColumn("Description", typeof(string)), 
                    new DataColumn("Amount", typeof(Decimal)), 
                });
                foreach (var item in items)
                {
                    invoiceData.Rows.Add(item.Qty,item.Desc,item.Cost
                    ); 
                }
                MyPrinter.GetReceiptHeading();
              var barcodePath=  BarCodeGen.QRcode(string.Format("FONTSTYLE INTERATED SOLUTION BN2700619 #{0} |Pr!nt press", invoice.InvoicID));
            CRInvoice crp = new CRInvoice();
            crp.Database.Tables["Invoice_receipt"].SetDataSource(invoiceData);
            CRPInvoiceViewer.ReportSource = null;
             crp.SetParameterValue("InvoiceID",invoice.InvoicID);
             crp.SetParameterValue("Name",customer.Name);
             crp.SetParameterValue("Contact",customer.Contact);
             crp.SetParameterValue("Type",invoice.Method);
             crp.SetParameterValue("Paid",invoice.Paid);
             crp.SetParameterValue("BarcodePath", barcodePath);
             crp.SetParameterValue("Bizcontact",string.IsNullOrEmpty(MyPrinter.Contact)?"08135258516":MyPrinter.Contact);///get contact and address
             crp.SetParameterValue("Other", string.IsNullOrEmpty(invoice.OtherPayment)?" ":invoice.OtherPayment+"(N)");
             crp.SetParameterValue("OtherAmount", invoice.OtherPaymentAmount); 
             crp.SetParameterValue("Cashier", Users.LoggedinUsername);
             var date = invoice.Date.ToString("dd/MM/yyyy");
             crp.SetParameterValue("TranDate",date ); 
             crp.SetParameterValue("Address",string.IsNullOrEmpty(MyPrinter.Address)?"Fontstyle integrated solution":MyPrinter.Address); 
            CRPInvoiceViewer.ReportSource = crp;
            loadingInvoiceReceipt = false;
            this.ShowDialog();
        }
        /// <summary>
        /// Reprint debt payment receipt
        /// </summary>
        /// <param name="invoice"></param>
        public void DebtReceipt(IInvoice invoice,ICashFlow cashFlowDetails)
        {
           
            ICashFlow cashFlow = Factory.createCashFlow();
            MyPrinter.GetReceiptHeading();
            var barcodePath = BarCodeGen.QRcode(string.Format("FONTSTYLE INTERATED SOLUTION BN2700619 #{0} |Reprint|Pr!nt press", invoice.InvoicID));
            CRDebtInvoice crp = new CRDebtInvoice();
            IInvoice debtInvoice = Factory.CreateInvoice();
            var DataRow = debtInvoice.DisplayInvoiceCustomer(invoice.InvoicID).Rows[0];
            var invoiceDetails = cashFlow.GetDebtReceiptDetails(cashFlowDetails).Rows[0];
            var netBalance = Convert.ToDecimal(invoiceDetails["NetDebt"].ToString());
                              

            CRPInvoiceViewer.ReportSource = null;
            crp.SetParameterValue("Name", DataRow["Name"].ToString());
            crp.SetParameterValue("Contact", DataRow["Contact"].ToString());
            crp.SetParameterValue("Type", invoice.Method);
            crp.SetParameterValue("Paid", invoice.Paid);
            crp.SetParameterValue("BarcodePath", barcodePath);
            crp.SetParameterValue("Bizcontact", string.IsNullOrEmpty(MyPrinter.Contact) ? "08135258516" : MyPrinter.Contact);///get contact and address
            crp.SetParameterValue("Other", invoice.Method + "(N):");

            crp.SetParameterValue("Cashier", Users.LoggedinUsername);
            var date =Convert.ToDateTime(invoiceDetails["Date"].ToString());
            crp.SetParameterValue("TranDate", date.ToString("dd/MM/yyyy"));
            crp.SetParameterValue("Paydate", invoice.Date.ToString("dd/MM/yyyy"));
            crp.SetParameterValue("Netbal", netBalance);
            crp.SetParameterValue("Address", string.IsNullOrEmpty(MyPrinter.Address) ? "Fontstyle integrated solution" : MyPrinter.Address);
            CRPInvoiceViewer.ReportSource = crp;
            loadingReprintDebtReceipt = false;
            this.ShowDialog();
        }
        /// <summary>
        /// Print debt payment receipt
        /// </summary>
        /// <param name="invoice"></param>
        /// <param name="customer"></param>
        /// <param name="netBalance"></param>
        /// <param name="paydate"></param>
        public   async void DebtReceipt(IInvoice invoice,ICustomer customer,string netBalance, DateTime paydate)
        {
            await Task.Run(() => LoadDebtReceiptAsync(invoice, customer, netBalance, paydate));
            var barcodePath = BarCodeGen.QRcode(string.Format("FONTSTYLE INTERATED SOLUTION BN2700619 #{0} | Pr!nt press", invoice.InvoicID));
            CRDebtInvoice crp = new CRDebtInvoice();
            CRPInvoiceViewer.ReportSource = null;
            crp.SetParameterValue("Name", customer.Name);
            crp.SetParameterValue("Contact", customer.Contact);
            crp.SetParameterValue("Type", invoice.Method);
            crp.SetParameterValue("Paid", invoice.Paid);
            crp.SetParameterValue("BarcodePath", barcodePath);
            crp.SetParameterValue("Bizcontact", string.IsNullOrEmpty(MyPrinter.Contact) ? "08135258516" : MyPrinter.Contact);///get contact and address
            crp.SetParameterValue("Other", invoice.Method + "(N):");

            crp.SetParameterValue("Cashier", Users.LoggedinUsername);
            var date = invoice.Date.ToString("dd/MM/yyyy");
            crp.SetParameterValue("TranDate", date);
            crp.SetParameterValue("Paydate", paydate.ToString("dd/MM/yyyy"));
            crp.SetParameterValue("Netbal", netBalance);
            crp.SetParameterValue("Address", string.IsNullOrEmpty(MyPrinter.Address) ? "Fontstyle integrated solution" : MyPrinter.Address);
            CRPInvoiceViewer.ReportSource = crp;
            loadingDebtReceipt = false;
            this.ShowDialog();
        }

        private void LoadDebtReceiptAsync(IInvoice invoice, ICustomer customer, string netBalance, DateTime paydate)
        {
            MyPrinter.GetReceiptHeading();
           
        }
        private void linkClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void linkClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
