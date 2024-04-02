using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipFollowTarget : ObjMovement
{
    [Header("Follow Target")]
    [SerializeField] protected Transform target;
    protected override void FixedUpdate()
    {
        this.getTargetPosition();
        base.FixedUpdate();
    }
    protected virtual void SetTarget(Transform target)
    {
        this.target = target;
    }
    protected virtual void getTargetPosition() //Hàm con trỏ chuột
    {
        this.targetPosition = this.target.position;
        this.targetPosition.z = 0;
    }

}
