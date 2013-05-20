using System;

class PrimeNumber
{
    static void Main()
    {
        Console.WriteLine("Please write a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0 && number <= 100)
        {
            int square = (int)Math.Sqrt(number);
            int primeFlag = 0;

            for (int i = 1; i < square; i++)
            {
                if ((number % square == 0))
                {
                    primeFlag = 1;
                }
            }

            if (primeFlag == 0 && number % number == 0)
            {
                Console.WriteLine("The number " + number + " is a prime.");
            }
            else
            {
                Console.WriteLine("The number " + number + " is not a prime.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a number between 1 and 100.");
        }
    }
}
