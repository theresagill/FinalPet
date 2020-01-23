using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPet
{
    public interface IStateOfPet
    {
        void Eat();
        void Drink();
        void Play();
        void ReceiveAffection();
        void Sleep();
        void Pray();
        void EatNew();
        void DrinkNew();
        void SleepNew();


    }
}
