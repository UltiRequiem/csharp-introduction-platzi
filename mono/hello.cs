using System;

internal static class Program
{
    static void Main(string[] args)
    {
        var (a, b, c) = (false, true, false);

        Console.WriteLine($"false && true = {a && b}");
        Console.WriteLine($"false || true = {a || b}");
        Console.WriteLine($"!false = {!a}");
    }
}
