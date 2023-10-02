using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Gelatin : Item
{
	public Gelatin() : base()
	{
		ItemName = "Gelatina";
		Description = "Una sustancia viscosa utilizada en la fabricaci�n de material " +
			"sint�tico y otros materiales, que se encuentra en determinados biomas del planeta.";
		IsMaterial = true;
		Behaviour = null;
	}
	public override List<Item> GenerateRecipe()
    {
        return null;
    }
}

