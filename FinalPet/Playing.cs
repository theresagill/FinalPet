using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace FinalPet
{
    [Serializable]
    class Playing : IStateOfPet
    {
        //fields
        private Pet mine;
        private System.Timers.Timer playTimer;

        //constructor
        public Playing(Pet p)
        {
            mine = p; //pass around the instance of
                      // the subclass that inherits from Pet
            //mine.PetPlaying = true;
            //playTimer = new System.Timers.Timer();
            //playTimer.Interval = 16000; //8 seconds?
            //playTimer.Elapsed += PlayTimesUp;
            //playTimer.Start();

        }

        private void PlayTimesUp(object sender, ElapsedEventArgs e)
        {
            //MessageBox.Show("Playtime is finished");
            mine.PetPlaying = false;
            playTimer.Enabled = false;
            playTimer.Stop();
            mine.PetVisible = false;
            mine.PetEnabled = false;
            //mine.State = new Affectioning(mine);
            //mine.State.ReceiveAffection();
        }

        public void Drink()
        {
            //do nada
        }


        public void PlayOld()
        {
            //mine.CurrentImage = Properties.Resources.catplaying;
            mine.CurrentImage = mine.PetPlayingImage;
            if (mine.PetBoredom > mine.Min_Boredom)
            // give user chance to play with pet and decrease PetBoredom
            {
                mine.PetPlayRateCounter++;
                if (mine.PetPlayRateCounter >= mine.PetPlayRateFrame)
                {
                    mine.PetPlayRateCounter = 0;//reset
                    //display buttons now
                    mine.PetVisible = true;
                    mine.PetEnabled = true;

                    mine.PetPlaying = true;
                    //playTimer = new System.Timers.Timer();
                    //playTimer.Interval = 16000; //8 seconds?
                    //playTimer.Elapsed += PlayTimesUp;
                    //playTimer.Start();
                }
                else//just need more time
                {

                }

            }
            else //pet has played enough
            {
                mine.PetVisible = false;
                mine.PetEnabled = false;
                mine.PetPlaying = false;
                
                
            }

        }

        public void Play()
        {
            
            if (mine.PetBoredom > mine.Min_Boredom)
            // give user chance to play with pet and decrease PetBoredom
            {
                mine.PetPlayRateCounter++;
                if (mine.PetPlayRateCounter >= mine.PetPlayRateFrame)
                {
                    if (mine.PetBoredom > 0)
                    {
                        mine.CurrentImage = mine.PetPlayingImage;
                        mine.PetPlayRateCounter = 0;//reset
                                                    //display buttons now which will decrease PetBoredom
                        mine.PetVisible = true;
                        mine.PetEnabled = true;
                        mine.PetPlaying = true;
                    }
                    else
                    {
                        EndPlay();
                    }
               
                }
                else//just need more time
                {
                    //do nada
                }

            }
            else //pet has played enough
            {
                EndPlay();
            }
        }//end Play

        public void EndPlay()
        {
            mine.PetVisible = false;
            mine.PetEnabled = false;
            mine.PetPlaying = false;
            mine.State = new Neutral(mine);
        }

        public void EatNew()
        {

        }
        public void SleepNew()
        {

        }
        public void DrinkNew()
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
