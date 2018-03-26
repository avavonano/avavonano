using Animals.Engine.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace Animals.Engine.Animals.Implementations
{
    public class Cat : Animal
    {


        private bool _likesFish;
        private int _catLife = 7;
        public Cat(string name, bool isFury, bool likesFish, int life, int damage, int defence,IPlayerUIStream txtBox)
            : base(name, isFury, life, damage,defence,AnimalType.Cat,"7 lifes",txtBox, "Meow")
        {
            _likesFish = likesFish;
        }
        public override bool CheckDeath()
        {
            if (base.CheckDeath())
            {
                if (_catLife <= 1)
                {
                    return true;
                }
                else
                {                    
                    _catLife -= 1;
                    Talk("Still " + _catLife + " out of 7 lifes bitch! MiaaaaaaarrrMouahahahahah");
                    //Life += InitialLife;
                    Life = Utilities.Math.RandomNumberBetween(50, 101);
                    Damage += Utilities.Math.RandomNumberBetween(1, 8);
                    Defense += Utilities.Math.RandomNumberBetween(1, 8);
                }
            }
            return false;
        }
        protected override void AttackInternal(IAnimal opponent)
        {
            Talk("Hhhssshhhhhhhhhhhhhhhhhhhhhhhhsssss");
            int a = Utilities.Math.RandomNumberBetween(1, 5);
            int extraDamage = 0;
            if (a == 3)
            {
                Talk("Miaaaaaarrrrrr");
                extraDamage = Damage;
            }
            opponent.ReceiveAttack(this,Damage+extraDamage);

        }
        public override void DeathWhisper()
        {
            Talk("khhhhhhhhhhhhhhhhhhhhhh");
        }

        public override int Defend(IAnimal opponent)
        {
            opponent.Life -= Utilities.Math.RandomNumberBetween(0, opponent is RandomBug ? 0: Defense);
            return 0;
        }
    }

}
