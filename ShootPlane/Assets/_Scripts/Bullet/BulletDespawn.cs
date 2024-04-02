using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BulletDespawn : DespawnByDistance
{
    public override void deSpawnObj()
    {
        BulletSpawner.Instance.DeSpawn(transform.parent);
    }
}
