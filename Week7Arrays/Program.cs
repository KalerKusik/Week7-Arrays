using System;

namespace Week7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal valida, mida ta hommikusöögiks sööbstring

            string[] food = { "joe nuts", "jogurt", "peekon", "auto", "roblox studio game engine" };

            food[2] = "among drip";

            Console.WriteLine("Menüüs:");

            for(int i = 0; i < food.Length; i++)
            {
                Console.WriteLine(food[i]);
            }

            Console.WriteLine("Vali toit (sisesta number 1-5):");

            int userChoice = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine($"Oled valinud {food[userChoice]}");
        }
    }
}
