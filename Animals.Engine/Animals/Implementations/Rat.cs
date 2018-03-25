using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals.Engine.UI.Interfaces;

namespace Animals.Engine.Animals.Implementations
{
    public class Rat : Animal
    {
        public Rat(string name, bool isFury, int life, int damage, int defence, IUIStream uistream) 
            : base(name, isFury, life, damage, defence, AnimalType.Rat, "Sewers Dweller: Psn Dmg & Immune to Psn", uistream,"Squeeecrq")
        {
        }

        public override int Defend(IAnimal opponent)
        {
            ImmuneToPoison();
            return Utilities.Math.RandomNumberBetween(0, Defense + opponent.Defense/2);
        }

        private void ImmuneToPoison()
        {
            PoisonDamage = 0;
        }
        protected override void AttackInternal(IAnimal opponent)
        {
            opponent.ReceiveAttack(this, Damage);
            opponent.PoisonDamage += Utilities.Math.RandomNumberBetween(4, 8);
            ImmuneToPoison();
        }
    }
}
