using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LemonadeStand
{
    class Game
    {

        //member variables (HAS A)
        
        public string response;
        public int lemonNumber;
        public int sugarNumber;
        public int iceNumber;
        public int numberResponse;                     
        
        public Day day;
        
       







        //Constructor (BUILDS OBJECT)
        public Game()
        {

            day = new Day();
            response = null;
            lemonNumber = 0;
            sugarNumber = 0;
            iceNumber = 0;
            numberResponse = 0;
            
            
            



        }



        //member methods(CAN DO)



        
        

        

        public void GameCheck()
        {
            if (day.player.wallet.totalMoney <= day.player.costOfSupplies)
            {
                Console.WriteLine("You ran out of money to make a single cup of lemonade! Game Over!");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        public void StatReset()
        {
            day.player.cupsOfLemonadeSold = 0;
            day.player.wallet.profit = 0;
        }

        

        public void WhoMakesRecipe()
        {
            Console.WriteLine("Would you like to make the recipe, 'Yes' or 'No'");
            string recipeDecision = Console.ReadLine();
            switch (recipeDecision)
            {
                case "Yes":
                    day.player.lemonadeMachine.MakePlayerRecipe();
                    day.player.lemonadeMachine.CanIMakePlayerRecipeLemonade();
                    break;
                case "No":
                    day.player.lemonadeMachine.CanIMakeLemonade();
                    break;
                default:
                    Console.WriteLine("That is not an option, please try again.");
                    WhoMakesRecipe();
                    break;
            }
        }

        

        public void MasterMeth()
        {
            Console.Clear();
            Console.WriteLine("Youre Total Money is " + day.player.wallet.totalMoney);
            Console.WriteLine("Would you like to see just 'One' days weather or the next 'Seven' days?");
            day.weather.OneDayOrSeven();
            Console.WriteLine("Press enter....");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("The price of lemons are " + day.player.CostOfLemon + " Dollars");
            day.player.CheckLemonOrderingMoney();
            GameCheck();
            Console.WriteLine("You have " + day.player.wallet.totalMoney + " Dollars left.");
            Console.WriteLine("The price of Sugar cubes are " + day.player.CostOfSugar + " Dollars");
            day.player.CheckSugarOrderingMoney();
            GameCheck();
            Console.WriteLine("You have " + day.player.wallet.totalMoney + " Dollars left.");
            Console.WriteLine("The price of Ice are " + day.player.CostOfIce + " Dollars");
            day.player.CheckIceOrderingMoney();
            GameCheck();
            Console.WriteLine("You have " + day.player.wallet.totalMoney + " Dollars left.");
            Console.WriteLine("The price of Cups are " + day.player.CostOfCup + " Dollars");
            day.player.CheckCupOrderingMoney();
            GameCheck();
            WhoMakesRecipe();
            Console.WriteLine("What would you like to set the price of one cup of lemonade?");
            Console.WriteLine("You cannot set the price higher than 2 times the amount that the supplies cost individually.");
            Console.WriteLine("The max set price is " + day.player.maxPrice + " Dollars.");
            Console.WriteLine("*Tip* If you set the price too high, you will have a lower cance of lemonade being purchased! *Tip*");
            day.player.SetPurchasePrice();
            Console.Clear();
            Console.WriteLine("Time to sell some Lemonade!");
            day.AmountOfCustomersForDay();
            day.FlowOfCustomers();
            Console.WriteLine("No more customers for the day!");
            Console.ReadLine();
            day.ProfitFromLemonadeSold();
            day.player.lemonadeMachine.inventory.Perishable();
            Console.WriteLine("Youre profit for the day is " + day.player.wallet.profit);
            Console.WriteLine("Youre total money is " + day.player.wallet.totalMoney);
            Console.ReadLine();
            StatReset();
            GameCheck();
            MasterMeth();

        }



    }
}
