using System.Collections.Generic;
using Game.Model.Items;

namespace Game.Model.Inventory
{
    public interface IInventory
    {
        IReadOnlyList<IItem> Items { get; }
        
        void Add(IItem item);
    }
}