using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawnerCtrl : SaiMonoBehaviour
{
    [SerializeField] protected JunkSpawner junkSpawner;
    public JunkSpawner JunkSpawner { get => junkSpawner; }
    [SerializeField] protected SpawnPoints spawnPoints;
    public SpawnPoints SpawnPoints { get => spawnPoints; }
    protected override void loadComponents()
    {
        base.loadComponents();
        this.loadJunkSpawner();
        this.loadSpawnPoints();
    }
    protected virtual void loadJunkSpawner()
    {
        if (this.junkSpawner != null) return;
        this.junkSpawner = GetComponent<JunkSpawner>();
        Debug.Log(gameObject.name + ": loadJunkSpawner" + gameObject);
    }
    protected virtual void loadSpawnPoints()
    {
        if (this.spawnPoints != null) return;
        this.spawnPoints = Transform.FindObjectOfType<SpawnPoints>(); //Khác Object
        Debug.Log(gameObject.name + ": loadjunkSpawnPoints" + gameObject);
    }
}
