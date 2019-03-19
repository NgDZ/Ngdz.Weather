using System;

namespace Ngdz.Weather.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var metar = "DAAG 191000Z 10009KT 9999 FEW026 BKN080 14/05 Q1021";
            var data = Ngdz.Weather.MetarDisplay.MetarDisplay.GetWeatherMessage(metar);
            System.Console.WriteLine(data);
        }
    }
}
