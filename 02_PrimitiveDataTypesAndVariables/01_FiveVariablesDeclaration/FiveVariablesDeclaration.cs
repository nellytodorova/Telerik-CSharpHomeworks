using System;

class FiveVariablesDeclaration
{
    static void Main()
    {
        ushort varUshort = 52130;
        sbyte varSbyte = -115;
        uint varUint = 4825932;
        byte varByte = 97;
        short varShort = -10000;

        Console.Write("Variable of type \"ushort\": {0}\n", varUshort);
        Console.Write("Variable of type \"sbyte\": {0}\n", varSbyte);
        Console.Write("Variable of type \"uint\": {0}\n", varUint);
        Console.Write("Variable of type \"byte\": {0}\n", varByte);
        Console.Write("Variable of type \"short\": {0}\n", varShort);
    }
}