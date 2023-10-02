using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : Item
{
	public Bow() : base()
	{
		ItemName = "Arco";
		Description = "Se corta una rama larga y flexible de biocelulosa, se hace un corte en cada extremo de la rama...";
		IsMaterial = true;
		Behaviour = null;
	}
	public override List<Item> GenerateRecipe()
	{
		return new List<Item> 
		{
			ItemFactory.Create(ItemType.Biocellulose),
			ItemFactory.Create(ItemType.Skin),
			ItemFactory.Create(ItemType.Glue)
			};
	}
}