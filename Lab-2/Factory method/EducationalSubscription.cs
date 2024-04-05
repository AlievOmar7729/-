namespace Factory_method
{
    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription() : base(10, 2, new List<string> { "Know-it-all", "History of Ukraine", "Math together" }) { }

        public override void DisplayDetails()
        {
            Console.WriteLine("Educational Subscription Details:");
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
