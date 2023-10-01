using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Trap : Item
{
	public Trap()
	{
		ItemName = "Trampa";
		Description = "Se coloca la red sobre un agujero en el suelo, se cubre el agujero con la piel y se esparce pirita sobre ella...";
		IsMaterial = true;
		Behaviour = null;
		Recipe = new List<Item> {new Net(), new Skin(), new Pyrite()};
	}
}
