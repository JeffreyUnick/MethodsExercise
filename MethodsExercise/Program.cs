namespace MethodsExercise
{
    public class Program
    {
        static bool GreetTheUser(string question) 
        // creating a methode to greet the user specifically according to his gender
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
        }
    }
}
