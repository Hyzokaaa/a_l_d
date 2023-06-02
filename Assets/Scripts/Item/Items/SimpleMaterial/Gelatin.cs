using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gelatin : Item
{
    public Gelatin()
    {
        ItemName = "Gelatina";
        Description = "Una sustancia viscosa utilizada en la fabricación de material " +
            "sintético y otros materiales, que se encuentra en determinados biomas del planeta.";
        IsMaterial = true;
        Behaviour = null;
        Recipe = null;
    }
}

