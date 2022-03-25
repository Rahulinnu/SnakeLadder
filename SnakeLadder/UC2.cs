using System;
namespace SnakeLadder
{
    public class UC2
    {
        public UC2()
        {
            Console.WriteLine("Welcome to UC2");

            Random random = new Random();
            int dice1 = random.Next(1, 7);
            Console.WriteLine("The Random Dice number is :" + dice1);
            Console.ReadLine();
        }
    }
}
