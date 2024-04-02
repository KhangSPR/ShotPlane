using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class JunkAbstract : SaiMonoBehaviour
{
    [SerializeField] protected ShootAbleObjectCtrl shotAbleObjectCtrl;
    public ShootAbleObjectCtrl JunkCtrl { get => shotAbleObjectCtrl;}
    protected override void loadComponents()
    {
        base.loadComponents();
        this.loadJunkCtrl();
    }
    protected virtual void loadJunkCtrl()
    {
        if (this.shotAbleObjectCtrl != null) return;
        this.shotAbleObjectCtrl = transform.parent.GetComponent<ShootAbleObjectCtrl>();
        Debug.Log(gameObject.name + ": loadJunkCtrl" + gameObject);
    }


}
