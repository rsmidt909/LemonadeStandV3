using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class LemonadeMachine
    {

        //member variables (HAS A)
        string response;
        int numberResponse;
        int lemonNumber;
        int sugarNumber;
        int iceNumber;
        public Inventory inventory;

        //Constructor (BUILDS OBJECT)
        public LemonadeMachine()
        {
            response = null;
            numberResponse = 0;
            lemonNumber = 0;
            sugarNumber = 0;
            iceNumber = 0;
            inventory = new Inventory();

        }



        //member methods(CAN DO)



        public void PlayerRecipeLemons()
        {
            Console.WriteLine("How many lemons would you like to go into your recipe?");
            response = Console.ReadLine();

            bool parseSuccess = int.TryParse(response, out numberResponse);
            if (parseSuccess)
            {
                lemonNumber = numberResponse;
            }
            else
            {
                Console.WriteLine("That was not a number.");
                PlayerRecipeLemons();
            }
        }

        public void PlayerRecipeSugar()
        {
            Console.WriteLine("How many Sugar Cubes would you like to go into your recipe?");
            response = Console.ReadLine();

            bool parseSuccess = int.TryParse(response, out numberResponse);
            if (parseSuccess)
            {
                sugarNumber = numberResponse;
            }
            else
            {
                Console.WriteLine("That was not a number.");
                PlayerRecipeSugar();
            }
        }


        public void PlayerRecipeIce()
        {
            Console.WriteLine("How many Ice cubes would you like to go into your recipe?");
            response = Console.ReadLine();
            iceNumber = int.Parse(response);
            bool parseSuccess = int.TryParse(response, out numberResponse);
            if (parseSuccess)
            {
                iceNumber = numberResponse;
            }
            else
            {
                Console.WriteLine("That was not a number.");
                PlayerRecipeIce();
            }
        }

        public void PlayerRecipe()
        {
            inventory.lemons = inventory.lemons - lemonNumber;
            inventory.sugar = inventory.sugar - sugarNumber;
            inventory.ice = inventory.ice - iceNumber;
            inventory.cups--;

        }

        public void CanIMakePlayerRecipeLemonade()
        {
            PlayerRecipe();
            inventory.CheckSupplies();
            if (inventory.supplies == false)
            {
                Console.WriteLine("You have made " + inventory.cupsOfLemonade + " cups of Lemonade.");
            }
            else
            {
                inventory.cupsOfLemonade++;
                CanIMakePlayerRecipeLemonade();
            }
        }

        public void CanIMakeLemonade()
        {
            MakeLemonade();
            inventory.CheckSupplies();
            if (inventory.supplies == false)
            {
                Console.WriteLine("You have made " + inventory.cupsOfLemonade + " cups of Lemonade.");
            }
            else
            {
                inventory.cupsOfLemonade++;
                CanIMakeLemonade();
            }
        }

        public void MakePlayerRecipe()
        {
            PlayerRecipeLemons();
            LemonCheck();
            PlayerRecipeSugar();
            SugarCheck();
            PlayerRecipeIce();
            IceCheck();
        }

        public void MakeLemonade()
        {
            inventory.lemons--;
            inventory.sugar -= 2;
            inventory.ice -= 2;
            inventory.cups--;


        }


        public void LemonCheck()
        {
            if (lemonNumber == 0)
            {
                Console.WriteLine("You need atleast 1 in your recipe. Please Try again.");
                PlayerRecipeLemons();
            }
        }


        public void SugarCheck()
        {
            if (sugarNumber == 0)
            {
                Console.WriteLine("You need atleast 1 in your recipe. Please Try again.");
                PlayerRecipeSugar();
            }
        }

        public void IceCheck()
        {
            if (iceNumber == 0)
            {
                Console.WriteLine("You need atleast 1 in your recipe. Please Try again.");
                PlayerRecipeIce();
            }
        }

    }
}
