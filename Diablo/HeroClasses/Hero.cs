using Diablo.HeroClasses.SubClassesToHeroes;
using Diablo.Items;
using Diablo.Items.Armour;
using Diablo.Items.Weapon;

namespace Diablo.HeroClasses
{
    public abstract class Hero
    {

        public string Name { get; set; }


        //public double Damage 
        //{ 
            
        //}

        public int Level { get; set; }


        protected PrimaryAttributes BasePrimaryAttributes { get; set; } = new PrimaryAttributes(1, 1, 1); // ökar när du levlar upp
        protected PrimaryAttributes TotalPrimaryAttributes { get; set; } = new PrimaryAttributes(1, 1, 1); // ökar när du har Armour / härstammar BasePrima...



        public Hero()
        {
            Level = 1;
        }

        private readonly IDictionary<ItemSlot, Item> Inventory = new Dictionary<ItemSlot, Item>();

        public Item this[ItemSlot key]
        {
            // returns value if exists
            get { return Inventory[key]; }

            // updates if exists, adds if doesn't exist
            set { Inventory[key] = value; }
        }

        public Hero(string _name)
        {
            Name = _name;
            Level = 1;
        }

        public virtual void LevelUp()
        {
            this.Level++;
        }

        //public int[] getAttributes()
        //{
        //    return new int[] { attributes.Strength, attributes.Dexterity, attributes.Intelligence };
        //}

        public virtual void PickUpItem(IEquipable item)
        {
            Type type = item.GetType();
            if (type == typeof(Weapon)) Inventory.Add((item as Weapon)!.ItemSlot, (item as Weapon)!);
            else if (type == typeof(Armour)) Inventory.Add((item as Armour)!.ItemSlot, (item as Armour)!);
        }

        public virtual void PickUpWeapon(Weapon weapon)
        {
            Inventory.Add(weapon.ItemSlot, weapon);
        }
        public virtual void PickUpArmour(Armour armour)
        {
            Inventory.Add(armour.ItemSlot, armour);
        }

        public virtual double CharacterDamage()
        {
            return Math.Round((Inventory[ItemSlot.SLOT_WEAPON] as Weapon)!.WeaponAttributes.Dps * (1 +  TotalPrimaryAttributes.Strength / 100), 2);
        }

    }
}
