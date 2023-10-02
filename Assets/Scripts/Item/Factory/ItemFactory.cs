using System;
using System.Collections.Generic;
using UnityEngine;
public class ItemFactory
{
	private static readonly Dictionary<ItemType, Func<Item>> itemCreators = new Dictionary<ItemType, Func<Item>>
	{
		{ ItemType.AcidWater, () => new AcidWater() },
		{ ItemType.Biocellulose, () => new Biocellulose() },
		{ ItemType.Gelatin, () => new Gelatin() },
		{ ItemType.MedicinalPlant, () => new MedicinalPlant()},
		{ ItemType.Pyrite, () => new Pyrite() },
		{ ItemType.Quartz, () => new Quartz() },
		{ ItemType.Skin, () => new Skin() },
		{ ItemType.SpaceGeode, () => new SpaceGeode() },
		{ ItemType.Uremia, () => new Uremia() },
		{ ItemType.Alloy, () => new Alloy() },
		{ ItemType.Glue, () => new Glue() },
		{ ItemType.Lens, () => new Lens() },
		{ ItemType.Paper, () => new Paper() },
		{ ItemType.SyntheticMaterial, () => new SyntheticMaterial() },
		{ ItemType.Water, () => new Water() },
		{ ItemType.Bandage, () => new Bandage() },	
		{ ItemType.Binoculars, () => new Binoculars() },	
		{ ItemType.Bonfire, () => new Bonfire() },	
		{ ItemType.Bow, () => new Bow() },				
		{ ItemType.Clock, () => new Clock() },	
		{ ItemType.Container, () => new Container() },	
		{ ItemType.Crossbow, () => new Crossbow() },	
		{ ItemType.Explosive, () => new Explosive() },	
		{ ItemType.Fuel, () => new Fuel() },	
		{ ItemType.Hut, () => new Hut() },
		{ ItemType.Infusion, () => new Infusion() },		
		{ ItemType.Knife, () => new Knife() },
		{ ItemType.Map, () => new Map() },	
		{ ItemType.Net, () => new Net() },		
		{ ItemType.Ointment, () => new Ointment() },	
		{ ItemType.Pomade, () => new Pomade() },																																																				
		{ ItemType.Scanner, () => new Scanner() },
		{ ItemType.Shelter, () => new Shelter() },
		{ ItemType.Spear, () => new Spear() },	
		{ ItemType.ThermalInsulator, () => new ThermalInsulator()},
		{ ItemType.Torch, () => new Torch()},
		{ ItemType.Trap, () => new Trap()}															
	};

	public static Item Create(ItemType type)
	{
		if (itemCreators.TryGetValue(type, out var creator))
		{
			return creator();
		}
		else
		{
			return null;
		}
	}
	public static List<Item> CreateAll(ItemType item, int count)
	{
		List<Item> items = new();
		for(int i = 0; i < count ; i++)
		{
			items.Add(ItemFactory.Create(item));
		}
		return items;
	} 
}