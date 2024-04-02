using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;
    public static InputManager Instance { get => instance;}

    [SerializeField] protected Vector3 mouseWorldPos;
    public Vector3 MouseWorldPos { get => mouseWorldPos; }
    [SerializeField] protected float onFiring;
    public float OnFiring { get => onFiring; }



    private void Awake()
    {
        if (InputManager.instance != null) Debug.LogError("Onlly 1 InputManager Warning");
        InputManager.instance = this;
    }
    private void FixedUpdate()
    {
        this.getMouseWorldPos();
  
    }
    private void Update()
    {
        this.getMouseDown();
    }
    protected virtual void getMouseDown()
    {
        this.onFiring = Input.GetAxis("Fire1");
    }
    protected virtual void getMouseWorldPos()
    {
        this.mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
