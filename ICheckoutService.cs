using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCS_3112_Exercise_1
{
    public interface ICheckoutService
    {
        CheckoutRecord Checkout(Repository repository);
    }
}
