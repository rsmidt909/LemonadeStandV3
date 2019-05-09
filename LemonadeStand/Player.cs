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
        string response;               
        public int maxPrice;
        public int priceofLemonade;
        public int cupsOfLemonadeSold;       
        int numberResponse;       
        public Wallet wallet;
        public Inventory inventory;
        public Store store;
        
        




        //Constructor (BUILDS OBJECT)
        public Player()
        {
                                                                          
            cupsOfLemonadeSold = 0;
            priceofLemonade = 0;            
            numberResponse = 0;
            response = null;            
            lemonadeMachine = new LemonadeMachine();
            wallet = new Wallet();
            inventory = new Inventory();
            store = new Store();
            maxPrice = store.costOfSupplies * 2;



        }



        //member methods(CAN DO)



        public void CheckLemonOrderingMoney()
        {
            if (wallet.totalMoney < store.costOfLemon)
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
                inventory.amountOfLemon = numberResponse;
            }
            else
            {
                Console.WriteLine("That was not a number.");
                OrderLemons();
            }


            wallet.totalMoney = wallet.totalMoney - (int.Parse(response) * store.costOfLemon);
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
            if (wallet.totalMoney < store.costOfSugar)
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
                inventory.amountOfSugar = numberResponse;
            }
            else
            {
                Console.WriteLine("That was not a number.");
                OrderSugar();
            }
            wallet.totalMoney = wallet.totalMoney - (int.Parse(response) * store.costOfSugar);
        }
        //-------------Sugar-----------------------------------------------------------------------

        public void CheckIceOrderingMoney()
        {
            if (wallet.totalMoney < store.costOfIce)
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
                inventory.amountOfIce = numberResponse;
            }
            else
            {
                Console.WriteLine("That was not a number.");
                OrderIce();
            }
            wallet.totalMoney = wallet.totalMoney - (int.Parse(response) * store.costOfIce);
        }

        //-----------Ice-------------------------------------------------------------
        public void CheckCupOrderingMoney()
        {
            if (wallet.totalMoney < store.costOfCup)
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
                inventory.amountOfCup = numberResponse;
            }
            else
            {
                Console.WriteLine("That was not a number.");
                OrderCup();
            }
            wallet.totalMoney = wallet.totalMoney - (int.Parse(response) * store.costOfCup);
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
