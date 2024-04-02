using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyDeSpawn : DespawnByDistance
{
    public override void deSpawnObj()
    {
        EnemySpawner.Instance.DeSpawn(transform.parent);
    }
    protected override void loadValue()
    {
        base.loadValue();
        this.Dislimit = 20f;
    }
}
