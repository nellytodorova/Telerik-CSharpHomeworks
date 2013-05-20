using System;

class HelloWorldStrings
{
    static void Main()
    {
        string helloWord = "Hello";
        string worldWord = "World";
        object sentenceObject = helloWord + " " + worldWord + "!";

        string sentenceString = (string)sentenceObject;

        Console.WriteLine(sentenceObject);
    }
}
