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
            response = null;
            lemonNumber = 0;
            sugarNumber = 0;
            iceNumber = 0;
            numberResponse = 0;
            moneyText = false;
            priceText = false;
            setPriceText = false;
            timeForLemonadeText = false;
            noMoreCustomersText = false;
            profitForDayText = false;
            weatherText = false;
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
            Console.WriteLine("Would you like to make the recipe, 'Yes' or 'No'");
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
                    Console.WriteLine("That is not an option, please try again.");
                    WhoMakesRecipe(inventory);
                    break;
            }
        }

        public void TextReset()
        {
            moneyText = false;
            priceText = false;
            setPriceText = false;
            timeForLemonadeText = false;
            noMoreCustomersText = false;
            profitForDayText = false;
            weatherText = false;
            gameOverText = false;
        }
        

        public void Run()
        {
            Console.Clear();
            weatherText = true;
            day.weather.OneDayOrSeven();           
            Console.ReadLine();
            Console.Clear();
            moneyText = true;            
            priceText = true;           
            day.player.CheckLemonOrderingMoney();
            GameCheck();
            moneyText = true;                        
            day.player.CheckSugarOrderingMoney();
            GameCheck();
            moneyText = true;
            day.player.CheckIceOrderingMoney();
            GameCheck();
            moneyText = true;
            day.player.CheckCupOrderingMoney();
            GameCheck();
            WhoMakesRecipe(day.player.inventory);
            setPriceText = true;            
            day.player.SetPurchasePrice();
            Console.Clear();
            timeForLemonadeText = true;           
            day.AmountOfCustomersForDay();
            day.FlowOfCustomers();
            noMoreCustomersText = true;            
            Console.ReadLine();
            day.ProfitFromLemonadeSold();
            day.player.inventory.Perishable();
            profitForDayText = true;
            moneyText = true;            
            Console.ReadLine();
            StatReset();
            TextReset();
            GameCheck();
            Run();

        }



    }
}
