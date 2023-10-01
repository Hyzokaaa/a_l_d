using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Explosive : Item
{
	public Explosive()
	{
		ItemName = "Explosivo";
		Description = "Se tritura la pirita hasta obtener polvo fino, se calienta el uremio hasta que se ablande y luego darle forma de recipiente...";
		IsMaterial = true;
		Behaviour = null;
		Recipe = new List<Item> {new Pyrite(), new Uremia()};
	}
}