using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace BeSpoked_Bikes_1.Repository
{
    public class SalesRepository : ISalesRepository
    {
        private const String ConnectionString = "Data Source=DESKTOP-VU2T0RJ\\SQLEXPRESS;Initial Catalog=BeSpoked;Integrated Security=True";
        private const String SalesDataProc = "dbo.GetSalesData";
        private DataTable _salesViewDataTable;

        public DataTable SalesViewDataTable
        {
            get
            {
                if (_salesViewDataTable == null)
                {
                    _salesViewDataTable = this.GetSalesViewData();
                }
                return _salesViewDataTable;
            }
        }

        /// <summary>
        /// Populate a bug summary data row
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="row"></param>
        internal static void PopulateBugSummaryDataRow(SqlDataReader reader, DataRow row)
        {
            row["Product Name"] = GetString(reader, "Product Name");
            row["Customer First Name"] = GetString(reader, "Customer First Name");
            row["Customer Last Name"] = GetString(reader, "Customer Last Name");
            row["SalesDate"] = GetString(reader, "Sales Date");
            row["Sasles Price"] = GetString(reader, "Sasles Price");
            row["Sales Person First Name"] = GetString(reader, "Salesperson First Name");
            row["Sales Person Last Name"] = GetString(reader, "Salesperson Last Name");
            row["Discount Percentage"] = GetString(reader, "Discount Percentage");
        }

        public DataTable GetFilteredDataTableByDates(DateTimePicker startDate, DateTimePicker endDate)
        {
            var dataList = SalesViewDataTable.AsEnumerable();

            //if (!String.IsNullOrWhiteSpace(startDate.ToString()))
            //{
            //    dataList = dataList.Where(row => row.Field<DateTimePicker>("Sales Date") >= startDate);
            //}

            if (!dataList.Any())
            {
                return CreateTable();
            }

            return dataList.CopyToDataTable();
        }

        private static DataTable CreateTable()
        {
            var table = new DataTable();

            table.Columns.Add("Product Name");
            table.Columns.Add("Customer First Name");
            table.Columns.Add("Customer Last Name");
            table.Columns.Add("SalesDate");
            table.Columns.Add("Sasles Price");
            table.Columns.Add("Sales Person First Name");
            table.Columns.Add("Sales Person Last Name");
            table.Columns.Add("Commission Percentage");
            table.Columns.Add("Discount Percentage");

            return table;
        }

        public DataTable GetSalesViewData()
        {
            var dataTable = CreateTable();

            using (var connection = new SqlConnection(ConnectionString))
            {
                using (var command = new SqlCommand(SalesDataProc, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var row = dataTable.NewRow();
                        PopulateBugSummaryDataRow(reader, row);

                        dataTable.Rows.Add(row);
                    }
                }
            }

            return dataTable;
        }

        /// <summary>
        /// Get the string representation value from a sql data reader
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private static String GetString(SqlDataReader reader, String key)
        {
            if (reader[key] is DBNull)
            {
                return null;
            }

            return reader[key].ToString();
        }
    }
}
