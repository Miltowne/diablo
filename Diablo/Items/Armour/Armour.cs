using Diablo.HeroClasses.SubClassesToHeroes;

namespace Diablo.Items.Armour
{
    public class Armour : Item, IEquipable
    {
        /// <summary>
        /// Sets the Armour type to the armour
        /// </summary>
        public ArmourType ArmourType { get; set; }

        /// <summary>
        /// Armour can have attributes to when the character have the armour in the inventory
        /// </summary>
        public PrimaryAttributes Attributes { get; set; }

    }
}
