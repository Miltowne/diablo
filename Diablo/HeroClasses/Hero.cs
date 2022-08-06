﻿using Diablo.HeroClasses.SubClassesToHeroes;
using Diablo.Items;
using Diablo.Items.Armour;
using Diablo.Items.Weapon;
using System.Text;

namespace Diablo.HeroClasses
{
    public abstract class Hero
    {

        public string? Name { get; set; }

        public int Level { get; private set; }


        public PrimaryAttributes BasePrimaryAttributes { get; protected set; } // ökar när du levlar upp
        protected PrimaryAttributes TotalPrimaryAttributes { get; set; } // ökar när du har Armour / härstammar BasePrima...

        protected List<WeaponType> CharacterWeaponTypes { get; set; }
        protected List<ArmourType> CharacterArmourTypes { get; set; }



        public Hero()
        {
            Level = 1;
        }
        public Hero(string? _name)
        {
            if (_name is not null) 
            { 
                Name = _name;
            }
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

        public StringBuilder GetGear()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Name: {Name}");
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append($"Level: {Level}");
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append($"Strength: {TotalPrimaryAttributes.Strength}");
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append($"Dexterity: {TotalPrimaryAttributes.Dexterity}");
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append($"Intelligence: {TotalPrimaryAttributes.Intelligence}");
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append($"Damage: {CharacterDamage()}");
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append($"Created: {DateTime.Now}");
            stringBuilder.Append(Environment.NewLine);
            return stringBuilder;
        }


        public virtual void LevelUp()
        {
            this.Level++;
        }

        public virtual void PickUpItem(IEquipable item)
        {
            Type type = item.GetType();
            if (type == typeof(Weapon)) Inventory.Add((item as Weapon)!.ItemSlot, (item as Weapon)!);
            else if (type == typeof(Armour)) Inventory.Add((item as Armour)!.ItemSlot, (item as Armour)!);
            else throw new Exception("Hero.PickUpItem: Item is neither type Weapon or Armour");
        }

        public virtual double CharacterDamage()
        {
            if (Inventory.ContainsKey(ItemSlot.SLOT_WEAPON))
            {
                return Math.Round((Inventory[ItemSlot.SLOT_WEAPON] as Weapon)!.WeaponAttributes.Dps * (1 + TotalPrimaryAttributes.Strength / 100), 2);
            }
            else return Math.Round(1 + TotalPrimaryAttributes.Strength / 100, 2);
        }
    }
}
