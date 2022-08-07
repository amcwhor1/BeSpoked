using System;
using System.Windows.Forms;

namespace BeSpoked_Bikes_1.Helpers
{
    internal static class DataGridViewHelper
    {
        internal static void SetDataGridViewProperties(DataGridView dataGridView, Boolean isReadOnly) 
        {
            //hide identity column
            dataGridView.Columns[0].Visible = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.RowHeadersVisible = false;
            dataGridView.ReadOnly = isReadOnly;

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
