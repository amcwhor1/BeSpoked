using System.Data;
using System.Windows.Forms;

namespace BeSpoked_Bikes_1.Repository
{
    public interface ISalesRepository
    {
        DataTable GetSalesViewData();

    }
}