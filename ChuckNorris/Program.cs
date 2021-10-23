﻿using System;
using System.IO;

namespace ChuckNorris
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomJoke;

            randomJoke = GenerateRamdomFromFile("chuck.txt");
            Console.WriteLine($"{randomJoke}");
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
