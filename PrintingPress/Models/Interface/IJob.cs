using System;
using System.Data;

namespace PrintingPress.Models.Job
{
    public interface IJob
    {
        int JobID { get; set; }

        /// <summary>
        /// Job category
        /// </summary>
        string Category { get; set; }

        /// <summary>
        /// Job description
        /// </summary>
        string Desc { get; set; }
        string Heading { get; set; }
        string Code { get; set; }

        int Qty { get; set; }
        Decimal Cost { get; set; }
        DataTable Search(string searchText);
        DataTable Search(DateTime datefrom);
        DataTable Search(DateTime datefrom, DateTime dateto);
    }
}