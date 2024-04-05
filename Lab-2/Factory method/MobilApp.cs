namespace Factory_method
{
    public class MobilApp : PurchaseMethod
    {
        public override void Purchase(Subscription subscription)
        {
            Console.WriteLine($"Payment for a subscription through the MobilApp system for the following subscription:");
            subscription.DisplayDetails();

            Console.WriteLine("Please enter your payment details (credit card number, expiry date, etc.):");
            string creditCardNumber = Console.ReadLine();



            Console.WriteLine("Please enter the subscription fee:");
            decimal enteredAmount = Convert.ToDecimal(Console.ReadLine());



            if (enteredAmount < subscription.MonthlyFee * subscription.MinimumSubscriptionPeriod)
            {
                Console.WriteLine("Error: Entered amount doesn't match subscription fee.");
                return;
            }
            else
            {
                Console.WriteLine("Payment confirmed! Subscription successfully purchased through the MobilApp.\n");
                Console.WriteLine($"The remaining funds were returned:{enteredAmount - subscription.MonthlyFee * subscription.MinimumSubscriptionPeriod} to a card - {creditCardNumber}");
            }




        }
    }
}
