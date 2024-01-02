namespace GjettTallet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var randomNumber = rand.Next(0, 101);

           while (true)
            {
                Console.WriteLine("Enter number");
                var input = Console.ReadLine();
                if (int.TryParse(input, out int userInput))
                {
                    if (userInput < randomNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (userInput > randomNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("You won");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
        }
    }
}