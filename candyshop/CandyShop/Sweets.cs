using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop
{
    class Sweets
    {
        protected double price;
        protected int sugar;


        public double GetPrice()
        {
            return this.price;
        }

        public int GetSugar()
        {
            return this.sugar;
        }

        public void IncreasePrice(double percentage)
        {
            price *= (percentage/100);
        }
    }
}
