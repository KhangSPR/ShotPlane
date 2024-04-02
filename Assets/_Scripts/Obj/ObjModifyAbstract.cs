using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjModifyAbstract : SaiMonoBehaviour
{
    [Header("Modify")]
    [SerializeField] protected ShootAbleObjectCtrl ShootAbleObjectCtrl;
    protected override void loadComponents()
    {
        base.loadComponents();
        this.LoadShootAbleObjectCtrl();
    }
    protected virtual void LoadShootAbleObjectCtrl()
    {
        if (this.ShootAbleObjectCtrl != null) return;
        this.ShootAbleObjectCtrl = transform.GetComponent<ShootAbleObjectCtrl>();
        Debug.LogWarning(transform.gameObject + " :LoadShootAbleObjectCtrl", gameObject);
    }

}
