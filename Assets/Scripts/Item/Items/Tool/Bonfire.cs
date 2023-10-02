using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonfire : Item
{
	public Bonfire() : base()
	{
		ItemName = "Hoguera";
		Description = "Se cortan varias ramas secas y pequeñas de biocelulosa con el cuchillo o la lanza, se apilan las ramas en forma de pirámide...";
		IsMaterial = true;
		Behaviour = null;
	}
	public override List<Item> GenerateRecipe()
	{
		List<Item> recipe = new();
		recipe.AddRange(ItemFactory.CreateAll(ItemType.Biocellulose, 6));
		recipe.Add(ItemFactory.Create(ItemType.Pyrite));
		return recipe;
	}
}