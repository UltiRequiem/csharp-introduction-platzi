using System;

internal static class Program
{
    static void Main(string[] args)
    {
        string[] coffeTypes = { "Cappuccino", "Latte", "Espresso" };

        foreach (var ct in coffeTypes)
        {
            Console.WriteLine($"{ct} Coffe");
        }
    }
}
