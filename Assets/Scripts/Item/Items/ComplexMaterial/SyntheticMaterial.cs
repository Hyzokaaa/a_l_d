using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyntheticMaterial : Item
{
	public SyntheticMaterial() : base()
	{
		ItemName = "Material Sintético";
		Description = "Se obtiene al procesar y moldear la gelatina. Es un material ligero, resistente y versátil.";
		IsMaterial = true;
	}
	public override List<Item> GenerateRecipe()
	{	
		return ItemFactory.CreateAll(ItemType.Gelatin, 2);
	}
}