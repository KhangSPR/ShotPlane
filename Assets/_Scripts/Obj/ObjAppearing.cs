using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjAppearing : SaiMonoBehaviour
{
    [Header("Obj Appearing")]
    [SerializeField] protected bool isAppearing = false;
    [SerializeField] protected bool appeared = false;
    [SerializeField] protected List<ObjAppearObserver> Observer = new List<ObjAppearObserver>();
    protected override void Start()
    {
        base.Start();
        this.OnAppearStar();
    }
    protected virtual void FixedUpdate()
    {
        this.Appearing();
    }
    protected abstract void Appearing();
    protected virtual void Appear()
    {
        this.appeared = true;
        this.isAppearing = false;
        this.OnAppearFinish();
    }
    //since list is protected, use this function
    public virtual void OnAppearAdd(ObjAppearObserver Observer)
    {
        this.Observer.Add(Observer);
    }
    protected virtual void OnAppearStar()
    {
        foreach(ObjAppearObserver observer in this.Observer)
        {
            observer.OnAppearStar();
        }
    }
    protected virtual void OnAppearFinish()
    {
        foreach (ObjAppearObserver observer in this.Observer)
        {
            observer.OnAppearFinish();
        }
    }
}
