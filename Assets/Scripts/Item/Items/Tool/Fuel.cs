using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Fuel : Item
{
	public Fuel()
	{
		ItemName = "Combustible";
		Description = "Se calienta y se enfría la gelatina, se tritura la pirita hasta obtener polvo fino, se mezcla el polvo de pirita con la gelatina...";
		IsMaterial = true;
		Behaviour = null;
		Recipe = new List<Item> {new Gelatin(), new Pyrite()};
	}
}