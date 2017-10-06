using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            CandyShop candyShop = new CandyShop(300, 100);
            candyShop.PrintInfo();
        }
    }
}
