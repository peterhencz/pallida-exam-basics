using System;
using System.Collections.Generic;
using System.IO;

namespace FavouriteAnimals
{
    class Animals
    {
        static string pathToFavourites = @"../../favourites.txt";
        string[] contentOfFavourites = File.ReadAllLines(pathToFavourites);

        public void UsageInfo()
        {
            Console.WriteLine("C# FavouriteAnimals [animal] [animal]");
        }

        public void AddAnimals (string[] args)
        {
            try
            {
                using (StreamWriter writer = File.AppendText(pathToFavourites))
                {
                    for (int i = 0; i < args.Length; i++)
                    {
                        // TODO
                        writer.WriteLine(args[i]);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Unable to add");
            }
        }
    }
}
