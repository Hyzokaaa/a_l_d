using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Uremia : Item
{
	public Uremia() : base()
	{
		ItemName = "Uremio";
		Description = "Un mineral duro y met�lico utilizado en la fabricaci�n de aleaciones " +
			"y herramientas.";
		IsMaterial = true;
		Behaviour = null;
	}
	public override List<Item> GenerateRecipe()
    {
        return null;
    }
}
