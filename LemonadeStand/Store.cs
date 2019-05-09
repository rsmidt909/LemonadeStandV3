using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {

        //member variables (HAS A)
       
        public int costOfCup;
        public int costOfIce;
        public int costOfSugar;
        public int costOfLemon;
        public int costOfSupplies;

        //Constructor (BUILDS OBJECT)
        public Store()
        {

            
            costOfLemon = 1;
            costOfCup = 1;
            costOfIce = 1;
            costOfSugar = 1;
            costOfSupplies = costOfCup + costOfIce + costOfSugar + costOfLemon;


        }




        //member methods(CAN DO)



    }
}
