using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shelter : Item
{
	public Shelter() : base()
	{
		ItemName = "Refugio";
		Description = "Se cortan varias piezas grandes de piel con el cuchillo o la lanza, se cosen las piezas entre sí por los bordes...";
		IsMaterial = true;
		Behaviour = null;
	}
	public override List<Item> GenerateRecipe()
	{
		List<Item> recipe = new();
		recipe.AddRange(ItemFactory.CreateAll(ItemType.Skin, 10));
		recipe.AddRange(ItemFactory.CreateAll(ItemType.Biocellulose, 4));
		return recipe;
	}
}