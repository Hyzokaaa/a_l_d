using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uremia : Item
{
    public Uremia()
    {
        ItemName = "Uremio";
        Description = "Un mineral duro y metálico utilizado en la fabricación de aleaciones " +
            "y herramientas.";
        IsMaterial = true;
        Behaviour = null;
        Recipe = null;
    }
}
