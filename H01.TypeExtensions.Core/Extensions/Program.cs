using System;
using System.Collections.Generic;
using H01.TypeExtensions.Core.Extensions;

class Program
{
    static void Main()
    {
        int x = 6;
        Console.WriteLine($"{x}² = {x.PowerOfTwo()}");

        string text = "Hallo Howest Web Backend";
        Console.WriteLine($"Chars: {text.CountChars()}");
        Console.WriteLine($"Spaces: {text.CountSpaces()}");
        Console.WriteLine($"'Web' count: {text.CountSubstring("Web")}");

        var numbers = new List<int> { 6, 3, 0, 6 };
        Console.WriteLine($"RMS = {numbers.SquareMeanRoot()}");
    }
}
