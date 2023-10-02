using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : Item
{
	public Map() : base()
	{
		ItemName = "Mapa";
		Description = "Se pegan las hojas entre sí por los bordes con el pegamento para hacer un papel grande, se dibuja un mapa del planeta...";
		IsMaterial = true;
		Behaviour = null;
	}
	public override List<Item> GenerateRecipe()
	{
		List<Item> recipe = new();
		recipe.AddRange(ItemFactory.CreateAll(ItemType.Paper, 5));
		recipe.Add(ItemFactory.Create(ItemType.Glue));
		return recipe;
	}
}