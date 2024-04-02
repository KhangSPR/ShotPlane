using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCtrl : SaiMonoBehaviour
{

    private static PlayerCtrl instance;
    public static PlayerCtrl Instance => instance;

    [SerializeField] protected ShipCtrl currentShip;
    public ShipCtrl CurrentShip => currentShip;

    [SerializeField] protected PlayerPickup playerPickup;
    public PlayerPickup PlayerPickup => playerPickup;

    protected override void Awake()
    {
        base.Awake();
        if (PlayerCtrl.instance != null) Debug.LogError("Only 1 PlayerCtrl allow to exist");
        PlayerCtrl.instance = this;
    }

    protected override void loadComponents()
    {
        base.loadComponents();
        this.LoadPlayerPickup();
        this.loadShipCtrl();
    }
    protected virtual void loadShipCtrl()
    {
        if (this.currentShip != null) return;
        this.currentShip = transform.GetComponent<ShipCtrl>();
        Debug.Log(transform.name + ": LoadCurrentShip", gameObject);
    }
    protected virtual void LoadPlayerPickup()
    {
        if (this.playerPickup != null) return;
        this.playerPickup = transform.GetComponentInChildren<PlayerPickup>();
        Debug.Log(transform.name + ": LoadPlayerPickup", gameObject);
    }
}