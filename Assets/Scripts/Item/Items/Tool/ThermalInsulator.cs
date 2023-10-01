using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ThermalInsulator : Item
{
	public ThermalInsulator()
	{
		ItemName = "Aislante térmico";
		Description = "Se cortan varias tiras largas y anchas de biocelulosa, se unta el pegamento sobre las tiras para impregnarlas...";
		IsMaterial = true;
		Behaviour = null;
		Recipe = new List<Item> {new Glue(), new Biocellulose(), new Gelatin()};
	}
}