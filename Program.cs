using System;

namespace zstephens_DataEncodingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // char ch;
            // ch = 'A';
            // Console.WriteLine($"ch is storing the value: {ch}");

            // int ch_decimal;
            // ch_decimal = ch;
            // Console.WriteLine($"The decimal value of ch is: {ch_decimal}");

            // int toConvert;
            // Console.Write("Enter an Integer: ");
            // toConvert = int.Parse(Console.ReadLine());

            // char asChar;
            // asChar = (char)toConvert;
            // Console.WriteLine($"The integer {toConvert} cast to a char is '{asChar}'");

            // char b;
            // b = (char)('A' + 1);
            // Console.WriteLine($"'A' + 1 = '{b}'");

            // char z;
            // z = (char)('Z' + 3);
            // Console.WriteLine($"'Z' + 3 = '{z}'");

            // char f; 
            // f = (char)('F' - 5);
            // Console.WriteLine($"'F' - 5 = '{f}' ");

            // char Khoor#Zruog$; 
            // Khoor#Zruog$ = (char)('Khoor#Zruog$' - 3);
            // Console.WriteLine($"'Khoor#Zruog$' - 3 = '{Khoor#Zruog$}' ");

            Cipher cipher;
            cipher = new Cipher(5);

            string encrypted;
            encrypted = cipher.Encrypt("rosebud");
            Console.WriteLine($"The encyrpted message is: '{encrypted}'");

            string decrypted;
            decrypted = cipher.Encrypt("rosebud");
            Console.WriteLine($"The encyrpted message is: '{decrypted}'");




        }
    }
}
