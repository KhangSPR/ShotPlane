using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class ItemPickupable : ItemAbstract
{
    [Header("Item Pickupable")]
    [SerializeField] protected SphereCollider _collider;

    public static ItemCode String2ItemCode(string itemName)
    {
        try
        {
            return (ItemCode)System.Enum.Parse(typeof(ItemCode), itemName); //Chuy?n ??i Chu?i thành Enum
        }
        catch (ArgumentException e)
        {
            Debug.LogError(e.ToString());
            return ItemCode.NoItem;
        }
        //return (ItemCode)System.Enum.Parse(typeof(ItemCode), itemName);
    }

    //public virtual void OnMouseDown()
    //{
    //    Debug.Log(transform.parent.name);
    //    PlayerCtrl.Instance.PlayerPickup.ItemPickup(this);
    //}
    protected virtual void OnMouseDown()
    {
        PlayerCtrl.Instance.PlayerPickup.ItemPickup(this);

    }
    protected override void loadComponents()
    {
        base.loadComponents();
        this.LoadTrigger();
    }

    protected virtual void LoadTrigger()
    {
        if (this._collider != null) return;
        this._collider = transform.GetComponent<SphereCollider>();
        this._collider.isTrigger = true;
        this._collider.radius = 0.1f;
        Debug.LogWarning(transform.name + " LoadTrigger", gameObject);
    }

    public virtual ItemCode GetItemCode()
    {
        return ItemPickupable.String2ItemCode(transform.parent.name);
    }

    public virtual void Picked()
    {
        this.itemCtrl.ItemDespawn.deSpawnObj();
    }

}