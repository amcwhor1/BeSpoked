using BeSpoked_Bikes_1.Helpers;
using System;
using System.Windows.Forms;

namespace BeSpoked_Bikes_1
{
    public partial class Products : Form
    {
        /// <summary>
        /// Instantiate this form
        /// </summary>
        public Products()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load Product form and grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Products_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.beSpokedDataSet.Products);

            DataGridViewHelper.SetDataGridViewProperties(this.productsDataGridView, false);
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.beSpokedDataSet);
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            FormHelper.GoToNextForm(this, new HomePage());
        }
    }
}
