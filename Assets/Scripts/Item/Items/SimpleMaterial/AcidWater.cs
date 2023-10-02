using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AcidWater : Item
{
	public AcidWater() : base()
	{
		ItemName = "Agua Ácida";
		Description = "Se obtiene de estanques ácidos o lluvias ácidas. No es potable y se requiere un envase para almacenarla.";
		IsMaterial = true;
		Behaviour = null;
	}
	public override List<Item> GenerateRecipe()
    {
        return null;
    }
}