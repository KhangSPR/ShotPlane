using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawner : Spawner
{
    private static JunkSpawner instance;
    public static JunkSpawner Instance { get => instance; }
    public static string meteoriteOne = "meteorite_1"; // bullet 1
    public static string meteoriteTwo = "meteorite_2"; // bullet 2
    public static string meteoriteThree = "meteorite_3";
    protected override void Awake()
    {
        base.Awake();
        if (JunkSpawner.instance != null) Debug.LogError("Onlly 1 JunkSpawner Warning");
        JunkSpawner.instance = this;
    }
}
