using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public abstract class Item 
{
	private string itemName;
	private string description;
	private bool isMaterial;
	private IBehaviour behaviour;
	private List<Item> recipe;   
	private GameObject prefab;
	protected Item()
    {
        Recipe = GenerateRecipe();
    }

	public abstract List<Item> GenerateRecipe();
	public string ItemName { get => itemName; set => itemName = value; }
	public string Description { get => description; set => description = value; }
	public bool IsMaterial { get => isMaterial; set => isMaterial = value; }
	public IBehaviour Behaviour { get => behaviour; set => behaviour = value; }
	public List<Item> Recipe { get => recipe; set => recipe = value; }
	public GameObject Prefab { get => prefab; set => prefab = value; }
}
