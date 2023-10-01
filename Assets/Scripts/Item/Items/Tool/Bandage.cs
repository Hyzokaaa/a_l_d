using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bandage : Consumible
{
	public Bandage()
	{
		ItemName = "Venda";
		Description = "Se calienta y se enfría la gelatina, se corta una tira larga y delgada de material sintético con el cuchillo o la lanza...";
		IsMaterial = true;
		Behaviour = null;
		Recipe = new List<Item> {new Gelatin(), new SyntheticMaterial()};
	}
}