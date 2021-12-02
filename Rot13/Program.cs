using System;

namespace HelloWorld2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;
            do
            {
                ProgramHeader();
                Console.WriteLine("Enter the text to encrypt:");
                string input = Console.ReadLine();
                Console.WriteLine($"\n{input} => {CipherText(input)}\n");
                Console.WriteLine("Encrypt Another? [Y]es or [N]o ?");
                keepPlaying = keepGoing();
            } while(keepPlaying);

        }

        public static void ProgramHeader()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Rot 13 Cipher -- by Wyatt Marshall");
            Console.ResetColor();

        }

        public static string CipherText(string s)
        {
            string cipherText = "";
            foreach (var item in s)
            {
                // Handle Upper Case Characters 
                if(item >= 65 && item <= 90)
                {
                    if(((int)item + 13) >= 90)
                    {
                        int i = ((int)item + 13) - 26;
                        cipherText += (char)i;
                    } else
                    {
                        int i = (int)item + 13;
                        cipherText += (char)i;
                    }
                }

                // Handle Lower Case Characters 
                if (item >= 97 && item <= 122)
                {
                    if (((int)item + 13) >= 122)
                    {
                        int i = ((int)item + 13) - 26;
                        cipherText += (char)i;
                    }
                    else
                    {
                        int i = (int)item + 13;
                        cipherText += (char)i;
                    }
                }

                // Handle numbers 48-57
                if (item >= 48 && item <= 57)
                {
                    if (((int)item + 13) >= 57)
                    {
                        int i = ((int)item + 13) - 11;
                        cipherText += (char)i;
                    }
                    else
                    {
                        int i = (int)item + 13;
                        cipherText += (char)i;
                    }
                }
            }
            return cipherText;
        }

        public static bool keepGoing()
        {
            while (true)
            {
                string playAgain = Console.ReadLine();
                if (playAgain != "" && (playAgain[0] == 'Y' || playAgain[0] == 'y'))
                {
                    return true;
                }
                else if (playAgain != "" && (playAgain[0] == 'N' || playAgain[0] == 'n'))
                {
                    return false;
                } else
                {
                    Console.WriteLine("Invalid input, please enter 'Y' for Yes or 'N' for No...");
                }
            }
            
        }
    }

}

