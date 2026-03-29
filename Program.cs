namespace Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int guess;
            int number;
            number = random.Next(1, 10);

            do
            {
                Console.WriteLine("Guess a number between 1 and 10");
                guess = Convert.ToInt32(Console.ReadLine());

                if (number == guess)
                {
                    Console.WriteLine("Horrey you won!");
                }
                else
                {
                    Console.WriteLine($"You loose! the number is {number}");
                }
            } while (number != guess);
        }
    }
}
