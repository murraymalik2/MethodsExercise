namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings -What is your first name?"); // output

            var userName = Console.ReadLine(); // input

            Console.WriteLine($"Hi {userName}. What is your favorite color?"); // output

            var color = Console.ReadLine(); // input

            Console.WriteLine($"{color} is a great color! What's your favorite animal? "); // output

            var animal = Console.ReadLine(); // input

            Console.WriteLine($"Okay you like the {animal} the best? That's cool! What's your favorite band?"); // output

            var band = Console.ReadLine(); // input

            Console.WriteLine($"{band} is a pretty neat band!");

        }
    }
}
