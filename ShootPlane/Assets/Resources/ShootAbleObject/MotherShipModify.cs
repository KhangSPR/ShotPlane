using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherShipModify : ObjModifyAbstract
{
    [Header("Mother Ship")]
    [SerializeField] protected float speed = 0.003f;
    [SerializeField] protected float speedRot = 0.1f;
    protected override void Start()
    {
        base.Start();
        this.ShipModify();
    }
    protected virtual void ShipModify()
    {
        this.ShootAbleObjectCtrl.ObjMovement.setSpeed(this.speed);
        this.ShootAbleObjectCtrl.ObjLookAtTarget.SetSpeedRot(this.speedRot);
    }
}
