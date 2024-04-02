using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjLookAtTarget : SaiMonoBehaviour
{
    [Header("LookAt Target")]
    [SerializeField] protected Vector3 targetPosition;
    [SerializeField] protected float speedRot = 1f;
    protected virtual void FixedUpdate()
    {
        this.lookAtTarget();
    }
    public virtual void SetSpeedRot(float setSpeedRot)
    {
        this.speedRot = setSpeedRot;
    }

    protected virtual void lookAtTarget() 
    {
        Vector3 diff = this.targetPosition - transform.parent.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;

        float timeSpeed = this.speedRot * Time.fixedDeltaTime;
        Quaternion targetEuler = Quaternion.Euler(0f, 0f, rot_z);
        Quaternion currentEuler = Quaternion.Lerp(transform.parent.rotation, targetEuler, timeSpeed); //current coordinates to next coordinates and speed
        transform.parent.rotation = currentEuler;
    }


}
