using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Net : Tool
{
	public Net() : base()
	{
		ItemName = "Red";
		Description = "Se cortan varias tiras finas y flexibles de material sintético con el cuchillo o la lanza," +
		" se entrelazan entre sí formando una malla cuadrada o rectangular, se pegan los extremos con el pegamento " +
		", se hacen cuatro lazos en las esquinas y se cuelga de cuatro árboles o postes.";
		IsMaterial = false;
	}
    public override List<Item> GenerateRecipe()
    {
		List<Item> recipe = new();
		recipe.AddRange(ItemFactory.CreateAll(ItemType.SyntheticMaterial, 10));
		recipe.Add(ItemFactory.Create(ItemType.Glue));
		return recipe;
	}
}