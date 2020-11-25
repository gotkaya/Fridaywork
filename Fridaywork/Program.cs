using System;
using System.IO;

namespace Fridaywork
{
    class Program
    {
        static void Main(string[] args)
        {
            MoveFruits();
            MoveVegetables();
        }

        public static void MoveFruits()
        {
            string sourceDirectory = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task";
            string destinationPath = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task\fruit";
            Console.WriteLine("What fruits would you like to move?");
            string userInput = Console.ReadLine();

            if (File.Exists(Path.Combine(sourceDirectory, userInput)))
            {
                File.Move(Path.Combine(sourceDirectory, userInput), Path.Combine(destinationPath, userInput));
                Console.WriteLine("File moved.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }


        }

        public static void MoveVegetables()
        {
            string sourceDirectory = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task";
            string destinationPath = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task\vegetables";
            Console.WriteLine("What vegetables would you like to move?");
            string userInput = Console.ReadLine();

            if (File.Exists(Path.Combine(sourceDirectory, userInput)))
            {
                File.Move(Path.Combine(sourceDirectory, userInput), Path.Combine(destinationPath, userInput));
                Console.WriteLine("File moved.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }



        }
    }
}
