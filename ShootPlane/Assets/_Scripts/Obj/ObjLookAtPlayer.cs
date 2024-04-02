using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjLookAtPlayer : ObjLookAtTarget
{
    [Header("LookAt Player")]
    [SerializeField] protected GameObject player;
    protected override void FixedUpdate()
    {
        this.getMousePosition();
        base.FixedUpdate();
    }
    protected override void loadComponents()
    {
        base.loadComponents();
        this.LoadPlayer();
    }
    protected virtual void LoadPlayer()
    {
        if (this.player != null) return;
        this.player = GameObject.FindGameObjectWithTag("Player");
        Debug.LogWarning(transform.name + ": LoadPlayer", gameObject);
        
    }
    protected virtual void getMousePosition() //Hàm con trỏ chuột
    {
        if(this.player == null) return;

       this.targetPosition = this.player.transform.position;
        this.targetPosition.z = 0;
    }

}
