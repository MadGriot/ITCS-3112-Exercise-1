using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCS_3112_Exercise_1
{
    internal interface ICatalog
    {
        void GetPolicy(Item item);
        List<CheckoutRecord> RetrieveRecords(Repository repository, CheckoutRecord checkoutRecord);
    }
}
