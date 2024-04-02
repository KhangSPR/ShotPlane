using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ObjMoviFoward : ObjMovement
{
    [Header("Follow Target")]
    [SerializeField] protected Transform target;
    protected override void FixedUpdate()
    {
        this.getTargetPosition();
        base.FixedUpdate();
    }
    protected override void loadComponents()
    {
        base.loadComponents();
        this.loadTargetMove();
    }
    protected virtual void getTargetPosition() //Hàm con trỏ chuột
    {
        this.targetPosition = this.target.position;
        this.targetPosition.z = 0;
    }
    protected virtual void loadTargetMove()
    {
        if (this.target != null) return;
        this.target = transform.Find("MoveTarget");
        Debug.LogWarning(transform.name + ": LoadMoveTarget", gameObject);
    }

}
