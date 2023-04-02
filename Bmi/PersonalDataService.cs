using System;
using static System.Math;
namespace Bmi
{
    public class PersonalDataService
    {

        public PersonalData? CalculateBmiView()
        {
            Console.WriteLine("Podaj swój wzrost w metrach (np. 1.83):");
            string heightFromInput = Console.ReadLine();
            Console.WriteLine("Podaj wagę:");
            string weightFromInput = Console.ReadLine();

            double weight;
            double height;
            bool isWeightValid = double.TryParse(weightFromInput, out weight);
            bool isHeightValid = double.TryParse(heightFromInput, out height);

            if (isWeightValid && isHeightValid)
            {
                PersonalData bmi = new PersonalData() { Weight = weight, Height = height };
                return bmi;
            }
            return null;
        }


        public double CalculateBmi(PersonalData bmiData)
        {
            double result = Round((bmiData.Weight / Pow(bmiData.Height, 2)), 2);
            return result;
        }


        public string GetBmiDefinition(double bmi)
        {
            string bmiDefinition = bmi switch
            {
                < 16 => "wygłodzenie",
                < 17 => "wychudzenie",
                < 18.6 => "niedowaga",
                < 25 => "waga prawidłowa",
                < 30 => "nadwaga",
                < 35 => "otyłość I stopnia",
                < 40 => "otyłość kliniczna",
                _ => "otyłość skrajna"
            };
            return bmiDefinition;
        }
    }
}

