using System;

class RectagleArea
{
    static void Main()
    {
        Console.WriteLine("Please enter rectangle's width: ");
        int width = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter rectangle's heigth: ");
        int height = int.Parse(Console.ReadLine());

        Console.WriteLine("Rectangle's are is: " + (width * height));
    }
}
