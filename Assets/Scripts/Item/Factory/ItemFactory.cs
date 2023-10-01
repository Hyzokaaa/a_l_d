using System;
using System.Collections.Generic;
using UnityEngine;
public class ItemFactory : MonoBehaviour
{
	public Item Create(ItemType type)
	{
		switch (type)
		{
			case ItemType.Gelatin:
				return new Gelatin();
			case ItemType.Quartz:
				return new Quartz();
			case ItemType.Pyrite:
				return new Pyrite();
			case ItemType.Uremia:
				return new Uremia();
			case ItemType.Biocellulose:
				return new Biocellulose();
			case ItemType.SpaceGeode:
				return new SpaceGeode();
			case ItemType.Skin:
				return new Skin();
			case ItemType.SyntheticMaterial:
				return new SyntheticMaterial();
			case ItemType.Alloy:
				return new Alloy();
			case ItemType.Scanner:
				return new Scanner();
			case ItemType.Knife:
				return new Knife();
			default:
				return null;
		}
	}
}