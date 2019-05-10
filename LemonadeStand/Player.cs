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
                UserInterface.NotEnoughLemonMoney();
            }

            else { OrderLemons(); }
        }

        public void OrderLemons()
        {

            UserInterface.HowManyLemonsToPurchase();
            response = Console.ReadLine();

            bool parseSuccess = int.TryParse(response, out numberResponse);
            if (parseSuccess)
            {               
                inventory.amountOfLemon = numberResponse;
            }
            else
            {
                UserInterface.NotANumber();
                OrderLemons();
            }


            wallet.totalMoney = wallet.totalMoney - (int.Parse(response) * store.costOfLemon);
        }
        
        //--------------lemons---------------------------------------------------------------------

        public void CheckSugarOrderingMoney()
        {
            if (wallet.totalMoney < store.costOfSugar)
            {
                UserInterface.NotEnoughSugarMoney()
            }
            else { OrderSugar(); }
        }
        public void OrderSugar()
        {
            UserInterface.HowManySugarCubesToPurchase();
            response = Console.ReadLine();            
            bool parseSuccess = int.TryParse(response, out numberResponse);
            if (parseSuccess)
            {
                inventory.amountOfSugar = numberResponse;
            }
            else
            {
                UserInterface.NotANumber();
                OrderSugar();
            }
            wallet.totalMoney = wallet.totalMoney - (int.Parse(response) * store.costOfSugar);
        }
        //-------------Sugar-----------------------------------------------------------------------

        public void CheckIceOrderingMoney()
        {
            if (wallet.totalMoney < store.costOfIce)
            {
                UserInterface.NotEnoughIceMoney();
            }
            else { OrderIce(); }
        }

        public void OrderIce()
        {
            UserInterface.HowManyIceCubesToPurchase();
            response = Console.ReadLine();           
            bool parseSuccess = int.TryParse(response, out numberResponse);
            if (parseSuccess)
            {
                inventory.amountOfIce = numberResponse;
            }
            else
            {
                UserInterface.NotANumber();
                OrderIce();
            }
            wallet.totalMoney = wallet.totalMoney - (int.Parse(response) * store.costOfIce);
        }

        //-----------Ice-------------------------------------------------------------
        public void CheckCupOrderingMoney()
        {
            if (wallet.totalMoney < store.costOfCup)
            {

                UserInterface.NotEnoughCupMoney();
            }
            else
            {
                OrderCup();
            }
        }

            public void OrderCup()
            {
            UserInterface.HowManyCupsToPurchase();
            response = Console.ReadLine();
            bool parseSuccess = int.TryParse(response, out numberResponse);
            if (parseSuccess)
            {
                inventory.amountOfCup = numberResponse;
            }
            else
            {
                UserInterface.NotANumber();
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
                UserInterface.NotANumber();
                SetPurchasePrice();
            }
                if (priceofLemonade > maxPrice)
            {
                UserInterface.PriceHigherThanAllowed();
                SetPurchasePrice();
            }
        }

        

        

        

        



    }   
        
        
    
}
