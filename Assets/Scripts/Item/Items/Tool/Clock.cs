using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : Item
{
	public Clock() : base()
	{
		ItemName = "Reloj";
		Description = "Se calienta el uremio y se le da forma de péndulo, se hace un agujero en el centro del péndulo e inserta un trozo pequeño de cuarzo...";
		IsMaterial = true;
		Behaviour = null;
	}
	public override List<Item> GenerateRecipe()
	{
		List<Item> recipe = new();
		recipe.AddRange(ItemFactory.CreateAll(ItemType.Uremia, 2));
		recipe.Add(ItemFactory.Create(ItemType.Lens));
		recipe.Add(ItemFactory.Create(ItemType.Quartz));
		return recipe;
	}
}