using System;

namespace SnakeLadder
{
    internal class Program
    {
        public static void UC1()
        {
            Console.WriteLine("Welcome to UC1");
            Console.WriteLine("Snake and ladder with single player start at 0");
            int start = 0;

        }
        public static void UC2()
        {
            Console.WriteLine("Welcome to UC2");

            Random random = new Random();
            int dice1 = random.Next(1, 7);
            Console.WriteLine("The Random Dice number is :" + dice1);
            Console.ReadLine();

        }




        public static void UC3()
        {
            int ladder = 1, ldice;
            int snake = 2, sdice;
            Console.WriteLine("Welcome to UC3");
            Random random = new Random();
            int randomCheck = random.Next(3);

            switch (randomCheck)
            {
                case 1:
                    {
                        Random rnd = new Random();
                        ldice = rnd.Next(1, 7);
                        Console.WriteLine("Got Ladder");
                        break;
                    }
                case 2:
                    {
                        Random sran = new Random();
                        sdice = sran.Next(1, 7);
                        Console.WriteLine("Got snake");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("No play, Stay at base");
                        break;
                    }
            }

            Console.ReadLine();



        }
        public static void UC4()
        {
            int ladder = 1, ldice;
            int snake = 2, sdice;
            int win = 100;
            int count = 0;
            Console.WriteLine("Welcome to UC4");
            while (count <= win)
            {
                if (count >= 0)
                {
                    Random random = new Random();
                    int randomCheck = random.Next(3);

                    switch (randomCheck)
                    {
                        case 1:
                            {
                                Random rnd = new Random();
                                ldice = rnd.Next(1, 7);
                                count = count + ldice;
                                Console.WriteLine("Got Ladder");
                                break;
                            }
                        case 2:
                            {
                                Random sran = new Random();
                                sdice = sran.Next(1, 7);
                                count = count - sdice;
                                Console.WriteLine("Got snake");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("No play");
                                break;
                            }
                    }
                }
                else
                {
                    count = 0;
                }

            }
            Console.WriteLine("Player wins" + count);

            Console.ReadLine();
        }

        public static void UC5()
        {
            int ladder = 1, ldice = 0;
            int snake = 2, sdice;
            int win = 100;
            int count = 0, a = 0;
            Console.WriteLine("Welcome to UC5");
            while (count != win)
            {
                if (count >= 0 && count < 100)
                {
                    Random random = new Random();
                    int randomCheck = random.Next(3);

                    switch (randomCheck)
                    {
                        case 1:
                            {
                                Console.WriteLine("Got Ladder");
                                Random rnd = new Random();
                                ldice = rnd.Next(1, 7);
                                count = count + ldice;
                                a = count;
                                break;
                            }
                        case 2:
                            {
                                Random sran = new Random();
                                sdice = sran.Next(1, 7);
                                count = count - sdice;
                                Console.WriteLine("Got snake");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("No play");
                                break;
                            }
                    }
                }
                else if (a > 100)
                {
                    count = a - ldice;
                }
                else
                {
                    count = 0;
                }

            }

            Console.WriteLine("Player wins" + count);
            Console.ReadLine();
        }

        public static void UC6()
        {
            int ladder = 1, ldice = 0;
            int snake = 2, sdice;
            int win = 100;
            int diceRoll = 0;
            int count = 0, a = 0;
            Console.WriteLine("Welcome to UC_6");
            while (count != win)
            {
                if (count >= 0 && count < 100)
                {
                    Random random = new Random();
                    int randomCheck = random.Next(3);
                    diceRoll++;

                    switch (randomCheck)
                    {
                        case 1:
                            {
                                Console.WriteLine("Got Ladder");
                                Random rnd = new Random();
                                ldice = rnd.Next(1, 7);
                                count = count + ldice;
                                Console.WriteLine("Position is " + count);
                                a = count;
                                break;
                            }
                        case 2:
                            {
                                Random sran = new Random();
                                sdice = sran.Next(1, 7);
                                count = count - sdice;
                                Console.WriteLine("Position is: " + count);
                                Console.WriteLine("Got snake");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("No play");
                                Console.WriteLine("Position is: " + count);
                                break;
                            }
                    }
                }
                else if (a > 100)
                {
                    count = a - ldice;
                }
                else
                {
                    count = 0;
                }

            }
            Console.WriteLine("Player wins" + count);
            Console.WriteLine("Number of time Dice Roll is to win: " + diceRoll);
            Console.ReadLine();

        }

        public static void UC7()
        {
            int ladder = 1, ldice = 0, ldice2 = 0;
            int snake = 2, sdice, sdice2;
            int win = 100;
            int diceRoll = 0, diceRoll2 = 0;
            int count = 0, count2 = 0, a = 0, b = 0;
            Console.WriteLine("Welcome to UC_7");
            while (count != win && count2 != win)//checking condition 
            {
                if ((count >= 0 && count < 100) && (count2 >= 0 && count2 < 100))//two player 
                {
                    Random random = new Random();
                    int randomCheck = random.Next(3);
                    diceRoll++;

                    switch (randomCheck)//Player one
                    {
                        case 1://got ladder
                            {
                                Console.WriteLine("Player 1 Got Ladder");
                                Random rnd = new Random();
                                ldice = rnd.Next(1, 7);
                                count = count + ldice;
                                if (count > 100)
                                {
                                    count -= ldice;
                                }
                                Console.WriteLine("Player 1 Position is " + count);
                                a = count;
                                break;
                            }
                        case 2://got snake
                            {
                                Random sran = new Random();
                                sdice = sran.Next(1, 7);
                                count = count - sdice;
                                if (count < 0)
                                {
                                    count += sdice;
                                }
                                Console.WriteLine("Player 1 Got snake");
                                Console.WriteLine("Player 1 position is: " + count);
                                break;
                            }
                        default://no play
                            {
                                Console.WriteLine("Player 1 No play");
                                Console.WriteLine("Player 1 Position is: " + count);
                                break;
                            }
                    }

                    if (randomCheck == 1)//got ladder so playing again
                    {
                        Random random3 = new Random();
                        int randomCheck3 = random3.Next(3);
                        diceRoll++;

                        switch (randomCheck3)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Player 1 Got Ladder");
                                    Random rnd3 = new Random();
                                    ldice = rnd3.Next(1, 7);
                                    count = count + ldice;
                                    if (count > 100)
                                    {
                                        count -= ldice;
                                    }
                                    Console.WriteLine("Player 1 Position is " + count);
                                    a = count;
                                    break;
                                }
                            case 2:
                                {
                                    Random sran3 = new Random();
                                    sdice = sran3.Next(1, 7);
                                    count = count - sdice;
                                    if (count < 0)
                                    {
                                        count += sdice;
                                    }
                                    Console.WriteLine("Player 1 Got snake");
                                    Console.WriteLine("Player 1 position is: " + count);
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Player 1 No play");
                                    Console.WriteLine("Player 1 Position is: " + count);
                                    break;
                                }
                        }
                    }
                    //Starting of Player two
                    Random random2 = new Random();
                    int randomCheck2 = random2.Next(3);
                    diceRoll2++;

                    switch (randomCheck2)
                    {
                        case 1:
                            {
                                Console.WriteLine("Player 2 Got Ladder");
                                Random rnd2 = new Random();
                                ldice2 = rnd2.Next(1, 7);
                                count2 = count2 + ldice2;
                                if (count2 > 100)
                                {
                                    count2 -= ldice2;
                                }
                                Console.WriteLine("Player 2 Position is " + count2);
                                b = count2;
                                break;
                            }
                        case 2:
                            {
                                Random sran2 = new Random();
                                sdice2 = sran2.Next(1, 7);
                                count2 = count2 - sdice2;
                                if (count2 < 0)
                                {
                                    count2 += sdice2;
                                }
                                Console.WriteLine("Player 2 Got snake");
                                Console.WriteLine("Player 2 Position is: " + count2);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Player 2 No play");
                                Console.WriteLine("Player 2 Position is: " + count2);
                                break;
                            }
                    }

                    if (randomCheck2 == 1)//got ladder so play again
                    {
                        Random random4 = new Random();
                        int randomCheck4 = random4.Next(3);
                        diceRoll2++;

                        switch (randomCheck4)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Player 2 Got Ladder");
                                    Random rnd4 = new Random();
                                    ldice2 = rnd4.Next(1, 7);
                                    count2 = count2 + ldice2;
                                    if (count2 > 100)
                                    {
                                        count2 -= ldice2;
                                    }
                                    Console.WriteLine("Player 2 Position is " + count2);
                                    b = count2;
                                    break;
                                }
                            case 2:
                                {
                                    Random sran4 = new Random();
                                    sdice2 = sran4.Next(1, 7);
                                    count2 = count2 - sdice2;
                                    if (count2 < 0)
                                    {
                                        count2 += sdice2;
                                    }
                                    Console.WriteLine("Player 2 Got snake");
                                    Console.WriteLine("Player 2 Position is: " + count2);
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Player 2 No play");
                                    Console.WriteLine("Player 2 Position is: " + count2);
                                    break;
                                }
                        }
                    }
                }
            }
            if (count > count2)
            {
                Console.WriteLine("Player 1 win and the point is: " + count);
                Console.WriteLine("Number of times dice roll is: " + diceRoll);
            }
            else
            {
                Console.WriteLine("Player 2 win and the point is: " + count2);
                Console.WriteLine("Number of times dice roll is: " + diceRoll2);
            }
        }

        static void Main(string[] args)
        {
            Program.UC1();
            Program.UC2();
            Program.UC3();
            Program.UC4();
            Program.UC5();
            Program.UC6();
            Program.UC7();
        }
    }
}