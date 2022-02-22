using System;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    //1. January 22, 2019 (right aligned in a 40 character field)
    public string Number01()
    {
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number02()
    {
        var date = _date.Now.ToString("yyyy.MM.dd");
        var answer = $"{date}";
        Console.WriteLine(answer);

         return answer;
    }

    public string Number03()
    {
        var date = _date.Now.ToString("dd of MMMM, yyyy");
        var answer = $"{date}";
        Console.WriteLine(answer);

         return answer;
       

    }

    public string Number04()
    {
         var date = _date.Now.ToString("Year: yyyy, Month: MM, Day: dd");
        var answer = $"{date}";
        Console.WriteLine(answer);

         return answer;
       
    }

    public string Number05()
    {
        var date = _date.Now.ToString($"dddd");
        var answer = $"{date,17}";
        Console.WriteLine(answer);

         return answer;


   
    }

    public string Number06()
    {
         var date = _date.Now.ToString($"h:mm tt dddd");
        var answer = $"{date, 10}";
        Console.WriteLine(answer);

         return answer;

       
    }

    public string Number07()
    {
        var date = _date.Now.ToString($"h: hh, m: mm, s: ss");
        var answer = $"{date}";
        Console.WriteLine(answer);

         return answer;

        
    }

    public string Number08()
    {
       var date = _date.Now.ToString($"yyyy.MM.dd.hh.mm.ss");
        var answer = $"{date}";
        Console.WriteLine(answer);

         return answer;
        

    }

    public string Number09()
    {
        var pi = 3.14;
        var date = _date.Now.ToString($"{pi:C}");
        var answer = $"{date}";
        Console.WriteLine(answer);

         return answer;
        

    }

    public string Number10()
    {
        var pi = 3.14;
        var date = _date.Now.ToString($"{pi,10:f3}");
        var answer = $"{date}";
        Console.WriteLine(answer);

         return answer;
        

    }

    public string Number11()
    {
        var squareRoot = Math.Sqrt(2);
        var answer = $"{squareRoot:X2}";
        Console.WriteLine(answer);

         return answer;

        //1.6A09E667F3BCC908B2F
           


    }

    //2.2019.01.22
}
