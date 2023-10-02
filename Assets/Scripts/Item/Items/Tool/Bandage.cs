using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bandage : Consumible
{
	public Bandage() : base()
	{
		ItemName = "Venda";
		Description = "Se calienta y se enfría la gelatina, se corta una tira larga y delgada de material sintético con el cuchillo o la lanza...";
		IsMaterial = true;
		Behaviour = null;
	}
	public override List<Item> GenerateRecipe()
	{

		return new List<Item> 
		{
			ItemFactory.Create(ItemType.Gelatin), 
			ItemFactory.Create(ItemType.SyntheticMaterial),
			ItemFactory.Create(ItemType.MedicinalPlant)
			};
	}
}