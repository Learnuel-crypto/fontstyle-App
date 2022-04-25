using System;
using System.Collections.Generic;
using System.Data;

namespace PrintingPress.Models.Job
{
    public interface IInvoice
    {
        string InvoicID { get; set; }

        /// <summary>
        /// total number of items in the invoice
        /// </summary>
        int Qty { get; set; }

        Decimal Total { get; set; }
        Decimal Paid { get; set; }
        string Method { get; set; }
        
        /// <summary>
        /// Balance left
        /// </summary>
        Decimal Balance { get; set; }

        /// <summary>
        /// Invoice date
        /// </summary>
        DateTime Date { get; set; }
 
    
        string ToDateTime(DateTime date);
        string Heading { get; set; }
        string Code { get; set; }
        string OtherPayment { get; set; }
        /// <summary>
        /// Transfered amount
        /// </summary>
        Decimal OtherPaymentAmount { get; set; }

        /// <summary>
        /// Make cash sale
        /// </summary>
        /// <param name="cart"></param>
        void Save(List<IJob> jobList, ICustomer customer);

        DataTable Display(string search);
        DataTable DisplayInvoiceByCode(string search);
        DataTable DisplayInvoiceByCategory(string search);
        DataTable Display(DateTime date);
        DataTable Display(DateTime datefrom, DateTime dateto);
        DataTable DisplayInvoiceItem(string invoiceid);
        DataTable DisplayInvoiceCustomer(string invoiceid);
        /// <summary>
        /// delete invoice
        /// </summary>
        void Delete();
        /// <summary>
        /// Delete customer invoice by auto id
        /// </summary>
        /// <param name="id"></param>
      void  Delete(string id);

        DataTable DisplayByCustomer(string search);
        /// <summary>
        /// Get customer debt
        /// </summary>
        /// <param name="search">customer id</param>
        /// <returns></returns>
        DataTable DisplayCustomerDebt(string search);
        /// <summary>
        /// Get invoice headingInfor for printing
        /// </summary>
        /// <param name="invoiceid"></param>
        /// <returns></returns>
        DataTable GetHeadingInfor(string invoiceid);
        DataTable DisplayByCustomer(string cusID, DateTime value);
        DataTable DisplayByCustomer(string cusID, DateTime value, DateTime dateto);
    }
}