using Animals.Engine.Animals;
namespace Animals.Engine.UI.Interfaces
{
    public interface IUIStream
    {
        bool LoggingOff { get; set; }
        void Talk(string phrase);
        void UpdateStats(IAnimal animal);
        void ShowHero(AnimalType animalType);
        void Reset(IAnimal animal);
    }
}
