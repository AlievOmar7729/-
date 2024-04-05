using Singleton;

Authenticator user1 =  Authenticator.GeInstance();



Console.WriteLine("Username: ");
string? username = Console.ReadLine();

Console.WriteLine("Password: ");
string? password = Console.ReadLine();

if (user1.Authenticate(username, password))
{
    Console.WriteLine("Authentication successful!");
}
else
{
    Console.WriteLine("Authentication failed.");
}