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
                                  
        public Day day;


        //Constructor (BUILDS OBJECT)
        public Game()
        {
            
            day = new Day();                                  

        }



        //member methods(CAN DO)






        public  void GameCheck()
        {
            if (day.player.wallet.totalMoney <= day.player.store.costOfSupplies)
            {
                UserInterface.GameOverText();
                Console.ReadLine();
                Environment.Exit(0);
            }
        }



        public void StatReset()
        {
            day.player.cupsOfLemonadeSold = 0;
            day.player.wallet.profit = 0;
        }

        

        public void WhoMakesRecipe(Inventory inventory)
        {
            UserInterface.MakeRecipeQuestion();
            string recipeDecision = Console.ReadLine();
            switch (recipeDecision)
            {
                case "Yes":
                    day.player.lemonadeMachine.MakePlayerRecipe();
                    day.player.lemonadeMachine.CanIMakePlayerRecipeLemonade(inventory);
                    break;
                case "No":
                    day.player.lemonadeMachine.CanIMakeLemonade(inventory);
                    break;
                default:
                    UserInterface.NotAnOption();
                    WhoMakesRecipe(inventory);
                    break;
            }
        }

        
        

        public void Run()
        {
            Console.Clear();
            UserInterface.WeatherText();
            day.weather.OneDayOrSeven();           
            Console.ReadLine();
            Console.Clear();           
            UserInterface.PriceText(day.player.store);
            UserInterface.MoneyText(day.player.wallet);           
            day.player.CheckLemonOrderingMoney();
            GameCheck();
            UserInterface.MoneyText(day.player.wallet);
            day.player.CheckSugarOrderingMoney();
            GameCheck();
            UserInterface.MoneyText(day.player.wallet);
            day.player.CheckIceOrderingMoney();
            GameCheck();
            UserInterface.MoneyText(day.player.wallet);
            day.player.CheckCupOrderingMoney();
            GameCheck();
            WhoMakesRecipe(day.player.inventory);
            UserInterface.SetPriceText(day.player);
            day.player.SetPurchasePrice();
            Console.Clear();
            UserInterface.LemonadeTimeText();
            day.AmountOfCustomersForDay();
            day.FlowOfCustomers();
            UserInterface.NoMoreCustomersText();           
            Console.ReadLine();
            day.ProfitFromLemonadeSold();
            day.player.inventory.Perishable();
            UserInterface.ProfitForTheDayText(day.player.wallet);
            UserInterface.MoneyText(day.player.wallet);
            Console.ReadLine();
            StatReset();
            GameCheck();
            Run();

        }



    }
}
