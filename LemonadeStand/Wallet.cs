using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Wallet
    {


        //member variables (HAS A)
        public int totalMoney;
        public int profit;
        public int costOfCup;
        public int costOfIce;
        public int costOfSugar;
        public int costOfLemon;



        //Constructor (BUILDS OBJECT)
        public Wallet()
        {
            totalMoney = 75;
            profit = 0;
            costOfCup = 1;
            costOfIce = 1;
            costOfSugar = 1;
            costOfLemon = 1;

        }



        //member methods(CAN DO)
       
        
        /*public bool CheckLemonOrderingMoney()
        {
            if (totalMoney < costOfLemon)
            {
                Console.WriteLine("You dont have enough money to order any lemons");
            }

            return (totalMoney > costOfLemon);
            //else { OrderLemons(); }
        }*/


        
        

        

    }
}
