using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace FinalPet
{
    [Serializable]
    class Affectioning : IStateOfPet
    {
        //fields
        private Pet mine;
        private System.Timers.Timer affectionTimer;

        //constructor
        public Affectioning(Pet p)
        {
            mine = p; //pass around the instance of
                      // the subclass that inherits from Pet
            //mine.PetHugging = true;
            //affectionTimer = new System.Timers.Timer();
            //affectionTimer.Interval = 16000; //8 seconds?
            //affectionTimer.Elapsed += AffectionTimesUp;
            //affectionTimer.Start();

        }

        private void AffectionTimesUp(object sender, ElapsedEventArgs e)
        {
            //MessageBox.Show("Affection time is finished");
            mine.PetHugging = false;
            affectionTimer.Enabled = false;
            affectionTimer.Stop();
            mine.PetHugVisible = false;
            mine.PetHugEnabled = false;
            //mine.State = new Eating(mine);
            //mine.State.Eat();
        }

        public void Drink()
        {
            //do nada
        }


        public void ReceiveAffectionOLD()
        {
            //mine.CurrentImage = Properties.Resources.cathuggingcat;
            mine.CurrentImage = mine.PetHuggingImage;
            if (mine.PetLonely > mine.Min_Lonely)
            // give user chance to play with pet and decrease PetBoredom
            {
                mine.PetHugRateCounter++;
                if (mine.PetHugRateCounter >= mine.PetHugRateFrame)
                {
                    mine.PetHugRateCounter = 0;//reset
                    mine.PetHugVisible = true;
                    mine.PetHugEnabled = true;

                    mine.PetHugging = true;
                    //affectionTimer = new System.Timers.Timer();
                    //ffectionTimer.Interval = 16000; //8 seconds?
                    //affectionTimer.Elapsed += AffectionTimesUp;
                    //affectionTimer.Start();
                }
                else//just need more time
                {

                }
            }
            else //pet has received enough affection
            {
                mine.PetHugging = false;
                mine.PetHugVisible = false;
                mine.PetHugEnabled = false;
                //affectionTimer.Stop();
                //mine.State = new Eating(mine);
                //mine.State.Eat();
                
            }

        }//end ReceiveAffectionOLD
        
        public void ReceiveAffection()
        {

            if (mine.PetLonely > mine.Min_Lonely)
            // give user chance to give pet affection
            {
                mine.PetHugRateCounter++;
                if (mine.PetHugRateCounter >= mine.PetHugRateFrame)
                {
                    if (mine.PetLonely > 0)
                    {
                        mine.CurrentImage = mine.PetHuggingImage;
                        mine.PetHugRateCounter = 0;//reset
                                                    //display buttons now which will decrease PetBoredom
                        mine.PetHugVisible = true;
                        mine.PetHugEnabled = true;
                        mine.PetHugging = true;
                    }
                    else
                    {
                        EndHug();
                    }

                }
                else//just need more time
                {
                    //do nada
                }

            }
            else //pet has played enough
            {
                EndHug();
            }
        }//end ReceiveAffection

        public void EndHug()
        {
            mine.PetHugVisible = false;
            mine.PetHugEnabled = false;
            mine.PetHugging = false;
            mine.State = new Neutral(mine);
        }

    
    public void EatNew()
        {

        }
        public void DrinkNew()
        {

        }
        public void SleepNew()
        {

        }

        public void Sleep()
        {
            //do nada
        }

        public void Pray()
        {
            //do nada
        }

        public void Play()
        {
            //do nada
        }

        public void Eat()
        {
            //do nada
        }
    }


}
