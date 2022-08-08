using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo.Items
{
    public abstract class Item
    {
        /// <summary>
        /// abstract class with the base properties for the armour and weapons
        /// </summary>
        public string? ItemName { get; set; }

        public int ItemLevel { get; set; }

        public ItemSlot ItemSlot { get; set; }

    }
}
