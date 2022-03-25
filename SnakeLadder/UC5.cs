using System;
namespace SnakeLadder
{
    public class UC5
    {
        public UC5()
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
        }
    }

