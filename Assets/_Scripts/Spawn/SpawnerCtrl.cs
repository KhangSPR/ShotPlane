using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCtrl : SaiMonoBehaviour
{
    [SerializeField] protected Spawner spawner;
    public Spawner Spawner => spawner;
    [SerializeField] protected SpawnPoints spawnPoints;
    public SpawnPoints SpawnPoints => spawnPoints;
    protected override void loadComponents()
    {
        base.loadComponents();
        this.loadSpawner();
        this.loadSpawnPoints();
    }
    
    protected virtual void loadSpawner()
    {
        if (this.spawner != null) return;
        this.spawner = GetComponent<Spawner>();
        Debug.Log(gameObject.name + ": loadSpawner" + gameObject);
    }
    protected virtual void loadSpawnPoints()
    {
        if (this.spawnPoints != null) return;
        this.spawnPoints = Transform.FindObjectOfType<SpawnPoints>(); //Khác Object
        Debug.Log(gameObject.name + ": loadSpawnPoints" + gameObject);
    }
}
