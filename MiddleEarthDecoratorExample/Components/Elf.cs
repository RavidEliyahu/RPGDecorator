using MiddleEarthDecorator.Components.Common;

namespace MiddleEarthDecorator.Components
{
    public class Elf : ICharacter
    {
        public string GetRaceName()
        {
            return GetType().Name;
        }

        public string Equipment()
        {
            return "* Daggers";
        }

        public int GetAttackPower()
        {
            return 4;
        }

        public void Wisdom()
        {
            Console.WriteLine("Thinking about the next project...");
        }
    }
}