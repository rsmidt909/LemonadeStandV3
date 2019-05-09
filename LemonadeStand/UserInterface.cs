using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    static class UserInterface
    {


        //member variables (HAS A)       


        




        //Constructor (BUILDS OBJECT)

        



        //member methods(CAN DO)
        public static void HowToPlay()
        {
            Console.WriteLine("How to play!\n" + "You'll recieve starting funds, with those funds you must decide how much of \n" +
            "Ice, Cups, Lemons, and Sugar you think you will need.\n" +
            "Before the start of each day, you will be prompted with the current weather and the next \n" +
            "days forcasted weather.\n" +
            "Once the day starts, customers will purchase your lemonade based off of the weather.\n" +
            "When the day has ended, you will be shown how much you earned in lemonade sales.\n" +
            "Any materials spent on making lemonade but not sold is lost.\n" +
            "And if your balance ever reaches zero, then you've gone out of business and lost!\n" +
            "How long can you last?\n" +
            "Press enter.....");
            Console.ReadLine();
        }

        

        public static void MoneyText(Game game)
        {
            if(game.moneyText == true)
            {
                Console.WriteLine("You have " + game.day.player.wallet.totalMoney + " Dollars.");
            }
        }

        public static void LemonText(Game game)
        {
            if (game.priceText == true)
            {
                Console.WriteLine("The price of lemons are " + game.day.player.store.costOfLemon + " Dollars.\n"+
                "The price of Sugar cubes are " + game.day.player.store.costOfSugar + " Dollars.\n"+
                "The price of Ice are " + game.day.player.store.costOfIce + " Dollars.\n"+
                "The price of Cups are " + game.day.player.store.costOfCup + " Dollars.");
            }
        }

        public static void SugarText(Game game)
        {
            if (game.setPriceText == true)
            {
                Console.WriteLine("What would you like to set the price of one cup of lemonade?\n"+
                "You cannot set the price higher than 2 times the amount that the supplies cost individually.\n"+
                "The max set price is " + game.day.player.maxPrice + " Dollars.\n"+
                "*Tip* If you set the price too high, you will have a lower cance of lemonade being purchased! *Tip*");
            }
        }

        public static void LemonadeTimeText(Game game)
        {
            if (game.timeForLemonadeText == true)
            {
                Console.WriteLine("Time to sell some Lemonade!");
            }
        }

        public static void NoMoreCustomersText(Game game)
        {
            if (game.noMoreCustomersText == true)
            {
                Console.WriteLine("No more customers for the day!");
            }
        }

        public static void ProfitForTheDayText(Game game)
        {
            if (game.profitForDayText == true)
            {
                Console.WriteLine("Youre profit for the day is " + game.day.player.wallet.profit);
            }
        }

        public static void WeatherText(Game game)
        {
            if (game.weatherText == true)
            {
                Console.WriteLine("Would you like to see just 'One' days weather or the next 'Seven' days?");
            }
        }

        public static void GameOverText(Game game)
        {
            if (game.gameOverText == true)
            {
                Console.WriteLine("You ran out of money to make a single cup of lemonade! Game Over!");
               
            }
        }


        









    }
}
