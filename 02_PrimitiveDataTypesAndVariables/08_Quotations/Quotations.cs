using System;

class Quotations
{
    static void Main()
    {
        string escapedSentence = "The \"use\" of quotations causes difficulties.";
        string quotedSentence = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine("Escaped sentence: {0}", escapedSentence);
        Console.WriteLine("Quoted sentence: {0}", quotedSentence);
    }
}
