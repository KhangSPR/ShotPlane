using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class InventoryAbstract : SaiMonoBehaviour
{
    [Header("Inventory Abstract")]
    [SerializeField] protected Inventory inventory;
    public Inventory Inventory => inventory;
    protected override void loadComponents()
    {
        base.loadComponents();
        this.loadInventory();

    }
    protected virtual void loadInventory()
    {
        if (this.inventory != null) return;
        this.inventory = transform.parent.GetComponent<Inventory>();
        Debug.Log(transform.name + "Load: loadInventory" + gameObject);
    }
}
