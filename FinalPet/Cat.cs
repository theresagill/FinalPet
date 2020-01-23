using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalPet
{
    [Serializable]
    class Cat:Pet
    {
        //fields
        int catHunger = 5;
        int minimalAppetite = 6;
        int catThirst = 5;
        int minimalThirst = 7;
        int catTired = 5;
        int minimalTired = 8;
        int catBoredom = 5;
        int catLoneliness = 4;

        //int catStartEating = 6;
        int catHungerFrame = 0;
        int catThirstFrame = 0;
        int catSleepFrame = 0;
       
        //the boring amount that the cat starts out with
        int catBored = 0;
        int catLonely = 0;

        readonly Random generator;
       
        

            
        public Cat(int food, int water,Image incomingImage)

        {

            CurrentImage = incomingImage;
            PetImage = Properties.Resources.cat;
            PetEatingImage = Properties.Resources.cateating;
            PetDrinkingImage = Properties.Resources.catdrinking;
            PetSleepingImage = Properties.Resources.catsleeping;
            PetPrayingImage = Properties.Resources.catpraying;
            PetPlayingImage = Properties.Resources.catplaying;
            PetHuggingImage = Properties.Resources.cathuggingcat;
            PetAwayImage = Properties.Resources.cataway;
            generator = new Random();
            catHungerFrame = generator.Next(120, 600);
            catThirstFrame = generator.Next(120, 600);
            PetNeedToEatFrame = catHungerFrame;
            PetAppetiteUpFrame = minimalAppetite;
            PetNeedToDrinkFrame = catThirstFrame;
            PetParchedFrame = minimalThirst;
            PetNeedToSleepFrame = generator.Next(120, 600);
            PetMinimalSleepFrame = minimalTired;
            Min_Boredom = catBoredom;
            Min_Lonely = catLoneliness;

            //PetBoredomFrame = generator.Next(120, 600);
            PetBoredomFrame = generator.Next(300, 600);

            PetLonelyFrame = generator.Next(120, 600);

            PetHunger = catHunger;
            PetThirst = catThirst;
            PetTired = catTired;
            PetBoredom = catBored;
            PetLonely = catLonely;
            
            //PetEatFrame = 60;pet continuously eating
            PetEatFrame = 30;
            PetDrinkFrame = 60;
            //PetSleepFrame = 60;
            PetSleepFrame = 20;//pet was in continuous sleep state 
                               //at 60
            PetPlayRateFrame = 20;
            PetHugRateFrame = 60;

            PetCurrentFood = food;
            PetCurrentWater = water;


        }

        //Methods
        


    }
}

