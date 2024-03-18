using MoneyClassLibrary;
using ProductClassLibrary;
using System.Text;
using WarehouseClassLibrary;
using ReportingClassLibrary;


var usd = new Currency("USD");

var pricelaptop = new Money(99, 99, usd, new PrintAmmountMoney());
var pricePC = new Money(150,00,usd, new PrintAmmountMoney());


var laptop = new Product("Laptop Acer Nitro", pricelaptop, new ChangePrice());
var PC = new Product("PC AX-22-C",pricePC,new ChangePrice());

List<Warehouse> warehouses = new List<Warehouse>();
var warehouseLaptop = new Warehouse(laptop, "шт.", 90, DateTime.Now);
var warehousePC = new Warehouse(PC, "шт.", 100, DateTime.Now);

warehouses.Add(warehouseLaptop);
warehouses.Add(warehousePC);

Reporting reportBoard = new Reporting(new ReportInventory());
reportBoard.ReportInventoryBoard(warehouses);

laptop.DecreasePrice(20, 00);

reportBoard.ReportInventoryBoard(warehouses);






















