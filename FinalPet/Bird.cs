using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace FinalPet
{

    [Serializable]
    class Bird : Pet
    {
        //fields
        //extra comment
        int birdHunger = 5;
        int minimalAppetite = 6;
        int birdThirst = 5;
        int minimalThirst = 7;
        int birdTired = 5;
        int minimalTired = 8;
        int birdBoredom = 5;
        int birdLoneliness = 3;

        int birdHungerFrame = 0;
        int birdThirstFrame = 0;
        int birdSleepFrame = 0;

        //the boring amount that the bird starts out with
        int birdBored = 0;
        int birdLonely = 0;

        readonly Random generator;
        



        public Bird(int food, int water, Image incomingImage)

        {
            CurrentImage = incomingImage;
            PetImage = Properties.Resources.bird;
            PetEatingImage = Properties.Resources.birdeating;
            PetDrinkingImage = Properties.Resources.birddrinking;
            PetSleepingImage = Properties.Resources.birdsleeping;
            //PetPrayingImage = Properties.Resources.birdpraying;
            PetPlayingImage = Properties.Resources.birdplaying;
            PetHuggingImage = Properties.Resources.huggablebird;
            PetAwayImage = Properties.Resources.birdaway;
            generator = new Random();
            birdHungerFrame = generator.Next(120, 600);
            birdThirstFrame = generator.Next(120, 600);
            PetNeedToEatFrame = birdHungerFrame;
            PetAppetiteUpFrame = minimalAppetite;
            PetNeedToDrinkFrame = birdThirstFrame;
            PetParchedFrame = minimalThirst;
            PetNeedToSleepFrame = generator.Next(120, 600);
            PetMinimalSleepFrame = minimalTired;
            Min_Boredom = birdBoredom;
            Min_Lonely = birdLoneliness;

            //PetBoredomFrame = generator.Next(120, 600);
            PetBoredomFrame = generator.Next(300, 600);

            PetLonelyFrame = generator.Next(120, 600);

            PetHunger = birdHunger;
            PetThirst = birdThirst;
            PetTired = birdTired;
            PetBoredom = birdBored;
            PetLonely = birdLonely;

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
