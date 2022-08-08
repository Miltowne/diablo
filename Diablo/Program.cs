// See https://aka.ms/new-console-template for more information


//[STAThread] 
using Diablo.HeroClasses;
using Diablo.HeroClasses.SubClassesToHeroes;
using Diablo.Items;
using Diablo.Items.Armour;
using Diablo.Items.Weapon;


        Warrior warrior = new Warrior("Paul");
        Weapon levelFiveAxe = new Weapon()
        {
            ItemName = "Common axe",
            ItemLevel = 1,
            ItemSlot = ItemSlot.SLOT_WEAPON,
            WeaponType = WeaponType.WEAPON_AXE,
            WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
        };


Armour testPlateBody = new Armour()
{
    ItemName = "Common plate body armor",
    ItemLevel = 5,
    ItemSlot = ItemSlot.SLOT_HEAD,
    ArmourType = ArmourType.ARMOUR_PLATE,
    Attributes = new PrimaryAttributes() { Strength = 1 }
};
Armour testPlate1Body = new Armour()
{
    ItemName = "Common plate legs armor",
    ItemLevel = 5,
    ItemSlot = ItemSlot.SLOT_LEGS,
    ArmourType = ArmourType.ARMOUR_PLATE,
    Attributes = new PrimaryAttributes() { Strength = 1 }
};
Armour testPlate2Body = new Armour()
{
    ItemName = "Common plate body armor",
    ItemLevel = 5,
    ItemSlot = ItemSlot.SLOT_BODY,
    ArmourType = ArmourType.ARMOUR_PLATE,
    Attributes = new PrimaryAttributes() { Strength = 20 }
};
Armour testPlate3Body = new Armour()
{
    ItemName = "Common plate body armor",
    ItemLevel = 5,
    ItemSlot = ItemSlot.SLOT_BODY,
    ArmourType = ArmourType.ARMOUR_PLATE,
    Attributes = new PrimaryAttributes() { Strength = 40 }
};
Armour testArmourBody = new Armour()
{
    ItemName = "Common plate body armor with style",
    ItemLevel = 1,
    ItemSlot = ItemSlot.SLOT_BODY,
    ArmourType = ArmourType.ARMOUR_PLATE,
    Attributes = new PrimaryAttributes() { Strength = 1 }
};
//warrior.PickUpItem(levelFiveAxe);
//warrior.LevelUp();

//warrior.LevelUp();
//warrior.LevelUp();
//warrior.LevelUp();
//warrior.LevelUp();
//warrior.LevelUp();

//warrior.PickUpItem(testPlateBody);
//warrior.PickUpItem(testPlate1Body);
//warrior.PickUpItem(testPlate2Body);
warrior.PickUpItem(testArmourBody);
Console.WriteLine(warrior.CharacterDamage());
//Console.WriteLine(warrior.GetCharacterInfo().ToString());

//warrior.PickUpItem(testPlate3Body);

Console.WriteLine(warrior.Stats);
//Console.WriteLine(warrior.Stats);


