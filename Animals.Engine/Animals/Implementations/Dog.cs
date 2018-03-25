using Animals.Engine.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Animals.Engine.Animals.Implementations
{
    public class Dog : Animal
    {

        public Dog(string name, bool isFury, int life, int damage, int defence,IUIStream txtBox)
            : base(name, isFury, life, damage,defence,AnimalType.Dog,"plus half opponent's life damage",txtBox)
        {
            greeting = "Woof";
        }
        protected override void AttackInternal(IAnimal opponent)
        {

            Talk("You will meet a horrible death");
            if(opponent is Dog)
            {
                Damage += Utilities.Math.RandomNumberBetween(25, 45);
            }
            int a = Utilities.Math.RandomNumberBetween(1, 30);
            int extraDamage = 0;
            if (a == 1)
            {
                Talk("Your end is near");
                extraDamage = (opponent.Life) / 2;
            }
            int b = Utilities.Math.RandomNumberBetween(1, 5);
            if (b == 1)
            {
                Talk("You got away, this time...");
                opponent.ReceiveAttack(this, 0);
            }
            else
            {
                opponent.ReceiveAttack(this, Damage + extraDamage);
            }
            
        }

        public override int Defend(IAnimal opponent)
        {
            return Utilities.Math.RandomNumberBetween(0, Defense);
        }
    }

}
