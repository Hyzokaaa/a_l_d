using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Net : Tool
{

	public Net()
	{
		ItemName = "Red";
		Description = "Se cortan varias tiras finas y flexibles de material sintético con el cuchillo o la lanza," +
		" se entrelazan entre sí formando una malla cuadrada o rectangular, se pegan los extremos con el pegamento " +
		", se hacen cuatro lazos en las esquinas y se cuelga de cuatro árboles o postes.";
		IsMaterial = false;
		Recipe = GenerateRecipe();
		// Agrega aquí las demás propiedades
	}

	private List<Item> GenerateRecipe()
	{
		List<Item> recipe = new();
		for (int i = 0; i < 10; i++)
		{
			recipe.Add(new SyntheticMaterial());
		}
		recipe.Add(new Glue());
		return recipe;
	}
}