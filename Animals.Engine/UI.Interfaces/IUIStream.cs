using Animals.Engine.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Engine.UI.Interfaces
{
    public interface IUIStream
    {
        bool LoggingOff { get; set; }
        void Talk(string phrase);
        void UpdateStats(IAnimal animal);
        void ShowHero(AnimalType animalType);
        void Reset(IAnimal animal);
        IAnimal PickAnimal();
    }
}
