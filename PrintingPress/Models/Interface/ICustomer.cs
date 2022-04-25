using System;
using System.Data;

namespace PrintingPress.Models.Job
{
    public interface ICustomer
    {
        string CusID { get; set; }

        /// <summary>
        /// Customer fullname
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Customer contact
        /// </summary>
        string Contact { get; set; }

        /// <summary>
        /// Get customer's contact
        /// </summary>
        /// <returns></returns>
        string GetContact();

        /// <summary>
        /// Check if customer exist
        /// </summary>
        /// <returns></returns>
        string CustomerExist(string name);

        DataTable DisplayCustomers(string search);
        DataTable GetCustomersNames(string search);
        DataTable GetCustomerReport(string search);
        DataTable GetCustomerReportByDate(DateTime datefrom, DateTime dateto);
       DataTable GetCustomerReportByDate(DateTime datefrom);
        /// <summary>
        /// Register Customer
        /// </summary>
        void Add();

        /// <summary>
        /// Delete customer
        /// </summary>
        void Delete();

       bool CustomerNumberExist();
       /// <summary>
       /// update customer details
       /// </summary>
       void Update();
    }
}