using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CraftingManager : MonoBehaviour
{
	[SerializeField]
	public List<Item> craftingList;
	[SerializeField]
	private int index;
	ItemFactory factory;
	public ItemType[] crafts;
	
	void Start()
	{
		factory = gameObject.AddComponent<ItemFactory>();
		craftingList = new();
		InitalizeList();
	}



	void OnTriggerStay(Collider other)
	{
		if(other.CompareTag("Player"))
		{
			Execute(other.GetComponent<Inventory>());

		}
	}

	public bool Execute(Inventory inventoryCopy)
	{
		if(Input.GetKeyDown(KeyCode.F))
		{
			if(Craft(craftingList[index], inventoryCopy) && inventoryCopy.items.Count > 0)
			{
				return true;
			}
			else
			{
			{
				print("NO PUDE CONSTRUIR ASERE");
			}
			}
		}
		return false;
	}

	public bool Craft(Item itemToCraft, Inventory playerInventory)
	{
		if (!CanCraft(itemToCraft, playerInventory))
		{
			return false;
		}
		foreach (Item requiredItem in itemToCraft.Recipe)
		{
			playerInventory.RemoveWithType(requiredItem);
		}
		playerInventory.AddItem(itemToCraft);
		return true;
	}
	public bool CanCraft(Item itemToCraft, Inventory playerInventory)
	{
		List<Item> inventoryCopy = playerInventory.items.Values.ToList();
		foreach (Item recipeItem in itemToCraft.Recipe)
		{
			bool found = false;
			for (int i = 0; i < inventoryCopy.Count; i++)
			{
				if (inventoryCopy[i].GetType() == recipeItem.GetType() || inventoryCopy[i].GetType().IsSubclassOf(recipeItem.GetType()))
				{
					inventoryCopy.RemoveAt(i);
					found = true;
					break;
				}
			}
			if (!found)
			{
				return false;
			}
		}
		return true;
	}
	private void InitalizeList()
	{
		foreach (ItemType craft in crafts)
		{
			craftingList.Add(factory.Create(craft));
		}
	}
}
/*
craftingList: Es una lista de objetos que se pueden crear.

index: Es el índice del objeto que se está creando actualmente.

factory: Es una referencia a la fábrica de objetos, que es responsable de crear los objetos.

crafts: Es una lista de los tipos de objetos que se pueden crear.

El método Start() se llama al inicio del juego. Aquí, se inicializa la fábrica de objetos y la lista de creación.

El método OnTriggerStay(Collider other) se llama cada frame en el que otro objeto está dentro del trigger
del objeto al que está adjunto este script. Si el otro objeto es el jugador, entonces se intenta crear un objeto.

El método Execute(Inventory inventoryCopy) se llama cuando el jugador presiona la tecla F. Intenta crear el objeto 
actualmente seleccionado y devuelve verdadero si tiene éxito y falso si no.

El método Craft(Item itemToCraft, Inventory playerInventory) intenta crear un objeto. Primero verifica si el objeto 
puede ser creado con el método CanCraft. Si es posible, entonces recorre cada objeto requerido en la receta del objeto 
a crear, lo elimina del inventario del jugador y finalmente añade el objeto creado al inventario. Si el objeto no puede 
ser creado, simplemente retorna false.

El método CanCraft(Item itemToCraft, Inventory playerInventory) verifica si un objeto puede ser creado. Comprueba 
si cada objeto requerido en la receta del objeto a crear está presente en el inventario del jugador. Si todos los 
objetos requeridos están presentes, entonces retorna verdadero. Si falta al menos uno, entonces retorna falso.

El método InitalizeList() inicializa la lista de creación con los objetos que se pueden crear.
*/