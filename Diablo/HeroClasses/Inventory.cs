

namespace Diablo.HeroClasses
{
    public class Inventory
    {
        private readonly IDictionary<string, string> DictnionaryInventory = new Dictionary<string, string>();

        public string this[string key]
        {
            // returns value if exists
            get { return DictnionaryInventory[key]; }

            // updates if exists, adds if doesn't exist
            set { DictnionaryInventory[key] = value; }
        }
    }
}
