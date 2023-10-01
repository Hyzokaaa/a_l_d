using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Water : Item
{
	public Water()
	{
		ItemName = "Agua";
		Description = "Se obtiene luego de procesar Agua Ácida proveniente de las lluvias o estanques ácidos.";
		IsMaterial = true;
		Behaviour = null;
		Recipe = new List<Item> {new AcidWater()};
	}
}