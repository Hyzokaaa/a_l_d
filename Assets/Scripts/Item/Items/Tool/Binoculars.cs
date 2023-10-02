using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Binoculars : Item
{
	public Binoculars() : base()
	{
		ItemName = "Binoculares";
		Description = "Se calienta el uremio y se le da forma de tubo, se hacen dos agujeros en cada extremo del tubo e insertan una lente en cada uno...";
		IsMaterial = true;
		Behaviour = null;
	}
	public override List<Item> GenerateRecipe()
	{
		List<Item> recipe = new();
		recipe.AddRange(ItemFactory.CreateAll(ItemType.Lens, 2));
		recipe.AddRange(ItemFactory.CreateAll(ItemType.Uremia, 2));
		recipe.Add(ItemFactory.Create(ItemType.Glue));
		return recipe;
	}
}