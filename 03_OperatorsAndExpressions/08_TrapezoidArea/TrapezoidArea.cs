using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Please enter side A of the trapezoid: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please enter side B of the trapezoid: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please enter height H of the trapezoid: ");
        double h = Convert.ToDouble(Console.ReadLine());

        double s = (a + b) / 2 * h;
        Console.WriteLine("Trapezoid's area is " + s);
    }
}
