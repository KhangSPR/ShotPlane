using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities: SaiMonoBehaviour
{
    [Header("Ability Abilities")]
    [SerializeField] protected AbilityObjectCtrl abilityObjectCtrl;
    public AbilityObjectCtrl AbilityObjectCtrl => abilityObjectCtrl;
    protected override void loadComponents()
    {
        base.loadComponents();
        this.LoadAbilityObjectCtrl();
    }
    protected virtual void LoadAbilityObjectCtrl()
    {
        if (this.abilityObjectCtrl != null) return;
        this.abilityObjectCtrl = transform.parent.GetComponent<AbilityObjectCtrl>();
        Debug.Log(gameObject.name + ": loadAbilityObjectCtrl" + gameObject);
    }
}
