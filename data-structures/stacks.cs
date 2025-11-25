using System;

class stacks
{
    static void Main()
    {
        Stack<string> undoStack = new Stack<string>();
        undoStack.Push("Entered 5+3");
        undoStack.Push("Entered 10-2");
        undoStack.Push("Entered 7*4");

        string lastAction = undoStack.Pop();
        Console.WriteLine("\nUndoing: " + lastAction);
    }
}