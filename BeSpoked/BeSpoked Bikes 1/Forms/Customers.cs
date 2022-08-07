using BeSpoked_Bikes_1.Helpers;
using System;
using System.Windows.Forms;

namespace BeSpoked_Bikes_1
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beSpokedDataSet);
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            this.customerTableAdapter.Fill(this.beSpokedDataSet.Customer);

            DataGridViewHelper.SetDataGridViewProperties(this.customerDataGridView, true);
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            FormHelper.GoToNextForm(this, new HomePage());
        }
    }
}
