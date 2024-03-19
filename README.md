# Programming principles

## Single Responsibility Principle (1)

Each class follows this principle. Example: the [Money](./Lab-1/MoneyClassLibrary/Money.cs#L21) and [PrintAmmountMoney](./Lab-1/MoneyClassLibrary/Money.cs#L59) classes were separated, since the first is needed only for storing and managing money. 

## Open closed Principle (2)

Adding new ways to withdraw money can be achieved by creating new classes that implement the [IPrintAmmountMoney](./Lab-1/MoneyClassLibrary/Money.cs#L12) interface without changing the existing code of the Money class. Thus, the Money class is open to extension with new [ways](./Lab-1/MoneyClassLibrary/Money.cs#L53) of withdrawing amounts, but is closed to modification of its core functionality.
The same principle is implemented in the Product class

## Interface Segregation Principle (3)

I have two interfaces for implementing the Reporting class, they were divided into (advanced and enhanced) and report. In this way, classes are not required to implement interfaces that are not relevant.

[IReportManager](./Lab-1/ReportingClassLibrary/Reporting.cs#L9)  [IReportInventory](./Lab-1/ReportingClassLibrary/Reporting.cs#L15)

## Dependency Inversion Principle (4)
The Product class depends on the [IChangePrice](./Lab-1/Product/Product.cs#L7) abstraction rather than on a specific implementation of price change. This allows you to replace price change implementations without affecting the [Product](./Lab-1/Product/Product.cs#L12,L25) class code, which is consistent with the principle

## Don't Repeat Yourself (5)

All code is written without repetition.

## Keep It Simple, Stupid (6) 

The methods are written very simply and easy to read. Do not save lines on purpose.

## YAGNI (7)

The functionality that was specified in the task is done; the remaining unnecessary methods are not needed and therefore are not implemented

## Composition Over Inheritance (8)

The code defines the [IChangePrice](./Lab-1/Product/Product.cs#L7) interface, which provides the ability to change the price of a product. The Product class contains a field of type [IChangePrice](./Lab-1/Product/Product.cs#L18), which represents the component responsible for changing the price of the product. When creating an instance of the [Product](./Lab-1/Product/Product.cs#L12) class, a specific implementation of [IChangePrice](./Lab-1/Product/Product.cs#L7) is passed, which allows you to dynamically change the price change strategy.

## Fail Fast (9)

the code contains stubs in the form of Exception in case the program does not work correctly

[price == null](./Lab-1/Product/Product.cs#L66)

[fractional < 0 || fractional > 99](./Lab-1/MoneyClassLibrary/Money.cs#L39)




