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

        

        public static void MoneyText(bool moneyText, Wallet wallet)
        {
            if(moneyText == true)
            {
                Console.WriteLine("You have " + wallet.totalMoney + " Dollars.");
            }
        }

        public static void PriceText(bool priceText, Store store)
        {
            
            if (priceText == true)
            {
                Console.WriteLine("The price of lemons are " + store.costOfLemon + " Dollars.\n"+
                "The price of Sugar cubes are " + store.costOfSugar + " Dollars.\n"+
                "The price of Ice are " + store.costOfIce + " Dollars.\n"+
                "The price of Cups are " + store.costOfCup + " Dollars.");
            }
        }

        public static void SetPriceText(bool setPriceText, Player player)
        {
            if (setPriceText == true)
            {
                Console.WriteLine("What would you like to set the price of one cup of lemonade?\n"+
                "You cannot set the price higher than 2 times the amount that the supplies cost individually.\n"+
                "The max set price is " + player.maxPrice + " Dollars.\n"+
                "*Tip* If you set the price too high, you will have a lower cance of lemonade being purchased! *Tip*");
            }
        }

        public static void LemonadeTimeText(bool timeForLemonadeText)
        {
            if (timeForLemonadeText == true)
            {
                Console.WriteLine("Time to sell some Lemonade!");
            }
        }

        public static void NoMoreCustomersText(bool noMoreCustomersText)
        {
            if (noMoreCustomersText == true)
            {
                Console.WriteLine("No more customers for the day!");
            }
        }

        public static void ProfitForTheDayText(bool profitForDayText, Wallet wallet)
        {
            if (profitForDayText == true)
            {
                Console.WriteLine("Youre profit for the day is " + wallet.profit);
            }
        }

        public static void WeatherText(bool weatherText)
        {
            if (weatherText == true)
            {
                Console.WriteLine("Would you like to see just 'One' days weather or the next 'Seven' days?");
            }
        }

        public static void GameOverText(bool gameOverText)
        {
            if (gameOverText == true)
            {
                Console.WriteLine("You ran out of money to make a single cup of lemonade! Game Over!");
               
            }
        }

        public static void NotANumber()
        {
            Console.WriteLine("That was not a number");
        }

        
        public static void YouNeedOne()
        {
            Console.WriteLine("You need atleast 1 in your recipe. Please Try again.");
        }

        public static void NumberOfLemonades(Inventory inventory)
        {
            Console.WriteLine("You have made " + inventory.cupsOfLemonade + " cups of Lemonade.");
        }

        public static void HowManyLemons()
        {
            Console.WriteLine("How many lemons would you like to go into your recipe?");
        }

        public static void HowMuchSugar()
        {
            Console.WriteLine("How many Sugar Cubes would you like to go into your recipe?");
        }

        public static void HowMuchIce()
        {
            Console.WriteLine("How many Ice cubes would you like to go into your recipe?");
        }

        public static void NotAnOption()
        {
            Console.WriteLine("That is not an option, please try again.");
        }

        public static void MakeRecipeQuestion()
        {
            Console.WriteLine("Would you like to make the recipe, 'Yes' or 'No'");
        }

        public static void ThirstLevelError()
        {
            Console.WriteLine("Something went wrong at Thirst Level");
        }

        public static void NotEnoughLemonMoney()
        {
            Console.WriteLine("You dont have enough money to order any lemons");
        }


        public static void NotEnoughSugarMoney()
        {
            Console.WriteLine("You dont have enough money to order any Sugar");
        }

        public static void NotEnoughIceMoney()
        {
            Console.WriteLine("You dont have enough money to order any Ice");
        }

        public static void NotEnoughCupMoney()
        {
            Console.WriteLine("You dont have enough money to order any Cups");
        }

        public static void PriceHigherThanAllowed()
        {
            Console.WriteLine("That price is higher than the allowed limit, please try again.");
        }

        public static void HowManyLemonsToPurchase()
        {
            Console.WriteLine("How many Lemons would you like to purchase?");
        }

        public static void HowManySugarCubesToPurchase()
        {
            Console.WriteLine("How many cubes of Sugar would you like to purchase?");
        }

        public static void HowManyCupsToPurchase()
        {
            Console.WriteLine("How many Cups would you like to purchase?");
        }

        public static void HowManyIceCubesToPurchase()
        {
            Console.WriteLine("How many cubes of Ice would you like to purchase?");
        }

        public static void ErrorInRandomCustomer()
        {
            Console.WriteLine("Something went wrong with RandomCustomer Method");
        }

        public static void WhoBoughtALemonade(Customer customer)
        {
            Console.WriteLine(customer.name + " bought a lemonade!");
        }

        public static void TodaysWeatherText(Weather weather)
        {
            Console.WriteLine("Todays weather will be " + weather.currentWeather);
        }


        public static void ForcastedWeatherText(Weather weather)
        {
            Console.WriteLine("The next day MAY be " + weather.forecastedWeather);
        }

        public static void WeatherChooserError()
        {
            Console.WriteLine("Something broke the weather chooser.");
        }


    }
}
