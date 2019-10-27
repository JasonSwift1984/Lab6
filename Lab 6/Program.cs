using System;

namespace Lab_6
{
    
        class Program
        {
            static void Main(string[] args)
            {
                bool again = true;

                Console.WriteLine("Welcome to the Grand Circus Casino!Roll the dice ? (y / n)");
                string UserInput = Console.ReadLine();

                while (again)
                {

                    if (UserInput == "Y" || UserInput == "y")
                    {
                        Console.WriteLine("How many sides should each die have");


                        int diceSides1 = int.Parse(Console.ReadLine());
                        int diceSides2 = diceSides1;

                        if (diceSides1 >= 1)
                        {
                            Random rnd = new Random();
                            int rollDice = rnd.Next(1, diceSides1 + 1);
                            int rollDice2 = rnd.Next(1, diceSides2 + 1);
                            Console.WriteLine(rollDice + "\n" + rollDice2);
                            Console.WriteLine("Roll Again? (y / n)");
                            string UserInput2 = Console.ReadLine();


                            if (UserInput2 == "Y" || UserInput2 == "y")
                            {

                            }
                            else if (UserInput2 == "n" || UserInput2 == "N")
                            {
                                Console.WriteLine("Exiting");
                                again = false;
                            }
                            else
                            {
                                Console.WriteLine("Invalid");
                                again = false;
                            }





                        }



                    }
                    else if (UserInput == "n" || UserInput == "N")
                    {
                        Console.WriteLine("Exiting");
                        again = false;
                    }
                    else
                    {
                        Console.WriteLine("GoodBye invalid response");
                        again = false;
                    }
                }

            }



        }
    }
