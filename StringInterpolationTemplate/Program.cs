using System;
using Microsoft.Extensions.DependencyInjection;
using StringInterpolationTemplate.Services;

namespace StringInterpolationTemplate;

public class Program
{
    private static void Main(string[] args)
    {
        try
        {
            var startup = new Startup();
            var serviceProvider = startup.ConfigureServices();
            var service = serviceProvider.GetService<IMainService>();

            service?.Invoke();
        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e);
        }



        DateTime myDate = DateTime.Parse("2019-01-22 23:01:27");
        var pi = Math.PI;

        Console.WriteLine($"{$"1.{myDate:MMMM} {myDate:dd} {myDate:yyyy}",40:f3}");
        Console.WriteLine($"2.{myDate:yyyy.MM.dd}");
        Console.WriteLine($"3.Day {myDate:dd} of {myDate:MMMM}, {myDate:yyyy}");
        Console.WriteLine($"4.Year:{myDate:yyyy}, Month: {myDate:MM}, Day: {myDate:dd}");
        Console.WriteLine($"5.{myDate,17:dddd}");
        Console.WriteLine($"6.{myDate,10:h:mm tt} {myDate,10:dddd}");
        Console.WriteLine($"7.h:{myDate:hh}, m:{myDate:mm}, s:{myDate:ss}");
        Console.WriteLine($"8.{myDate:yyyy.MM.dd.hh.mm.ss}");
        Console.WriteLine($"9.{pi:C}");
        Console.WriteLine($"10.{pi,10:f3}");
        Console.WriteLine(Math.Sqrt(2));


int squareRoot = (int)Math.Sqrt(2);

    int x = 0;
    int remainder = 0;

    string hexDec = "";



            while (squareRoot != 0)
            {
                remainder = squareRoot % 16;
                if (remainder< 10)
                {
                    remainder = remainder + 48;
                    Console.WriteLine(remainder);
                }
                else
                {
                    remainder = remainder + 55;
                    Console.WriteLine(remainder);
                }
hexDec += Convert.ToChar(remainder);
squareRoot = squareRoot / 16;
            }

            Console.Write("Hexa-decimal number : ");
for (x = hexDec.Length - 1; x >= 0; x--)
{
    Console.Write(hexDec[x]);
}

Console.WriteLine();
    }
}


    
    
