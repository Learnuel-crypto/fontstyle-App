using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Modification.Models.Helper
{
    /// <summary>
    /// handle all logic for datagridview design
    /// </summary>
    static class DataGridStyle
    {

        private static int fontSize;

        public static int FontSize
        {
            get
            {

                if (fontSize == 0)
                    FontSize = 10;
                return fontSize;
            }
            set
            {

                fontSize = value;
            }
        }

        public static int SetFontSize(string size="10")
        {
            return FontSize= Int32.Parse(size);
        }
        /// <summary>
        /// Style DataGridView
        /// </summary>
        /// <param name="dgv"></param>
        public static void StyleDatagridview(DataGridView dgv)

        {
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv.BackgroundColor = Color.White;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.Font = new Font("Segoe UI", FontSize, FontStyle.Regular);
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersWidth = 20;

        }

        /// <summary>
        /// Fixed size display
        /// </summary>
        /// <param name="dgv"></param>
        public static void StyleDatagridviewFixed(DataGridView dgv)

        {
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv.BackgroundColor = Color.White;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.Font = new Font("Segoe UI", FontSize, FontStyle.Regular);
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public static void StyleDatagridviewLedger(DataGridView dgv)

        {
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.BackgroundColor = Color.White;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.Font = new Font("Segoe UI", FontSize, FontStyle.Regular);
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        /// <summary>
        /// Change the row color of the datagridview
        /// </summary>
        /// <param name="dgv"></param>
        public static void StyleRowColor(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells["Status"].Value.ToString().ToLower() == "not cleared")
                {
                    // row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }

                if (row.Cells["Status"].Value.ToString().ToLower() == "cleared")
                {
                    //row.DefaultCellStyle.BackColor = Color.Blue;
                    row.DefaultCellStyle.ForeColor = Color.Green;
                }

            }
        }
        /// <summary>
        /// Change the forecolor of legder gridview
        /// </summary>
        /// <param name="dgv"></param>
        public static void StyleLedgerColumnColor(DataGridView dgv)
        {
            foreach (DataGridViewRow Row in dgv.Rows)
            {
                Row.Cells[2].Style.ForeColor = Color.Red;
                Row.Cells[3].Style.ForeColor = Color.Blue;

            }
        }
        /// <summary>
        /// User Material design for dataGridView
        /// </summary>
        /// <param name="dgv"></param>
        public static void StyleDatagridMaterial(DataGridView dgv)

        {
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.DefaultCellStyle.SelectionBackColor = Color.ForestGreen;//     Color.DarkTurquoise;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.BorderStyle = BorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 70);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
            dgv.Font = new Font("Segoe UI", FontSize, FontStyle.Regular);
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           // dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

    }
}
