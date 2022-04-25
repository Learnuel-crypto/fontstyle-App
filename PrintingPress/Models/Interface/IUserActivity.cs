using System;
using System.Data;

namespace ChucksMedicare.Model
{
    public interface IUserActivity
    {
        /// <summary>
        /// Methods are not connect to the table
        /// </summary>
        /// <param name="description"></param>
        string Description { get; set; }

        /// <summary>
        /// Record user activity
        /// </summary>
        void RecordActivity();

        /// <summary>
        /// Search activity by date
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        DataTable SearchByDate(DateTime date);

        /// <summary>
        /// Seach user acctivity
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        DataTable DisplayUserLog(string search);

        /// <summary>
        /// Search user activity between dates
        /// </summary>
        /// <param name="datefrom"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        DataTable SearchBetweenDates(DateTime datefrom, DateTime to);
    }
}