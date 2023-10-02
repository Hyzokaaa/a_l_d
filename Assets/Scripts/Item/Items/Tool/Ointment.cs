using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ointment : Item
{
	public Ointment() : base()
	{
		ItemName = "Ungüento";
		Description = "Se calienta la gelatina y se mezcla con las plantas medicinales"+
		" en un recipiente, se deja enfriar la mezcla hasta que se espese, se aplica el"+
		" ungüento sobre las quemaduras o las heridas con un pincel o un dedo para aliviarlas.";
		IsMaterial = true;
		Behaviour = null;
	}
	public override List<Item> GenerateRecipe()
	{
		List<Item> recipe = new();
		recipe.AddRange(ItemFactory.CreateAll(ItemType.MedicinalPlant, 2));
		recipe.Add(ItemFactory.Create(ItemType.Gelatin));
		return recipe;
	}
}