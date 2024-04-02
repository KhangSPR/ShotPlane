using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCtrl : SaiMonoBehaviour
{
    private static GameCtrl instance;
    public static GameCtrl Instance { get => instance; }
    [SerializeField] protected Camera maincamera;
    public Camera Maincamera { get => maincamera; }
    protected override void Awake()
    {
        base.Awake();
        if (GameCtrl.instance != null) Debug.LogError("Onlly 1 GameCtrl Warning");
        GameCtrl.instance = this;
    }
    protected override void loadComponents()
    {
        base.loadComponents();
        this.loadCamera();
    }
    protected virtual void loadCamera()
    {
        if (this.maincamera != null) return;
        this.maincamera = Transform.FindObjectOfType<Camera>();
        Debug.Log(transform.name + "Load Camera " + gameObject);
    }
}
