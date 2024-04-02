using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbstract : SaiMonoBehaviour
{
    [SerializeField] protected PlayerCtrl playerCtrl;
    public PlayerCtrl PlayerCtrl => playerCtrl;
    protected override void loadComponents()
    {
        base.loadComponents();
        this.loadPlayerCtrl();
    }
    protected virtual void loadPlayerCtrl()
    {
        if (this.playerCtrl != null) return;
        this.playerCtrl = transform.parent.GetComponent<PlayerCtrl>();
        Debug.Log(transform.name + ": loadPlayerCtrl", gameObject);
    }
}
