using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawnRadam : SaiMonoBehaviour
{
    [SerializeField] protected JunkSpawnerCtrl junkCtrl;
    [SerializeField] protected float radamTimer = 0f;
    [SerializeField] protected float radamDelay = 1f;
    [SerializeField] protected float radamLimit = 20f;
    //[SerializeField] protected int  junkCtrl;
    //[SerializeField] protected int junkCtrl;
    protected override void loadComponents()
    {
        base.loadComponents();
        this.loadJunkCtrl();
    }
    protected virtual void loadJunkCtrl()
    {
        if (this.junkCtrl != null) return;
        this.junkCtrl = GetComponent<JunkSpawnerCtrl>();
        Debug.Log(gameObject.name + ": loadJunkCtrl" + gameObject);
    }
    protected virtual void FixedUpdate()
    {
        this.junkSpawning();
    }
    protected virtual void junkSpawning()
    {
        if (this.radamReachLimit()) return;
        this.radamTimer += Time.fixedDeltaTime;
        if (this.radamTimer < this.radamDelay) return;
        this.radamTimer = 0;
        Transform newpoints = this.junkCtrl.SpawnPoints.GetRandom();
        Vector3 pos = newpoints.position;
        //
        Quaternion rotation = transform.rotation;
        Transform prefab = this.junkCtrl.JunkSpawner.RandomPrefab();
        Transform obj = this.junkCtrl.JunkSpawner.Spawn(prefab, pos, rotation);
        obj.gameObject.SetActive(true);
        //Invoke(nameof(this.junkSpawning), 1f); //?? Quy
    }
    public virtual bool radamReachLimit()
    {
        int currentJunk = junkCtrl.JunkSpawner.SpawnerCount;
        return currentJunk >= radamLimit;
    }
}
