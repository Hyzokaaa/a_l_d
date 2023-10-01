using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : Weapon
{
	public Knife()
	{
		ItemName = "Cuchillo";
		Description = "Se calienta el uremio y se le da forma de hoja afilada, se enrolla el material sintético alrededor del extremo opuesto al filo y se pega con la gelatina para hacer el mango, se enfría y se afila el cuchillo.";
		IsMaterial = false;
		Recipe = new List<Item> {new Uremia(),new Uremia(), new SyntheticMaterial(), new Gelatin()};
		Behaviour = new BehHit();
	}
}
