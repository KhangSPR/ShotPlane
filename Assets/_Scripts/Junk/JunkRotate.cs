using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkRotate : JunkAbstract
{
    [SerializeField] protected float speedRotate = 9f;
    protected virtual void FixedUpdate()
    {
        this.junkRotate();
    }
    protected virtual void junkRotate()
    {
        Vector3 eulers = new Vector3(0, 0, 1);
        this.shotAbleObjectCtrl.Modle.Rotate(eulers * this.speedRotate * Time.fixedDeltaTime);
    }
}
