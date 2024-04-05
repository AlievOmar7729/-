namespace Factory_method
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription() : base(20, 5, new List<string> { "PremiumTV", "Sports", "Film364", "Entertainment24/7" }) { }

        public override void DisplayDetails()
        {
            Console.WriteLine("Premium Subscription Details:");
            Console.WriteLine($"Monthly Fee: {MonthlyFee}");
            Console.WriteLine($"Minimum Subscription Period: {MinimumSubscriptionPeriod} month(s)");
            Console.WriteLine($"Channels:");
            foreach (var channel in IncludedChannels)
            {
                Console.WriteLine($"    -- {channel}");
            }
        }
    }
}
