using System;

class PointInCircleOutOfRectangle
{
    static void Main()
    {
        Console.WriteLine("Please enter x coordinate value: ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter y coordinate value: ");
        int y = int.Parse(Console.ReadLine());

        int resultCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1);

        if (resultCircle <= 9)
        {

            if (x > 5 && x < (-1) && y > 1 && y < -1)
            {
                Console.WriteLine("The point is inside the circle and outside of the rectangle.");
            }
            else
            {
                Console.WriteLine("The point is inside the circle and inside of the rectangle.");
            }
        }
        else
        {
            if (x > 5 && x < (-1) && y > 1 && y < -1)
            {
                Console.WriteLine("The point is outside the circle and outside of the rectangle.");
            }
            else
            {
                Console.WriteLine("The point is outside the circle and inside of the rectangle.");
            }
        }
    }
}
