using Animals.Engine.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animals.Engine.Animals.Implementations
{
    public class Rhino : Animal
    {
        protected Rhino(string name, bool isFury, int life, int damage, int defence, IUIStream txtBox)
            : base(name, isFury, life, damage, defence, AnimalType.Rhino,"to be filled",  txtBox)
        {
        }

        protected override void AttackInternal(IAnimal opponent)
        {
            throw new NotImplementedException();
        }

        public override int Defend(IAnimal opponent)
        {
            throw new NotImplementedException();
        }
    }
}
