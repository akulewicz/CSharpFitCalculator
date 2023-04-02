using System;
using static System.Math;

namespace Bmi;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kalkulator BMI");

        BmiCalculatorService bmiService = new BmiCalculatorService();

        var bmiData = bmiService.CalculateBmiView();
        if (bmiData != null)
        {
            double bmi = bmiService.CalculateBmi(bmiData);
            string definition = bmiService.GetBmiDefinition(bmi);

            Console.WriteLine($"Twoje BMI wynosi: {bmi} - {definition}");
        }
        else
        {
            Console.WriteLine($"Nieprawidłowe dane");
        }
        
      
        //Console.WriteLine("Kalkulator BMI");
        //Console.WriteLine("Podaj swój wzrost w metrach (np. 1.83):");
        //string heightFromInput = Console.ReadLine();
        //Console.WriteLine("Podaj wagę:");
        //string weightFromInput = Console.ReadLine();

        //double weight;
        //double height;
        //bool isWeightValid = double.TryParse(weightFromInput, out weight);
        //bool isHeightValid = double.TryParse(heightFromInput, out height);

        //if (isWeightValid && isHeightValid)
        //{
        //    double bmi = Round((weight / Pow(height, 2)), 2);
        //    string bmiDefinition = bmi switch
        //    {
        //        < 16 => "wygłodzenie",
        //        < 17 => "wychudzenie",
        //        < 18.6 => "niedowaga",
        //        < 25 => "waga prawidłowa",
        //        < 30 => "nadwaga",
        //        < 35 => "otyłość I stopnia",
        //        < 40 => "otyłość kliniczna",
        //        _ => "otyłość skrajna"
        //    };

        //    Console.WriteLine($"Waga: {weight}");
        //    Console.WriteLine($"Wzrost: {height}");
        //    Console.WriteLine($"BMI: {bmi} - {bmiDefinition}");
        //}
        //else
        //{
        //    Console.WriteLine("Podałeś nieprawidłowe wartości");
        //}
    }
}

