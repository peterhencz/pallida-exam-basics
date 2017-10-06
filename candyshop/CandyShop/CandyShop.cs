using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop
{
    class CandyShop
    {
        private double income;
        private int sugar;
        List<Sweets> sweetList;
        Sweets sweet = new Sweets();

        public CandyShop(double income, int sugar)
        {
            this.income = income;
            this.sugar = sugar;
        }

        public void CreateCandy(Candy candy)
        {
            sweetList.Add(new Candy());
        }

        public void CreateLollipop(Lollipop lollipop)
        {
            sweetList.Add(new Lollipop());
        }

        public string PrintInfo()
        {
            int numberOfCandies = 0;
            int numberOfLollipops = 0;

            for (int i = 0; i < sweetList.Count; i++)
            {
                //TODO
            }

            return string.Format("Invetory: {0} candies, {1} lollipops, Income: {2}$, Sugar: {3}gr", numberOfCandies, numberOfLollipops, income, sugar);
        }

        public void Sell (Sweets sweet, int amount)
        {
            //TODO
        }

        public void Raise (double number)
        {
            //TODO
        }

        public void BuySugar (int amountOfSugar)
        {
            double priceOfSugar = 0.1;
            income -= amountOfSugar * priceOfSugar;
            sugar += amountOfSugar; 
        }
    }
}
