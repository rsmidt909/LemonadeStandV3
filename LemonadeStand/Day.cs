using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LemonadeStand
{
    class Day
    {

        //member variables (HAS A)
        
        public Weather weather;
        public Player player;
        public Customer customer;
        public int amountOfCustomers;





        //Constructor (BUILDS OBJECT)
        public Day()
        {
            weather = new Weather();
            amountOfCustomers = 0;
            customer = null;
            player = new Player();
        }



        //member methods(CAN DO)


        public void FlowOfCustomers()
        {
            for (int i = 0; i < player.inventory.cupsOfLemonade & i < amountOfCustomers;)
            {
                RandomCustomer();
                customer.HowMuchThirst(weather);
                customer.PersonalThirstNullifier();
                PriceTooHigh();
                customer.MaxThirstCheck();
                customer.BuyLemonade();
                LemonadePurchased();
                BuyCheck();
                CupsOfLemonadeSold();
                Thread.Sleep(1000);
            }
        }
        public  void BuyCheck()
        {
            if (customer.purchaseLemonade == true)
            {
                UserInterface.WhoBoughtALemonade(customer);
            }
        }
        public void RandomCustomer()
        {
            int who = RandomNumber(0, 7);
            switch (who)
            {
                case 1:
                    customer = new Joe();
                    break;
                case 2:
                    customer = new Domino();
                    break;
                case 3:
                    customer = new Elissa();
                    break;
                case 4:
                    customer = new Ender();
                    break;
                case 5:
                    customer = new Marcus();
                    break;
                case 6:
                    customer = new AfroSamurai();
                    break;
                default:
                    UserInterface.ErrorInRandomCustomer();
                    break;


            }
        }

        public void AmountOfCustomersForDay()
        {
            amountOfCustomers = RandomNumber(1, 100);
        }


        public void ProfitFromLemonadeSold()
        {
            player.wallet.profit = player.wallet.profit + (player.cupsOfLemonadeSold * player.priceofLemonade);
        }

        public void PriceTooHigh()
        {
            if (player.priceofLemonade > 5)
            {
                customer.maxthirst = +100;
            }
        }

        public void CupsOfLemonadeSold()
        {
            if (customer.purchaseLemonade == true)
            {
                player.cupsOfLemonadeSold++;
            }
        }

        public void LemonadePurchased()
        {
            if (customer.purchaseLemonade == true & player.inventory.cupsOfLemonade > 0)
            {
                player.inventory.cupsOfLemonade--;
                player.wallet.totalMoney = player.wallet.totalMoney + player.priceofLemonade;

            }
        }

        public int RandomNumber(int min, int max)
        {
            Random rando = new Random();
            return rando.Next(min, max);
        }


    }
}
