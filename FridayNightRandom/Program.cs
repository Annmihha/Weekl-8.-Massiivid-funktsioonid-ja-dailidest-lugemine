using System;

namespace FridayNightRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            //toidu ja joogi valiku tegemine arvuti poolt kasutades GenerateRamdomIndex-i
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie(); //filmi valiku tegemine arvuti poolt, iseseisev ülesanne
        }

        private static int GenerateRamdomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
            
            Console.WriteLine($"Computer picked: {foods[GenerateRamdomIndex(foods)]}");
        }

        private static void DisplayRandomDrink()
        {
            string[] drinks = { "apple juice", "coke", "fanta", "sprite" };
        
            Console.WriteLine($"Computer picked: {drinks[GenerateRamdomIndex(drinks)]}");
        }

        private static void DisplayRandomMovie()
        {
            string[] movies = { "Robin Hood", "Infinite", "Dune" };
                       
            Console.WriteLine($"Computer picked: {movies[GenerateRamdomIndex(movies)]}");
        }
    }
}
