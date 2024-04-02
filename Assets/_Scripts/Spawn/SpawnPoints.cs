using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : SaiMonoBehaviour
{
    [SerializeField] protected List<Transform> points;

    protected override void loadComponents()
    {
        base.loadComponents();
        this.loadSpawnPoints();
    }
    protected virtual void loadSpawnPoints()
    {
        if (this.points.Count > 0) return;
        foreach(Transform obj in transform)
        {
            this.points.Add(obj);
        }
        Debug.Log(gameObject.name + ": loadSpawnPoints" + gameObject);
    }
    public virtual Transform GetRandom()
    {
        int rand = Random.Range(0, this.points.Count);
        return this.points[rand];
    }
}
