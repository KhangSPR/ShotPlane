using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaiMonoBehaviour : MonoBehaviour
{
    protected virtual void Awake()
    {
        this.loadComponents();
        this.loadValue();
    }
    protected virtual void Reset()
    {
        this.loadComponents();
        this.loadValue();
    }
    protected virtual void Start()
    {
        
    }
    protected virtual void OnEnable()
    {

    }
    protected virtual void loadComponents()
    {
        //for override
    }
    protected virtual void loadValue()
    {
        //for override
    }
}
