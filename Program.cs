namespace Hangman_Lite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wrongGuess = 3;
            Console.WriteLine("Hangman Lite");
            Console.WriteLine("");
            Console.WriteLine("A Gration's Lite LLC creation");
            Console.WriteLine("Please click 'ENTER'");
            Console.ReadLine();
            Thread.Sleep(100);
            Console.WriteLine("Please wait....");
            Thread.Sleep(600);
            Console.WriteLine("Hello");
            Console.ReadLine();



            if (wrongGuess == 0)
            {
                Console.WriteLine("Place a guess");
                Console.WriteLine("");
                Console.WriteLine("+---+");
                Console.WriteLine("|   |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("=========");
                Console.WriteLine("");
                Console.WriteLine("The Word:");
                Console.WriteLine("________");
            }
            else if (wrongGuess == 1)
            {
                Console.WriteLine("+---+");
                Console.WriteLine("|   |");
                Console.WriteLine("o   |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("=========");
            }
            else if (wrongGuess == 2)
            {
                Console.WriteLine(" +---+");
                Console.WriteLine(" |   |");
                Console.WriteLine(" o   |");
                Console.WriteLine("/|\\  |");
                Console.WriteLine("     |"); 
                Console.WriteLine("     |");
                Console.WriteLine("=========");
            }
            else if (wrongGuess == 3)
            {
                Console.WriteLine("  +---+");
                Console.WriteLine("  |   |");
                Console.WriteLine("  o   |");
                Console.WriteLine(" /|\\  |");
                Console.WriteLine("  |   |");
                Console.WriteLine(" / \\  |");
                Console.WriteLine("=========");
            }
        }
    }
}