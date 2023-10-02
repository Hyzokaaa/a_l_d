using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hut : Item
{
	public Hut() : base()
	{
		ItemName = "Cabaña";
		Description = "Se cortan varias ramas gruesas y rectas de biocelulosa con el cuchillo o la lanza, se clavan las ramas en el suelo...";
		IsMaterial = true;
		Behaviour = null;
	}
	public override List<Item> GenerateRecipe()
	{
		List<Item> recipe = new();
		recipe.AddRange(ItemFactory.CreateAll(ItemType.Biocellulose, 20));
		recipe.AddRange(ItemFactory.CreateAll(ItemType.Glue, 10));
		return recipe;
	}
}