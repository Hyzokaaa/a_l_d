using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : Item
{
	public Container() : base()
	{
		ItemName = "Recipiente";
		Description = "Se calienta el cuarzo hasta que se ablande y luego darle forma de cuenco con un martillo o una piedra...";
		IsMaterial = true;
		Behaviour = null;
	}
	public override List<Item> GenerateRecipe()
    {
        return new List<Item>
		{
			ItemFactory.Create(ItemType.Quartz)
		};
    }
}