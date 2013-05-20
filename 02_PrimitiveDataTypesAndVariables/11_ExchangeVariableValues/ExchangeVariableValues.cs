using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        a = a + b; // a = 15, b = 10
        b = a - b; // a = 15, b = 5
        a = a - b; // a = 10, b = 5

        Console.WriteLine("The first value is now {0} and the second is {1}", a, b);
    }
}
