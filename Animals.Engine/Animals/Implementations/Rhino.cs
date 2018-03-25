using Animals.Engine.UI.Interfaces;
using System;

namespace Animals.Engine.Animals.Implementations
{
    public class Rhino : Animal
    {
        public Rhino(string name, bool isFury, int life, int damage, int defence, IUIStream txtBox)
            : base(name, isFury, life, damage, defence, AnimalType.Rhino,"to be filled",  txtBox,"GGGGRRRRRRrrrrrrrmmmmmhhhhhhhh")
        {
        }

        protected override void AttackInternal(IAnimal opponent)
        {
            Talk("......................... ........... ........ ....");
            int a = Utilities.Math.RandomNumberBetween(1, 25);
            int extraDamage = 0;
            if (a == 17)
            {
                Talk("RRRrrrhhhhhmmmmmphhhh  Wraghahgarrrrf");
                extraDamage = opponent.InitialLife;
            }
            opponent.ReceiveAttack(this, Damage + extraDamage);
        }

        public override int Defend(IAnimal opponent)
        {
            Talk("Pfffff weak");
            return Utilities.Math.RandomNumberBetween((Defense/2), Defense);
        }
    }
}
