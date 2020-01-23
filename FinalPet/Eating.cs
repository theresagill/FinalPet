using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPet
{
    [Serializable]
    class Eating : IStateOfPet
    {
        //fields
        private Pet mine;
        
        //constructor
        public Eating(Pet p)
        { 
            mine = p; //pass around the instance of
                             // the subclass that inherits from Pet
        }
        public void Drink()
        {
            //do nada
        }

        //The Eat method is the starting point into the 
        //world of going from state to state object.  The first 
        //if/else/else statement control the initial entry into
        //eatContinued.  Only when you actually EAT something,
        //do the tests get you closer to going to Drinking,
        //the next state that is tested.

        //OOOOLLDDD COODEEE
        public void EatOLD()
        {
            //pet is hungry and is waiting to eat a morsel(eat rate),
            // or is still hungry and needs to eat another morsel
            if (mine.PetEating)
                EatContinued();
            //pet is being tested if the hunger has met the
            //minimal level to eat (PetHunger can grow
            //                     (if pet never gets enough food)
            else if (mine.PetHunger >= mine.PetAppetiteUpFrame)
            {
                mine.PetEating = true;
                EatContinued();
            }
            else
            {
                //Do nothing.  Pet isn't hungry enough yet
                //wait another tick to test again
            }
            
        }
        
        public void EatContinued()
        {

        }
        public void Eat()
        {

            mine.PetEatCounter++;
            if(mine.PetEatCounter >= mine.PetEatFrame)
            {
                if (mine.PetHunger > 0)
                    if(mine.PetCurrentFood > 0)
                    {
                        //mine.CurrentImage = Properties.Resources.cateating;
                        mine.CurrentImage = mine.PetEatingImage;
                        mine.PetCurrentFood--;
                        mine.PetHunger--;
                        mine.PetEatCounter = 0;

                        mine.PetEating = true;
                    }
                    else
                    {
                        //notify user  I need food or just go to Drinking
                        mine.PetEating = false;
                        mine.PetEatCounter = 0;
                        //mine.State = new Drinking(mine);
                       // mine.State.Drink();
                    }
                //Else I have eaten enough and PetHunger is
                //down to 0
                else
                {
                    mine.PetEating = false;
                    mine.PetEatCounter = 0;
                    //mine.State = new Drinking(mine);
                    //mine.State.Drink();
                }

            }
            else
            {
                //wait until rate of eating indicates time to eat
            }
        }//end of EatContinued

        public void EatNew()
        {

            mine.PetEatCounter++;
            if (mine.PetEatCounter >= mine.PetEatFrame)
            {
                //not sure why i must do the next 2 if statements
                if (mine.PetHunger > 0)
                    if (mine.PetCurrentFood > 0)
                    {
                        mine.CurrentImage = mine.PetEatingImage;
                        mine.PetCurrentFood--;
                        mine.PetHunger--;
                        mine.PetEatCounter = 0;
                    }
                    else
                        EndEat();
                else
                    EndEat();
            }
            else
            {
                //wait until rate of eating indicates time to eat
            }
        }//end of EatNew

        public void EndEat()
        {
           mine.PetEating = false;
           mine.State = new Neutral(mine);
        }
        public void DrinkNew()
        {

        }
        public void SleepNew()
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

        public void Sleep()
        {
            //do nada
        }
    }
}
