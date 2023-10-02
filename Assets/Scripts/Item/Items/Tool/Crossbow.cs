using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossbow : Item
{
	public Crossbow() : base()
	{
		ItemName = "Ballesta";
		Description = "Se calienta el uremio hasta que se ablande y luego darle forma de bastón con un martillo o una piedra...";
		IsMaterial = true;
		Behaviour = null;
	}
	public override List<Item> GenerateRecipe()
	{
		List<Item> recipe = new();
		recipe.AddRange(ItemFactory.CreateAll(ItemType.Uremia, 3));
		recipe.Add(ItemFactory.Create(ItemType.Bow));
		return null;
	}
}