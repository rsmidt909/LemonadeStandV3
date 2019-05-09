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
        public static string instructions;
        
        



        //Constructor (BUILDS OBJECT)
        




        //member methods(CAN DO)
        public static void SetHowToPlay()
        {
            instructions = ("How to play!\n" + "You'll recieve starting funds, with those funds you must decide how much of \n" +
            "Ice, Cups, Lemons, and Sugar you think you will need.\n" +
            "Before the start of each day, you will be prompted with the current weather and the next \n" +
            "days forcasted weather.\n" +
            "Once the day starts, customers will purchase your lemonade based off of the weather.\n" +
            "When the day has ended, you will be shown how much you earned in lemonade sales.\n" +
            "Any materials spent on making lemonade but not sold is lost.\n" +
            "And if your balance ever reaches zero, then you've gone out of business and lost!\n" +
            "How long can you last?\n" +
            "Press enter.....");           
        }

        public static void TellHowToPlay()
        {
            Console.WriteLine(instructions);
        }
        

        




        


        



        




    }
}
