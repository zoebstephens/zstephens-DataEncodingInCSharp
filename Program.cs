﻿using System;

namespace zstephens_DataEncodingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            ch = 'A';
            Console.WriteLine($"ch is storing the value: {ch}");

            int ch_decimal;
            ch_decimal = ch;
            Console.WriteLine($"The decimal value of ch is: {ch_decimal}");

            int toConvert;
            Console.Write("Enter an Integer: ");
            toConvert = int.Parse(Console.ReadLine());

            char asChar;
            asChar = (char)toConvert;
            Console.WriteLine($"The integer {toConvert} cast to a char is '{asChar}'");

            char b;
            b = (char)('A' + 1);
            Console.WriteLine($"'A' + 1 = '{b}'");
        }
    }
}
