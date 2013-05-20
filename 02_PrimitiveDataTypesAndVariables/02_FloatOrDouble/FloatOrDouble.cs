using System;

class FloatOrDouble
{
    static void Main()
    {
        double varDouble = 34.567839023;
        float varFloat = 12.345f;
        double varDoubleOther = 8923.1234857;
        float varFloatOther = 3456.091f;

        Console.Write("Variable of type \"double\": {0}\n", varDouble);
        Console.Write("Variable of type \"float\": {0}\n", varFloat);
        Console.Write("Variable of type \"double\": {0}\n", varDoubleOther);
        Console.Write("Variable of type \"float\": {0}\n", varFloatOther);
    }
}
