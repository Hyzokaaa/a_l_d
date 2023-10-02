using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicinalPlant : Consumible
{
    public MedicinalPlant() : base()
    {
        ItemName = "Planta Medicinal";
        Description = "Una especie botánica que se encuentra en diversos biomas del planeta. Sus hojas, tallos o raíces poseen propiedades curativas que pueden ser utilizadas para tratar diversas dolencias o enfermedades. Se puede utilizar en su estado natural o procesada para elaborar infusiones, ungüentos, pomadas y otros productos de salud.";
        IsMaterial = true;
        Behaviour = null;
    }
    public override List<Item> GenerateRecipe()
    {
        return null;
    }
}