using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPet
{
    [Serializable]
    class Sleeping : IStateOfPet
    {
        //fields
        private Pet mine;

        //constructor
        public Sleeping(Pet p)
        {
            mine = p; //pass around the instance of
                      // the subclass that inherits from Pet
        }
        public void Drink()
        {
            //do nada
        }


        public void Sleep()
        {
            mine.CurrentImage = Properties.Resources.catsleeping;
            //pet is hungry and is waiting to eat a morsel(eat rate),
            // or is still hungry and needs to eat another morsel
            if (mine.PetSleeping)
                SleepContinued();
            //pet is being tested if the hunger has met the
            //minimal level to eat (PetHunger can grow
            //                     (if pet never gets enough food)
            else if (mine.PetTired >= mine.PetMinimalSleepFrame)
            {
                mine.PetSleeping = true;
                SleepContinued();
            }
            else
            {
                //Do nothing.  Pet isn't hungry enough yet
                //wait another tick to test again
            }

        }
        public void SleepContinued()
        {

            mine.PetSleepCounter++;
            if (mine.PetSleepCounter >= mine.PetSleepFrame)
            {
                if (mine.PetTired > 0)
                {
                    //mine.CurrentImage = Properties.Resources.catsleeping;
                    mine.CurrentImage = mine.PetSleepingImage;
                    mine.PetTired--;
                    //additional subtraction to fix infinite loop
                    if (mine.PetTired > 0)
                        mine.PetTired--;
                    mine.PetSleepCounter = 0;
                }
                else
                {
                    mine.PetSleeping = false;
                    mine.PetSleepCounter = 0;
                    //mine.State = new Praying(mine);
                    //mine.State.Pray();
                }
            }
            else
            {
                //wait until rate of eating indicates time to eat
            }
        }//end of SleepContinued

        public void SleepNew()
        {

            mine.PetSleepCounter++;
            if (mine.PetSleepCounter >= mine.PetSleepFrame)
            {
                if (mine.PetTired > 0)
                {
                    mine.CurrentImage = mine.PetSleepingImage;
                    mine.PetTired--;
                    mine.PetSleepCounter = 0;
                }
                else
                    EndSleep();
            }
            else
            {
                //wait until rate of eating indicates time to eat
            }
        }//end of SleepNew

        public void EndSleep()
        {
            mine.PetSleeping = false;
            mine.State = new Neutral(mine);
        }
        public void EatNew()
        {

        }
        public void DrinkNew()
        {

        }

        public void Play()
        {
            //do nada
        }

        public void Pray()
        {
            //do nada
        }

        public void ReceiveAffection()
        {
            //do nada
        }

        public void Eat()
        {
            //do nada
        }
    }
}
