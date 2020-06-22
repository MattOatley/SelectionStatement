using System;

namespace StatementExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("You have joined the number game!");
            
            Console.WriteLine("The rules are simple, you have to choose two numbers and try to guess my number from between those");
            
            Console.WriteLine("First, pick a large number to determine the range");
            var userInput = int.Parse(Console.ReadLine());

            var random = new Random();
            var number = random.Next(1, userInput);

            Console.WriteLine("Now input the number you would like to guess");

            var userInput1 = int.Parse(Console.ReadLine());

            if (userInput1 > number)
            {
                Console.WriteLine("Sorry! You guessed too high!!");
            }
            else if(userInput1 < number)
            {
                Console.WriteLine("Sorry! Too low!");
            }
            else
            {
                Console.WriteLine("Nevermind!");
            }


            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Math is a difficult subject!");
                    break;
                case "History":
                    Console.WriteLine("History is a difficult subject!");
                    break;
                case "English":
                    Console.WriteLine("English is a difficult subject!");
                    break;
                case "PE":    
                    Console.WriteLine("PE is a fun class!");
                    break;
                case "Spanish":
                    Console.WriteLine("Spanish is a difficult class!");
                    break;
                default:
                    Console.WriteLine("Every subject is difficult!");
                    break;
                
            }
        }
    }
}
