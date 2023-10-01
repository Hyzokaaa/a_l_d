using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : Weapon
{
	public Spear()
	{
		ItemName = "Lanza";
		Description = "Se corta una rama larga y recta de biocelulosa, se hace un agujero en uno de los " +
		"extremos e inserta el cuchillo, se envuelve la piel alrededor de la unión y se ata para asegurarla.";
		IsMaterial = false;
		Recipe = new List<Item> {new Knife(), new Biocellulose(), new SyntheticMaterial()};
		// Agrega aquí las demás propiedades
	}
}