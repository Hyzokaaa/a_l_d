using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : Item
{	
	public Explosive() : base()
	{
		ItemName = "Explosivo";
		Description = "Se tritura la pirita hasta obtener polvo fino, se calienta el uremio hasta que se ablande y luego darle forma de recipiente...";
		IsMaterial = true;
		Behaviour = null;
	}
	public override List<Item> GenerateRecipe()
	{
		List<Item> recipe = new();
		recipe.AddRange(ItemFactory.CreateAll(ItemType.Pyrite, 10));
		recipe.AddRange(ItemFactory.CreateAll(ItemType.Uremia, 2));
		recipe.Add(ItemFactory.Create(ItemType.SyntheticMaterial));
		return recipe;
	}
}