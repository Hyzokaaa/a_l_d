using System;
using System.Collections.Generic;
using UnityEngine;
public class Inventory : MonoBehaviour
{
    public Dictionary<int, Item> items;
    private int slots = 10;
    private int selectedItem = 1;
    private int selectedBehaviour = 0;

    private void Awake()
    {
        items = new Dictionary<int, Item>();
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
                    return;
                }
            }
        }
    }
    public void RemoveItem(int index)
    {
        items.Remove(index);
    }
    public void UseItem()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (items.Count <= 0)
            {
                print("no tengo item");
                return;
            }
            if (!items.ContainsKey(selectedItem))
            {
                print("no tengo el item " + selectedItem + " asignado");
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
            print(selectedItem);
        }
    }

    public void ChangeBehaviour()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            selectedBehaviour = selectedBehaviour == 0 ? 1 : 0;
            print(selectedBehaviour);
        }
    }
    private void Update()
    {
        ChangeBehaviour();
        RotateInventory();
        UseItem();
    }
}

