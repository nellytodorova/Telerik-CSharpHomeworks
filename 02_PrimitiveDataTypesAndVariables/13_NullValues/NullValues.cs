using System;

class NullValues
{
    static void Main()
    {
        int? first = null;
        Console.WriteLine("Null integer value: " + first);
        Console.WriteLine("Get default value: " + first.GetValueOrDefault());

        double? second = null;

        second = 4.9;
        double? third = 7.89;

        Console.WriteLine(second);
        Console.WriteLine(second + third);
    }
}