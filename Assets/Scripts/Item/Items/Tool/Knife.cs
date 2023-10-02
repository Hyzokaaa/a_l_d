using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : Weapon
{
	public Knife() : base()
	{
		ItemName = "Cuchillo";
		Description = "Se calienta el uremio y se le da forma de hoja afilada, se enrolla el material sintético alrededor del extremo opuesto al filo y se pega con la gelatina para hacer el mango, se enfría y se afila el cuchillo.";
		IsMaterial = false;
		Behaviour = new BehHit();
	}
	public override List<Item> GenerateRecipe()
	{
		List<Item> recipe = new();
		recipe.AddRange(ItemFactory.CreateAll(ItemType.Uremia, 2));
		recipe.Add(ItemFactory.Create(ItemType.SyntheticMaterial));
		return recipe;
	}
}
