using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Lens : Item
{
	public Lens()
	{
		ItemName = "Lente";
		Description = "Se calienta el cuarzo y se le da forma de disco plano, se pule el disco hasta obtener una superficie lisa y transparente...";
		IsMaterial = true;
		Behaviour = null;
		Recipe = new List<Item> {new Quartz(), new Water()};
	}
}