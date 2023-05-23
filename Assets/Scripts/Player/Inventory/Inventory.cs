using System;
using System.Collections.Generic;
using UnityEngine;
internal class Inventory : MonoBehaviour
{
    private List<Item> items = new List<Item>();
    private int selectedItem = 1;
    public void AddItem(Item item, int slots)
    {
        if(items.Count < slots)
        items.Add(item);
    }
    public void RemoveItem(int index)
    {
        items.RemoveAt(index);
    }
    public void UseItem(Item item)
    {
        //TODO
    }
}
