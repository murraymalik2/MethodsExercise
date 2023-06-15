using System.ComponentModel;

namespace MethodsExercise
{
     class Program
    {
        public int Sum (int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }  
        public static int Multiply(int num1, int num2, int num3)
        { 
            return num1 * num2 *num3; 
         }
        static void Main(string[] args)
        {
            var amountOfCars = Sum(2, 6);
            var blah = Multiply(60, 2, 4);
            
            Console.WriteLine("Greetings -What is your first name?"); // output

            var userName = Console.ReadLine(); // input

            Console.WriteLine($"Hi {userName}. What is your favorite color?"); // output

            var color = Console.ReadLine(); // input

            Console.WriteLine($"{color} is a great color! What's your favorite animal? "); // output

            var animal = Console.ReadLine(); // input

            Console.WriteLine($"Okay you like the {animal} the best? That's cool! What's your favorite band?"); // output

            var band = Console.ReadLine(); // input

            Console.WriteLine($"{band} is a pretty neat band!");

            Console.WriteLine($"Name:{userName}");
            Console.WriteLine($"Favorite color:{color}");
            Console.WriteLine($"Favorite aninmal:{animal}");
            Console.WriteLine($"Favorite band: {band}");

        }
    }
}
