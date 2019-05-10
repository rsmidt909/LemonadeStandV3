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
        public bool moneyText;
        public bool priceText;
        public bool setPriceText;
        public bool timeForLemonadeText;
        public bool noMoreCustomersText;
        public bool profitForDayText;
        public bool weatherText;
        public bool gameOverText;


        //Constructor (BUILDS OBJECT)
        public Game()
        {
            
            day = new Day();           
            moneyText = true;
            priceText = true;
            setPriceText = true;
            timeForLemonadeText = true;
            noMoreCustomersText = true;
            profitForDayText = true;
            weatherText = true;
            gameOverText = false;








        }



        //member methods(CAN DO)






        public  void GameCheck()
        {
            if (day.player.wallet.totalMoney <= day.player.store.costOfSupplies)
            {
                gameOverText = true;
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
            UserInterface.WeatherText(weatherText);
            day.weather.OneDayOrSeven();           
            Console.ReadLine();
            Console.Clear();           
            UserInterface.PriceText(priceText, day.player.store);
            UserInterface.MoneyText(moneyText, day.player.wallet);           
            day.player.CheckLemonOrderingMoney();
            GameCheck();
            UserInterface.MoneyText(moneyText, day.player.wallet);
            day.player.CheckSugarOrderingMoney();
            GameCheck();
            UserInterface.MoneyText(moneyText, day.player.wallet);
            day.player.CheckIceOrderingMoney();
            GameCheck();
            UserInterface.MoneyText(moneyText, day.player.wallet);
            day.player.CheckCupOrderingMoney();
            GameCheck();
            WhoMakesRecipe(day.player.inventory);
            UserInterface.SetPriceText(setPriceText, day.player);
            day.player.SetPurchasePrice();
            Console.Clear();
            UserInterface.LemonadeTimeText(timeForLemonadeText);
            day.AmountOfCustomersForDay();
            day.FlowOfCustomers();
            UserInterface.NoMoreCustomersText(noMoreCustomersText);           
            Console.ReadLine();
            day.ProfitFromLemonadeSold();
            day.player.inventory.Perishable();
            UserInterface.ProfitForTheDayText(profitForDayText, day.player.wallet);
            UserInterface.MoneyText(moneyText, day.player.wallet);
            Console.ReadLine();
            StatReset();
            GameCheck();
            Run();

        }



    }
}
