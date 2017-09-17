using System;

public class Program
{
    public static void Main()
    {
        Box<int> box = new Box<int>();
        box.Add(1);
        box.Add(2);
        box.Add(3);
        Console.WriteLine(box.Remove());
        Console.WriteLine(box.Count);
    }
}

