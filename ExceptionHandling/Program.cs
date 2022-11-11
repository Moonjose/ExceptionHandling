using ExceptionHandling.Entities;
using ExceptionHandling.Entities.Exceptions;
using System.Globalization;

Console.WriteLine("Enter account data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Holder: ");
string holder = Console.ReadLine();
Console.Write("Initial balance: ");
double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Withdraw limit: ");
double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Account acc = new Account(number, holder, initialBalance, withdrawLimit);

Console.WriteLine();
Console.Write("Enter amount for withdraw: ");
double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

try {
   
    acc.WithDraw(amount);
    Console.WriteLine($"New balance: {acc.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
}
catch (DomainException e) {
    Console.WriteLine("Withdraw error: " + e.Message);
}
