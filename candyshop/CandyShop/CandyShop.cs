using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop
{
    class CandyShop
    {
        private int income;
        private int sugar;
        List<Sweets> sweetList;

        public CandyShop(int income, int sugar)
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

            return string.Format("Invetory: {0} candies, {1} lollipops, Income: {2}$, Sugar: {3}gr", numberOfCandies, numberOfLollipops, income, sugar);
        }

        public void Sell (int amount)
        {

        }

        public void Raise (double number)
        {

        }

        public void BuySugar (int amount)
        {

        }
    }
}
