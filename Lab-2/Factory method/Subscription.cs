namespace Factory_method
{
    public abstract class Subscription
    {
        public decimal MonthlyFee { get; protected set; }
        public int MinimumSubscriptionPeriod { get; protected set; }
        public List<string> IncludedChannels { get; protected set; }

        public Subscription(decimal monthlyFee, int minimumSubscriptionPeriod, List<string> includedChannels)
        {
            MonthlyFee = monthlyFee;
            MinimumSubscriptionPeriod = minimumSubscriptionPeriod;
            IncludedChannels = includedChannels;
        }

        public abstract void DisplayDetails();
    }


}
