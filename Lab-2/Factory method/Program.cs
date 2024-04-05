using Factory_method;




Console.WriteLine("Please choose the type of subscription:");
Console.WriteLine("1.Domestic Subscription");
Console.WriteLine("2.Educational Subscription");
Console.WriteLine("3.Premium Subscription");

int subscriptionTypeChoice = Convert.ToInt32(Console.ReadLine());
Subscription ?subscription = null;

switch (subscriptionTypeChoice)
{
    case 1:
        subscription = SubscriptionFactory.CreateSubscription("domestic");
        break;
    case 2:
        subscription = SubscriptionFactory.CreateSubscription("educational");
        break;
    case 3:
        subscription = SubscriptionFactory.CreateSubscription("premium");
        break;
    default:
        Console.WriteLine("Invalid choice!");
        return;
}


//If the implementation was done on a specific service, then run this command
PurchaseMethod purchaseMethod = new WebSite();
//PurchaseMethod purchaseMethod = new MobileApp();
//PurchaseMethod purchaseMethod = new ManagerCall();
purchaseMethod.Purchase(subscription);

