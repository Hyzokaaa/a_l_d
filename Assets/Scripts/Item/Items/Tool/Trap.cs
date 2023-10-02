using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : Item
{
	public Trap() : base()
	{
		ItemName = "Trampa";
		Description = "Se coloca la red sobre un agujero en el suelo, se cubre el agujero con la piel y se esparce pirita sobre ella...";
		IsMaterial = true;
		Behaviour = null;
	}
	public override List<Item> GenerateRecipe()
	{
		return new List<Item>
		{
			ItemFactory.Create(ItemType.Net),
			ItemFactory.Create(ItemType.Skin),
			ItemFactory.Create(ItemType.Pyrite)
		};
	}
}
