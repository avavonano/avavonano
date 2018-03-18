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
        public RandomBug(string name, bool isFury, int life, int damage, int defence, ref TextBox txtBox) 
            : base(name, isFury, life, damage, defence, AnimalType.RandomBug,"poison sting with virous", ref txtBox)
        {
        }

        protected override void AttackInternal(IAnimal opponent)
        {
            opponent.Life -= Utilities.RandomNumberBetween(1, 2* Damage);
        }

        public override int Defend(IAnimal opponent)
        {
            int hit = Utilities.RandomNumberBetween(0, opponent is Rhino ? 4 : 2);
            if(hit==1)
            {
                Talk("Poisooooonnnn sting..... You will die whore.");
                opponent.PoisonDamage += Utilities.RandomNumberBetween(1, 8); ;
            }
            
            return 0;
        }
        public override void ReceiveAttack(IAnimal opponent, int receivingDamage)
        {
            int defence = Defend(opponent);
            receivingDamage = receivingDamage - defence < 0 ? 0 : receivingDamage - defence;
            int hit = Utilities.RandomNumberBetween(0, opponent is Cat ? (Defense / 5) : Defense);
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
