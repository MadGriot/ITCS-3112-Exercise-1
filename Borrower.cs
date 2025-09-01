
namespace ITCS_3112_Exercise_1
{
    public class Borrower : ICheckoutService
    {
        public int ID;
        public string name;
        public string email;

        public Reciept Checkout(Repository repository, CheckoutRecord checkoutRecord)
        {
            throw new NotImplementedException();
        }
    }
}
