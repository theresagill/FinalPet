using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalPet
{
    [Serializable]
    class Dog:Pet
    {
        //fields
        int dogHunger = 5;
        int minimalAppetite = 6;
        int dogThirst = 5;
        int minimalThirst = 7;
        int dogTired = 5;
        int minimalTired = 8;
        int dogBoredom = 5;
        int dogLoneliness = 5;

        int dogHungerFrame = 0;
        int dogThirstFrame = 0;
        int dogSleepFrame = 0;

        //the boring amount that the dog starts out with
        int dogBored = 0;
        int dogLonely = 0;

        readonly Random generator;
        



        public Dog(int food, int water, Image incomingImage)

        {
            CurrentImage = incomingImage;
            PetImage = Properties.Resources.huskydog;
            PetEatingImage = Properties.Resources.dogeating;
            PetDrinkingImage = Properties.Resources.dogdrinking;
            PetSleepingImage = Properties.Resources.dogsleeping;
            PetPrayingImage = Properties.Resources.dogpraying;
            PetPlayingImage = Properties.Resources.dogplaying;
            PetHuggingImage = Properties.Resources.huggabledog;
            PetAwayImage = Properties.Resources.dogaway;
            generator = new Random();
            dogHungerFrame = generator.Next(120, 600);
            dogThirstFrame = generator.Next(120, 600);
            PetNeedToEatFrame = dogHungerFrame;
            PetAppetiteUpFrame = minimalAppetite;
            PetNeedToDrinkFrame = dogThirstFrame;
            PetParchedFrame = minimalThirst;
            PetNeedToSleepFrame = generator.Next(120, 600);
            PetMinimalSleepFrame = minimalTired;
            Min_Boredom = dogBoredom;
            Min_Lonely = dogLoneliness;

            //PetBoredomFrame = generator.Next(120, 600);
            PetBoredomFrame = generator.Next(300, 600);

            PetLonelyFrame = generator.Next(120, 600);

            PetHunger = dogHunger;
            PetThirst = dogThirst;
            PetTired = dogTired;
            PetBoredom = dogBored;
            PetLonely = dogLonely;

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

    }
        //Methods
 }
