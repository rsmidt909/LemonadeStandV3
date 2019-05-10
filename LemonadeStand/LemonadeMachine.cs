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
            UserInterface.HowManyLemons();
            response = Console.ReadLine();
            bool parseSuccess = int.TryParse(response, out numberResponse);
            if (parseSuccess)
            {
                lemonNumber = numberResponse;
            }
            else
            {
                UserInterface.NotANumber();
                PlayerRecipeLemons();
            }
        }

        public void PlayerRecipeSugar()
        {
            UserInterface.HowMuchSugar();
            response = Console.ReadLine();

            bool parseSuccess = int.TryParse(response, out numberResponse);
            if (parseSuccess)
            {
                sugarNumber = numberResponse;
            }
            else
            {
                UserInterface.NotANumber();
                PlayerRecipeSugar();
            }
        }


        public void PlayerRecipeIce()
        {
            UserInterface.HowMuchIce();
            response = Console.ReadLine();           
            bool parseSuccess = int.TryParse(response, out numberResponse);
            if (parseSuccess)
            {
                iceNumber = numberResponse;
            }
            else
            {
                UserInterface.NotANumber();
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
                UserInterface.NumberOfLemonades(inventory);
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
                UserInterface.NumberOfLemonades(inventory);
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
                UserInterface.YouNeedOne();
                PlayerRecipeLemons();
            }
        }


        public void SugarCheck()
        {
            if (sugarNumber == 0)
            {
                UserInterface.YouNeedOne();
                PlayerRecipeSugar();
            }
        }

        public void IceCheck()
        {
            if (iceNumber == 0)
            {
                UserInterface.YouNeedOne();
                PlayerRecipeIce();
            }
        }

    }
}
