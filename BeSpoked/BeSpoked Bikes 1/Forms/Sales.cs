using BeSpoked_Bikes_1.Helpers;
using BeSpoked_Bikes_1.Repository;
using System;
using System.Data;
using System.Windows.Forms;

namespace BeSpoked_Bikes_1
{
    public partial class Sales : Form
    {
        private readonly ISalesRepository salesRepository;

        public Sales(ISalesRepository salesRepository)
        {
            this.salesRepository = salesRepository;
            InitializeComponent();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            FormHelper.GoToNextForm(this, new HomePage());
        }

        private void salesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beSpokedDataSet);
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            this.salesTableAdapter.Fill(this.beSpokedDataSet.Sales);
            this.salesDataGridView.DataSource = salesRepository.GetSalesViewData();

            DataGridViewHelper.SetDataGridViewProperties(salesDataGridView, true);
        }

        private void FilterDateRangeButton_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date;

            DataTable dataTable = salesRepository.GetSalesViewData();
            DataView dv = new DataView(dataTable);

            dv.RowFilter = String.Format("SalesDate >= #{0:MM/dd/yyyy}# AND SalesDate <= #{1:MM/dd/yyyy}#", startDate, endDate);

            salesDataGridView.DataSource = dv;
        }
    }
}
