using Diablo.HeroClasses.SubClassesToHeroes;

namespace Diablo.Items.Armour
{
    public class Armour : Item, IEquipable
    {
        public ArmourType ArmourType { get; set; }

        public PrimaryAttributes Attributes { get; set; }

    }
}
