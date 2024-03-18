using MoneyClassLibrary;
using System.Diagnostics;


namespace ProductClassLibrary
{
   public interface IChangePrice
    {
        void DecreasePrice(Money price,int decreaseWhole, int decreaseFractions);
    }

    public class Product
    {

        public string Name { get; set; }
        public Money Price { get; set; }

        private readonly IChangePrice _priceChanger;
        public Product(string name, Money price, IChangePrice priceChanger)
        {
            this.Name = name;
            this.Price = price;
            this._priceChanger = priceChanger;
        }
        public void DecreasePrice(int decreaseWhole, int decreaseFractions)
        {
            this._priceChanger.DecreasePrice(this.Price,decreaseWhole, decreaseFractions);
        }


    }






    public class ChangePrice : IChangePrice
    {
        public void DecreasePrice(Money price, int decreaseWhole, int decreaseFractions)
        {
            if (price != null)
            {
                int currentWhole = price.Whole;
                int currentFractions = price.Fractions;

                int newWhole = currentWhole - decreaseWhole;
                int newFractions = currentFractions - decreaseFractions;

                if (newFractions < 0)
                {
                    newWhole -= 1;
                    newFractions += 100;
                }

                if (newWhole < 0 || (newWhole == 0 && newFractions < 0))
                {
                    Console.WriteLine("Ціна не може бути відємною");
                    return;
                }

                price.SetAmount(newWhole, newFractions);
            }
            else
            {
                throw new InvalidOperationException("Invalid Price");
            }
        }
    }

}
