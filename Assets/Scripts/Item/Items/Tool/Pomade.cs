using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pomade : Item
{
	public Pomade() : base()
	{
		ItemName = "Pomada";
		Description = "Se calienta la gelatina y se hierven las plantas medicinales,"+
		" se tritura la pirita hasta obtener polvo fino, se mezcla el polvo de pirita"+
		" con la gelatina en un recipiente hasta obtener una pasta homogénea, se aplica"+
		" la pomada sobre las heridas o las infecciones con un pincel o un dedo para curarlas.";
		IsMaterial = true;
		Behaviour = null;
	}
	public override List<Item> GenerateRecipe()
	{
		List<Item> recipe = new();
		recipe.AddRange(ItemFactory.CreateAll(ItemType.MedicinalPlant, 2));
		recipe.Add(ItemFactory.Create(ItemType.Pyrite));
		recipe.Add(ItemFactory.Create(ItemType.Water));
		return recipe;
	}
}