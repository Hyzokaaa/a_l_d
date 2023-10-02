using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpaceGeode : Item
{
	public SpaceGeode() : base()
	{
		ItemName = "Geoda Espacial";
		Description = "Un objeto utilizado para herramientas, obtenido al romper y pulir rocas" +
			" espaciales.";
		IsMaterial = true;
		Behaviour = null;
	}
	public override List<Item> GenerateRecipe()
    {
        return null;
    }
}

