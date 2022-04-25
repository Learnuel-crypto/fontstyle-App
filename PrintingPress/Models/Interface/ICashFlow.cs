using System;
using System.Data;

namespace PrintingPress.Models.Job
{
    public interface ICashFlow
    {
        DataTable Display(DateTime date);
        DataTable Display(DateTime datefrom, DateTime dateto);
        DataTable DisplayInvoiceItem(string invoiceid);
        string CashID { get; set; }
        void Delete(string cashcode);
        DataTable Search(string search);
        DataTable SearchByHeading(string heading);
        string Description { get; set; }
        DataTable GetDebtReceiptDetails(ICashFlow details);
        DataTable GetCodeStatus(string code);
    }
}