﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {

        //member variables (HAS A)
        public int lemons;
        public int sugar;
        public int cups;
        public int ice;
        public bool supplies;
        public int cupsOfLemonade;




        //Constructor (BUILDS OBJECT)
        public Inventory()
        {
            lemons = 0;
            sugar = 0;
            cups = 0;
            ice = 0;
            supplies = true;
            cupsOfLemonade = 0;
        }





        //member methods(CAN DO)
        public void CheckSupplies()
        {
            if (lemons < 0)
            {
                 supplies = false;
            }
            else if (sugar < 0)
            {
                 supplies = false;
            }
            else if (cups < 0)
            {
                 supplies = false;
            }
            else if (ice < 0)
            {
                supplies = false;
            }
            else
            {
                supplies = true;
            }
        }

        public void Perishable()
        {
            cups = 0;
            ice = 0;
            sugar = 0;
            lemons = 0;
            cupsOfLemonade = 0;
        }

        


        


        

    }
}
