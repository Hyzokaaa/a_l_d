using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Binoculars : Item
{
	public Binoculars()
	{
		ItemName = "Binoculares";
		Description = "Se calienta el uremio y se le da forma de tubo, se hacen dos agujeros en cada extremo del tubo e insertan una lente en cada uno...";
		IsMaterial = true;
		Behaviour = null;
		Recipe = new List<Item> {new Lens(), new Uremia()};
	}
}