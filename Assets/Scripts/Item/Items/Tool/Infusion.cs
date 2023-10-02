using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infusion : Item
{
	public Infusion() : base()
	{
		ItemName = "Infusión";
		Description = "Se cortan varias flores o frutos de biocelulosa con el cuchillo o la lanza, se lavan las flores o los frutos con agua...";
		IsMaterial = true;
		Behaviour = null;
		Recipe = new List<Item> {new Biocellulose(), new Water()};
	}
	public override List<Item> GenerateRecipe()
	{
		List<Item> recipe = new();
		recipe.AddRange(ItemFactory.CreateAll(ItemType.MedicinalPlant, 4));
		recipe.Add(ItemFactory.Create(ItemType.Water));
		return recipe;
	}
}