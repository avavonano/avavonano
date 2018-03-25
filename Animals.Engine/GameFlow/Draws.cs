﻿using Animals.Engine.Advantages;
using Animals.Engine.Advantages.Implementations;
using Animals.Engine.Animals;
using Animals.Engine.Animals.Implementations;
using Animals.Engine.UI.Interfaces;

namespace Animals.Engine.GameFlow
{
    public static class Draws
    {
        public static IAnimal GetAnimal(string name, IUIStream uiStream)
        {
            IAnimal animal;
            int rnd = Utilities.Math.RandomNumberBetween(0, 3);
            if (rnd == 0)
            {
                animal = new Cat(name, false, false, 200, 20, 10, uiStream);
            }
            else if (rnd == 1)
            {
                animal = new Dog(name, true, 550, 50, 18, uiStream);
            }
            else
            {
                animal = new RandomBug(name, true, 20, 3, 25, uiStream);
            }
            return animal;
        }
        public static Advantage GetAdvantage()
        {
            Advantage advantage;
            int rnd = Utilities.Math.RandomNumberBetween(0, 3);
            if (rnd == 0)
            {
                advantage = new RedrawDeckAdvantage();
            }
            else if (rnd == 1)
            {
                advantage = new RedrawDeckAdvantage();
            }
            else
            {
                advantage = new SeeOpponentDeck();
            }
            return advantage;
        }
    }
}
