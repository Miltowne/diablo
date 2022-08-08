using Diablo.Helpers;
using Diablo.HeroClasses.SubClassesToHeroes;
using Diablo.Items;
using Diablo.Items.Armour;
using Diablo.Items.Weapon;
using System.Text;

namespace Diablo.HeroClasses
{
    public abstract class Hero
    {

        public string Name { get; set; }

        public int Level { get; private set; } = 1;

        public PrimaryAttributes BasePrimaryAttributes { get; protected set; } // ökar när du levlar upp
        public PrimaryAttributes TotalPrimaryAttributes { get; protected set; } // ökar när du har Armour / härstammar BasePrima...

        public List<WeaponType> CharacterWeaponTypes { get; protected set; }
        public  List<ArmourType> CharacterArmourTypes { get; protected set; }


        public string Stats => CharacterStatDisplay().ToString(); 

        public Hero()
        {
        }
        public Hero(string _name)
        {
            if (_name is not null)
            {
                Name = _name;
            }
        }
        /// <summary>
        /// IDictionary is more easy-to-use when it's supposed to update, read and add, than 
        /// the normal Dictionary
        /// </summary>
        private Dictionary<ItemSlot, Item> Inventory = new Dictionary<ItemSlot, Item>();

        public Item this[ItemSlot key]
        {
            // returns value if exists
            get { return Inventory[key]; }

            // updates if exists, adds if doesn't exist
            set { Inventory[key] = value; }
        }
        /// <summary>
        /// Creates a StringBuilder with all the essential stats and inventory items
        /// </summary>
        /// <returns>StringBuilder</returns>
        private StringBuilder CharacterStatDisplay()
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
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append($"Inventory Items");
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append(Environment.NewLine);
            if (Inventory.ContainsKey(ItemSlot.SLOT_HEAD))
            {
                stringBuilder.Append($"Head: {(Inventory[ItemSlot.SLOT_HEAD] as Armour)!.ItemName}");
                stringBuilder.Append(Environment.NewLine);
                stringBuilder.Append($"Level: {(Inventory[ItemSlot.SLOT_HEAD] as Armour)!.ItemLevel}");
                stringBuilder.Append(Environment.NewLine);
                stringBuilder.Append($"Strength: {(Inventory[ItemSlot.SLOT_BODY] as Armour)!.Attributes.GetAllAttributes()[0]}");
                stringBuilder.Append(Environment.NewLine);
                stringBuilder.Append($"Dexterity: {(Inventory[ItemSlot.SLOT_BODY] as Armour)!.Attributes.GetAllAttributes()[1]}");
                stringBuilder.Append(Environment.NewLine);
                stringBuilder.Append($"Intelligence: {(Inventory[ItemSlot.SLOT_BODY] as Armour)!.Attributes.GetAllAttributes()[2]}");
                stringBuilder.Append(Environment.NewLine);
                stringBuilder.Append(Environment.NewLine);
            }
            if (Inventory.ContainsKey(ItemSlot.SLOT_BODY))
            {
                stringBuilder.Append($"Body: {(Inventory[ItemSlot.SLOT_BODY] as Armour)!.ItemName}");
                stringBuilder.Append(Environment.NewLine);
                stringBuilder.Append($"Level: {(Inventory[ItemSlot.SLOT_BODY] as Armour)!.ItemLevel}");
                stringBuilder.Append(Environment.NewLine);
                stringBuilder.Append($"Strength: {(Inventory[ItemSlot.SLOT_BODY] as Armour)!.Attributes.GetAllAttributes()[0]}");
                stringBuilder.Append(Environment.NewLine);
                stringBuilder.Append($"Dexterity: {(Inventory[ItemSlot.SLOT_BODY] as Armour)!.Attributes.GetAllAttributes()[1]}");
                stringBuilder.Append(Environment.NewLine);
                stringBuilder.Append($"Intelligence: {(Inventory[ItemSlot.SLOT_BODY] as Armour)!.Attributes.GetAllAttributes()[2]}");
                stringBuilder.Append(Environment.NewLine);
                stringBuilder.Append(Environment.NewLine);
            }
            if (Inventory.ContainsKey(ItemSlot.SLOT_LEGS))
            {
                stringBuilder.Append($"Legs: {(Inventory[ItemSlot.SLOT_LEGS] as Armour)!.ItemName}");
                stringBuilder.Append(Environment.NewLine);
                stringBuilder.Append($"Level: {(Inventory[ItemSlot.SLOT_LEGS] as Armour)!.ItemLevel}");
                stringBuilder.Append(Environment.NewLine);
                stringBuilder.Append($"Strength: {(Inventory[ItemSlot.SLOT_HEAD] as Armour)!.Attributes.GetAllAttributes()[0]}");
                stringBuilder.Append(Environment.NewLine);
                stringBuilder.Append($"Dexterity: {(Inventory[ItemSlot.SLOT_HEAD] as Armour)!.Attributes.GetAllAttributes()[1]}");
                stringBuilder.Append(Environment.NewLine);
                stringBuilder.Append($"Intelligence: {(Inventory[ItemSlot.SLOT_HEAD] as Armour)!.Attributes.GetAllAttributes()[2]}");
                stringBuilder.Append(Environment.NewLine);
                stringBuilder.Append(Environment.NewLine);

            }
            if (Inventory.ContainsKey(ItemSlot.SLOT_WEAPON))
            {
                stringBuilder.Append($"Weapon: {(Inventory[ItemSlot.SLOT_WEAPON] as Weapon)!.ItemName}");
                stringBuilder.Append(Environment.NewLine);
                stringBuilder.Append($"Level: {(Inventory[ItemSlot.SLOT_WEAPON] as Weapon)!.ItemLevel}");
                stringBuilder.Append(Environment.NewLine);
                stringBuilder.Append($"Type: {(Inventory[ItemSlot.SLOT_WEAPON] as Weapon)!.WeaponType}");
                stringBuilder.Append(Environment.NewLine);
                stringBuilder.Append($"Attack Speed: {(Inventory[ItemSlot.SLOT_WEAPON] as Weapon)!.WeaponAttributes.AttackSpeed}");
                stringBuilder.Append(Environment.NewLine);
                stringBuilder.Append($"Damage: {(Inventory[ItemSlot.SLOT_WEAPON] as Weapon)!.WeaponAttributes.AttackSpeed}");
                stringBuilder.Append(Environment.NewLine);
                stringBuilder.Append($"Dmg: {(Inventory[ItemSlot.SLOT_WEAPON] as Weapon)!.WeaponAttributes.Dps}");
                stringBuilder.Append(Environment.NewLine);
                stringBuilder.Append(Environment.NewLine);
            }
            return stringBuilder;
        }

        public virtual void LevelUp()
        {
            this.Level++;
        }

        private void UpdateAttributes(Item item)
        {
            if (item.GetType() != typeof(Armour)) {
                return;
            }

            Armour armour = (Armour)item;

            if (Inventory.ContainsKey(item.ItemSlot))
            {
                TotalPrimaryAttributes -= armour.Attributes;
            }

                TotalPrimaryAttributes += armour.Attributes;


        }
        public virtual string PickUpItem(IEquipable item)
        {
            Type type = item.GetType();
            if (type == typeof(Weapon)) 
            {
                Inventory[(item as Weapon)!.ItemSlot] = (item as Weapon)!;
                return "New weapon equipped!";
            }
            else if (type == typeof(Armour))
            { 
                UpdateAttributes((item as Item)!);
                Inventory[(item as Item)!.ItemSlot] = (item as Armour)!;
                return "New armour equipped!";
            }
            else throw new InvalidItemException("Hero.PickUpItem: Item is neither type Weapon or Armour");
        }
        public virtual double CharacterDamage()
        {
            if (Inventory.ContainsKey(ItemSlot.SLOT_WEAPON))
            {
                return Math.Round((Inventory[ItemSlot.SLOT_WEAPON] as Weapon)!.WeaponAttributes.Dps * (1 + TotalPrimaryAttributes.Strength / 100), 2);
            }
            else return Math.Round(1 + Convert.ToDouble(TotalPrimaryAttributes.Strength) / 100, 2);
        }
    }
}
