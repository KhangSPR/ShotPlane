using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShootByDistance : ObjShooting
{
    [SerializeField] protected Transform target;
    [SerializeField] protected float distance = Mathf.Infinity;
    [SerializeField] protected float shootDistance = 5f;
    protected virtual void SetTarget(Transform target)
    {
        this.target = target;
    }
    protected override bool IsShooting()
    {
        this.distance = Vector3.Distance(transform.position, this.target.position);
        this.isShooting = this.distance < this.shootDistance;

        return this.isShooting;
    }
}
