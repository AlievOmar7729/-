namespace Factory_method
{
    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription() : base(5, 1, new List<string> { "News", "Comedy 1", "Animal world" }) { }

        public override void DisplayDetails()
        {
            Console.WriteLine("Domestic Subscription Details:");
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
