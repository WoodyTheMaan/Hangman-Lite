namespace Hangman_Lite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wrongGuess = 3;
            string displayWord = "________", secretWord = "COMPUTER";
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


            string guess = "";
            while (guess.Length != 1)
            {
                Console.WriteLine("Place a guess");
                guess = Console.ReadLine().ToUpper();
            }

            if (wrongGuess == 0)
            {
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
                Console.WriteLine(displayWord);
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
                Console.WriteLine("The Word:");
                Console.WriteLine(displayWord);
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
                Console.WriteLine("The Word:");
                Console.WriteLine(displayWord);
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
                Console.WriteLine($"The Word: {secretWord}");
                
            }
        }
    }
}