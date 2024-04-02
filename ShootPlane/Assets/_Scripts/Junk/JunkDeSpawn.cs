using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class JunkDeSpawn : DespawnByDistance
{
    public override void deSpawnObj()
    {
        JunkSpawner.Instance.DeSpawn(transform.parent);
    }
    protected override void loadValue()
    {
        base.loadValue();
        this.Dislimit = 20f;
    }
}
