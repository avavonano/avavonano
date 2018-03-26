using Animals.Engine.Animals;
namespace Animals.Engine.UI.Interfaces
{
    public interface IPlayerUIStream
    {
        bool LoggingOff { get; set; }
        /// <summary>
        /// Must make the animal to say the phrase in the UI.
        /// </summary>
        /// <param name="phrase"></param>
        void Talk(string phrase);
        /// <summary>
        /// Must Update the stats of the card in the UI.
        /// </summary>
        /// <param name="animal"></param>
        void UpdateStats(IAnimal animal);
        /// <summary>
        /// Must Show the card in the UI.
        /// </summary>
        /// <param name="animalType"></param>
        void ShowHero(AnimalType animalType);
        /// <summary>
        /// Must reset the animal's UI Fields using animal.
        /// </summary>
        /// <param name="animal"></param>
        void Reset(IAnimal animal);
    }
}
