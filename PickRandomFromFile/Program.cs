using System;
using System.IO;

namespace PickRandomFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // string filePath = @"C:\Users\...\samples\foods.txt"; // lihtsalt failist andmete maha lugemine ja kuvamine
            // string[] dataFromFile = File.ReadAllLines(filePath);
            // foreach(string element in dataFromFile)
            {
                // Console.WriteLine(element);
            }

            string randomFood, randomDrink, randomMovie;

            randomFood = GenerateRamdomFromFile("foods.txt");
            randomDrink = GenerateRamdomFromFile("drinks.txt");
            randomMovie = GenerateRamdomFromFile("movies.txt");

            Console.WriteLine($"Tonight you will have some {randomFood} with {randomDrink} and watch {randomMovie}.");
        }


        private static int GenerateRamdomIndex(string[] someArray)
            {
                Random rnd = new Random();
                int randomIndex = rnd.Next(0, someArray.Length);

                return randomIndex;
            }

        private static string GenerateRamdomFromFile(string fileName)
        {
            string filePath = $@"C:\Users\...\samples\{fileName}";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRamdomIndex(dataFromFile)];

            return randomElement;

        }

    }
}
