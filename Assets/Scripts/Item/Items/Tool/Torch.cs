using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : Item
{
	public Torch() : base()
	{
		ItemName = "Antorcha";
		Description = "Se corta una rama larga y gruesa de biocelulosa con el cuchillo o la lanza, se hace un agujero en uno de los extremos de la rama...";
		IsMaterial = true;
		Behaviour = null;
	}
	public override List<Item> GenerateRecipe()
	{
		return new List<Item>
		{
			ItemFactory.Create(ItemType.Biocellulose),
			ItemFactory.Create(ItemType.Skin),
			ItemFactory.Create(ItemType.Fuel)
		};
	}
}