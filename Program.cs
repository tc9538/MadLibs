using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program guides the use to fill in the blanks to make a story
            Author: Truc
            */


            // Let the user know that the program is starting:
            Console.WriteLine("Program is starting...");

            // Give the Mad Lib a title:
            string title = "Grumpy Bear";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter first adjective: ");
            string firstAdj = Console.ReadLine();

            Console.WriteLine("Enter second adjective: ");
            string secondAdj = Console.ReadLine();

            Console.WriteLine("Enter third adjective: ");
            string thirdAdj = Console.ReadLine();

            Console.WriteLine("Enter one verb: ");
            string verb = Console.ReadLine();

            Console.WriteLine("Enter first noun: ");
            string firstNoun = Console.ReadLine();

            Console.WriteLine("Enter second noun: ");
            string secondNoun = Console.ReadLine();

            Console.WriteLine("Etner an input for an animal: ");
            string animal = Console.ReadLine();

            Console.WriteLine("Etner an input for a food: ");
            string food = Console.ReadLine();

            Console.WriteLine("Etner an input for a fruit: ");
            string fruit = Console.ReadLine();

            Console.WriteLine("Etner an input for a superhero: ");
            string superHero = Console.ReadLine();

            Console.WriteLine("Etner an input for a country: ");
            string country = Console.ReadLine();

            Console.WriteLine("Etner an input for a dessert: ");
            string dessert = Console.ReadLine();

            Console.WriteLine("Etner an input for a year: ");
            string year = Console.ReadLine();

            // The template for the story:

            string story = $"This morning {userName} woke up feeling {firstAdj}. 'It is going to be a {secondAdj} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {firstNoun}, which made all the {fruit}s very {thirdAdj}. Concerned, {userName} texted {superHero}, who flew {userName} to {country} and dropped {userName} in a puddle of frozen {dessert}. {userName} woke up in the year {year}, in a world where {secondNoun}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);


        }
    }
}
