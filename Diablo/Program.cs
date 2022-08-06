// See https://aka.ms/new-console-template for more information


//[STAThread] 
using Diablo.HeroClasses;
using Diablo.Items;
using Diablo.Items.Weapon;


        Warrior warrior = new Warrior();
        Weapon levelFiveAxe = new Weapon()
        {
            ItemName = "Common axe",
            ItemLevel = 5,
            ItemSlot = ItemSlot.SLOT_WEAPON,
            WeaponType = WeaponType.WEAPON_AXE,
            WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
        };

        warrior.PickUpItem(levelFiveAxe);


//Console.WriteLine(levelFiveAxe.WeaponAttributes.Dps);
Console.WriteLine(warrior.CharacterDamage());

Console.WriteLine(warrior.GetGear().ToString());
    
