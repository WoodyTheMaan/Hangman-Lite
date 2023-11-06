namespace Hangman_Lite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wrongGuess = 0;
            string displayWord = "________", secretWord = "COMPUTER";
            bool repeat = true;
            bool done = false;
            Console.WriteLine("Hangman Lite");
            Console.WriteLine("");
            Console.WriteLine("A Gration's Lite LLC creation");
            Console.WriteLine("Please click 'ENTER'");
            Console.ReadLine();
            Thread.Sleep(100);
            Console.WriteLine("Please wait....");
            Thread.Sleep(600);
            
           

            while (repeat)
            {
                string guess = "";
                while (guess.Length != 1)
                {
                    Console.WriteLine("Place a guess");
                    guess = Console.ReadLine().ToUpper();
                }
                bool correctGuess = false;
                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (guess[0] == secretWord[i])
                    {
                        displayWord = displayWord.Remove(i,1);
                        displayWord = displayWord.Insert(i, guess);
                        correctGuess = true;
                    }
                }

                if (!correctGuess)
                {
                    wrongGuess = wrongGuess + 1;
                    Console.WriteLine("You guessed wrong");
                    Console.WriteLine("Click Enter to continue");
                    Console.ReadLine();
                }
                if (!displayWord.Contains('_'))
                {
                    Console.WriteLine("YOU WON!!!!");
                    Console.WriteLine("The word was COMPUTER!");
                    break;
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
                    Console.WriteLine("You lost.....");
                    Console.WriteLine($"The Word: {secretWord}");
                    
                    done = !done;

                }
            }
        }
    }
}