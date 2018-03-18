using Animals.Engine.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Animals.Engine.Animals
{
    public interface IAnimal
    {
        //Combat
        int Life { get; set; }
        int InitialLife { get; set; }
        int Damage { get; set; }
        int Defense { get; set; }
        int Fatigue { get; set; }
        int PoisonDamage { get; set; }
        AnimalType AnimalType { get; set; }
        // bool Stealth { get; set; }
        string SpecialAbilities { get; set; }
        //Theme
        string Name { get; set; }
        bool IsFury { get; set; }
        
        IUIStream Console { get; set; }
        //  int Size 

        void Talk(string extraGreeting = "");
        void Attack(IAnimal opponent);
        void ReceiveAttack(IAnimal opponent, int receivingDamage);
        int Defend(IAnimal opponent);
        bool CheckDeath();
        void DeathWhisper();
        void ShowHero();
    }
}
