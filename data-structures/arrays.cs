using System;

class arrays
{
    static void Main()
    {
        string[] expressions = new string[] {"5 + 3", "10 - 2", "7 * 4", "20 / 5", "3 ^ 2"};
        Console.WriteLine("Calculator History:");
        foreach (string expr in expressions)
        {
            Console.WriteLine(expr);
        }
    }
}