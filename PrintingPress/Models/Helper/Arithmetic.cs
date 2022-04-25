using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintingPress.Models.Helper
{
  public  class Arithmetic : IArithmetic
    {

        /// <summary>
        /// Get total of a datagridview
        /// </summary>
        /// <param name="dataGrid">Datagrideview</param>
        /// <param name="cell">Cell to sum</param>
        /// <returns></returns>
      public  Decimal TotalGridColumn(DataGridView dataGrid, string cell)
        {
            try
            {

           
            var total = 0.00m;
            if (dataGrid.RowCount > 0)
            {
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    total += Convert.ToDecimal(row.Cells[cell].Value.ToString());
                }
            }

            return total;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
