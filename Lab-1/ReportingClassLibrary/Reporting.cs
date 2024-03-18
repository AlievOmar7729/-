using MoneyClassLibrary;
using ProductClassLibrary;
using WarehouseClassLibrary;

using System;

namespace ReportingClassLibrary
{
    public interface IReportManager
    {
        void RegisterRequired(Warehouse warehouse, string name, int quantity, int dollars, int cents);
        void RegisterProperty(Warehouse warehouse, string name, int quantity);
    }

    public interface IReportInventory
    {
        void ReportInventoryBoard(List<Warehouse> warehouses);
    }


    public class Reporting : IReportManager
    {

        private readonly IReportInventory _reportInventory;
        public Reporting(IReportInventory reportInventory)
        {
            _reportInventory = reportInventory;
        }
        public void RegisterRequired(Warehouse warehouse, string name, int quantity, int dollars, int cents)
        {
            if (warehouse != null)
            {
                warehouse.Quantity += quantity;
                Console.WriteLine($"Зареєстровано надходження {quantity} одиниць товару {name}. Загальна кількість: {warehouse.Quantity}");
            }
            else
            {
                Console.WriteLine("Неможливо зареєструвати надходження. Невірний склад.");
            }
        }

        public void RegisterProperty(Warehouse warehouse, string name, int quantity)
        {
            if (warehouse != null)
            {
                if (warehouse.Quantity >= quantity)
                {
                    warehouse.Quantity -= quantity;
                    Console.WriteLine($"Відправлено {quantity} одиниць товару {name}. Залишок: {warehouse.Quantity}");
                }
                else
                {
                    Console.WriteLine("Недостатньо товару на складі для відвантаження.");
                }
            }
            else
            {
                Console.WriteLine("Неможливо відправити товар. Невірний склад.");
            }
        }

        public void ReportInventoryBoard(List<Warehouse> warehouses)
        {
            this._reportInventory.ReportInventoryBoard(warehouses);
        }


    }



    public class ReportInventory : IReportInventory
    {
        public void ReportInventoryBoard(List<Warehouse> warehouses)
        {
            foreach (var warehouse in warehouses)
            {
                if (warehouse != null)
                {
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine($"Звіт про залишки на складі:");
                    Console.WriteLine($"Найменування: {warehouse.Product.Name}");
                    Console.WriteLine($"Одиниця виміру: {warehouse.Unit}");
                    Console.WriteLine($"Ціна за одиницю: {warehouse.Product.Price.Amount} {warehouse.Product.Price.Currency.Symbol}");
                    Console.WriteLine($"Кількість: {warehouse.Quantity}");
                    Console.WriteLine($"Дата останнього завозу: {warehouse.LastStockDate}");
                    Console.WriteLine("-------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("Неможливо сформувати звіт. Невірний склад.");
                    Console.WriteLine("-------------------------------------------------------------------");
                }
            }
        }
    }
}



