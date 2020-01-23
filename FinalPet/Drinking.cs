using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPet
{
    [Serializable]
    class Drinking : IStateOfPet
    {
        //fields
        private Pet mine;

        //constructor
        public Drinking(Pet p)
        {
            mine = p; //pass around the instance of
                      // the subclass that inherits from Pet
        }
        public void Eat()
        {
            //do nada
        }

        public void Drink()
        {
            if (mine.PetDrinking)
                DrinkContinued();
            else if (mine.PetThirst >= mine.PetParchedFrame)
            {
                mine.PetDrinking = true;
                DrinkContinued();
            }
            else
            {
                //wait for pet to get thirsty
                
            }

        }
        public void DrinkContinued()
        {
            mine.PetDrinkCounter++;
            if (mine.PetDrinkCounter >= mine.PetDrinkFrame)
            {
                if (mine.PetThirst > 0)
                    if (mine.PetCurrentWater > 0)
                    {
                        //mine.CurrentImage = Properties.Resources.catdrinking;
                        mine.CurrentImage = mine.PetDrinkingImage;
                        mine.PetCurrentWater--;
                        mine.PetThirst--;
                        mine.PetDrinkCounter = 0;
                    }
                    else
                    {
                        //notify user  I need food or just go to Sleeping
                        mine.PetDrinking = false;
                        mine.PetDrinkCounter = 0;
                        //mine.State = new Sleeping(mine);
                        //mine.State.Sleep();
                    }
                else
                {
                    mine.PetDrinking = false;
                    mine.PetDrinkCounter = 0;
                    //mine.State = new Sleeping(mine);
                    //mine.State.Sleep();
                }

            }
            else
            {
                //wait until rate of eating indicates time to eat
            }
        }//end of DrinkContinued

        public void Play()
        {
            //do nada
        }

        public void DrinkNew()
        {
            mine.PetDrinkCounter++;
            if (mine.PetDrinkCounter >= mine.PetDrinkFrame)
            {
                //not sure why I need the next 2 if statements
                if (mine.PetThirst > 0)
                    if (mine.PetCurrentWater > 0)
                    {
                        mine.CurrentImage = mine.PetDrinkingImage;
                        mine.PetCurrentWater--;
                        mine.PetThirst--;
                        mine.PetDrinkCounter = 0;
                    }
                    else
                        EndDrink();
                else
                    EndDrink();
            }
            else
            {
                //wait until rate of eating indicates time to eat
            }
        }//end of DrinkNew

        public void EndDrink()
        {
            mine.PetDrinking = false;
            mine.State = new Neutral(mine);
        }

        public void EatNew()
        {

        }
        public void SleepNew()
        {

        }
        public void Pray()
        {
            //do nada
        }

        public void ReceiveAffection()
        {
            //do nada
        }

        public void Sleep()
        {
            //do nada
        }
    }

}
