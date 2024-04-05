namespace Factory_method
{
    public class ManagerCall : PurchaseMethod
    {
        public override void Purchase(Subscription subscription)
        {
            Console.WriteLine($"Payment for a subscription through the ManagerCall system for the following subscription:");
            subscription.DisplayDetails();

            Console.WriteLine("Please enter your payment details (credit card number, expiry date, etc.):");
            string creditCardNumber = Console.ReadLine();



            Console.WriteLine("Enter the amount you are willing to spend on the purchase:");
            decimal enteredAmount = Convert.ToDecimal(Console.ReadLine());



            if (enteredAmount < subscription.MonthlyFee * subscription.MinimumSubscriptionPeriod)
            {
                Console.WriteLine("Error: Entered amount doesn't match subscription fee.");
                return;
            }
            else
            {
                Console.WriteLine("Payment confirmed! Subscription successfully purchased through the ManagerCall.\n");
                Console.WriteLine($"The remaining funds were returned:{enteredAmount - subscription.MonthlyFee * subscription.MinimumSubscriptionPeriod}USD to a card - {creditCardNumber}");
            }
        }


    }
}
