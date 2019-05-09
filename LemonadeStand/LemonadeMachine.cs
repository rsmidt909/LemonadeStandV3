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
        

        //Constructor (BUILDS OBJECT)
        public LemonadeMachine()
        {
            response = null;
            numberResponse = 0;
            lemonNumber = 0;
            sugarNumber = 0;
            iceNumber = 0;
            

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

        public void PlayerRecipe(Inventory inventory)
        {
            inventory.amountOfLemon = inventory.amountOfLemon - lemonNumber;
            inventory.amountOfSugar = inventory.amountOfSugar - sugarNumber;
            inventory.amountOfIce = inventory.amountOfIce - iceNumber;
            inventory.amountOfCup--;

        }

        public void CanIMakePlayerRecipeLemonade(Inventory inventory)
        {
            PlayerRecipe(inventory);
            inventory.CheckSupplies();
            if (inventory.supplies == false)
            {
                Console.WriteLine("You have made " + inventory.cupsOfLemonade + " cups of Lemonade.");
            }
            else
            {
                inventory.cupsOfLemonade++;
                CanIMakePlayerRecipeLemonade(inventory);
            }
        }

        public void CanIMakeLemonade(Inventory inventory)
        {
            MakeLemonade(inventory);
            inventory.CheckSupplies();
            if (inventory.supplies == false)
            {
                Console.WriteLine("You have made " + inventory.cupsOfLemonade + " cups of Lemonade.");
            }
            else
            {
                inventory.cupsOfLemonade++;
                CanIMakeLemonade(inventory);
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

        public void MakeLemonade(Inventory inventory)
        {
            inventory.amountOfLemon--;
            inventory.amountOfSugar -= 2;
            inventory.amountOfIce -= 2;
            inventory.amountOfCup--;


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
