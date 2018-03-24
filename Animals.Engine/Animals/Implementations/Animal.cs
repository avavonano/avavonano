using Animals.Engine.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Animals.Engine.Animals.Implementations
{
    public abstract class Animal : IAnimal
    {

        public string Name { get; set; }
        public bool IsFury { get; set; }
        public int Life { get; set; }
        public int Damage { get; set; }
        public int InitialLife { get; set; }
        public int Defense { get; set; }
        public int Fatigue { get; set; }
        public int PoisonDamage { get; set; } = 0;
        public string SpecialAbilities { get; set; }
        public IUIStream Console { get; set; }
        public AnimalType AnimalType { get; set; }
        protected string greeting;
        

        protected Animal(string name, bool isFury, int life, int damage, int defence,AnimalType animalType, string specialAbilities, IUIStream uistream)
        {
            Name = name;
            IsFury = isFury;
            Life = life;
            Damage = damage;
            InitialLife = life;
            Defense = defence;
            Console = uistream;
            AnimalType = animalType;
            SpecialAbilities = specialAbilities;
                       
           // ShowHero();
        }

        public virtual void Talk(string extraGreeting = "")
        {
            Console.Talk(extraGreeting == ""?greeting: Name + ": '" + extraGreeting + "'.");            
        }
        public void ShowHero()
        {
            Console.Reset(this);
            Console.UpdateStats(this);
            Console.ShowHero(AnimalType);
        }
        public  void Attack(IAnimal opponent)
        {
            Talk();
            AttackInternal(opponent);
            ApplyPoison();
            Console.UpdateStats(this);
        }
        protected abstract void AttackInternal(IAnimal opponent);
        public virtual bool CheckDeath()
        {
            bool res = Life <= 0;
            Talk("Player " + Name + " has " + Life + " left out of " + InitialLife);
            if (res) { DeathWhisper(); }
            return res;
        }
        public void  ReceiveAttack(IAnimal opponent, int receivingDamage)
        {
            ReceiveAttackInternal(opponent, receivingDamage);
            Console.UpdateStats(this);       
        }
        protected virtual void ReceiveAttackInternal(IAnimal opponent, int receivingDamage)
        {
            int defence = Defend(opponent);
            receivingDamage = receivingDamage - defence < 0 ? 0  : receivingDamage - defence;
            Life -= (receivingDamage);
        }
        public virtual void ApplyPoison()
        {
            Life -= (PoisonDamage);
        }
        public virtual void DeathWhisper()
        {
            Talk(Name + ": 'I see the light..... Ooohhh it's heellll.'");
        }

        public abstract int Defend(IAnimal opponent);
    }
}
