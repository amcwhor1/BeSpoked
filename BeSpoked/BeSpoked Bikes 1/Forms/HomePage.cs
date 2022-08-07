using BeSpoked_Bikes_1.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeSpoked_Bikes_1
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void SalesPersonnelButton_Click(object sender, System.EventArgs e)
        {
            FormHelper.GoToNextForm(this, new SalesPersonnel());
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            FormHelper.GoToNextForm(this, new Products());
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            FormHelper.GoToNextForm(this, new Customers());
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            FormHelper.GoToNextForm(this, new Sales(new SalesRepository()));
        }
    }
}
