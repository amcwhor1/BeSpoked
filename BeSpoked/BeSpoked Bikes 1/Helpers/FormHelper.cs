using System.Windows.Forms;

namespace BeSpoked_Bikes_1
{
    internal class FormHelper
    {
        internal static void GoToNextForm(Form currentForm, Form nextForm)
        {
            currentForm.Hide();
            nextForm.Show();
        }
    }
}