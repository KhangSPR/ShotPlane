using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public abstract class ShootAbleObjectCtrl : SaiMonoBehaviour
{

    [SerializeField] protected Transform modle;
    public Transform Modle { get => modle; }
    [SerializeField] protected Despawn deSpawn;
    public Despawn DeSpawn => deSpawn;
    [SerializeField] protected ShootAbleObjectSO shootAbleObjectSO;
    public ShootAbleObjectSO ShootAbleObjectSO => shootAbleObjectSO;
    [SerializeField] protected ObjShooting objShooting;
    public ObjShooting ObjShooting => objShooting;
    [SerializeField] protected ObjMovement objMovement;
    public ObjMovement ObjMovement => objMovement;
    [SerializeField] protected ObjLookAtTarget objLookAtTarget;
    public ObjLookAtTarget ObjLookAtTarget => objLookAtTarget;
    [SerializeField] protected EnemySpawner enemySpawner;
    public EnemySpawner EnemySpawner => enemySpawner;


    protected override void loadComponents()
    {
        base.loadComponents();
        this.loadModle();
        this.LoadDeSpawn();
        this.loadShootAbleObjectSO();
        this.LoadObjShooting();
        this.LoadObjMovement();
        this.LoadObjLookAtTarget();
        this.LoadEnemySpawner();
    }
    protected virtual void LoadEnemySpawner()
    {
        if (this.enemySpawner != null) return;
        this.enemySpawner = transform.parent?.parent?.GetComponent<EnemySpawner>();
        Debug.LogWarning(gameObject.name + "LoadEnemySpawner" + gameObject);
    }
    protected virtual void LoadObjLookAtTarget()
    {
        if (this.objLookAtTarget != null) return;
        this.objLookAtTarget = transform.GetComponentInChildren<ObjLookAtTarget>();
        Debug.LogWarning(gameObject.name + ": LoadObjLookAtTarget", gameObject);
    }
    protected virtual void LoadObjMovement()
    {
        if (this.objMovement != null) return;
        this.objMovement = transform.GetComponentInChildren<ObjMovement>();
        Debug.LogWarning(gameObject.name + ": LoadObjMovement" + gameObject);
    }
    protected virtual void LoadObjShooting()
    {
        if (this.objShooting != null) return;
        this.objShooting = transform.GetComponentInChildren<ObjShooting>();
        Debug.Log(gameObject.name + ": loadObjShooting" + gameObject);
    }
    protected virtual void LoadDeSpawn()
    {
        if (this.deSpawn != null) return;
        this.deSpawn = transform.GetComponentInChildren<Despawn>();
        Debug.Log(gameObject.name + ": loadDeSpawn" + gameObject);
    }
    protected virtual void loadModle()
    {
        if (this.modle != null) return;
        this.modle = transform.Find("Modle");
        Debug.Log(gameObject.name + ": loadModle" + gameObject);
    }
    protected virtual void loadShootAbleObjectSO() // ScriptableObject
    {
        if (this.shootAbleObjectSO != null) return;
        string resPath = "ShootAbleObject/" + this.GetObjectTypeString() + "/" + transform.name;
        this.shootAbleObjectSO = Resources.Load<ShootAbleObjectSO>(resPath); //Ph?i t?o Folder là Resources
        Debug.LogWarning(transform.name + ": LoadShootAbleObjectSO" + resPath, gameObject);
    }
    protected abstract string GetObjectTypeString();
}
