using System;

class IsoscelesTriangle
{
    static void Main()
    {
        char copy = '\u00A9';

        Console.WriteLine(@"
                    {0}
                  {0}  {0}
                {0}      {0}
             {0}   {0}   {0}   {0}"
            , copy);
    }
}
