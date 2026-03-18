class Arcade
{
    public void GuessTheNumber()
    {
        int n, counter=0;
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
            if (k < 1 || k > 100)
            {
                Console.WriteLine("Your number is out of range! Try again.");
                continue;
            }
            counter++;

            if (k == n)
            {
                Console.WriteLine($"Congratulations, you won in {counter} attempts!");
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

            Console.WriteLine("What is your next guess? ");
        }
    }

    public float CalculateAvarage(int[] values)
    {
        int sum=0;
        foreach (int i in values)
        {
            sum += i;
        }
        return (float)sum / values.Length;
    }

    public int CalculateMax(int[] values)
    {
        int max = values[0];
        foreach (int i in values)
        {
            if (max < i)
            {
                max = i;
            }
        }
        return max;
    }

    public int CalculateMin(int[] values)
    {
        int min = values[0];
        foreach (int i in values)
        {
            if (min > i)
            {
                min = i;
            }
        }
        return min;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Konnichiwa!\n");
        Arcade arcade = new Arcade();
        arcade.GuessTheNumber();
    }
}