using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : Weapon
{
	public Spear() : base()
	{
		ItemName = "Lanza";
		Description = "Se corta una rama larga y recta de biocelulosa, se hace un agujero en uno de los " +
		"extremos e inserta el cuchillo, se envuelve la piel alrededor de la unión y se ata para asegurarla.";
		IsMaterial = false;
	}
	public override List<Item> GenerateRecipe()
	{
		return new List<Item>
		{
			ItemFactory.Create(ItemType.Knife),
			ItemFactory.Create(ItemType.Biocellulose),
			ItemFactory.Create(ItemType.SyntheticMaterial)
		};
	}
}