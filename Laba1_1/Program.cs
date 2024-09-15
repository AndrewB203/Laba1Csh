using System;
using System.ComponentModel.DataAnnotations;
class Program
{
    static void Main()
    {
        Console.WriteLine("Min and max values for CTS type");
        Console.WriteLine($"sbyte: Min={sbyte.MinValue}, Max={sbyte.MaxValue}");
        Console.WriteLine($"byte: Min={byte.MinValue}, Max={byte.MaxValue}");
        Console.WriteLine($"short: Min ={short.MinValue}, Max={short.MaxValue}");
        Console.WriteLine($"ushort: Min={ushort.MinValue}, Max={ushort.MaxValue}"); 
        Console.WriteLine($"int: Min={int.MinValue}, Max={int.MaxValue}");
        Console.WriteLine($"uint: Min={uint.MinValue}, Max={uint.MaxValue}");
        Console.WriteLine($"long: Min={long.MinValue}, Max={long.MaxValue}");
        Console.WriteLine($"ulong: Min={ulong.MinValue}, Max={ulong.MaxValue}");
        Console.WriteLine($"float: Min={float.MinValue}, Max={float.MaxValue}");
        Console.WriteLine($"double: Min={double.MinValue}, Max={double.MaxValue}");
        Console.WriteLine($"decimal: Min={decimal.MinValue}, Max={decimal.MaxValue}");
    }
};