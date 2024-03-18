using System.Text;

namespace MoneyClassLibrary
{
    public interface IMoney
    {
        public int Whole { get; }
        public int Fractions { get; }
        public decimal Amount { get; }
    }

    public interface IPrintAmmountMoney
    {
        void PrintAmount(Money money);
    }
    public interface ISetAmmountMoney
    {
        void SetAmount(int whole, int fractions);
    }

    public class Money : ISetAmmountMoney, IMoney
    {
        private Currency currency;
        public Currency Currency => currency;
        public int Whole { get; private set; }
        public int Fractions { get; private set; }
        public decimal Amount { get => Whole + Fractions / 100m; }
        private readonly IPrintAmmountMoney _printAmount;

        public Money(int whole, int fractional, Currency currency, IPrintAmmountMoney printAmount)
        {
            if (whole < 0)
            {
                throw new ArgumentException("Whole part cannot has value less than 0", nameof(whole));
            }

            if (fractional < 0 || fractional > 99)
            {
                throw new ArgumentException("Fractional part can only has values from 0 to 99", nameof(fractional));
            }

            Whole = whole;
            Fractions = fractional;
            this.currency = currency;
            _printAmount = printAmount;
        }

        public void SetAmount(int whole, int fractions)
        {
            Whole = whole;
            Fractions = fractions;
        }
        public void PrintAmount(Money money)
        {
            this._printAmount.PrintAmount(money);
        }
    }

    public class PrintAmmountMoney : IPrintAmmountMoney
    {
        public void PrintAmount(Money money)
        {
            Console.WriteLine($"{money.Amount} {money.Currency.Symbol}");
        }
    }







}
