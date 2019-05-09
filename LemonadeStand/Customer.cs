using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
     abstract class Customer
    {


        //member variables (HAS A)
        public int maxthirst;              
        public bool purchaseLemonade;       
        public string name;
        public int personalThirstAttribute;
        



        //Constructor (BUILDS OBJECT)
        public Customer()
        {
                       
            maxthirst = 0;                                   
            purchaseLemonade = false;
        }



        //member methods(CAN DO)
        public abstract void HowMuchThirst(Weather weather);
        
        public abstract void BuyLemonade();

        public abstract void Info();

        public abstract void PersonalThirstNullifier();

        public abstract void MaxThirstCheck();

        public abstract int RandomNumber(int min, int max);
        

    }
}
