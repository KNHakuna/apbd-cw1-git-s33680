class Arcade
{
    public void GuessTheNumber()
    {
        int n;
        Random rand = new Random();
        n = rand.Next(1, 100);

        Console.WriteLine("Guess the number! What is your first guess? ");

        while (true)
        {
            string input = Console.ReadLine();
            int k;

            if (!int.TryParse(input, out k))
            {
                Console.WriteLine("That is not a number!");
                continue;
            }

            if (k == n)
            {
                Console.WriteLine("Congratulations, you won!");
                break;
            }
            else if (k < n)
            {
                Console.WriteLine("Too low!");
            }
            else
            {
                Console.WriteLine("Too high!");
            }

            Console.WriteLine("\n What is your next guess? ");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Arcade arcade = new Arcade();
        arcade.GuessTheNumber();
    }
}