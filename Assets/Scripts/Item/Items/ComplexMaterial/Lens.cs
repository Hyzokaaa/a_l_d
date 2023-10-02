using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Lens : Item
{
	public Lens() : base()
	{
		ItemName = "Lente";
		Description = "Se calienta el cuarzo y se le da forma de disco plano, se pule el disco hasta obtener una superficie lisa y transparente...";
		IsMaterial = true;
		Behaviour = null;
	}
	public override List<Item> GenerateRecipe()
	{
		
		return new List<Item> 
		{
			ItemFactory.Create(ItemType.Quartz),
			ItemFactory.Create(ItemType.Water)
			};
	}
}