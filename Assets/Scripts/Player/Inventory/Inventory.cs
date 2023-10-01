using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public class Inventory : MonoBehaviour
{
	public Dictionary<int, Item> items;
	[SerializeField]
	private int slots = 10;
	private int selectedItem = 1;
	private int selectedBehaviour = 0;
	public event Action Changes;

	
	private void Awake()
	{
		items = new Dictionary<int, Item>();
		Changes?.Invoke();
	}
	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			ShowInventoryOnConsole();
		}
		ChangeBehaviour();
		RotateInventory();
		UseItem();
	}

	public void AddItem(Item item)
	{
		if (items.Count < slots)
		{
			for (int i = 1; i <= slots; i++)
			{
				if (!items.ContainsKey(i))
				{
					items[i] = item;
					Changes?.Invoke();
					return;
				}
			}
		}
	}
	public void RemoveItem(int index)
	{
		items.Remove(index);
		Changes?.Invoke();
	}
	public void UseItem()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			if (items.Count <= 0)
			{
				//print("no tengo item");
				return;
			}
			if (!items.ContainsKey(selectedItem))
			{
				//print("no tengo el item " + selectedItem + " asignado");
				return;
			}
			if (items[selectedItem] is Tool)
			{
				if (selectedBehaviour == 0)
				{
					items[selectedItem].Behaviour.Execute();
				}
				else if (selectedBehaviour == 1)
				{
					Tool item = items[selectedItem] as Tool;
					item.SecondBehaviour.Execute();
				}
			}
			else if (items[selectedItem] is Weapon)
			{
				if (Input.GetKeyDown(KeyCode.Mouse0))
				{
					items[selectedItem].Behaviour.Execute();
				}
			}
		}
	}
	public void RotateInventory()
	{
		float scrollValue = Input.GetAxis("Mouse ScrollWheel");
		if (scrollValue != 0)
		{
			int intValue = Mathf.FloorToInt(scrollValue * 10);
			selectedItem += intValue;
			if (selectedItem < 1)
			{
				selectedItem = 5;
			}
			if (selectedItem > 5)
			{
				selectedItem = 1;
			}
			Changes?.Invoke();
		}
	}

	public void ChangeBehaviour()
	{
		if (Input.GetKeyDown(KeyCode.Tab))
		{
			selectedBehaviour = selectedBehaviour == 0 ? 1 : 0;
			Changes?.Invoke();
			print(selectedBehaviour);
		}
	}
	public int GetBehaviour()
	{
		return selectedBehaviour;
	}
	public int GetSelectedIndex()
	{
		return selectedItem;
	}

	public Item GetSelectedItem()
	{   
		if(items.Count > 0 && items.ContainsKey(selectedItem))
		{
			if(items.TryGetValue(selectedItem, out var item)) { 
				return items[selectedItem];
			}
		}
		return null;    
	}
	public List<Item> ConvertToList()
	{
		 return items.Values.ToList();
	} 
	public Dictionary<int, Item> ConvertToDictionary(List<Item> list)
	{
		Dictionary<int, Item> dictionary = new Dictionary<int, Item>();
		for (int i = 0; i < list.Count; i++)
		{
			dictionary[i] = list[i];
		}
		return dictionary;
	}
	public void ShowInventoryOnConsole()
	{
		for(int i = 0 ; i < items.Count ; i++)
		{
			if(items.TryGetValue(i, out Item item))
			{
				print(item.ItemName);
			}
		}
	}
	public void RemoveItem(Item itemToRemove)
	{
		foreach (var item in items)
		{
			if (item.Value.ItemName == itemToRemove.ItemName)
			{
				items.Remove(item.Key);
				Changes?.Invoke();
				return;
			}
		}
	}
	public void RemoveWithType(Item itemToRemove)
	{
		Type typeToRemove = itemToRemove.GetType();
		foreach (var item in items)
		{
			if (item.Value.GetType() == typeToRemove || item.Value.GetType().IsSubclassOf(typeToRemove))
			{
				items.Remove(item.Key);
				return;
			}
		}
	}
}

