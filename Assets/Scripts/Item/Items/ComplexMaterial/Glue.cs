using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Glue : Item
{
	public Glue() : base()
	{
		ItemName = "Pegamento";
		Description = "Se calienta la gelatina y se mezcla con el agua en un recipiente, se deja enfriar la mezcla hasta que se espese...";
		IsMaterial = true;
		Behaviour = null;
	}
	public override List<Item> GenerateRecipe()
	{
		return new List<Item> 
		{
			ItemFactory.Create(ItemType.Gelatin), 
			ItemFactory.Create(ItemType.Water)
			};
	}
}