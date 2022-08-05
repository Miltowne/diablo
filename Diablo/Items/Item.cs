using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo.Items
{
    public abstract class Item
    {
        public string ItemName { get; set; }

        public int ItemLevel { get; set; }

        public Slot ItemSlot { get; set; }

        //public Item(string _itemName, int _itemLevel, Slot itemSlot)
        //{
        //    ItemName = _itemName;
        //    ItemLevel = _itemLevel;
        //    ItemSlot = itemSlot;
        //}
    }
}
