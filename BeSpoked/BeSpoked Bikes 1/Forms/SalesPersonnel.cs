using BeSpoked_Bikes_1.Helpers;
using System;
using System.Windows.Forms;

namespace BeSpoked_Bikes_1
{
    public partial class SalesPersonnel : Form
    {
        public SalesPersonnel()
        {
            InitializeComponent();
        }

        private void salesPersonBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salesPersonBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beSpokedDataSet);

        }

        private void SalesPersonnel_Load(object sender, EventArgs e)
        {
            this.salesPersonTableAdapter.Fill(this.beSpokedDataSet.SalesPerson);
            DataGridViewHelper.SetDataGridViewProperties(this.salesPersonDataGridView, false);
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            FormHelper.GoToNextForm(this, new HomePage());
        }


        private void CommissionReportButton_Click(object sender, EventArgs e)
        {
            FormHelper.GoToNextForm(this, new CommissionReport());
        }
    }
}
