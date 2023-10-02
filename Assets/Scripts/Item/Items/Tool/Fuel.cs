using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : Item
{
	public Fuel() : base()
	{
		ItemName = "Combustible";
		Description = "Se calienta y se enfría la gelatina, se tritura la pirita hasta obtener polvo fino, se mezcla el polvo de pirita con la gelatina...";
		IsMaterial = true;
		Behaviour = null;
	}
	public override List<Item> GenerateRecipe()
	{
		List<Item> recipe = new();
		recipe.AddRange(ItemFactory.CreateAll(ItemType.Gelatin, 10));
		recipe.AddRange(ItemFactory.CreateAll(ItemType.Pyrite, 5));
		return recipe;
	}
}