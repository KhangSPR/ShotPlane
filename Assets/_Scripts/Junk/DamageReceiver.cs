using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public abstract class DamageReceiver : SaiMonoBehaviour
{
    [Header("Damage Receiver")]
    [SerializeField] protected int isHP = 1;
    [SerializeField] protected int isMaxHP = 3;
    [SerializeField] protected bool isDead = false;
    [SerializeField] protected SphereCollider sphereCollider;

    protected override void OnEnable() // Goi 1 lan moi khi reset
    {
        this.ReBorn();
    }
    protected override void loadComponents()
    {
        base.loadComponents();
        this.loadSphereCollider();
    }
    protected virtual void loadSphereCollider()
    {
        if (this.sphereCollider != null) return;
        this.sphereCollider = GetComponent<SphereCollider>();
        this.sphereCollider.isTrigger = true;
        this.sphereCollider.radius = 0.2f;
        Debug.Log(transform.name + ": loadSphereCollider", gameObject);
    }
    protected override void loadValue()
    {
        base.loadValue();
        this.ReBorn();
    }
    public virtual void ReBorn()
    {
        this.isHP = this.isMaxHP;
        this.isDead = false;
    }
    protected virtual void Add(int ADD)
    {
        if (this.isDead==true) return;
        this.isHP += ADD;
        if (this.isHP > this.isMaxHP) this.isHP = this.isMaxHP;
    }
    public virtual void deDuct(int Deduct)
    {
        if (this.isDead==true) return;
        this.isHP -= Deduct;
        if (this.isMaxHP < 0)
            this.isHP = 0;
        this.checkDead();
    }
    protected virtual bool IsDead()
    {
        return this.isHP <= 0;
    }
    protected virtual void checkDead()
    {
        if (!this.IsDead()) return;
        this.isDead = true;
        this.onDead();
    }
    protected abstract void onDead();
    
}
