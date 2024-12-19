using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Number_Gussing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game welcomeClass = new Game();

            welcomeClass.Game_01();
            //welcomeClass.Game_01_PlayAgain();



        }

        class Game
        {
            static Random randoms = new Random();
            int gussing_number;
            int DSL;
            int UIG;
            public void Game_01()
            {
                gussing_number = randoms.Next(0, 100);
                Game_01_main_code();
            }
            public void Game_01_userinput_code()
            {
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.Write("Enter your guess : ");
                int user_input = Convert.ToInt32(Console.ReadLine());
                UIG = user_input;

                if (UIG > 100)
                {
                    Console.WriteLine();
                    Console.WriteLine("You input number " + UIG + " is not in table sorry your chance will recover soon.");

                    DSL--;
                }

                else if (UIG < gussing_number)
                {
                    Console.WriteLine();
                    Console.WriteLine("Incorrect! The number is greater than  " + UIG + ".");
                }
                else if (UIG > gussing_number)
                {
                    Console.WriteLine();
                    Console.WriteLine("Incorrect! The number is less than  " + UIG + ".");
                }



            }

            public void Game_01_main_code()
            {
                try
                {
                    Console.WriteLine("Welcome to the Number Guessing Game!");
                    Console.WriteLine("I'm thinking of a number between 1 and 100.");
                    Console.WriteLine("You have chances according the difficulty level.");
                    Console.WriteLine();
                    Console.WriteLine("Please select the difficulty level:");
                    Console.WriteLine();
                    Console.WriteLine("1. Easy (10 chances)");
                    Console.WriteLine("2. Medium (5 chances)");
                    Console.WriteLine("3. Hard (3 chances)");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Enter your choice: ");

                    //Console.WriteLine(gussing_number);
                    int Difficulty_selection = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");

                    if (Difficulty_selection == 1)
                    {

                        Console.WriteLine("Great! You have selected the Easy difficulty level.");
                        Console.WriteLine("Let's start the game!");

                        for (DSL = 0; DSL < 10; DSL++)
                        {
                            Game_01_userinput_code();
                            if (UIG == gussing_number)
                            {
                                Console.WriteLine("Congratulations! You guessed the correct number in " + DSL + " attempts.");
                                Game_01_PlayAgain();
                                break;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("You lose please try again");
                        Game_01_PlayAgain();
                    }
                    else if (Difficulty_selection == 2)
                    {

                        Console.WriteLine("Great! You have selected the Medium difficulty level.");
                        Console.WriteLine("Let's start the game!");

                        for (DSL = 0; DSL < 5; DSL++)
                        {
                            Game_01_userinput_code();
                            if (UIG == gussing_number)
                            {
                                Console.WriteLine("Congratulations! You guessed the correct number in " + DSL + " attempts.");
                                Game_01_PlayAgain();
                                break;
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("You lose please try again");
                            Game_01_PlayAgain();
                        }
                    }
                    else if (Difficulty_selection == 3)
                    {

                        Console.WriteLine("Great! You have selected the Hard difficulty level.");
                        Console.WriteLine("Let's start the game!");


                        for (DSL = 0; DSL < 3; DSL++)
                        {
                            Game_01_userinput_code();
                            if (UIG == gussing_number)
                            {
                                Console.WriteLine("Congratulations! You guessed the correct number in " + DSL + " attempts.");
                                Game_01_PlayAgain();
                                break;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("You lose please try again");
                        Game_01_PlayAgain();
                    }
                    else
                    {
                        Console.WriteLine("Not a difficulty level");
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wronge Input");

                    Game welcomeClass = new Game();

                    welcomeClass.Game_01();
                }
            }

            public void Game_01_PlayAgain()
            {



                Console.WriteLine("Would you lick to Play Again");
                Console.WriteLine();
                Console.WriteLine("1. Yes : 2. No");
                Console.WriteLine();
                Console.Write("Enter your choice: ");

                int playagain_input = Convert.ToInt32(Console.ReadLine());

                if (playagain_input == 1)
                {
                    Console.Clear();
                    Game_01();
                }
                else if (playagain_input == 2)
                {
                    Environment.Exit(0);
                }

            }
        }
    }
}
