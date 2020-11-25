using System;
using System.IO;

namespace DeleteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DeleteFromFruits();
            DeleteFromVegetables();
        }

        public static void DeleteFromFruits()
        {
            string rootPath = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task\fruit";
            string fileName = "toiletPaper.txt";

            if (File.Exists(Path.Combine(rootPath, fileName)))
            {
                File.Delete(Path.Combine(rootPath, fileName));
                Console.WriteLine("File deleted.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }

        }

        public static void DeleteFromVegetables()
        {
            string rootPath = @"C:\Users\opilane\samples\LOGITpe20-Week12-WorkingWithFiles-Task\vegetables";
            string fileName = "cheese.txt";

            if (File.Exists(Path.Combine(rootPath, fileName)))
            {
                File.Delete(Path.Combine(rootPath, fileName));
                Console.WriteLine("File deleted.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
