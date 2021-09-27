using System;

namespace dotNet_LearnPath
{
    class Program
    {
        static void Main(string[] args)
        {
            int fehrenheit = 94;

            decimal celsius = Math.Round(convertFehrenitToCelsius(fehrenheit), 1);

            Console.WriteLine(fehrenheit + " F equals " + celsius + " C.");

            static decimal convertFehrenitToCelsius(decimal fehrenhiteTemp)
            {
                return (fehrenhiteTemp - 32) * 5 / 9;
            }
        }


    }
}
