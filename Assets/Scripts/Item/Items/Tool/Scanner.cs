using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scanner : Tool
{
	public Scanner() : base()
	{
		ItemName = "Escaner";
		Description = "Una herramienta utilizada para analizar " +
			"el entorno, d�gase flora o fauna";
		IsMaterial = false;
		Behaviour = new BehScan();
		SecondBehaviour = new BehHit();
		Prefab = ItemPrefab.scannerPrefab;
	}
	public override List<Item> GenerateRecipe()
	{
		List<Item> recipe = new();
		recipe.AddRange(ItemFactory.CreateAll(ItemType.Uremia, 2));
		recipe.Add(ItemFactory.Create(ItemType.Quartz));
		return recipe;
	}
}
