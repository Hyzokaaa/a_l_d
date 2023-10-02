using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Paper : Item
{
	public Paper() : base()
	{
		ItemName = "Papel";
		Description = "Se hierve la gelatina junto al agua, se agregan los fragmentos de biocelulosa cortada y se remueve hasta obtener una crema...";
		IsMaterial = true;
		Behaviour = null;
	}
	public override List<Item> GenerateRecipe()
	{
		return new List<Item> 
		{
			ItemFactory.Create(ItemType.Biocellulose), 
			ItemFactory.Create(ItemType.Gelatin), 
			ItemFactory.Create(ItemType.Water)};
	}
}