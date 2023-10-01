using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Skin : Item
{
    public Skin()
    {
        ItemName = "Piel";
        Description = "Un tejido suave y el�stico que cubre a los animales.";
        IsMaterial = true;
        Behaviour = null;
        Recipe = null;
    }
}
