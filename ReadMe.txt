1. The borrower class checkouts an Item using ICheckoutService Interface
2. The Checkout method creates a CheckoutRecord and saves it a repository.
3. The repository has a INotifier Interface that Alerts due dates and prints them if needed
4.  The ICatalog Interface can RetrieveRecords and can Get the Policy of an Item
