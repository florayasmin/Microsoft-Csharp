using System;
using System.Collections.Generic;

class linkedlists
{
    static void Main()
    {
        LinkedList<string> results = new LinkedList<string>();
        results.AddLast("Result: 8");
        results.AddLast("Result: 5");
        results.AddLast("Result: 28");
        results.AddLast("Result: 4");
        results.AddLast("Result: 9");

        results.Remove("Result: 5");
        Console.WriteLine("\nUpdated Calculation Results:");
        foreach (string result in results)
        {
            Console.WriteLine(result);
        }
    }
}