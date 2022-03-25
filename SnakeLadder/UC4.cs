using System;
namespace SnakeLadder
{
    public class UC4
    {
        public UC4()
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
    }
}
