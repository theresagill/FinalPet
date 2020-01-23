using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPet
{
    [Serializable]


    public abstract class Pet

    {
        const int MAX_HUNGER = 10;//same for all pets
        const int MAX_THIRST = 10;
        const int MAX_TIRED = 10;
        const int MAX_BOREDOM = 10;
        const int MAX_LONELINESS = 10;

        private int min_Boredom = 0;
        public int Min_Boredom
        {
            get { return min_Boredom; }
            set { min_Boredom = value; }

        }

        private int min_Lonely = 0;
        public int Min_Lonely
        {
            get { return min_Lonely; }
            set { min_Lonely = value; }

        }

        protected int petCurrentFood;
        public int PetCurrentFood
        {
            get { return petCurrentFood; }
            set { petCurrentFood = value; }
        }

        protected int petCurrentWater;
        public int PetCurrentWater
        {
            get { return petCurrentWater; }
            set { petCurrentWater = value; }
        }

        //private Bitmap currentImage;
        
        private Image currentImage;
        public Image CurrentImage
        {
            get { return (Bitmap) currentImage; }
            //set => currentImage = (Bitmap) value
            set { currentImage = value; }
        }

        private Image petImage;
        public Image PetImage
        {
            get { return (Bitmap)petImage; }
            set { petImage = value; }
        }

        private Image petEatingImage;
        public Image PetEatingImage
        {
            get { return (Bitmap)petEatingImage; }
            set { petEatingImage = value; }
        }

        private Image petDrinkingImage;
        public Image PetDrinkingImage
        {
            get { return (Bitmap)petDrinkingImage; }
            set { petDrinkingImage = value; }
        }

        private Image petSleepingImage;
        public Image PetSleepingImage
        {
            get { return (Bitmap)petSleepingImage; }
            set { petSleepingImage = value; }
        }

        private Image petPrayingImage;
        public Image PetPrayingImage
        {
            get { return (Bitmap)petPrayingImage; }
            set { petPrayingImage = value; }
        }

        private Image petPlayingImage;
        public Image PetPlayingImage
        {
            get { return (Bitmap)petPlayingImage; }
            set { petPlayingImage = value; }
        }

        private Image petHuggingImage;
        public Image PetHuggingImage
        {
            get { return (Bitmap)petHuggingImage; }
            set { petHuggingImage = value; }
        }

        private Image petAwayImage;
        public Image PetAwayImage
        {
            get { return (Bitmap)petAwayImage; }
            set { petAwayImage = value; }
        }

        //fields set in this abstract class
        // create new objects that implement this interface
        // the new objects are any one of a number of states
        // that the pet is in.  Each state has the interface
        // methods
        private IStateOfPet state;
        public IStateOfPet State
        {
            get { return state; }
            set { state = value; }
        }
        protected int hungerCounter = 0;//works with petHungerFrame.
                                        // When hungerCounter, which increases per tick, reaches
                                        // NeedToEat frame, pet is hungry enough to need to eat.  
        protected int drinkCounter = 0;
        protected int tiredCounter = 0;
        protected int boredomCounter = 0;
        protected int lonelyCounter = 0;

        protected int petPlayCounter = 0;
        public int PetPlayCounter
        {
            get { return petPlayCounter; }
            set { petPlayCounter = value; }
        }

        protected int petEatCounter = 0;// work with rates of eating, drinking
        public int PetEatCounter
        {
            get { return petEatCounter; }
            set { petEatCounter = value; }
        }
        protected int petDrinkCounter = 0;
        public int PetDrinkCounter
        {
            get { return petDrinkCounter; }
            set { petDrinkCounter = value; }
        }
        protected int petSleepCounter = 0;
        public int PetSleepCounter
        {
            get { return petSleepCounter; }
            set { petSleepCounter = value; }
        }

        bool firstTimeHere = true;

        protected bool petEating = false;
        public bool PetEating
        {
            get { return petEating; }
            set { petEating = value; }
        }
        protected bool petDrinking = false;
        public bool PetDrinking
        {
            get { return petDrinking; }
            set { petDrinking = value; }
        }

        protected bool petSleeping = false;
        public bool PetSleeping
        {
            get { return petSleeping; }
            set { petSleeping = value; }
        }
        protected bool petPlaying = false;
        public bool PetPlaying
        {
            get { return petPlaying; }
            set { petPlaying = value; }
        }
        protected bool petHugging = false;
        public bool PetHugging
        {
            get { return petHugging; }
            set { petHugging = value; }
        }


        // fields below are set in subclass
        // Fields related to hunger/eating/dish full
        //I consolidated the actions of getting hungry and
        //starting the action of eating.  
        protected int petNeedToEatFrame;//level of hungriness to 
                                        //begin to 
        public int PetNeedToEatFrame
        {
            get { return petNeedToEatFrame; }
            set { petNeedToEatFrame = value; }
        }
        protected int petAppetiteUpFrame;
        public int PetAppetiteUpFrame
        {
            get { return petAppetiteUpFrame; }
            set { petAppetiteUpFrame = value; }
        }
        protected int petParchedFrame;
        public int PetParchedFrame
        {
            get { return petParchedFrame; }
            set { petParchedFrame = value; }
        }

        protected int petNeedToDrinkFrame;
        public int PetNeedToDrinkFrame
        {
            get { return petNeedToDrinkFrame; }
            set { petNeedToDrinkFrame = value; }
        }

        protected int petNeedToSleepFrame;
        public int PetNeedToSleepFrame
        {
            get { return petNeedToSleepFrame; }
            set { petNeedToSleepFrame = value; }
        }

        protected int petMinimalSleepFrame;
        public int PetMinimalSleepFrame
        {
            get { return petMinimalSleepFrame; }
            set { petMinimalSleepFrame = value; }
        }

        protected int petEatFrame;//rate of eating
        public int PetEatFrame
        {
            get { return petEatFrame; }
            set { petEatFrame = value; }
        }


        protected int petDrinkFrame;
        public int PetDrinkFrame
        {
            get { return petDrinkFrame; }
            set { petDrinkFrame = value; }
        }

        protected int petSleepFrame;
        public int PetSleepFrame
        {
            get { return petSleepFrame; }
            set { petSleepFrame = value; }
        }

        protected int petHunger = 0;// counter that increases 
                                    // when petNeedToEat frame is
                                    // is reached by Hunger Counter 
                                    // Increases each time petNeedToEat
                                    //frame is reached.  Food must be
                                    //available for it to decrease
        public int PetHunger
        {
            get { return petHunger; }
            set { petHunger = value; }
        }
        protected int petThirst = 0;// counter that increases 
                                    //when petNeedToDrink frame
                                    //is reached by Drink counter
        //property for petThirst
        public int PetThirst
        {
            get { return petThirst; }
            set { petThirst = value; }
        }
        protected int petTired = 0;// counter that increases
                                   // when petNeedToSleep frame
                                    //is reavched by Tired counter
        //property for petTired
        public int PetTired
        {
            get { return petTired; }
            set { petTired = value; }
        }

        protected int petBoredom;
        public int PetBoredom
        {
            get { return petBoredom; }
            set { petBoredom = value; }
        }
        private int petBoredomFrame;
        public int PetBoredomFrame
        {
            get { return petBoredomFrame; }
            set { petBoredomFrame = value; }
        }
        private int petPlayRateCounter = 0;
        public int PetPlayRateCounter
        {
            get { return petPlayRateCounter; }
            set { petPlayRateCounter = value; }
        }
        private int petPlayRateFrame;
        public int PetPlayRateFrame
        {
            get { return petPlayRateFrame; }
            set { petPlayRateFrame = value; }
        }
        private int petHugRateCounter = 0;
        public int PetHugRateCounter
        {
            get { return petHugRateCounter; }
            set { petHugRateCounter = value; }
        }
        private int petHugRateFrame;
        public int PetHugRateFrame
        {
            get { return petHugRateFrame; }
            set { petHugRateFrame = value; }
        }
        //Buttons are set in form1.cs UpdateView
        private bool petVisible;
        public bool PetVisible
        {
            get { return petVisible; }
            set { petVisible = value; }
        }
        private bool petEnabled;
        public bool PetEnabled
        {
            get { return petEnabled; }
            set { petEnabled = value; }
        }

        protected int petLonely;
        public int PetLonely
        {
            get { return petLonely; }
            set { petLonely = value; }
        }
        private int petLonelyFrame;
        public int PetLonelyFrame
        {
            get { return petLonelyFrame; }
            set { petLonelyFrame = value; }
        }

        //Buttons are set in form1.cs UpdateView
        private bool petHugVisible;
        public bool PetHugVisible
        {
            get { return petHugVisible; }
            set { petHugVisible = value; }
        }
        private bool petHugEnabled;
        public bool PetHugEnabled
        {
            get { return petHugEnabled; }
            set { petHugEnabled = value; }
        }


        //constructor
        public Pet()
        {

            
        }
        //methods
        public void IncreaseNeedCounters()
        {
            //increase these counters for each tick
            //they are reset back to zero
            //when pet hunger or pet thirst or pet tired
            // or pet deprived is increased.  They
            //help tabulate when the pet has reached
            //the point to get hungry, thirsty, tired
            // or deprived.
            hungerCounter++;
            drinkCounter++;
            tiredCounter++;
            boredomCounter++;
            lonelyCounter++;
            


        }
        public void Updateneeds()
        {
            if (hungerCounter>= petNeedToEatFrame)
            {
                //Don't let pet get so hungry that it can't
                //overcome hungriness if food is supplied
                if (PetHunger < MAX_HUNGER)
                        PetHunger++;//increase hunger.  This
                            //can be more than inital setting if 
                            //pet never eats due to no food
                hungerCounter = 0;
            }

            //if (drinkCounter < petNeedToDrinkFrame)
            if (drinkCounter >= petNeedToDrinkFrame)
            {
                if (PetThirst < MAX_THIRST)
                     PetThirst++;
                drinkCounter = 0;
            }
            if (tiredCounter >= petNeedToSleepFrame)
            {
                if (PetTired < MAX_TIRED)
                   PetTired++;
                tiredCounter = 0;
            }
            if (boredomCounter >= petBoredomFrame)
            {
                if (PetBoredom < MAX_BOREDOM)
                    PetBoredom++;
                boredomCounter = 0;
            }
            if (lonelyCounter >= petLonelyFrame)
            {
                if (PetLonely < MAX_LONELINESS)
                    PetLonely++;
                lonelyCounter = 0;
            }

        }
        //OOOOOLDDDD  COOODDDEEE
        public void CallStateOLD()
        {
            string typeOfStateClass;
            if (firstTimeHere)
            {
                //CODE commented out below
                //is moved into Form1 due to the save function.
                //State = new Eating(this);
                State.Eat();

                firstTimeHere = false;
            }
            else
            {
                //Call the current object that is in state
                //Call that method's Eat method
                //State.Eat();
                typeOfStateClass = State.GetType().Name;
                switch (typeOfStateClass)
                {
                    case "Eating":
                        State.Eat();
                        break;

                    case "Drinking":
                        State.Drink();
                        break;

                    case "Sleeping":
                        State.Sleep();
                        break;

                    case "Praying":
                        State.Pray();
                       break;

                    case "Playing":
                        State.Play();
                        break;
                  
                    case "Affectioning":
                        State.ReceiveAffection();
                        break;

                    default: break;

                }
            }
        }// end method CallStateOLD
        public void CallStateALSOOLD()
        {
           if (PetHunger > 0)//pet has reached petNeedToEatFrame
                             // at least once
            {
               if (PetEating)
                   State.Eat();
               else
               {
                   State = new Eating(this);
                   State.Eat();
               }
                
            }
           if (PetThirst > 0)//pet has reached petNeedToDrinkFrame
                              // at least once
           {
               if (PetDrinking)
                   State.Drink();
               else
               {
                  State = new Drinking(this);
                  State.Drink();
              }
           }
            if (PetTired > 0)//pet has reached petNeedToDrinkFrame
                              // at least once
            {
                if (PetSleeping)
                    State.Sleep();
                else
                {
                    State = new Sleeping(this);
                    State.Sleep();
                }
            }
            if (PetBoredom > 0)//pet has reached petNeedToDrinkFrame
                             // at least once
            {
                if (PetPlaying)
                    State.Play();
                else
                {
                    State = new Playing(this);
                    State.Play();
                }

            }
            if (PetLonely > 0)//pet has reached petNeedToDrinkFrame
                             // at least once
            {
                if (PetHugging)
                    State.ReceiveAffection();
                else
                {
                    State = new Affectioning(this);
                    State.ReceiveAffection();
                }
            }

        }//end of callstatealsoold
        public void CheckHunger()
        {
              if (PetCurrentFood > 0)
              {
                  //instead of checking if PetHunger > 0
                  //it doesn't have to go down to zero
                  //that would take too long
                  if (PetHunger >  PetAppetiteUpFrame)
                  {
                      if (PetEating)
                      {
                          //do nada
                      }
                      else
                      {
                          State = new Eating(this);
                          PetEating = true;
                      }
                  }
                  else//wait to eat
                  {
                      EndEat();
                      //petEating = false;
                      //State = new Neutral(this);
                  }
              }
              else// there is no more food to eat
              {
                  
                  petEating = false;
                  State = new Neutral(this);
            }

            
        }//end CheckHunger

        public void EndEat()
        {
            petEating = false;
            State = new Neutral(this);

        }

        public void CheckThirst()
        {
             if (PetCurrentWater > 0)
             {
                 //instead of checking if PetThirst > 0
                 //it doesn't have to go down to zero
                 //that would take too long
                 if (PetThirst > PetParchedFrame)
                 //if (PetThirst > 0)
                    {
                     if (PetDrinking)
                     {
                          //do nada
                     }
                     else
                     {
                         State = new Drinking(this);
                         PetDrinking = true;
                     }
                 }
                 else//pet has drank enough
                 {
                     EndDrink();
                     //petDrinking = false;
                     //State = new Neutral(this);
                }
             }
             else// there is no more water to drink
             {
                 EndDrink();
                 //petDrinking = false;
                 //State = new Neutral(this);
             }

        }//end CheckThirst

        public void EndDrink()
        {
            petDrinking = false;
            State = new Neutral(this);

        }

        public void CheckTiredness()
        {
            if (PetTired > PetMinimalSleepFrame)
            {
               if (PetSleeping)
               {
                   //do nada
               }
               else
               {
                   State = new Sleeping(this);
                   PetSleeping = true;
               }
            }
            else//pet has slept enough
            {
               EndSleep();
            }
            

        }//end CheckTiredness
        public void EndSleep()
        {
            petSleeping = false;
            State = new Neutral(this);

        }
        public void CheckBoredom()
        {
            if (PetBoredom > 0)
            {
                if (PetPlaying)
                {
                    //do nada
                }
                else
                {
                    State = new Playing(this);
                    PetPlaying = true;
                }
            }
            else//pet has played enough
            {
                EndPlay();
            }

        }//end CheckTiredness
        public void EndPlay()
        {
            PetPlaying = false;
            State = new Neutral(this);

        }

        public void CheckLoneliness()
        {
            if (PetLonely > 0)
            {
                if (PetHugging)
                {
                    //do nada
                }
                else
                {
                    State = new Affectioning(this);
                    PetHugging = true;
                }
            }
            else//pet has hugged enough
            {
                EndHug();
            }

        }//end CheckLoneliness
        public void EndHug()
        {
            PetHugging = false;
            State = new Neutral(this);

        }


        public void CallState()
        {
            if (PetEating || PetDrinking || PetSleeping || PetPlaying
                || PetHugging)
            {
                //do nada
            }
            else CheckHunger();

            if (PetEating || PetDrinking || PetSleeping || PetPlaying 
                || PetHugging)
            {
                //do nada
            }
            else CheckThirst();

            if (PetEating || PetDrinking || PetSleeping || PetPlaying
                || PetHugging)
            {
                //do nada
            }
            else CheckTiredness();

            if (PetEating || PetDrinking || PetSleeping || PetPlaying
                || PetHugging)
            {
                //do nada
            }
            else CheckBoredom();

            if (PetEating || PetDrinking || PetSleeping || PetPlaying
                || PetHugging)
            {
                //do nada
            }
            else CheckLoneliness();


            State.EatNew();
            State.DrinkNew();
            State.SleepNew();
            State.Play();
            State.ReceiveAffection();
        }

        public bool TakeAway()
        {
            if (PetHunger == MAX_HUNGER &&
                PetThirst == MAX_THIRST &&
                PetTired == MAX_TIRED &&
                PetBoredom == MAX_BOREDOM &&
                PetLonely == MAX_LONELINESS)
            {
                CurrentImage = PetAwayImage;
                return true;
            }
            else
                return false;
        }
        public Image GetImage()
        {
            return (Image) currentImage;
        }

                
    }
}
