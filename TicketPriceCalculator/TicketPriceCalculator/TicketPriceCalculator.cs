// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
class TicketPriceCalculator
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        if (age <= 12 || age >= 65)
            Console.WriteLine("Ticket Price: GHC7");
        else
            Console.WriteLine("Ticket Price: GHC10");
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}

