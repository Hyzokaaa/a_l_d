using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThermalInsulator : Item
{
	public ThermalInsulator() : base()
	{
		ItemName = "Aislante térmico";
		Description = "Se cortan varias tiras largas y anchas de biocelulosa, se unta el pegamento sobre las tiras para impregnarlas...";
		IsMaterial = true;
		Behaviour = null;
	}
	public override List<Item> GenerateRecipe()
	{
		List<Item> recipe = new();
		recipe.AddRange(ItemFactory.CreateAll(ItemType.Biocellulose, 3));
		recipe.AddRange(ItemFactory.CreateAll(ItemType.Gelatin, 3));
		recipe.Add(ItemFactory.Create(ItemType.Glue));
		return recipe;
	}
}