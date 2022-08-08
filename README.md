# Diablo



# About the project
Diablo is based on the game Diablo 3. It's a console application and have classes of heroes with attributes like Strength, Dexterity and Intelligence and Weapons and Armour that the characters we remember from the game can wield.


## Built With

C#, Console Application, Xunit tests, Visual Studio 2022

## Getting Started / Usage

# In program.cs

using Diablo.HeroClasses;
using Diablo.HeroClasses.SubClassesToHeroes;
using Diablo.Items;
using Diablo.Items.Armour;
using Diablo.Items.Weapon;


# creates a hero
Warrior warrior = new Warrior();

# creates a hero with a name
Warrior warrior = new Warrior("FrankTheMauler");

# creates a item
Weapon weapon = new Weapon();
Armour armour = new Armour();

# gives the item to hero
warrior.PickUpItem(weapon)

# returns the stats of the character
warrior.Stats

# returns damage of the character
warrior.Dps

## Author
Tim Jonasson
