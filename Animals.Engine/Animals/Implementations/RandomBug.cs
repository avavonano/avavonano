using Animals.Engine.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animals.Engine.Animals.Implementations
{
    public class RandomBug : Animal
    {
        public RandomBug(string name, bool isFury, int life, int damage, int defence, IPlayerUIStream txtBox) 
            : base(name, isFury, life, damage, defence, AnimalType.RandomBug,"poison sting with virous",  txtBox,"Bbbzzzzzz")
        {
        }

        protected override void AttackInternal(IAnimal opponent)
        {
            opponent.Life -= Utilities.Math.RandomNumberBetween(1, 2* Damage);
        }

        public override int Defend(IAnimal opponent)
        {
            int hit = Utilities.Math.RandomNumberBetween(0, opponent is Rhino ? 4 : 2);
            if(hit==1)
            {
                Talk("Poisooooonnnn sting..... You will die whore.");
                opponent.PoisonDamage += Utilities.Math.RandomNumberBetween(1, 8); ;
            }
            
            return 0;
        }
        protected override void ReceiveAttackInternal(IAnimal opponent, int receivingDamage)
        {
            int defence = Defend(opponent);
            receivingDamage = receivingDamage - defence < 0 ? 0 : receivingDamage - defence;
            int hit = Utilities.Math.RandomNumberBetween(0, opponent is Cat ? (Defense / 5) : Defense);
            if (hit == 1)
            {
                Talk("SpluchHH!");
                Life -= InitialLife/2 ;
            }
            else
            {
                Talk("Zzzzzzzzzzz... you missed stupid bitch!");
            }
        }
    }
}
