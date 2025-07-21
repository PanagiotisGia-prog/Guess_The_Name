using System.Xml.Linq;

namespace Guess_the_name
{
    internal class Program
    {
        static int playerNum = 0;
        static void Main(string[] args)
        {
            /*
             * Guess The Name Game
             * -------------------
             * This is a simple console game where the player tries to guess the same name as the computer.
             * The player is shown a list of names and can choose by typing either the number or the name.
             * The computer randomly selects a name each round.
             * If the player's choice matches the computer's, they win and their score increases.
             * The game continues until the player decides to stop.
             * 
             * Created as a learning project for practicing C# basics, user input, and randomization.
             */

            bool state = true;
            Random guess = new Random();
            string[] names = { "James", "Maria", "Anissa", "Antonis", "Panagiotis", "Ingrid", "Fernado", "Korina", "Thomas", "Vasiliki", "Paraskeuas" };


            //Console.WriteLine(cpu[name]);

            Console.WriteLine("Let's play <<Guess The Name>>");
            Console.WriteLine("You're gonna be given a list with names and you need to choose one of them.");
            Console.WriteLine("You're goal is to guess the same name with the computer, if you do then you win otherwise you can try again from the start");

            int correctGuess = 0;

            while (state)
            {
                Console.WriteLine("Let's start check all the names and pick one:\n");
                Console.WriteLine("1. James\n2. Maria\n3. Anissa\n4. Antonis\n5. Panagiotis\n6. Ingrid\n7. Fernado\n8. Korina\n9. Thomas\n10. Vasiliki\n11. Paraskeuas");
                Console.WriteLine("\nRemember you can type either the number or the name");


                int cpu = guess.Next(0, names.Length);

                string? player = Console.ReadLine()?.ToLower();

                if (player != null)
                {
                    switch (player)
                    {
                        case "1":
                        case "james":
                            Console.WriteLine($"\nYou chose the name: {names[0]}");
                            playerNum = 0;
                            //state = false;
                            break;

                        case "2":
                        case "maria":
                            Console.WriteLine($"\nYou chose the name: {names[1]}");
                            playerNum = 1;
                            //state = false;
                            break;

                        case "3":
                        case "anissa":
                            Console.WriteLine($"\nYou chose the name: {names[2]}");
                            playerNum = 2;
                            //state = false;
                            break;

                        case "4":
                        case "antonis":
                            Console.WriteLine($"\nYou chose the name: {names[3]}");
                            playerNum = 3;
                            //state = false;
                            break;

                        case "5":
                        case "panagiotis":
                            Console.WriteLine($"\nYou chose the name: {names[4]}");
                            playerNum = 4;
                            //state = false;
                            break;

                        case "6":
                        case "ingrid":
                            Console.WriteLine($"\nYou chose the name: {names[5]}");
                            playerNum = 5;
                            //state = false;
                            break;

                        case "7":
                        case "fernado":
                            Console.WriteLine($"\nYou chose the name: {names[6]}");
                            playerNum = 6;
                            //state = false;
                            break;

                        case "8":
                        case "korina":
                            Console.WriteLine($"\nYou chose the name: {names[7]}");
                            playerNum = 7;
                            //state = false;
                            break;

                        case "9":
                        case "thomas":
                            Console.WriteLine($"\nYou chose the name: {names[8]}");
                            playerNum = 8;
                            //state = false;
                            break;

                        case "10":
                        case "vasiliki":
                            Console.WriteLine($"\nYou chose the name: {names[9]}");
                            playerNum = 9;
                            //state = false;
                            break;

                        case "11":
                        case "paraskeuas":
                            Console.WriteLine($"\nYou chose the name: {names[10]}");
                            playerNum = 10;
                            //state = true;
                            break;

                        default:
                            Console.WriteLine("\nInvalid Input please enter a valid name or number");
                            continue;
                    }
                }
                else
                {
                    Console.WriteLine("\nYou need to guess a name.");
                    continue;
                }

                Console.WriteLine($"CPU chose the name: {names[cpu]}");

                if (playerNum != cpu)
                {
                    Console.WriteLine("\nUnfortunately you didn't guessed correctly, but you can try again");
                }
                else
                {
                    Console.WriteLine("\nYou guessed correctly! Congratulations!");
                    correctGuess++;
                }

                Console.WriteLine($"\nYou have guessed correctly {correctGuess} times!");

                Console.WriteLine("\nDo you wanna play again? type (Y/N)");
                string? playAgain = Console.ReadLine()?.ToLower();
                if (playAgain is not "y" or "yes")
                {
                    state = false;
                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}
