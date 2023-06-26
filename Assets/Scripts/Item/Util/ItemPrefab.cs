using System;
using System.Collections.Generic;
using UnityEngine;

public static class ItemPrefab
{
    public static GameObject scannerPrefab;

    public static void Initialize()
    {
        scannerPrefab = Resources.Load<GameObject>("Prefabs/Items/Scanner");
    }
}
