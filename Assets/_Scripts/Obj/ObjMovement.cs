using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjMovement : SaiMonoBehaviour
{
    [Header("Obj Movement")]
    [SerializeField] protected Vector3 targetPosition;
    [SerializeField] protected float speed = 0.1f;
    [SerializeField] protected float distance = 1.0f;
    [SerializeField] protected float minDistance = 1.0f;
    protected virtual void FixedUpdate()
    {
        this.Moving();
    }
    public virtual void setSpeed(float setspeed)
    {
        this.speed = setspeed;
    }

    protected virtual void Moving()
    {
        //distance from current position to object
        this.distance = Vector3.Distance(transform.position, this.targetPosition);
        if (this.distance < minDistance) return;

        Vector3 newPos = Vector3.Lerp(transform.parent.position, targetPosition, this.speed);
        transform.parent.position = newPos;
    }

}
