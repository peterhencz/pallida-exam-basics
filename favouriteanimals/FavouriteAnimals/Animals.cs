using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavouriteAnimals
{
    class Animals
    {
        static string path = @"../../favourites.txt";
        string[] contentFavourites = File.ReadAllLines(path);

        public void UsageInfo()
        {
            Console.WriteLine("C# FavouriteAnimals [animal] [animal]");
        }

        public void ListAnimals ()
        {
            for (int i = 0; i < contentFavourites.Length; i++)
            {
                Console.WriteLine(contentFavourites[i]);
            }
        }

        public void AddAnimals (string[] args)
        {
            try
            {
                using (StreamWriter writer = File.AppendText(path))
                {
                    writer.WriteLine(args[0]);

                    //for (int i = 0; i < args.Length; i++)
                    //{
                    //    writer.WriteLine(args[i]);
                    //}
                }
            }
            catch
            {
                Console.WriteLine("Unable to add");
            }
        }
    }
}
