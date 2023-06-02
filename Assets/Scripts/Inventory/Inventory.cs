using System;
using System.Collections.Generic;
using UnityEngine;
public class Inventory : MonoBehaviour
{
    public List<Item> items;
    private int selectedItem = 0;
    private int selectedBehaviour = 0;

    private void Awake()
    {
        items = new List<Item>();
    }

    public void AddItem(Item item)
    {
        items.Add(item);
    }
    public void RemoveItem(int index)
    {
        items.RemoveAt(index);
    }
    public void UseItem()
    {
        if (items.Count == 0)
        {
            print("no tengo item");
            return;
        }
        if (items[selectedItem] is Tool)
        {

            if (selectedBehaviour == 0)
            {
                items[selectedItem].Behaviour.Execute();
            }
            else if(selectedBehaviour == 1)
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
        UseItem();
    }
}

