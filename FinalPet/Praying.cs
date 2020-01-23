using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Media;

namespace FinalPet
{
    [Serializable]
    class Praying : IStateOfPet
    {
        //fields
        private Pet mine;
        private System.Timers.Timer prayTimer;


        //constructor
        public Praying(Pet p)
        {
            mine = p; //pass around the instance of
                      // the subclass that inherits from Pet
            prayTimer = new System.Timers.Timer();
            prayTimer.Interval = 16000; //8 seconds?
            prayTimer.Elapsed += PrayTimesUp;
            prayTimer.Start();
        }
        private void PrayTimesUp(object sender, ElapsedEventArgs e)
        {
            //MessageBox.Show("Praytime is finished");
            prayTimer.Enabled = false;
            prayTimer.Stop();
            mine.State = new Playing(mine);
            mine.State.Play();
        }
        public void Drink()
        {
            //do nada
        }
        public void Pray()
        {
            //mine.CurrentImage = Properties.Resources.catpraying;
            mine.CurrentImage = mine.PetPrayingImage;
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            simpleSound.Play();
            

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
        public void Play()
        {
            //do nada
        }

        public void Sleep()
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
