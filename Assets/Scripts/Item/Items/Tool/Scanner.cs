using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Scanner : Tool
{
    public Scanner()
    {
        ItemName = "Escaner";
        Description = "Una herramienta utilizada para analizar " +
            "el entorno, d�gase flora o fauna";
        IsMaterial = false;
        Behaviour = new BehScan();
        SecondBehaviour = new BehHit();
        Recipe = new List<Item> {new Uremia(), new Uremia(), new Quartz() };
        Prefab = ItemPrefab.scannerPrefab;
    }

}
