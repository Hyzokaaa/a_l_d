using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Clock : Item
{
	public Clock()
	{
		ItemName = "Reloj";
		Description = "Se calienta el uremio y se le da forma de péndulo, se hace un agujero en el centro del péndulo e inserta un trozo pequeño de cuarzo...";
		IsMaterial = true;
		Behaviour = null;
		Recipe = new List<Item> {new Lens(), new Uremia(), new Water()};
	}
}