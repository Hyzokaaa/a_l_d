using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Quartz : Item
{
	public Quartz() : base()
	{
		ItemName = "Cuarzo";
		Description = "Un mineral transparente y duro utilizado para hacer relojes, " +
			"cristales y transmisores.";
		IsMaterial = true;
		Behaviour = null;
	}
	public override List<Item> GenerateRecipe()
    {
        return null;
    }
}