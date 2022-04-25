using System.Windows.Forms;

namespace PrintingPress.Models.Helper
{
    public interface IArithmetic
    {
        decimal TotalGridColumn(DataGridView dataGrid, string cell);
    }
}