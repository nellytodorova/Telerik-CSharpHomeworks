using System;

class Trapezoid
{
    static void Main()
    {
        byte N = byte.Parse(Console.ReadLine());

        char asterisk = '*';
        char dot = '.';
        int startAsterisk = N + 1;

        // i - number of row
        for (byte i = 1; i <= N + 1; i++)
        {
            // j - number of the position in the row
            for (byte j = 1; j <= (N * 2); j++)
            {
                // if we are on the first row
                if (i == 1) {
                    Console.Write((j <= N) ? dot : asterisk);
                }

                if (i != 1)
                {
                    if (j == (N * 2) || j == startAsterisk)
                    {
                        Console.Write(asterisk);
                    }
                    else if (i == (N + 1))
                    {
                        Console.Write(asterisk);
                    }
                    else
                    {
                        Console.Write(dot);
                    }
                }          
            }

            startAsterisk--;
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}