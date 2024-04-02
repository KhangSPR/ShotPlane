using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public abstract class ShootAbleObjectAbstact : SaiMonoBehaviour
{
    [Header("ShootAbleObject Abstact")]
    [SerializeField] protected ShootAbleObjectCtrl shootAbleObjectCtrl;
    public ShootAbleObjectCtrl ShootAbleObjectCtrl => shootAbleObjectCtrl;
    protected override void loadComponents()
    {
        base.loadComponents();
        this.LoadShootAbleObjectCtrl();
    }
    protected virtual void LoadShootAbleObjectCtrl()
    {
        if (this.shootAbleObjectCtrl != null) return;
        this.shootAbleObjectCtrl = transform.parent.GetComponentInChildren<ShootAbleObjectCtrl>();
        Debug.Log(gameObject.name + ": loadShootAbleObjectCtrl" + gameObject);
    }
}
