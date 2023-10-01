using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Glue : Item
{
	public Glue()
	{
		ItemName = "Pegamento";
		Description = "Se calienta la gelatina y se mezcla con el agua en un recipiente, se deja enfriar la mezcla hasta que se espese...";
		IsMaterial = true;
		Behaviour = null;
		Recipe = new List<Item> {new Gelatin(), new Water()};
	}
}