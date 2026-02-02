using System;

class demo
{
    static void Main()
    {
        dynamic a = 20;

        a = 32.5;
        Console.WriteLine("double: " + a);

        a = 'P';
        Console.WriteLine("char: " + a);

        a = "Prince";  
        Console.WriteLine("string: " + a);

        Console.ReadLine();
    }
}
