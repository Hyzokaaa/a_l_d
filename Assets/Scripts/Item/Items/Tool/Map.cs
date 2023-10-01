using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Map : Item
{
	public Map()
	{
		ItemName = "Mapa";
		Description = "Se pegan las hojas entre sí por los bordes con el pegamento para hacer un papel grande, se dibuja un mapa del planeta...";
		IsMaterial = true;
		Behaviour = null;
		Recipe = new List<Item> {new Paper(), new Glue()};
	}
}