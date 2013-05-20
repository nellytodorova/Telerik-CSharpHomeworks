using System;

class AsciiTable
{
    static void Main()
    { 
        int numAsciiExtended = 128;

        for (int i = 0; i < numAsciiExtended; i++)
        {
            char ascii = (char)i;
            string asciiDisplay;

            asciiDisplay = ascii.ToString();

            if (char.IsControl(ascii))
            {
                asciiDisplay = "Control symbol";
            }

            Console.WriteLine(asciiDisplay);
        }
    }
}