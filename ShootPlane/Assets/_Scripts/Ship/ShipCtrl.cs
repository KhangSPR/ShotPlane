using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipCtrl : SaiMonoBehaviour
{
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
        this.inventory = transform.GetComponentInChildren<Inventory>();
        Debug.Log(transform.name + ": loadInventory", gameObject);
    }


}
