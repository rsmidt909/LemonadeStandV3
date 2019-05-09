using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Marcus : Customer
    {

        //member variables (HAS A)





        //Constructor (BUILDS OBJECT)

        public Marcus()
        {
            name = "Marcus";
            personalThirstAttribute = 20;
        }



        //member methods(CAN DO)

        public override void HowMuchThirst(Weather weather)
        {
            if (weather.currentWeather == "Hot")
            {
                maxthirst = 10;
            }
            else if (weather.currentWeather == "Nice")
            {
                maxthirst = 25;
            }
            else if (weather.currentWeather == "Cold")
            {
                maxthirst = 50;
            }
            else if (weather.currentWeather == "Rainy")
            {
                maxthirst = 100;
            }
            else Console.WriteLine("Something went wrong at Thirst Level");

        }

        public override void BuyLemonade()
        {
            if (RandomNumber(1, maxthirst) > (maxthirst / 2))
            {
                purchaseLemonade = true;
            }
            else { purchaseLemonade = false; }
        }

        public override void Info()
        {
            if (purchaseLemonade == true)
            {
                Console.WriteLine(name + " bought a lemonade!");
            }
        }

        public override void PersonalThirstNullifier()
        {
            maxthirst = maxthirst - personalThirstAttribute;
        }

        public override void MaxThirstCheck()
        {
            if (maxthirst <= 0)
            {
                maxthirst = 2;
            }
        }

        public override int RandomNumber(int min, int max)
        {
            Random rando = new Random();
            return rando.Next(min, max);
        }


    }
}
