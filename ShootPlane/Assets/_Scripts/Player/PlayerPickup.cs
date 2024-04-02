using Unity.VisualScripting.ReorderableList;
using UnityEngine;

public class PlayerPickup : PlayerAbstract
{
    public virtual void ItemPickup(ItemPickupable itemPickupable)
    {

        ItemInventory itemInventory = itemPickupable.ItemCtrl.ItemInventory;
        if (this.playerCtrl.CurrentShip.Inventory.AddItem(itemInventory))
        {
            itemPickupable.Picked();
        }
    }
}
