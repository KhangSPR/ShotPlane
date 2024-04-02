using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjAppearWithoutShoot : ShootAbleObjectAbstact, ObjAppearObserver
{
    [Header("Obj Appear WithoutShoot")]
    [SerializeField] protected ObjAppearing objAppearing;
    public ObjAppearing ObjAppearing => objAppearing;
    protected override void OnEnable()
    {
        base.OnEnable();
        this.RegisterAppearEvent();
    }
    protected override void loadComponents()
    {
        base.loadComponents();
        this.LoadObjAppearing();
    }
    protected virtual void LoadObjAppearing()
    {
        if (this.objAppearing != null) return;
        this.objAppearing = transform.GetComponent<ObjAppearing>();
        Debug.Log(gameObject.name + ": loadObjAppearing" + gameObject);
    }
    //Sign up for the event
    protected virtual void RegisterAppearEvent()
    {
        this.objAppearing.OnAppearAdd(this);
    }

    public void OnAppearStar()
    {
        this.shootAbleObjectCtrl.ObjShooting.gameObject.SetActive(false);
        this.shootAbleObjectCtrl.ObjLookAtTarget.gameObject.SetActive(false);
    }

    public void OnAppearFinish()
    {
        this.shootAbleObjectCtrl.ObjShooting.gameObject.SetActive(true);
        this.shootAbleObjectCtrl.ObjLookAtTarget.gameObject.SetActive(true);
    }
}
