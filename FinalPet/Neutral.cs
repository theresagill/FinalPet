using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPet
{
    [Serializable]
    class Neutral : IStateOfPet
    {

        //fields
        private Pet mine;

        //constructor
        public Neutral(Pet p)
        {
            mine = p; //pass around the instance of
                      // the subclass that inherits from Pet
        }
        public void Drink()
        {
            //do nada
        }

        public void DrinkNew()
        {
            mine.CurrentImage = mine.PetImage;
        }

        public void Eat()
        {
            //do nada
        }

        public void EatNew()
        {
            mine.CurrentImage = mine.PetImage;
            
        }

        public void Play()
        {
            mine.CurrentImage = mine.PetImage;
            
        }

        public void Pray()
        {
            //do nada  
        }

        public void ReceiveAffection()
        {
            mine.CurrentImage = mine.PetImage;
        }

        public void Sleep()
        {
            mine.CurrentImage = mine.PetImage;
        }

        public void SleepNew()
        {
            mine.CurrentImage = mine.PetImage;
        }
    }

    }
