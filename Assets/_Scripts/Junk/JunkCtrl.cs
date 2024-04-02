using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JunkCtrl : ShootAbleObjectCtrl
{
    protected override string GetObjectTypeString()
    {
        return ObjectType.Junk.ToString();
    }
}
