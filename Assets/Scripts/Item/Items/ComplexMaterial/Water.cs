using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Water : Item
{
	public Water() : base()
	{
		ItemName = "Agua";
		Description = "Se obtiene luego de procesar Agua Ácida proveniente de las lluvias o estanques ácidos.";
		IsMaterial = true;
		Behaviour = null;
	}
	public override List<Item> GenerateRecipe()
	{
		return new List<Item>
		{
			ItemFactory.Create(ItemType.AcidWater)
			};
	}
}