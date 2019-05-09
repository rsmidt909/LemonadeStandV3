using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {

        //member variables (HAS A)
        
        public bool supplies;
        public int cupsOfLemonade;       
        public int amountOfCup;
        public int amountOfIce;
        public int amountOfSugar;
        public int amountOfLemon;





        //Constructor (BUILDS OBJECT)
        public Inventory()
        {
            
            supplies = true;
            cupsOfLemonade = 0;            
            amountOfCup = 0;
            amountOfIce = 0;
            amountOfSugar = 0;
            amountOfLemon = 0;
        }





        //member methods(CAN DO)
        public void CheckSupplies()
        {
            if (amountOfLemon < 0)
            {
                 supplies = false;
            }
            else if (amountOfSugar < 0)
            {
                 supplies = false;
            }
            else if (amountOfCup < 0)
            {
                 supplies = false;
            }
            else if (amountOfIce < 0)
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
            amountOfCup = 0;
            amountOfIce = 0;
            amountOfSugar = 0;
            amountOfLemon = 0;
            cupsOfLemonade = 0;
        }

        


        


        

    }
}
