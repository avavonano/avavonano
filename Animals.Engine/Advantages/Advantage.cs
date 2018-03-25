using Animals.Engine.GameFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Engine.Advantages
{
    public abstract class Advantage
    {
        public string Description { get; private set; }
        protected Advantage(string description)
        {
            Description = description;
        }
        public void ApplyAdvantage(Player player, Game game)
        {
            ApplyAdvantageInternal(player, game);
            player.UIStream.Talk("Advantage: " + GetType().Name + " (" + Description + ") was excercised.");
        }
        protected abstract void ApplyAdvantageInternal(Player player, Game game);
    }
}
