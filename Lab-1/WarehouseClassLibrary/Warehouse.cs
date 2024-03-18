using MoneyClassLibrary;
using ProductClassLibrary;
using System.Data;


namespace WarehouseClassLibrary
{
    public interface ITovarInfo
    {
        public string Unit { get; set; }
        public int Quantity { get; set; }
        public DateTime LastStockDate { get; set; }
    }





    public class Warehouse : ITovarInfo
    {
        public Product Product { get; set; }
        public string Unit { get; set; }
        public int Quantity { get; set; }
        public DateTime LastStockDate { get; set; }


        public Warehouse(Product product, string unit, int quantity, DateTime lastStockDate)
        {
            Product = product;
            Unit = unit;
            Quantity = quantity;
            LastStockDate = lastStockDate;
        }
    }






}
