using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Paper : Item
{
	public Paper()
	{
		ItemName = "Papel";
		Description = "Se hierve la gelatina junto al agua, se agregan los fragmentos de biocelulosa cortada y se remueve hasta obtener una crema...";
		IsMaterial = true;
		Behaviour = null;
		Recipe = new List<Item> {new Biocellulose(), new Gelatin(), new Water()};
	}
}