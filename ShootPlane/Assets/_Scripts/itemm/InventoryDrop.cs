using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryDrop : InventoryAbstract
{
    //[Header("Item Drop")]
    protected override void Start()
    {
        base.Start();
        Invoke(nameof(this.Test), 5);
    }
    protected virtual void Test()
    {
        Vector3 pos = transform.position;
        pos.x += 1;
        this.DropItemIndex(0,pos,transform.rotation);
    }
    protected virtual void DropItemIndex(int itemIndex, Vector3 droppos, Quaternion dropros)
    {
        ItemInventory itemInventory = this.inventory.Items[itemIndex];


        ItemDropSpawner.Instance.Drop(itemInventory, droppos, dropros);
        this.inventory.Items.Remove(itemInventory);

    }
    
}
