namespace MethodsExercise
{
    public class Program
    {
        static bool GreetTheUser(string question) 
        {
            Console.WriteLine(question);
            string userInput = Console.ReadLine()?.Trim().ToLower();//I wanted to make sure the input comes back in lowercases
            return userInput == "girl";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what's your name?!");
            string name = Console.ReadLine();

            if (GreetTheUser("Thanks ! And by the way, are you a girl or a man ?!"))
            {
                Console.WriteLine($"What's up girl, how are you ?\n All the {name} I know are very beautiful woman and I'm pretty sure you are too.");
            }
            else
            {
                Console.WriteLine($"What's up man. I hope you're doing good today. All the {name} I know are smart dudes. I guess you are too.");
            }
            
            Console.WriteLine("I propose we get to know each other better. So I'm gonna ask you a serie of question\n Ready ? Go.");
            
            Console.WriteLine("What is your favorite Sport ?");
            string sport = Console.ReadLine();
            
            Console.WriteLine("What was your favorite movie ?");
            string movie = Console.ReadLine();
            
            Console.WriteLine("And what is your favorite color");
            string color = Console.ReadLine();
            
            Console.WriteLine($"Check this out {name}, if {sport} wasn't a sport, and {movie} has never been produce, I think {color} would be the only good thing that you and I both like\nHave a great day !!");

            
// EXERCISE 2 creation of methods that can do maths simple operation


            static int Addition (int a, int b) // Simple add a + b;
            {
                return (a + b);
            }

            static int Subtraction (int a, int b)// Simple subtract=> a - b;
            {
                return (a - b);
            }

            static int Multiplication(int a, int b)// Simple mult
            {
                return (a * b);
            }

            static int Division(int a, int b)// simple div
            {
                return (a / b);
            }

            static int AdditionPlus(params int[] numbers)
            {
                return numbers.Sum();
            }

            Console.WriteLine($"{Addition(10, 20)}, {Subtraction(10, 15)}, {Multiplication(10, 20)}, {Division(10, 20)}");
            
            int result = SumNumbers(13, -90, 89, 65, 90 );
            int mul = Multiply(9, 20, 8);
            int div = Divide(10, 20, 8);
            int sus = Sustraction(90, 20, 8);
            Console.WriteLine($" Total sum: {result}\n Total mul would be {mul}\n Total sum is {result}\n Total div is {div}\n And total sus is {sus}");
        }
        static int SumNumbers(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++ )
            {
                sum = sum + numbers[i];
            }
            return sum;
        }

        static int Multiply(params int[] numbers1 )
        {
            int mul = 1;
            for (int i = 0; i < numbers1.Length; i++)
            {
                mul = mul * numbers1[i];
            }
            return mul; 
        }

        static int Divide(params int[] numbers1)
        {
            int div = 1;
            for (int i = 0; i < numbers1.Length; i++)
            {
                div = div / numbers1[i];
            }
            return div;
        }
        static int Sustraction(params int[] numbers1)
        {
            int sus = 0;
            for (int i = 0; i < numbers1.Length; i++)
            {
                sus = sus - numbers1[i];
            }
            return sus;
        }
    }
}
