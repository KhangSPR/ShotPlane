using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjLookAtMouse : ObjLookAtTarget
{
    protected override void FixedUpdate()
    {
        this.getMousePosition();
        base.FixedUpdate();
    }
    protected virtual void getMousePosition() //Hàm con trỏ chuột
    {
        this.targetPosition = InputManager.Instance.MouseWorldPos;
        this.targetPosition.z = 0;
    }

}
