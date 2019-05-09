using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LemonadeStand
{
    class Player
    {


        //member variables (HAS A)
        public LemonadeMachine lemonadeMachine;
        public int CostOfLemon;
        public int CostOfSugar;
        public int CostOfIce;
        public int CostOfCup;                
        string response;        
        public int costOfSupplies;
        public int maxPrice;
        public int priceofLemonade;
        public int cupsOfLemonadeSold;       
        int numberResponse;       
        public Wallet wallet;
        
        




        //Constructor (BUILDS OBJECT)
        public Player()
        {
                                
            CostOfCup = 1;
            CostOfIce = 1;
            CostOfSugar = 1;
            CostOfLemon = 1;            
            costOfSupplies = CostOfCup + CostOfIce + CostOfSugar + CostOfLemon;
            maxPrice = costOfSupplies * 2;            
            cupsOfLemonadeSold = 0;
            priceofLemonade = 0;            
            numberResponse = 0;
            response = null;            
            lemonadeMachine = new LemonadeMachine();
            wallet = new Wallet();
            
            
        }



        //member methods(CAN DO)



        public void CheckLemonOrderingMoney()
        {
            if (wallet.totalMoney < wallet.costOfLemon)
            {
                Console.WriteLine("You dont have enough money to order any lemons");
            }

            else { OrderLemons(); }
        }

        public void OrderLemons()
        {

            Console.WriteLine("How many Lemons would you like to purchase?");
            response = Console.ReadLine();

            bool parseSuccess = int.TryParse(response, out numberResponse);
            if (parseSuccess)
            {               
                lemonadeMachine.inventory.lemons = numberResponse;
            }
            else
            {
                Console.WriteLine("That was not a number.");
                OrderLemons();
            }


            wallet.totalMoney = wallet.totalMoney - (int.Parse(response) * CostOfLemon);
        }
        /*public void OrderLemons()
        {
            
            Console.WriteLine("How many Lemons would you like to purchase?");
            response = Console.ReadLine();
            
            bool parseSuccess = int.TryParse(response, out numberResponse);
            if (parseSuccess)
            {
                bool canAffordLemons= wallet.CheckLemonOrderingMoney();
                lemonadeMachine.inventory.lemons = numberResponse;
            }
            else
            {                
                Console.WriteLine("That was not a number.");
                OrderLemons();
            }


            totalMoney = totalMoney - (int.Parse(response) * CostOfLemon);
        }*/
        //--------------lemons---------------------------------------------------------------------

        public void CheckSugarOrderingMoney()
        {
            if (wallet.totalMoney < wallet.costOfSugar)
            {
                Console.WriteLine("You dont have enough money to order any Sugar");
            }
            else { OrderSugar(); }
        }
        public void OrderSugar()
        {
            Console.WriteLine("How many cubes of Sugar would you like to purchase?");
            response = Console.ReadLine();            
            bool parseSuccess = int.TryParse(response, out numberResponse);
            if (parseSuccess)
            {
                lemonadeMachine.inventory.sugar = numberResponse;
            }
            else
            {
                Console.WriteLine("That was not a number.");
                OrderSugar();
            }
            wallet.totalMoney = wallet.totalMoney - (int.Parse(response) * CostOfSugar);
        }
        //-------------Sugar-----------------------------------------------------------------------

        public void CheckIceOrderingMoney()
        {
            if (wallet.totalMoney < wallet.costOfIce)
            {
                Console.WriteLine("You dont have enough money to order any Ice");
            }
            else { OrderIce(); }
        }

        public void OrderIce()
        {
            Console.WriteLine("How many cubes of Ice would you like to purchase?");
            response = Console.ReadLine();           
            bool parseSuccess = int.TryParse(response, out numberResponse);
            if (parseSuccess)
            {
                lemonadeMachine.inventory.ice = numberResponse;
            }
            else
            {
                Console.WriteLine("That was not a number.");
                OrderIce();
            }
            wallet.totalMoney = wallet.totalMoney - (int.Parse(response) * CostOfIce);
        }

        //-----------Ice-------------------------------------------------------------
        public void CheckCupOrderingMoney()
        {
            if (wallet.totalMoney < wallet.costOfCup)
            {

                Console.WriteLine("You dont have enough money to order any Cups");
            }
            else
            {
                OrderCup();
            }
        }

            public void OrderCup()
            {
            Console.WriteLine("How many Cups would you like to purchase?");
            response = Console.ReadLine();
            bool parseSuccess = int.TryParse(response, out numberResponse);
            if (parseSuccess)
            {
                lemonadeMachine.inventory.cups = numberResponse;
            }
            else
            {
                Console.WriteLine("That was not a number.");
                OrderCup();
            }
            wallet.totalMoney = wallet.totalMoney - (int.Parse(response) * CostOfCup);
        }

        //------------Cups-----------------------------------------------------------

        

        public void SetPurchasePrice()
        {
            response = Console.ReadLine();           
            bool parseSuccess = int.TryParse(response, out numberResponse);
            if (parseSuccess)
            {
                priceofLemonade = numberResponse;
            }
            else
            {
                Console.WriteLine("That was not a number.");
                SetPurchasePrice();
            }
                if (priceofLemonade > maxPrice)
            {
                Console.WriteLine("That price is higher than the allowed limit, please try again.");
                SetPurchasePrice();
            }
        }

        

        

        

        



    }   
        
        
    
}
