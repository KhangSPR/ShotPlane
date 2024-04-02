using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDespawn : DespawnByDistance
{
    public override void deSpawnObj()
    {
        ItemDropSpawner.Instance.DeSpawn(transform.parent);
    }

    protected override void loadValue()
    {
        base.loadValue();
        this.Dislimit = 70f;
    }
}