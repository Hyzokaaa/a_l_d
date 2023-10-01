using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyntheticMaterial : Item
{
    public SyntheticMaterial()
    {
        ItemName = "Material Sintético";
        Description = "Se obtiene al procesar y moldear la gelatina. Es un material ligero, resistente y versátil.";
        IsMaterial = true;
        Recipe = new List<Item> {new Gelatin()};
        // Agrega aquí las demás propiedades
    }
}