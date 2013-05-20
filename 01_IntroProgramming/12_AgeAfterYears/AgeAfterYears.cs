using System;

class AgeAfterYears
{
    static void Main()
    {
        int addYears = 10;
        DateTime today = DateTime.Now;

        DateTime addYearsToday = today.AddYears(addYears);

        Console.WriteLine("Please enter your date of birth:");
        DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());

        int years = addYearsToday.Year - dateOfBirth.Year;

        if (years < 120 && years > 10)
        {
            Console.WriteLine("After {0} years you will be {1} years old.", addYears, years);   
        }
        else
        {
            Console.WriteLine("Please try again and enter correct information!");
        }  
    }
}