using System;

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("Please write x coordinate value: ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Please write y coordinate value: ");
        int y = int.Parse(Console.ReadLine());

        int result = x * x + y * y;

        if (result <= 5 * 5)
        {
            Console.WriteLine("The point is inside the circle with K(O, 5)");
        }
        else
        {
            Console.WriteLine("The point is outside the circle with K(O, 5)");
        }
    }
}
