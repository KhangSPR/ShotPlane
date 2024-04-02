using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FxDespawn : DespawnByTime
{
    public override void deSpawnObj()
    {
        FXSpawner.Instance.DeSpawn(transform.parent);
    }
}
